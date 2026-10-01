using ClinicaMedica.Modelo.Entidades;

namespace ClinicaMedica.Modelo.Utilidades
{
    /// <summary>Guarda los datos del usuario que inició sesión y sus permisos.</summary>
    public static class Sesion
    {
        public static Usuario Usuario { get; private set; }
        public static HashSet<string> Permisos { get; private set; } = new HashSet<string>();

        /// <summary>Si el usuario es un médico, aquí queda su IdMedico (si no, null).</summary>
        public static int? IdMedico { get; private set; }

        public static void Iniciar(Usuario usuario, IEnumerable<string> permisos, int? idMedico)
        {
            Usuario = usuario;
            Permisos = new HashSet<string>(permisos, StringComparer.OrdinalIgnoreCase);
            IdMedico = idMedico;
        }

        public static bool TienePermiso(string codigo) => Permisos.Contains(codigo);

        public static void Cerrar()
        {
            Usuario = null;
            Permisos = new HashSet<string>();
            IdMedico = null;
        }
    }

    /// <summary>Códigos de permisos (deben coincidir con la tabla Permisos).</summary>
    public static class P
    {
        public const string UsuariosGestionar = "USUARIOS_GESTIONAR";
        public const string RolesGestionar = "ROLES_GESTIONAR";
        public const string EspecialidadesGestionar = "ESPECIALIDADES_GESTIONAR";
        public const string MedicosGestionar = "MEDICOS_GESTIONAR";
        public const string PacientesVer = "PACIENTES_VER";
        public const string PacientesGestionar = "PACIENTES_GESTIONAR";
        public const string CitasVerTodas = "CITAS_VER_TODAS";
        public const string CitasAgendar = "CITAS_AGENDAR";
        public const string CitasVerPropias = "CITAS_VER_PROPIAS";
        public const string CitasAtender = "CITAS_ATENDER";
        public const string HistorialVer = "HISTORIAL_VER";
        public const string HistorialEditar = "HISTORIAL_EDITAR";
        public const string BitacoraVer = "BITACORA_VER";
    }
}
