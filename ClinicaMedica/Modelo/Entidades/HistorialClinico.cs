using System.ComponentModel;

namespace ClinicaMedica.Modelo.Entidades
{
    public class HistorialClinico
    {
        [DisplayName("ID")] public int IdHistorial { get; set; }
        [Browsable(false)] public int IdPaciente { get; set; }
        [DisplayName("Paciente")] public string NombrePaciente { get; set; }
        [Browsable(false)] public int IdMedico { get; set; }
        [DisplayName("Médico")] public string NombreMedico { get; set; }
        [DisplayName("Cita")] public int? IdCita { get; set; }
        [DisplayName("Fecha consulta")] public DateTime FechaConsulta { get; set; }
        [DisplayName("Diagnóstico")] public string Diagnostico { get; set; }
        public string Tratamiento { get; set; }
        public string Observaciones { get; set; }
    }
}
