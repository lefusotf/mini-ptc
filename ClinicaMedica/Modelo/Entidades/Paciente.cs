using System.ComponentModel;

namespace ClinicaMedica.Modelo.Entidades
{
    public class Paciente
    {
        [DisplayName("ID")] public int IdPaciente { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string DUI { get; set; }
        [DisplayName("Fecha nac.")] public DateTime FechaNacimiento { get; set; }
        [DisplayName("Edad")] public int Edad
        {
            get
            {
                int edad = DateTime.Today.Year - FechaNacimiento.Year;
                if (FechaNacimiento.Date > DateTime.Today.AddYears(-edad)) edad--;
                return edad;
            }
        }
        [DisplayName("Género")] public string Genero { get; set; }
        [DisplayName("Teléfono")] public string Telefono { get; set; }
        public string Correo { get; set; }
        [DisplayName("Dirección")] public string Direccion { get; set; }
        [DisplayName("Tipo sangre")] public string TipoSangre { get; set; }
        public string Alergias { get; set; }
        [DisplayName("Registrado")] public DateTime FechaRegistro { get; set; }

        [Browsable(false)] public string NombreCompleto => $"{Nombres} {Apellidos}";
        public override string ToString() => string.IsNullOrEmpty(DUI) ? NombreCompleto : $"{NombreCompleto} ({DUI})";
    }
}
