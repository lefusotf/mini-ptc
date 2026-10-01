using ClinicaMedica.Modelo.Entidades;
using ClinicaMedica.Modelo.Utilidades;
using Microsoft.Data.SqlClient;
using static ClinicaMedica.Modelo.Conexion;

namespace ClinicaMedica.Modelo.DAO
{
    public class CitaDAO
    {
        /// <summary>
        /// Lista citas. Si idMedico tiene valor solo se muestran las de ese médico (vista del Médico).
        /// Si fecha tiene valor se filtra por ese día.
        /// </summary>
        public List<Cita> Listar(string filtro, DateTime? fecha, int? idMedico) => Consultar(
            @"SELECT c.IdCita, c.IdPaciente, p.Nombres + ' ' + p.Apellidos AS NombrePaciente,
                     c.IdMedico, m.Nombres + ' ' + m.Apellidos AS NombreMedico, e.Nombre AS NombreEspecialidad,
                     c.Fecha, c.Hora, c.Motivo, c.Estado, c.Observaciones
              FROM Citas c
              JOIN Pacientes p      ON p.IdPaciente = c.IdPaciente
              JOIN Medicos m        ON m.IdMedico = c.IdMedico
              JOIN Especialidades e ON e.IdEspecialidad = m.IdEspecialidad
              WHERE (p.Nombres + ' ' + p.Apellidos LIKE @f OR m.Nombres + ' ' + m.Apellidos LIKE @f
                     OR c.Estado LIKE @f OR c.Motivo LIKE @f)
                AND (@Fecha IS NULL OR c.Fecha = @Fecha)
                AND (@IdMedico IS NULL OR c.IdMedico = @IdMedico)
              ORDER BY c.Fecha DESC, c.Hora",
            dr => new Cita
            {
                IdCita = dr.Entero("IdCita"),
                IdPaciente = dr.Entero("IdPaciente"),
                NombrePaciente = dr.Texto("NombrePaciente"),
                IdMedico = dr.Entero("IdMedico"),
                NombreMedico = dr.Texto("NombreMedico"),
                NombreEspecialidad = dr.Texto("NombreEspecialidad"),
                Fecha = dr.Fecha("Fecha"),
                Hora = (TimeSpan)dr["Hora"],
                Motivo = dr.Texto("Motivo"),
                Estado = dr.Texto("Estado"),
                Observaciones = dr.Texto("Observaciones")
            },
            Param("@f", "%" + filtro + "%"), Param("@Fecha", fecha?.Date), Param("@IdMedico", idMedico));

        /// <summary>
        /// Regla de negocio que soluciona la DUPLICIDAD DE HORARIOS:
        /// ni el médico ni el paciente pueden tener otra cita activa en la misma fecha y hora.
        /// (Además la BD tiene un índice único como segunda protección.)
        /// </summary>
        public void ValidarDisponibilidad(Cita c)
        {
            int choques = Convert.ToInt32(EjecutarEscalar(
                @"SELECT COUNT(*) FROM Citas
                  WHERE Fecha = @Fecha AND Hora = @Hora AND Estado <> 'Cancelada' AND IdCita <> @IdCita
                    AND IdMedico = @IdMedico",
                Param("@Fecha", c.Fecha.Date), Param("@Hora", c.Hora),
                Param("@IdCita", c.IdCita), Param("@IdMedico", c.IdMedico)));
            if (choques > 0)
                throw new ExcepcionDatos("El médico ya tiene una cita agendada en esa fecha y hora. Elija otro horario.");

            choques = Convert.ToInt32(EjecutarEscalar(
                @"SELECT COUNT(*) FROM Citas
                  WHERE Fecha = @Fecha AND Hora = @Hora AND Estado <> 'Cancelada' AND IdCita <> @IdCita
                    AND IdPaciente = @IdPaciente",
                Param("@Fecha", c.Fecha.Date), Param("@Hora", c.Hora),
                Param("@IdCita", c.IdCita), Param("@IdPaciente", c.IdPaciente)));
            if (choques > 0)
                throw new ExcepcionDatos("El paciente ya tiene otra cita en esa fecha y hora.");
        }

        public void Insertar(Cita c)
        {
            if (c.Estado != "Cancelada") ValidarDisponibilidad(c);
            Ejecutar(@"INSERT INTO Citas (IdPaciente, IdMedico, Fecha, Hora, Motivo, Estado, Observaciones, IdUsuarioRegistro)
                       VALUES (@IdPaciente, @IdMedico, @Fecha, @Hora, @Motivo, @Estado, @Observaciones, @IdUsuario)",
                Param("@IdPaciente", c.IdPaciente), Param("@IdMedico", c.IdMedico), Param("@Fecha", c.Fecha.Date),
                Param("@Hora", c.Hora), Param("@Motivo", c.Motivo), Param("@Estado", c.Estado),
                Param("@Observaciones", c.Observaciones), Param("@IdUsuario", Sesion.Usuario?.IdUsuario));
        }

        public void Actualizar(Cita c)
        {
            if (c.Estado != "Cancelada") ValidarDisponibilidad(c);
            Ejecutar(@"UPDATE Citas SET IdPaciente = @IdPaciente, IdMedico = @IdMedico, Fecha = @Fecha, Hora = @Hora,
                              Motivo = @Motivo, Estado = @Estado, Observaciones = @Observaciones
                       WHERE IdCita = @IdCita",
                Param("@IdPaciente", c.IdPaciente), Param("@IdMedico", c.IdMedico), Param("@Fecha", c.Fecha.Date),
                Param("@Hora", c.Hora), Param("@Motivo", c.Motivo), Param("@Estado", c.Estado),
                Param("@Observaciones", c.Observaciones), Param("@IdCita", c.IdCita));
        }

        /// <summary>Usado por el médico: solo cambia el estado y las observaciones.</summary>
        public void ActualizarEstado(int idCita, string estado, string observaciones) => Ejecutar(
            "UPDATE Citas SET Estado = @Estado, Observaciones = @Obs WHERE IdCita = @Id",
            Param("@Estado", estado), Param("@Obs", observaciones), Param("@Id", idCita));

        public void Eliminar(int id) =>
            Ejecutar("DELETE FROM Citas WHERE IdCita = @Id", Param("@Id", id));
    }
}
