using Microsoft.Data.SqlClient;

namespace ClinicaMedica.Modelo.DAO
{
    /// <summary>Métodos de ayuda para leer columnas que pueden venir NULL desde SQL Server.</summary>
    internal static class LectorExtensiones
    {
        public static string Texto(this SqlDataReader dr, string col) =>
            dr[col] == DBNull.Value ? null : dr[col].ToString();

        public static int Entero(this SqlDataReader dr, string col) => Convert.ToInt32(dr[col]);

        public static int? EnteroNulo(this SqlDataReader dr, string col) =>
            dr[col] == DBNull.Value ? (int?)null : Convert.ToInt32(dr[col]);

        public static DateTime Fecha(this SqlDataReader dr, string col) => Convert.ToDateTime(dr[col]);

        public static DateTime? FechaNula(this SqlDataReader dr, string col) =>
            dr[col] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(dr[col]);

        public static bool Booleano(this SqlDataReader dr, string col) => Convert.ToBoolean(dr[col]);
    }
}
