using ClinicaMedica.Modelo.Entidades;
using static ClinicaMedica.Modelo.Conexion;

namespace ClinicaMedica.Modelo.DAO
{
    public class HistorialDAO
    {
        public List<HistorialClinico> ListarPorPaciente(int idPaciente) => Consultar(
            @"SELECT h.IdHistorial, h.IdPaciente, p.Nombres + ' ' + p.Apellidos AS NombrePaciente,
                     h.IdMedico, m.Nombres + ' ' + m.Apellidos AS NombreMedico, h.IdCita,
                     h.FechaConsulta, h.Diagnostico, h.Tratamiento, h.Observaciones
              FROM HistorialClinico h
              JOIN Pacientes p ON p.IdPaciente = h.IdPaciente
              JOIN Medicos m   ON m.IdMedico = h.IdMedico
              WHERE h.IdPaciente = @IdPaciente
              ORDER BY h.FechaConsulta DESC",
            dr => new HistorialClinico
            {
                IdHistorial = dr.Entero("IdHistorial"),
                IdPaciente = dr.Entero("IdPaciente"),
                NombrePaciente = dr.Texto("NombrePaciente"),
                IdMedico = dr.Entero("IdMedico"),
                NombreMedico = dr.Texto("NombreMedico"),
                IdCita = dr.EnteroNulo("IdCita"),
                FechaConsulta = dr.Fecha("FechaConsulta"),
                Diagnostico = dr.Texto("Diagnostico"),
                Tratamiento = dr.Texto("Tratamiento"),
                Observaciones = dr.Texto("Observaciones")
            },
            Param("@IdPaciente", idPaciente));

        public void Insertar(HistorialClinico h) => Ejecutar(
            @"INSERT INTO HistorialClinico (IdPaciente, IdMedico, IdCita, FechaConsulta, Diagnostico, Tratamiento, Observaciones)
              VALUES (@IdPaciente, @IdMedico, @IdCita, @FechaConsulta, @Diagnostico, @Tratamiento, @Observaciones)",
            Param("@IdPaciente", h.IdPaciente), Param("@IdMedico", h.IdMedico), Param("@IdCita", h.IdCita),
            Param("@FechaConsulta", h.FechaConsulta), Param("@Diagnostico", h.Diagnostico),
            Param("@Tratamiento", h.Tratamiento), Param("@Observaciones", h.Observaciones));

        public void Actualizar(HistorialClinico h) => Ejecutar(
            @"UPDATE HistorialClinico SET IdMedico = @IdMedico, FechaConsulta = @FechaConsulta,
                     Diagnostico = @Diagnostico, Tratamiento = @Tratamiento, Observaciones = @Observaciones
              WHERE IdHistorial = @IdHistorial",
            Param("@IdMedico", h.IdMedico), Param("@FechaConsulta", h.FechaConsulta),
            Param("@Diagnostico", h.Diagnostico), Param("@Tratamiento", h.Tratamiento),
            Param("@Observaciones", h.Observaciones), Param("@IdHistorial", h.IdHistorial));

        public void Eliminar(int id) =>
            Ejecutar("DELETE FROM HistorialClinico WHERE IdHistorial = @Id", Param("@Id", id));
    }
}
