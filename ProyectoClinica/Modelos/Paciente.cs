using System;
using System.Data;
using System.Data.SqlClient;

namespace Modelos
{
    public class Paciente
    {
        private int idPaciente;
        private string nombre;
        private string dui;
        private DateTime fechaNacimiento;
        private string genero;
        private string telefono;
        private string direccion;

        public int IdPaciente { get { return idPaciente; } set { idPaciente = value; } }
        public string Nombre { get { return nombre; } set { nombre = value; } }
        public string Dui { get { return dui; } set { dui = value; } }
        public DateTime FechaNacimiento { get { return fechaNacimiento; } set { fechaNacimiento = value; } }
        public string Genero { get { return genero; } set { genero = value; } }
        public string Telefono { get { return telefono; } set { telefono = value; } }
        public string Direccion { get { return direccion; } set { direccion = value; } }

        public static DataTable Mostrar(string buscar)
        {
            try
            {
                using (SqlConnection con = Conexion.Conectar())
                {
                    string consulta = @"SELECT IdPaciente, Nombre, DUI, FechaNacimiento, Genero, Telefono, Direccion
                                        FROM Pacientes
                                        WHERE Nombre LIKE @buscar OR DUI LIKE @buscar";
                    SqlCommand cmd = new SqlCommand(consulta, con);
                    cmd.Parameters.AddWithValue("@buscar", "%" + buscar + "%");
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

        // Para los ComboBox de citas e historial
        public static DataTable ObtenerPacientes()
        {
            try
            {
                using (SqlConnection con = Conexion.Conectar())
                {
                    SqlDataAdapter da = new SqlDataAdapter("SELECT IdPaciente, Nombre FROM Pacientes ORDER BY Nombre", con);
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
                    SqlCommand cmd = new SqlCommand(@"INSERT INTO Pacientes (Nombre, DUI, FechaNacimiento, Genero, Telefono, Direccion)
                                                      VALUES (@nombre, @dui, @fecha, @genero, @telefono, @direccion)", con);
                    cmd.Parameters.AddWithValue("@nombre", nombre);
                    cmd.Parameters.AddWithValue("@dui", string.IsNullOrEmpty(dui) ? (object)DBNull.Value : dui);
                    cmd.Parameters.AddWithValue("@fecha", fechaNacimiento);
                    cmd.Parameters.AddWithValue("@genero", genero);
                    cmd.Parameters.AddWithValue("@telefono", telefono);
                    cmd.Parameters.AddWithValue("@direccion", direccion);
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
                    SqlCommand cmd = new SqlCommand(@"UPDATE Pacientes SET Nombre = @nombre, DUI = @dui, FechaNacimiento = @fecha,
                                                             Genero = @genero, Telefono = @telefono, Direccion = @direccion
                                                      WHERE IdPaciente = @id", con);
                    cmd.Parameters.AddWithValue("@nombre", nombre);
                    cmd.Parameters.AddWithValue("@dui", string.IsNullOrEmpty(dui) ? (object)DBNull.Value : dui);
                    cmd.Parameters.AddWithValue("@fecha", fechaNacimiento);
                    cmd.Parameters.AddWithValue("@genero", genero);
                    cmd.Parameters.AddWithValue("@telefono", telefono);
                    cmd.Parameters.AddWithValue("@direccion", direccion);
                    cmd.Parameters.AddWithValue("@id", idPaciente);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            catch (SqlException ex)
            {
                throw new Exception(Conexion.MensajeError(ex));
            }
        }

        public static bool Eliminar(int idPaciente)
        {
            try
            {
                using (SqlConnection con = Conexion.Conectar())
                {
                    SqlCommand cmd = new SqlCommand("DELETE FROM Pacientes WHERE IdPaciente = @id", con);
                    cmd.Parameters.AddWithValue("@id", idPaciente);
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
