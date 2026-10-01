using System.Collections.Generic;

namespace Modelos
{
    // Guarda los datos del usuario que inició sesión
    public static class Sesion
    {
        public static int IdUsuario { get; set; }
        public static string Usuario { get; set; }
        public static string Rol { get; set; }
        public static int IdMedico { get; set; }          // 0 si el usuario no es médico
        public static List<string> Permisos { get; set; } = new List<string>();

        public static bool TienePermiso(string permiso)
        {
            return Permisos.Contains(permiso);
        }

        public static void Cerrar()
        {
            IdUsuario = 0;
            Usuario = null;
            Rol = null;
            IdMedico = 0;
            Permisos = new List<string>();
        }
    }
}
