using System.ComponentModel;

namespace ClinicaMedica.Modelo.Entidades
{
    public class Cita
    {
        [DisplayName("ID")] public int IdCita { get; set; }
        [Browsable(false)] public int IdPaciente { get; set; }
        [DisplayName("Paciente")] public string NombrePaciente { get; set; }
        [Browsable(false)] public int IdMedico { get; set; }
        [DisplayName("Médico")] public string NombreMedico { get; set; }
        [DisplayName("Especialidad")] public string NombreEspecialidad { get; set; }
        [DisplayName("Fecha")] public DateTime Fecha { get; set; }
        [DisplayName("Hora")] public TimeSpan Hora { get; set; }
        public string Motivo { get; set; }
        public string Estado { get; set; }
        public string Observaciones { get; set; }

        public static readonly string[] Estados = { "Pendiente", "Confirmada", "Atendida", "Cancelada" };
    }
}
