using Modelos.Conexion_DB;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Modelos.Entidades
{
    public class Especialidad
    {
        private int idEspecialidad;
        private string nombreEspecialidad;

        public int IdEspecialidad { get => idEspecialidad; set => idEspecialidad = value; }
        public string NombreEspecialidad { get => nombreEspecialidad; set => nombreEspecialidad = value; }

        public static DataTable cargarEspecialidades()
        {
            DataTable tablaVirtual = new DataTable();
            using (SqlConnection conexion = Conexion.conectar())
            {
                if (conexion == null) return tablaVirtual;
                string comandoSQL = "SELECT idEspecialidad AS [#], nombreEspecialidad AS [Especialidad] FROM Especialidad;";
                SqlDataAdapter adaptador = new SqlDataAdapter(comandoSQL, conexion);
                adaptador.Fill(tablaVirtual);
            }
            return tablaVirtual;
        }

        public static DataTable cargarCombo()
        {
            DataTable tablaVirtual = new DataTable();
            using (SqlConnection conexion = Conexion.conectar())
            {
                if (conexion == null) return tablaVirtual;
                SqlDataAdapter adaptador = new SqlDataAdapter("SELECT idEspecialidad, nombreEspecialidad FROM Especialidad;", conexion);
                adaptador.Fill(tablaVirtual);
            }
            return tablaVirtual;
        }

        public bool InsertarEspecialidad()
        {
            try
            {
                using (SqlConnection conexion = Conexion.conectar())
                {
                    if (conexion == null) return false;
                    using (SqlCommand comandoObjeto = new SqlCommand("INSERT INTO Especialidad (nombreEspecialidad) VALUES (@nombre);", conexion))
                    {
                        comandoObjeto.Parameters.AddWithValue("@nombre", nombreEspecialidad);
                        return comandoObjeto.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error al registrar la especialidad: " + ex.Message, "Error BD", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public bool ActualizarEspecialidad()
        {
            try
            {
                using (SqlConnection conexion = Conexion.conectar())
                {
                    if (conexion == null) return false;
                    using (SqlCommand comandoObjeto = new SqlCommand("UPDATE Especialidad SET nombreEspecialidad = @nombre WHERE idEspecialidad = @id;", conexion))
                    {
                        comandoObjeto.Parameters.AddWithValue("@nombre", nombreEspecialidad);
                        comandoObjeto.Parameters.AddWithValue("@id", idEspecialidad);
                        return comandoObjeto.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error al actualizar la especialidad: " + ex.Message, "Error BD", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public static bool EliminarEspecialidad(int idEspecialidad)
        {
            try
            {
                using (SqlConnection conexion = Conexion.conectar())
                {
                    if (conexion == null) return false;
                    using (SqlCommand comandoObjeto = new SqlCommand("DELETE FROM Especialidad WHERE idEspecialidad = @id;", conexion))
                    {
                        comandoObjeto.Parameters.AddWithValue("@id", idEspecialidad);
                        return comandoObjeto.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (SqlException ex)
            {
                if (ex.Number == 547)
                    MessageBox.Show("No se puede eliminar porque hay médicos con esta especialidad.", "Conflicto de Referencias", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                else
                    MessageBox.Show("Error al eliminar la especialidad: " + ex.Message, "Error BD", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
