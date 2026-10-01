using ClinicaMedica.Modelo.Entidades;
using ClinicaMedica.Modelo.Utilidades;

namespace ClinicaMedica.Modelo.DAO
{
    /// <summary>Lógica de autenticación: valida usuario, contraseña (BCrypt), bloqueo e inicia la sesión.</summary>
    public class LoginDAO
    {
        private readonly UsuarioDAO usuarios = new UsuarioDAO();

        public Usuario Autenticar(string nombreUsuario, string clave)
        {
            Usuario u = usuarios.BuscarPorNombreUsuario(nombreUsuario.Trim());

            // Mensaje genérico: no revelamos si lo que falló fue el usuario o la contraseña
            if (u == null)
            {
                Logger.Actividad("LOGIN_FALLIDO", "Login", $"Usuario inexistente: {nombreUsuario}");
                throw new ExcepcionDatos("Usuario o contraseña incorrectos.");
            }

            if (!u.Activo)
            {
                Logger.Actividad("LOGIN_BLOQUEADO", "Login", $"Intento de acceso de usuario inactivo: {u.NombreUsuario}");
                throw new ExcepcionDatos("El usuario está inactivo o bloqueado. Contacte al administrador.");
            }

            if (!Seguridad.Verificar(clave, u.ClaveHash))
            {
                int intentos = usuarios.RegistrarIntentoFallido(u.IdUsuario);
                Logger.Actividad("LOGIN_FALLIDO", "Login", $"Contraseña incorrecta para {u.NombreUsuario} (intento {intentos})");
                if (intentos >= 3)
                    throw new ExcepcionDatos("Ha superado 3 intentos fallidos. El usuario fue bloqueado.");
                throw new ExcepcionDatos($"Usuario o contraseña incorrectos. Intentos restantes: {3 - intentos}");
            }

            usuarios.RegistrarAccesoExitoso(u.IdUsuario);
            var permisos = new RolDAO().ListarCodigosPermisoDeRol(u.IdRol);
            int? idMedico = new MedicoDAO().ObtenerIdPorUsuario(u.IdUsuario);
            Sesion.Iniciar(u, permisos, idMedico);
            Logger.Actividad("LOGIN", "Login", $"Inicio de sesión de {u.NombreUsuario} ({u.NombreRol})");
            return u;
        }
    }
}
