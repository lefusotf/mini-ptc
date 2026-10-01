using System;
using System.Data;
using System.Data.SqlClient;

namespace Modelos
{
    public class Historial
    {
        private int idHistorial;
        private int idPaciente;
        private int idMedico;
        private string diagnostico;
        private string tratamiento;

        public int IdHistorial { get { return idHistorial; } set { idHistorial = value; } }
        public int IdPaciente { get { return idPaciente; } set { idPaciente = value; } }
        public int IdMedico { get { return idMedico; } set { idMedico = value; } }
        public string Diagnostico { get { return diagnostico; } set { diagnostico = value; } }
        public string Tratamiento { get { return tratamiento; } set { tratamiento = value; } }

        // Historial completo de un paciente (seguimiento histórico)
        public static DataTable MostrarPorPaciente(int idPaciente)
        {
            try
            {
                using (SqlConnection con = Conexion.Conectar())
                {
                    string consulta = @"SELECT h.IdHistorial, h.IdMedico, h.Fecha, m.Nombre AS Medico, h.Diagnostico, h.Tratamiento
                                        FROM Historial h
                                        INNER JOIN Medicos m ON h.IdMedico = m.IdMedico
                                        WHERE h.IdPaciente = @idPaciente
                                        ORDER BY h.Fecha DESC";
                    SqlCommand cmd = new SqlCommand(consulta, con);
                    cmd.Parameters.AddWithValue("@idPaciente", idPaciente);
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

        public bool Agregar()
        {
            try
            {
                using (SqlConnection con = Conexion.Conectar())
                {
                    SqlCommand cmd = new SqlCommand(@"INSERT INTO Historial (IdPaciente, IdMedico, Diagnostico, Tratamiento)
                                                      VALUES (@idPaciente, @idMedico, @diagnostico, @tratamiento)", con);
                    cmd.Parameters.AddWithValue("@idPaciente", idPaciente);
                    cmd.Parameters.AddWithValue("@idMedico", idMedico);
                    cmd.Parameters.AddWithValue("@diagnostico", diagnostico);
                    cmd.Parameters.AddWithValue("@tratamiento", tratamiento);
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
                    SqlCommand cmd = new SqlCommand(@"UPDATE Historial SET Diagnostico = @diagnostico, Tratamiento = @tratamiento
                                                      WHERE IdHistorial = @id", con);
                    cmd.Parameters.AddWithValue("@diagnostico", diagnostico);
                    cmd.Parameters.AddWithValue("@tratamiento", tratamiento);
                    cmd.Parameters.AddWithValue("@id", idHistorial);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            catch (SqlException ex)
            {
                throw new Exception(Conexion.MensajeError(ex));
            }
        }

        public static bool Eliminar(int idHistorial)
        {
            try
            {
                using (SqlConnection con = Conexion.Conectar())
                {
                    SqlCommand cmd = new SqlCommand("DELETE FROM Historial WHERE IdHistorial = @id", con);
                    cmd.Parameters.AddWithValue("@id", idHistorial);
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
