using System.ComponentModel;

namespace ClinicaMedica.Modelo.Entidades
{
    public class Medico
    {
        [DisplayName("ID")] public int IdMedico { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string JVPM { get; set; }
        [DisplayName("Teléfono")] public string Telefono { get; set; }
        public string Correo { get; set; }
        [Browsable(false)] public int IdEspecialidad { get; set; }
        [DisplayName("Especialidad")] public string NombreEspecialidad { get; set; }
        [Browsable(false)] public int? IdUsuario { get; set; }
        [DisplayName("Usuario del sistema")] public string NombreUsuario { get; set; }
        public bool Activo { get; set; }

        [Browsable(false)] public string NombreCompleto => $"Dr(a). {Nombres} {Apellidos}";
        public override string ToString() => $"{NombreCompleto} ({NombreEspecialidad})";
    }
}
