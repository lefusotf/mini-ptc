using System.Configuration;
using ClinicaMedica.Modelo.Utilidades;
using Microsoft.Data.SqlClient;

namespace ClinicaMedica.Modelo
{
    /// <summary>
    /// Centraliza la conexión a SQL Server.
    /// - La cadena de conexión se lee de App.config (no está "quemada" en el código).
    /// - Todas las consultas usan parámetros (evita inyección SQL).
    /// - Las conexiones se cierran siempre con "using".
    /// - Los errores de SQL se traducen a mensajes entendibles (ExcepcionDatos).
    /// </summary>
    public static class Conexion
    {
        private static string CadenaConexion
        {
            get
            {
                var cs = ConfigurationManager.ConnectionStrings["ClinicaDB"];
                if (cs == null)
                    throw new ExcepcionDatos("No se encontró la cadena de conexión 'ClinicaDB' en App.config.");
                return cs.ConnectionString;
            }
        }

        public static SqlConnection ObtenerConexion()
        {
            var cn = new SqlConnection(CadenaConexion);
            cn.Open();
            return cn;
        }

        /// <summary>Prueba si el servidor responde (se usa en el login).</summary>
        public static bool ProbarConexion(out string mensaje)
        {
            try
            {
                using (ObtenerConexion()) { }
                mensaje = "Conexión exitosa";
                return true;
            }
            catch (SqlException ex)
            {
                mensaje = TraducirError(ex);
                Logger.Error(ex, "Probar conexión");
                return false;
            }
            catch (Exception ex)
            {
                mensaje = ex.Message;
                Logger.Error(ex, "Probar conexión");
                return false;
            }
        }

        /// <summary>Ejecuta INSERT / UPDATE / DELETE y devuelve las filas afectadas.</summary>
        public static int Ejecutar(string sql, params SqlParameter[] parametros)
        {
            try
            {
                using (var cn = ObtenerConexion())
                using (var cmd = CrearComando(cn, sql, parametros))
                {
                    return cmd.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                Logger.Error(ex, sql);
                throw new ExcepcionDatos(TraducirError(ex), ex);
            }
        }

        /// <summary>Ejecuta una consulta que devuelve un solo valor (COUNT, SCOPE_IDENTITY...).</summary>
        public static object EjecutarEscalar(string sql, params SqlParameter[] parametros)
        {
            try
            {
                using (var cn = ObtenerConexion())
                using (var cmd = CrearComando(cn, sql, parametros))
                {
                    var valor = cmd.ExecuteScalar();
                    return valor == DBNull.Value ? null : valor;
                }
            }
            catch (SqlException ex)
            {
                Logger.Error(ex, sql);
                throw new ExcepcionDatos(TraducirError(ex), ex);
            }
        }

        /// <summary>Ejecuta un SELECT y convierte cada fila en un objeto usando la función "mapear".</summary>
        public static List<T> Consultar<T>(string sql, Func<SqlDataReader, T> mapear, params SqlParameter[] parametros)
        {
            var lista = new List<T>();
            try
            {
                using (var cn = ObtenerConexion())
                using (var cmd = CrearComando(cn, sql, parametros))
                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                        lista.Add(mapear(dr));
                }
                return lista;
            }
            catch (SqlException ex)
            {
                Logger.Error(ex, sql);
                throw new ExcepcionDatos(TraducirError(ex), ex);
            }
        }

        /// <summary>Crea un parámetro convirtiendo null en DBNull.</summary>
        public static SqlParameter Param(string nombre, object valor)
        {
            if (valor is string s && string.IsNullOrWhiteSpace(s))
                valor = null;
            return new SqlParameter(nombre, valor ?? DBNull.Value);
        }

        private static SqlCommand CrearComando(SqlConnection cn, string sql, SqlParameter[] parametros)
        {
            var cmd = new SqlCommand(sql, cn);
            if (parametros != null)
                cmd.Parameters.AddRange(parametros);
            return cmd;
        }

        /// <summary>Convierte los códigos de error de SQL Server en mensajes claros para el usuario.</summary>
        public static string TraducirError(SqlException ex)
        {
            switch (ex.Number)
            {
                case 2627:
                case 2601:
                    return "Ya existe un registro con esos datos (valor duplicado).\n" +
                           "Si es una cita, el médico ya tiene otra cita en ese horario.";
                case 547:
                    return "No se puede completar la operación porque el registro está relacionado con otros datos " +
                           "(por ejemplo, un paciente con citas o un médico con historial).";
                case 515:
                    return "Falta un dato obligatorio.";
                case 8152:
                case 2628:
                    return "Uno de los textos ingresados es demasiado largo.";
                case 18456:
                    return "Usuario o contraseña de SQL Server incorrectos. Revise App.config.";
                case 4060:
                    return "No existe la base de datos ClinicaMedicaDB. Ejecute los scripts de la carpeta BaseDeDatos.";
                case -2:
                    return "El servidor tardó demasiado en responder (tiempo de espera agotado).";
                case 2:
                case 53:
                case -1:
                    return "No se pudo conectar al servidor de base de datos. Verifique que SQL Server esté encendido " +
                           "y que el nombre del servidor en App.config sea correcto.";
                default:
                    return "Error de base de datos (" + ex.Number + "): " + ex.Message;
            }
        }
    }
}
