using ClinicaMedica.Modelo.Entidades;
using Microsoft.Data.SqlClient;
using static ClinicaMedica.Modelo.Conexion;

namespace ClinicaMedica.Modelo.DAO
{
    public class UsuarioDAO
    {
        private const string SelectBase =
            @"SELECT u.IdUsuario, u.NombreUsuario, u.NombreCompleto, u.Correo, u.ClaveHash, u.IdRol,
                     r.Nombre AS NombreRol, u.Activo, u.IntentosFallidos, u.UltimoAcceso
              FROM Usuarios u JOIN Roles r ON r.IdRol = u.IdRol ";

        private static Usuario Mapear(SqlDataReader dr) => new Usuario
        {
            IdUsuario = dr.Entero("IdUsuario"),
            NombreUsuario = dr.Texto("NombreUsuario"),
            NombreCompleto = dr.Texto("NombreCompleto"),
            Correo = dr.Texto("Correo"),
            ClaveHash = dr.Texto("ClaveHash"),
            IdRol = dr.Entero("IdRol"),
            NombreRol = dr.Texto("NombreRol"),
            Activo = dr.Booleano("Activo"),
            IntentosFallidos = dr.Entero("IntentosFallidos"),
            UltimoAcceso = dr.FechaNula("UltimoAcceso")
        };

        public List<Usuario> Listar(string filtro = "") => Consultar(
            SelectBase + @"WHERE u.NombreUsuario LIKE @f OR u.NombreCompleto LIKE @f OR r.Nombre LIKE @f
                           ORDER BY u.NombreUsuario",
            Mapear, Param("@f", "%" + filtro + "%"));

        public Usuario BuscarPorNombreUsuario(string nombreUsuario) => Consultar(
            SelectBase + "WHERE u.NombreUsuario = @NombreUsuario",
            Mapear, Param("@NombreUsuario", nombreUsuario)).FirstOrDefault();

        /// <summary>
        /// Usuarios cuyo rol tiene el permiso CITAS_VER_PROPIAS (rol de médico) y que todavía
        /// no están ligados a otro médico.
        /// </summary>
        public List<Usuario> ListarMedicosDisponibles(int? idMedicoActual) => Consultar(
            SelectBase + @"WHERE u.Activo = 1
                             AND EXISTS (SELECT 1 FROM RolPermisos rp JOIN Permisos p ON p.IdPermiso = rp.IdPermiso
                                         WHERE rp.IdRol = u.IdRol AND p.Codigo = 'CITAS_VER_PROPIAS')
                             AND NOT EXISTS (SELECT 1 FROM Medicos m WHERE m.IdUsuario = u.IdUsuario
                                             AND (@IdMedico IS NULL OR m.IdMedico <> @IdMedico))
                           ORDER BY u.NombreUsuario",
            Mapear, Param("@IdMedico", idMedicoActual));

        public int Insertar(Usuario u) => Convert.ToInt32(EjecutarEscalar(
            @"INSERT INTO Usuarios (NombreUsuario, NombreCompleto, Correo, ClaveHash, IdRol, Activo)
              VALUES (@NombreUsuario, @NombreCompleto, @Correo, @ClaveHash, @IdRol, @Activo);
              SELECT SCOPE_IDENTITY();",
            Param("@NombreUsuario", u.NombreUsuario), Param("@NombreCompleto", u.NombreCompleto),
            Param("@Correo", u.Correo), Param("@ClaveHash", u.ClaveHash),
            Param("@IdRol", u.IdRol), Param("@Activo", u.Activo)));

        /// <summary>Actualiza los datos. Si ClaveHash viene vacío se conserva la contraseña actual.</summary>
        public void Actualizar(Usuario u) => Ejecutar(
            @"UPDATE Usuarios SET NombreUsuario = @NombreUsuario, NombreCompleto = @NombreCompleto,
                     Correo = @Correo, IdRol = @IdRol, Activo = @Activo,
                     ClaveHash = COALESCE(@ClaveHash, ClaveHash),
                     IntentosFallidos = CASE WHEN @Activo = 1 THEN 0 ELSE IntentosFallidos END
              WHERE IdUsuario = @IdUsuario",
            Param("@NombreUsuario", u.NombreUsuario), Param("@NombreCompleto", u.NombreCompleto),
            Param("@Correo", u.Correo), Param("@IdRol", u.IdRol), Param("@Activo", u.Activo),
            Param("@ClaveHash", u.ClaveHash), Param("@IdUsuario", u.IdUsuario));

        public void Eliminar(int idUsuario) =>
            Ejecutar("DELETE FROM Usuarios WHERE IdUsuario = @Id", Param("@Id", idUsuario));

        public void CambiarClave(int idUsuario, string nuevoHash) => Ejecutar(
            "UPDATE Usuarios SET ClaveHash = @Hash WHERE IdUsuario = @Id",
            Param("@Hash", nuevoHash), Param("@Id", idUsuario));

        // ---------------- Usados por el Login ----------------

        public void RegistrarAccesoExitoso(int idUsuario) => Ejecutar(
            "UPDATE Usuarios SET IntentosFallidos = 0, UltimoAcceso = GETDATE() WHERE IdUsuario = @Id",
            Param("@Id", idUsuario));

        /// <summary>Suma un intento fallido; al llegar a 3 el usuario se desactiva (bloquea).</summary>
        public int RegistrarIntentoFallido(int idUsuario) => Convert.ToInt32(EjecutarEscalar(
            @"UPDATE Usuarios SET IntentosFallidos = IntentosFallidos + 1,
                     Activo = CASE WHEN IntentosFallidos + 1 >= 3 THEN 0 ELSE Activo END
              WHERE IdUsuario = @Id;
              SELECT IntentosFallidos FROM Usuarios WHERE IdUsuario = @Id;",
            Param("@Id", idUsuario)));

    }
}
