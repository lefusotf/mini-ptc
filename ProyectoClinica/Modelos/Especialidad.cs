using System;
using System.Data;
using System.Data.SqlClient;

namespace Modelos
{
    public class Especialidad
    {
        private int idEspecialidad;
        private string nombreEspecialidad;

        public int IdEspecialidad { get { return idEspecialidad; } set { idEspecialidad = value; } }
        public string NombreEspecialidad { get { return nombreEspecialidad; } set { nombreEspecialidad = value; } }

        public static DataTable Mostrar()
        {
            try
            {
                using (SqlConnection con = Conexion.Conectar())
                {
                    SqlDataAdapter da = new SqlDataAdapter("SELECT IdEspecialidad, NombreEspecialidad FROM Especialidades", con);
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
                    SqlCommand cmd = new SqlCommand("INSERT INTO Especialidades (NombreEspecialidad) VALUES (@nombre)", con);
                    cmd.Parameters.AddWithValue("@nombre", nombreEspecialidad);
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
                    SqlCommand cmd = new SqlCommand("UPDATE Especialidades SET NombreEspecialidad = @nombre WHERE IdEspecialidad = @id", con);
                    cmd.Parameters.AddWithValue("@nombre", nombreEspecialidad);
                    cmd.Parameters.AddWithValue("@id", idEspecialidad);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            catch (SqlException ex)
            {
                throw new Exception(Conexion.MensajeError(ex));
            }
        }

        public static bool Eliminar(int idEspecialidad)
        {
            try
            {
                using (SqlConnection con = Conexion.Conectar())
                {
                    SqlCommand cmd = new SqlCommand("DELETE FROM Especialidades WHERE IdEspecialidad = @id", con);
                    cmd.Parameters.AddWithValue("@id", idEspecialidad);
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
