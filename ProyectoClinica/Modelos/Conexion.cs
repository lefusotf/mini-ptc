using System;
using System.Data.SqlClient;

namespace Modelos
{
    public class Conexion
    {
        // Cambiar el servidor por el que aparece en SQL Server Management Studio
        private static string servidor = "(localdb)\\MSSQLLocalDB";
        private static string baseDatos = "ClinicaDB";

        public static SqlConnection Conectar()
        {
            SqlConnection conexion = new SqlConnection("Data Source=" + servidor + "; Initial Catalog=" + baseDatos + "; Integrated Security=true;");
            conexion.Open();
            return conexion;
        }

        // Convierte los errores de SQL Server en mensajes que el usuario entienda
        public static string MensajeError(SqlException ex)
        {
            if (ex.Number == 547)
                return "No se puede eliminar porque tiene registros relacionados (citas, historial, etc.).";
            if (ex.Number == 2627 || ex.Number == 2601)
                return "Ese registro ya existe (dato repetido).";
            if (ex.Number == 4060)
                return "No existe la base de datos ClinicaDB. Ejecute el script ClinicaDB.sql.";
            if (ex.Number == 2 || ex.Number == 53 || ex.Number == -1)
                return "No se pudo conectar con SQL Server. Revise el nombre del servidor en Conexion.cs.";
            return "Error de base de datos: " + ex.Message;
        }
    }
}
