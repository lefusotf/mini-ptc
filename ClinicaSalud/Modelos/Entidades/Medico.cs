using Modelos.Conexion_DB;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Modelos.Entidades
{
    public class Medico
    {
        private int idMedico;
        private string nombreMedico;
        private string telefono;
        private string correo;
        private int idEspecialidad;
        private int idUsuario;

        public int IdMedico { get => idMedico; set => idMedico = value; }
        public string NombreMedico { get => nombreMedico; set => nombreMedico = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Correo { get => correo; set => correo = value; }
        public int IdEspecialidad { get => idEspecialidad; set => idEspecialidad = value; }
        public int IdUsuario { get => idUsuario; set => idUsuario = value; }

        public static DataTable cargarMedicos()
        {
            DataTable tablaVirtual = new DataTable();
            using (SqlConnection conexion = Conexion.conectar())
            {
                if (conexion == null) return tablaVirtual;
                SqlDataAdapter adaptador = new SqlDataAdapter("SELECT * FROM vistaMedicos;", conexion);
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
                SqlDataAdapter adaptador = new SqlDataAdapter("SELECT idMedico, nombreMedico FROM Medico;", conexion);
                adaptador.Fill(tablaVirtual);
            }
            return tablaVirtual;
        }

        public static DataTable cargarUsuariosMedicos()
        {
            DataTable tablaVirtual = new DataTable();
            using (SqlConnection conexion = Conexion.conectar())
            {
                if (conexion == null) return tablaVirtual;
                SqlDataAdapter adaptador = new SqlDataAdapter("SELECT idUsuario, nombreUsuario FROM Usuario WHERE id_Rol = 2;", conexion);
                adaptador.Fill(tablaVirtual);
            }
            DataRow fila = tablaVirtual.NewRow();
            fila["idUsuario"] = 0;
            fila["nombreUsuario"] = "(Sin usuario)";
            tablaVirtual.Rows.InsertAt(fila, 0);
            return tablaVirtual;
        }

        // Si el usuario que inició sesión es médico, devuelve su idMedico (0 si no lo es)
        public static int obtenerIdMedico(int idUsuario)
        {
            using (SqlConnection conexion = Conexion.conectar())
            {
                if (conexion == null) return 0;
                using (SqlCommand comandoObjeto = new SqlCommand("SELECT idMedico FROM Medico WHERE id_Usuario = @idUsuario;", conexion))
                {
                    comandoObjeto.Parameters.AddWithValue("@idUsuario", idUsuario);
                    object resultado = comandoObjeto.ExecuteScalar();
                    if (resultado == null) return 0;
                    return Convert.ToInt32(resultado);
                }
            }
        }

        public bool InsertarMedico()
        {
            string comandoSQL = "INSERT INTO Medico (nombreMedico, telefono, correo, id_Especialidad, id_Usuario) " +
                                "VALUES (@nombre, @telefono, @correo, @id_Especialidad, @id_Usuario);";
            try
            {
                using (SqlConnection conexion = Conexion.conectar())
                {
                    if (conexion == null) return false;
                    using (SqlCommand comandoObjeto = new SqlCommand(comandoSQL, conexion))
                    {
                        comandoObjeto.Parameters.AddWithValue("@nombre", nombreMedico);
                        comandoObjeto.Parameters.AddWithValue("@telefono", telefono);
                        comandoObjeto.Parameters.AddWithValue("@correo", correo);
                        comandoObjeto.Parameters.AddWithValue("@id_Especialidad", idEspecialidad);
                        if (idUsuario == 0)
                            comandoObjeto.Parameters.AddWithValue("@id_Usuario", DBNull.Value);
                        else
                            comandoObjeto.Parameters.AddWithValue("@id_Usuario", idUsuario);
                        return comandoObjeto.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error al registrar el médico: " + ex.Message, "Error BD", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public bool ActualizarMedico()
        {
            string comandoSQL = @"UPDATE Medico SET nombreMedico = @nombre, telefono = @telefono, correo = @correo,
                                         id_Especialidad = @id_Especialidad, id_Usuario = @id_Usuario
                                  WHERE idMedico = @idMedico;";
            try
            {
                using (SqlConnection conexion = Conexion.conectar())
                {
                    if (conexion == null) return false;
                    using (SqlCommand comandoObjeto = new SqlCommand(comandoSQL, conexion))
                    {
                        comandoObjeto.Parameters.AddWithValue("@nombre", nombreMedico);
                        comandoObjeto.Parameters.AddWithValue("@telefono", telefono);
                        comandoObjeto.Parameters.AddWithValue("@correo", correo);
                        comandoObjeto.Parameters.AddWithValue("@id_Especialidad", idEspecialidad);
                        if (idUsuario == 0)
                            comandoObjeto.Parameters.AddWithValue("@id_Usuario", DBNull.Value);
                        else
                            comandoObjeto.Parameters.AddWithValue("@id_Usuario", idUsuario);
                        comandoObjeto.Parameters.AddWithValue("@idMedico", idMedico);
                        return comandoObjeto.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error al actualizar el médico: " + ex.Message, "Error BD", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public static bool EliminarMedico(int idMedico)
        {
            try
            {
                using (SqlConnection conexion = Conexion.conectar())
                {
                    if (conexion == null) return false;
                    using (SqlCommand comandoObjeto = new SqlCommand("DELETE FROM Medico WHERE idMedico = @idMedico;", conexion))
                    {
                        comandoObjeto.Parameters.AddWithValue("@idMedico", idMedico);
                        return comandoObjeto.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (SqlException ex)
            {
                if (ex.Number == 547)
                    MessageBox.Show("No se puede eliminar porque el médico tiene citas o historial registrado.", "Conflicto de Referencias", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                else
                    MessageBox.Show("Error al eliminar el médico: " + ex.Message, "Error BD", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public static DataTable buscarMedicos(string texto)
        {
            DataTable tablaVirtual = new DataTable();
            using (SqlConnection conexion = Conexion.conectar())
            {
                if (conexion == null) return tablaVirtual;
                SqlCommand comandoObjeto = new SqlCommand("SELECT * FROM vistaMedicos WHERE Medico LIKE @texto OR Especialidad LIKE @texto;", conexion);
                comandoObjeto.Parameters.AddWithValue("@texto", "%" + texto + "%");
                SqlDataAdapter adaptador = new SqlDataAdapter(comandoObjeto);
                adaptador.Fill(tablaVirtual);
            }
            return tablaVirtual;
        }

        public static int contarMedicos()
        {
            using (SqlConnection conexion = Conexion.conectar())
            {
                if (conexion == null) return 0;
                SqlCommand comandoObjeto = new SqlCommand("SELECT COUNT(*) FROM Medico;", conexion);
                return Convert.ToInt32(comandoObjeto.ExecuteScalar());
            }
        }
    }
}
