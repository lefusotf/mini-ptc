using Modelos.Conexion_DB;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Modelos.Entidades
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

        public int IdCita { get => idCita; set => idCita = value; }
        public int IdPaciente { get => idPaciente; set => idPaciente = value; }
        public int IdMedico { get => idMedico; set => idMedico = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public string Hora { get => hora; set => hora = value; }
        public string Motivo { get => motivo; set => motivo = value; }
        public string Estado { get => estado; set => estado = value; }

        public static DataTable cargarCitas(int idMedico)
        {
            DataTable tablaVirtual = new DataTable();
            using (SqlConnection conexion = Conexion.conectar())
            {
                if (conexion == null) return tablaVirtual;
                string comandoSQL = "SELECT * FROM vistaCitas";
                if (idMedico > 0)
                    comandoSQL += " WHERE id_Medico = @idMedico";
                comandoSQL += " ORDER BY Fecha DESC, Hora;";

                SqlCommand comandoObjeto = new SqlCommand(comandoSQL, conexion);
                comandoObjeto.Parameters.AddWithValue("@idMedico", idMedico);
                SqlDataAdapter adaptador = new SqlDataAdapter(comandoObjeto);
                adaptador.Fill(tablaVirtual);
            }
            return tablaVirtual;
        }

        // Evita la duplicidad de horarios: un médico no puede tener dos citas a la misma fecha y hora
        public bool horarioOcupado()
        {
            string comandoSQL = @"SELECT COUNT(*) FROM Cita
                                  WHERE id_Medico = @idMedico AND fecha = @fecha AND hora = @hora
                                    AND estado <> 'Cancelada' AND idCita <> @idCita;";
            using (SqlConnection conexion = Conexion.conectar())
            {
                if (conexion == null) return false;
                using (SqlCommand comandoObjeto = new SqlCommand(comandoSQL, conexion))
                {
                    comandoObjeto.Parameters.AddWithValue("@idMedico", idMedico);
                    comandoObjeto.Parameters.AddWithValue("@fecha", fecha.Date);
                    comandoObjeto.Parameters.AddWithValue("@hora", hora);
                    comandoObjeto.Parameters.AddWithValue("@idCita", idCita);
                    int cantidad = Convert.ToInt32(comandoObjeto.ExecuteScalar());
                    return cantidad > 0;
                }
            }
        }

        public bool InsertarCita()
        {
            string comandoSQL = "INSERT INTO Cita (id_Paciente, id_Medico, fecha, hora, motivo, estado) " +
                                "VALUES (@id_Paciente, @id_Medico, @fecha, @hora, @motivo, @estado);";
            try
            {
                using (SqlConnection conexion = Conexion.conectar())
                {
                    if (conexion == null) return false;
                    using (SqlCommand comandoObjeto = new SqlCommand(comandoSQL, conexion))
                    {
                        comandoObjeto.Parameters.AddWithValue("@id_Paciente", idPaciente);
                        comandoObjeto.Parameters.AddWithValue("@id_Medico", idMedico);
                        comandoObjeto.Parameters.AddWithValue("@fecha", fecha.Date);
                        comandoObjeto.Parameters.AddWithValue("@hora", hora);
                        comandoObjeto.Parameters.AddWithValue("@motivo", motivo);
                        comandoObjeto.Parameters.AddWithValue("@estado", estado);
                        return comandoObjeto.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error al registrar la cita: " + ex.Message, "Error BD", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public bool ActualizarCita()
        {
            string comandoSQL = @"UPDATE Cita SET id_Paciente = @id_Paciente, id_Medico = @id_Medico, fecha = @fecha,
                                         hora = @hora, motivo = @motivo, estado = @estado
                                  WHERE idCita = @idCita;";
            try
            {
                using (SqlConnection conexion = Conexion.conectar())
                {
                    if (conexion == null) return false;
                    using (SqlCommand comandoObjeto = new SqlCommand(comandoSQL, conexion))
                    {
                        comandoObjeto.Parameters.AddWithValue("@id_Paciente", idPaciente);
                        comandoObjeto.Parameters.AddWithValue("@id_Medico", idMedico);
                        comandoObjeto.Parameters.AddWithValue("@fecha", fecha.Date);
                        comandoObjeto.Parameters.AddWithValue("@hora", hora);
                        comandoObjeto.Parameters.AddWithValue("@motivo", motivo);
                        comandoObjeto.Parameters.AddWithValue("@estado", estado);
                        comandoObjeto.Parameters.AddWithValue("@idCita", idCita);
                        return comandoObjeto.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error al actualizar la cita: " + ex.Message, "Error BD", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public static Cita buscarCita(int idCita)
        {
            using (SqlConnection conexion = Conexion.conectar())
            {
                if (conexion == null) return null;
                using (SqlCommand comandoObjeto = new SqlCommand("SELECT * FROM Cita WHERE idCita = @idCita;", conexion))
                {
                    comandoObjeto.Parameters.AddWithValue("@idCita", idCita);
                    using (SqlDataReader lector = comandoObjeto.ExecuteReader())
                    {
                        if (!lector.Read()) return null;
                        Cita cita = new Cita();
                        cita.IdCita = Convert.ToInt32(lector["idCita"]);
                        cita.IdPaciente = Convert.ToInt32(lector["id_Paciente"]);
                        cita.IdMedico = Convert.ToInt32(lector["id_Medico"]);
                        cita.Fecha = Convert.ToDateTime(lector["fecha"]);
                        cita.Hora = lector["hora"].ToString();
                        cita.Motivo = lector["motivo"].ToString();
                        cita.Estado = lector["estado"].ToString();
                        return cita;
                    }
                }
            }
        }

        public static bool EliminarCita(int idCita)
        {
            try
            {
                using (SqlConnection conexion = Conexion.conectar())
                {
                    if (conexion == null) return false;
                    using (SqlCommand comandoObjeto = new SqlCommand("DELETE FROM Cita WHERE idCita = @idCita;", conexion))
                    {
                        comandoObjeto.Parameters.AddWithValue("@idCita", idCita);
                        return comandoObjeto.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error al eliminar la cita: " + ex.Message, "Error BD", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public static DataTable buscarCitas(string texto, int idMedico)
        {
            DataTable tablaVirtual = new DataTable();
            using (SqlConnection conexion = Conexion.conectar())
            {
                if (conexion == null) return tablaVirtual;
                string comandoSQL = "SELECT * FROM vistaCitas WHERE (Paciente LIKE @texto OR Medico LIKE @texto OR Estado LIKE @texto)";
                if (idMedico > 0)
                    comandoSQL += " AND id_Medico = @idMedico";
                comandoSQL += " ORDER BY Fecha DESC, Hora;";
                SqlCommand comandoObjeto = new SqlCommand(comandoSQL, conexion);
                comandoObjeto.Parameters.AddWithValue("@texto", "%" + texto + "%");
                comandoObjeto.Parameters.AddWithValue("@idMedico", idMedico);
                SqlDataAdapter adaptador = new SqlDataAdapter(comandoObjeto);
                adaptador.Fill(tablaVirtual);
            }
            return tablaVirtual;
        }

        public static DataTable cargarCitasHoy(int idMedico)
        {
            DataTable tablaVirtual = new DataTable();
            using (SqlConnection conexion = Conexion.conectar())
            {
                if (conexion == null) return tablaVirtual;
                string comandoSQL = "SELECT Hora, Paciente, Medico, Motivo, Estado, id_Medico FROM vistaCitas WHERE Fecha = CAST(GETDATE() AS DATE)";
                if (idMedico > 0)
                    comandoSQL += " AND id_Medico = @idMedico";
                comandoSQL += " ORDER BY Hora;";
                SqlCommand comandoObjeto = new SqlCommand(comandoSQL, conexion);
                comandoObjeto.Parameters.AddWithValue("@idMedico", idMedico);
                SqlDataAdapter adaptador = new SqlDataAdapter(comandoObjeto);
                adaptador.Fill(tablaVirtual);
            }
            return tablaVirtual;
        }

        public static int contarCitas(int idMedico, bool soloHoy, bool soloPendientes)
        {
            using (SqlConnection conexion = Conexion.conectar())
            {
                if (conexion == null) return 0;
                string comandoSQL = "SELECT COUNT(*) FROM Cita WHERE 1 = 1";
                if (soloHoy) comandoSQL += " AND fecha = CAST(GETDATE() AS DATE)";
                if (soloPendientes) comandoSQL += " AND estado = 'Pendiente'";
                if (idMedico > 0) comandoSQL += " AND id_Medico = @idMedico";
                SqlCommand comandoObjeto = new SqlCommand(comandoSQL, conexion);
                comandoObjeto.Parameters.AddWithValue("@idMedico", idMedico);
                return Convert.ToInt32(comandoObjeto.ExecuteScalar());
            }
        }
    }
}
