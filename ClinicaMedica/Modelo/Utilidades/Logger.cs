using ClinicaMedica.Modelo.DAO;

namespace ClinicaMedica.Modelo.Utilidades
{
    /// <summary>
    /// Registro de actividades (logging):
    /// - Actividad(): guarda en la tabla Bitacora lo que hace cada usuario.
    /// - Error(): guarda las excepciones en un archivo de texto dentro de la carpeta "Logs".
    /// El logger nunca debe detener el programa, por eso todo va dentro de try-catch.
    /// </summary>
    public static class Logger
    {
        private static readonly string CarpetaLogs = Path.Combine(AppContext.BaseDirectory, "Logs");
        private static readonly object Candado = new object();

        public static void Actividad(string accion, string modulo, string descripcion)
        {
            try
            {
                new BitacoraDAO().Registrar(Sesion.Usuario?.IdUsuario, accion, modulo, descripcion);
            }
            catch (Exception ex)
            {
                EscribirArchivo("No se pudo guardar en Bitacora: " + ex.Message);
            }
            EscribirArchivo($"[{accion}] {modulo}: {descripcion}");
        }

        public static void Error(Exception ex, string contexto)
        {
            EscribirArchivo($"ERROR en {contexto}\n{ex.GetType().Name}: {ex.Message}\n{ex.StackTrace}");
        }

        private static void EscribirArchivo(string texto)
        {
            try
            {
                lock (Candado)
                {
                    Directory.CreateDirectory(CarpetaLogs);
                    string archivo = Path.Combine(CarpetaLogs, $"log_{DateTime.Now:yyyyMMdd}.txt");
                    string usuario = Sesion.Usuario?.NombreUsuario ?? "(sin sesión)";
                    File.AppendAllText(archivo, $"{DateTime.Now:yyyy-MM-dd HH:mm:ss} | {usuario} | {texto}{Environment.NewLine}");
                }
            }
            catch
            {
                // Si ni siquiera se puede escribir el archivo, se ignora para no cerrar la aplicación
            }
        }
    }
}
