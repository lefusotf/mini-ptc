using System;
using System.Data;
using System.Data.SqlClient;

namespace Modelos
{
    public class Cita
    {
        private int idCita;
        private int idPaciente;
        private int idMedico;
        private DateTime fecha;
        private string hora;
        private string motivo;
        private string estado;

        public int IdCita { get { return idCita; } set { idCita = value; } }
        public int IdPaciente { get { return idPaciente; } set { idPaciente = value; } }
        public int IdMedico { get { return idMedico; } set { idMedico = value; } }
        public DateTime Fecha { get { return fecha; } set { fecha = value; } }
        public string Hora { get { return hora; } set { hora = value; } }
        public string Motivo { get { return motivo; } set { motivo = value; } }
        public string Estado { get { return estado; } set { estado = value; } }

        // Si idMedico es mayor que 0 solo se muestran las citas de ese médico
        public static DataTable Mostrar(string buscar, int idMedico)
        {
            try
            {
                using (SqlConnection con = Conexion.Conectar())
                {
                    string consulta = @"SELECT c.IdCita, c.IdPaciente, c.IdMedico, p.Nombre AS Paciente, m.Nombre AS Medico,
                                               c.Fecha, c.Hora, c.Motivo, c.Estado
                                        FROM Citas c
                                        INNER JOIN Pacientes p ON c.IdPaciente = p.IdPaciente
                                        INNER JOIN Medicos m ON c.IdMedico = m.IdMedico
                                        WHERE (p.Nombre LIKE @buscar OR m.Nombre LIKE @buscar OR c.Estado LIKE @buscar)
                                          AND (@idMedico = 0 OR c.IdMedico = @idMedico)
                                        ORDER BY c.Fecha DESC, c.Hora";
                    SqlCommand cmd = new SqlCommand(consulta, con);
                    cmd.Parameters.AddWithValue("@buscar", "%" + buscar + "%");
                    cmd.Parameters.AddWithValue("@idMedico", idMedico);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
            }
            catch (SqlException ex)
            {
                throw new Exception(Conexion.MensajeError(ex));
            }
        }

        // Evita la DUPLICIDAD DE HORARIOS: revisa si el médico ya tiene una cita
        // (que no esté cancelada) en la misma fecha y hora
        public bool HorarioOcupado()
        {
            using (SqlConnection con = Conexion.Conectar())
            {
                SqlCommand cmd = new SqlCommand(@"SELECT COUNT(*) FROM Citas
                                                  WHERE IdMedico = @idMedico AND Fecha = @fecha AND Hora = @hora
                                                    AND Estado <> 'Cancelada' AND IdCita <> @idCita", con);
                cmd.Parameters.AddWithValue("@idMedico", idMedico);
                cmd.Parameters.AddWithValue("@fecha", fecha.Date);
                cmd.Parameters.AddWithValue("@hora", hora);
                cmd.Parameters.AddWithValue("@idCita", idCita);
                return Convert.ToInt32(cmd.ExecuteScalar()) > 0;
            }
        }

        public bool Agregar()
        {
            try
            {
                using (SqlConnection con = Conexion.Conectar())
                {
                    SqlCommand cmd = new SqlCommand(@"INSERT INTO Citas (IdPaciente, IdMedico, Fecha, Hora, Motivo, Estado)
                                                      VALUES (@idPaciente, @idMedico, @fecha, @hora, @motivo, @estado)", con);
                    cmd.Parameters.AddWithValue("@idPaciente", idPaciente);
                    cmd.Parameters.AddWithValue("@idMedico", idMedico);
                    cmd.Parameters.AddWithValue("@fecha", fecha.Date);
                    cmd.Parameters.AddWithValue("@hora", hora);
                    cmd.Parameters.AddWithValue("@motivo", motivo);
                    cmd.Parameters.AddWithValue("@estado", estado);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            catch (SqlException ex)
            {
                throw new Exception(Conexion.MensajeError(ex));
            }
        }

        public bool Modificar()
        {
            try
            {
                using (SqlConnection con = Conexion.Conectar())
                {
                    SqlCommand cmd = new SqlCommand(@"UPDATE Citas SET IdPaciente = @idPaciente, IdMedico = @idMedico, Fecha = @fecha,
                                                             Hora = @hora, Motivo = @motivo, Estado = @estado
                                                      WHERE IdCita = @id", con);
                    cmd.Parameters.AddWithValue("@idPaciente", idPaciente);
                    cmd.Parameters.AddWithValue("@idMedico", idMedico);
                    cmd.Parameters.AddWithValue("@fecha", fecha.Date);
                    cmd.Parameters.AddWithValue("@hora", hora);
                    cmd.Parameters.AddWithValue("@motivo", motivo);
                    cmd.Parameters.AddWithValue("@estado", estado);
                    cmd.Parameters.AddWithValue("@id", idCita);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            catch (SqlException ex)
            {
                throw new Exception(Conexion.MensajeError(ex));
            }
        }

        public static bool Eliminar(int idCita)
        {
            try
            {
                using (SqlConnection con = Conexion.Conectar())
                {
                    SqlCommand cmd = new SqlCommand("DELETE FROM Citas WHERE IdCita = @id", con);
                    cmd.Parameters.AddWithValue("@id", idCita);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            catch (SqlException ex)
            {
                throw new Exception(Conexion.MensajeError(ex));
            }
        }
    }
}
