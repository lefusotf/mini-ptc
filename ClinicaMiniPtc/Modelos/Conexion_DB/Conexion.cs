using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Modelos.Conexion_DB
{
    public class Conexion
    {
        private static string servidor = "(localdb)\\MSSQLLocalDB";
        private static string baseDeDatos = "ClinicaMiniPtcDB";

        public static SqlConnection conectar()
        {
            string cadena = $"Data Source={servidor};Initial Catalog={baseDeDatos};Integrated Security=true;";
            SqlConnection conexion = new SqlConnection(cadena);
            try
            {
                conexion.Open();
                return conexion;
            }
            catch (SqlException ex)
            {
                conexion.Dispose();
                switch (ex.Number)
                {
                    case 2:
                    case 53:
                        MessageBox.Show($"No se pudo encontrar el servidor '{servidor}'. Verifica que el servicio de SQL Server esté iniciado.",
                            "Servidor Inaccesible", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    case 4060:
                        MessageBox.Show($"La base de datos '{baseDeDatos}' no existe en el servidor o no tienes autorización.",
                            "Base de Datos no encontrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    default:
                        MessageBox.Show($"Error inesperado de SQL Server ({ex.Number}: {ex.Message})",
                            "Error de Conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }
                return null;
            }
            catch (Exception ex)
            {
                conexion.Dispose();
                MessageBox.Show("Ocurrió un error general del sistema: " + ex.Message, "Error crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
    }
}
