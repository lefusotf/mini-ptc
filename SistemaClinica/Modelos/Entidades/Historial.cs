using Modelos.Conexion_DB;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Modelos.Entidades
{
    public class Historial
    {
        private int idHistorial;
        private int idPaciente;
        private int idMedico;
        private string diagnostico;
        private string tratamiento;

        public int IdHistorial { get => idHistorial; set => idHistorial = value; }
        public int IdPaciente { get => idPaciente; set => idPaciente = value; }
        public int IdMedico { get => idMedico; set => idMedico = value; }
        public string Diagnostico { get => diagnostico; set => diagnostico = value; }
        public string Tratamiento { get => tratamiento; set => tratamiento = value; }

        // Todas las consultas de un paciente (seguimiento histórico)
        public static DataTable cargarHistorial(int idPaciente)
        {
            DataTable tablaVirtual = new DataTable();
            using (SqlConnection conexion = Conexion.conectar())
            {
                if (conexion == null) return tablaVirtual;
                SqlCommand comandoObjeto = new SqlCommand("SELECT * FROM vistaHistorial WHERE id_Paciente = @idPaciente ORDER BY Fecha DESC;", conexion);
                comandoObjeto.Parameters.AddWithValue("@idPaciente", idPaciente);
                SqlDataAdapter adaptador = new SqlDataAdapter(comandoObjeto);
                adaptador.Fill(tablaVirtual);
            }
            return tablaVirtual;
        }

        public bool InsertarHistorial()
        {
            string comandoSQL = "INSERT INTO Historial (id_Paciente, id_Medico, diagnostico, tratamiento) " +
                                "VALUES (@id_Paciente, @id_Medico, @diagnostico, @tratamiento);";
            try
            {
                using (SqlConnection conexion = Conexion.conectar())
                {
                    if (conexion == null) return false;
                    using (SqlCommand comandoObjeto = new SqlCommand(comandoSQL, conexion))
                    {
                        comandoObjeto.Parameters.AddWithValue("@id_Paciente", idPaciente);
                        comandoObjeto.Parameters.AddWithValue("@id_Medico", idMedico);
                        comandoObjeto.Parameters.AddWithValue("@diagnostico", diagnostico);
                        comandoObjeto.Parameters.AddWithValue("@tratamiento", tratamiento);
                        return comandoObjeto.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error al registrar la consulta: " + ex.Message, "Error BD", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public bool ActualizarHistorial()
        {
            string comandoSQL = "UPDATE Historial SET diagnostico = @diagnostico, tratamiento = @tratamiento WHERE idHistorial = @idHistorial;";
            try
            {
                using (SqlConnection conexion = Conexion.conectar())
                {
                    if (conexion == null) return false;
                    using (SqlCommand comandoObjeto = new SqlCommand(comandoSQL, conexion))
                    {
                        comandoObjeto.Parameters.AddWithValue("@diagnostico", diagnostico);
                        comandoObjeto.Parameters.AddWithValue("@tratamiento", tratamiento);
                        comandoObjeto.Parameters.AddWithValue("@idHistorial", idHistorial);
                        return comandoObjeto.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error al actualizar el historial: " + ex.Message, "Error BD", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public static bool EliminarHistorial(int idHistorial)
        {
            try
            {
                using (SqlConnection conexion = Conexion.conectar())
                {
                    if (conexion == null) return false;
                    using (SqlCommand comandoObjeto = new SqlCommand("DELETE FROM Historial WHERE idHistorial = @idHistorial;", conexion))
                    {
                        comandoObjeto.Parameters.AddWithValue("@idHistorial", idHistorial);
                        return comandoObjeto.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error al eliminar la consulta: " + ex.Message, "Error BD", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
