using Modelos.Conexion_DB;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Modelos.Entidades
{
    public class Paciente
    {
        private int idPaciente;
        private string nombrePaciente;
        private string dui;
        private DateTime fechaNacimiento;
        private string genero;
        private string telefono;
        private string direccion;

        public int IdPaciente { get => idPaciente; set => idPaciente = value; }
        public string NombrePaciente { get => nombrePaciente; set => nombrePaciente = value; }
        public string Dui { get => dui; set => dui = value; }
        public DateTime FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
        public string Genero { get => genero; set => genero = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Direccion { get => direccion; set => direccion = value; }

        public static DataTable cargarPacientes()
        {
            DataTable tablaVirtual = new DataTable();
            using (SqlConnection conexion = Conexion.conectar())
            {
                if (conexion == null) return tablaVirtual;
                SqlDataAdapter adaptador = new SqlDataAdapter("SELECT * FROM vistaPacientes;", conexion);
                adaptador.Fill(tablaVirtual);
            }
            return tablaVirtual;
        }

        // Para los ComboBox de citas e historial
        public static DataTable cargarCombo()
        {
            DataTable tablaVirtual = new DataTable();
            using (SqlConnection conexion = Conexion.conectar())
            {
                if (conexion == null) return tablaVirtual;
                SqlDataAdapter adaptador = new SqlDataAdapter("SELECT idPaciente, nombrePaciente FROM Paciente;", conexion);
                adaptador.Fill(tablaVirtual);
            }
            return tablaVirtual;
        }

        public bool InsertarPaciente()
        {
            string comandoSQL = "INSERT INTO Paciente (nombrePaciente, dui, fechaNacimiento, genero, telefono, direccion) " +
                                "VALUES (@nombre, @dui, @fechaNacimiento, @genero, @telefono, @direccion);";
            try
            {
                using (SqlConnection conexion = Conexion.conectar())
                {
                    if (conexion == null) return false;
                    using (SqlCommand comandoObjeto = new SqlCommand(comandoSQL, conexion))
                    {
                        comandoObjeto.Parameters.AddWithValue("@nombre", nombrePaciente);
                        comandoObjeto.Parameters.AddWithValue("@dui", dui);
                        comandoObjeto.Parameters.AddWithValue("@fechaNacimiento", fechaNacimiento);
                        comandoObjeto.Parameters.AddWithValue("@genero", genero);
                        comandoObjeto.Parameters.AddWithValue("@telefono", telefono);
                        comandoObjeto.Parameters.AddWithValue("@direccion", direccion);
                        return comandoObjeto.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error al registrar el paciente: " + ex.Message, "Error BD", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public bool ActualizarPaciente()
        {
            string comandoSQL = @"UPDATE Paciente SET nombrePaciente = @nombre, dui = @dui, fechaNacimiento = @fechaNacimiento,
                                         genero = @genero, telefono = @telefono, direccion = @direccion
                                  WHERE idPaciente = @idPaciente;";
            try
            {
                using (SqlConnection conexion = Conexion.conectar())
                {
                    if (conexion == null) return false;
                    using (SqlCommand comandoObjeto = new SqlCommand(comandoSQL, conexion))
                    {
                        comandoObjeto.Parameters.AddWithValue("@nombre", nombrePaciente);
                        comandoObjeto.Parameters.AddWithValue("@dui", dui);
                        comandoObjeto.Parameters.AddWithValue("@fechaNacimiento", fechaNacimiento);
                        comandoObjeto.Parameters.AddWithValue("@genero", genero);
                        comandoObjeto.Parameters.AddWithValue("@telefono", telefono);
                        comandoObjeto.Parameters.AddWithValue("@direccion", direccion);
                        comandoObjeto.Parameters.AddWithValue("@idPaciente", idPaciente);
                        return comandoObjeto.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error al actualizar el paciente: " + ex.Message, "Error BD", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public static bool EliminarPaciente(int idPaciente)
        {
            try
            {
                using (SqlConnection conexion = Conexion.conectar())
                {
                    if (conexion == null) return false;
                    using (SqlCommand comandoObjeto = new SqlCommand("DELETE FROM Paciente WHERE idPaciente = @idPaciente;", conexion))
                    {
                        comandoObjeto.Parameters.AddWithValue("@idPaciente", idPaciente);
                        return comandoObjeto.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (SqlException ex)
            {
                if (ex.Number == 547)
                    MessageBox.Show("No se puede eliminar porque el paciente tiene citas o historial registrado.", "Conflicto de Referencias", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                else
                    MessageBox.Show("Error al eliminar el paciente: " + ex.Message, "Error BD", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
