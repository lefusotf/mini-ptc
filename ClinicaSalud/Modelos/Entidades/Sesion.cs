using System.Collections.Generic;

namespace Modelos.Entidades
{
    // Guarda los datos del usuario que inició sesión mientras el programa está abierto
    public static class Sesion
    {
        public static int IdUsuario;
        public static string NombreUsuario;
        public static string Rol;
        public static int IdMedico;
        public static List<string> Permisos = new List<string>();

        public static bool TienePermiso(string permiso)
        {
            return Permisos.Contains(permiso);
        }

        public static void cerrarSesion()
        {
            IdUsuario = 0;
            NombreUsuario = null;
            Rol = null;
            IdMedico = 0;
            Permisos = new List<string>();
        }
    }
}
