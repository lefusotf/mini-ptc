using System;
using System.Data;
using System.Data.SqlClient;

namespace Modelos
{
    public class Medico
    {
        private int idMedico;
        private string nombre;
        private string telefono;
        private string correo;
        private int idEspecialidad;
        private int idUsuario;   // 0 = sin usuario

        public int IdMedico { get { return idMedico; } set { idMedico = value; } }
        public string Nombre { get { return nombre; } set { nombre = value; } }
        public string Telefono { get { return telefono; } set { telefono = value; } }
        public string Correo { get { return correo; } set { correo = value; } }
        public int IdEspecialidad { get { return idEspecialidad; } set { idEspecialidad = value; } }
        public int IdUsuario { get { return idUsuario; } set { idUsuario = value; } }

        public static DataTable Mostrar(string buscar)
        {
            try
            {
                using (SqlConnection con = Conexion.Conectar())
                {
                    string consulta = @"SELECT m.IdMedico, m.Nombre, m.Telefono, m.Correo,
                                               e.NombreEspecialidad AS Especialidad, u.Usuario
                                        FROM Medicos m
                                        INNER JOIN Especialidades e ON m.IdEspecialidad = e.IdEspecialidad
                                        LEFT JOIN Usuarios u ON m.IdUsuario = u.IdUsuario
                                        WHERE m.Nombre LIKE @buscar OR e.NombreEspecialidad LIKE @buscar";
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
        public static DataTable ObtenerMedicos()
        {
            try
            {
                using (SqlConnection con = Conexion.Conectar())
                {
                    SqlDataAdapter da = new SqlDataAdapter("SELECT IdMedico, Nombre FROM Medicos ORDER BY Nombre", con);
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

        // Usuarios con rol Médico (IdRol = 2) para ligarlos a un médico
        public static DataTable ObtenerUsuariosMedicos()
        {
            try
            {
                using (SqlConnection con = Conexion.Conectar())
                {
                    SqlDataAdapter da = new SqlDataAdapter(
                        "SELECT 0 AS IdUsuario, '(Sin usuario)' AS Usuario UNION ALL SELECT IdUsuario, Usuario FROM Usuarios WHERE IdRol = 2", con);
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

        public static int ObtenerIdMedicoDeUsuario(int idUsuario)
        {
            using (SqlConnection con = Conexion.Conectar())
            {
                SqlCommand cmd = new SqlCommand("SELECT IdMedico FROM Medicos WHERE IdUsuario = @id", con);
                cmd.Parameters.AddWithValue("@id", idUsuario);
                object resultado = cmd.ExecuteScalar();
                return resultado == null ? 0 : Convert.ToInt32(resultado);
            }
        }

        public bool Agregar()
        {
            try
            {
                using (SqlConnection con = Conexion.Conectar())
                {
                    SqlCommand cmd = new SqlCommand(@"INSERT INTO Medicos (Nombre, Telefono, Correo, IdEspecialidad, IdUsuario)
                                                      VALUES (@nombre, @telefono, @correo, @idEspecialidad, @idUsuario)", con);
                    cmd.Parameters.AddWithValue("@nombre", nombre);
                    cmd.Parameters.AddWithValue("@telefono", telefono);
                    cmd.Parameters.AddWithValue("@correo", correo);
                    cmd.Parameters.AddWithValue("@idEspecialidad", idEspecialidad);
                    cmd.Parameters.AddWithValue("@idUsuario", idUsuario == 0 ? (object)DBNull.Value : idUsuario);
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
                    SqlCommand cmd = new SqlCommand(@"UPDATE Medicos SET Nombre = @nombre, Telefono = @telefono, Correo = @correo,
                                                             IdEspecialidad = @idEspecialidad, IdUsuario = @idUsuario
                                                      WHERE IdMedico = @id", con);
                    cmd.Parameters.AddWithValue("@nombre", nombre);
                    cmd.Parameters.AddWithValue("@telefono", telefono);
                    cmd.Parameters.AddWithValue("@correo", correo);
                    cmd.Parameters.AddWithValue("@idEspecialidad", idEspecialidad);
                    cmd.Parameters.AddWithValue("@idUsuario", idUsuario == 0 ? (object)DBNull.Value : idUsuario);
                    cmd.Parameters.AddWithValue("@id", idMedico);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            catch (SqlException ex)
            {
                throw new Exception(Conexion.MensajeError(ex));
            }
        }

        public static bool Eliminar(int idMedico)
        {
            try
            {
                using (SqlConnection con = Conexion.Conectar())
                {
                    SqlCommand cmd = new SqlCommand("DELETE FROM Medicos WHERE IdMedico = @id", con);
                    cmd.Parameters.AddWithValue("@id", idMedico);
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
