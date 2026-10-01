namespace Modelos
{
    // Encriptación de contraseñas con la librería BCrypt.Net
    public static class Encriptacion
    {
        public static string Encriptar(string clave)
        {
            return BCrypt.Net.BCrypt.HashPassword(clave);
        }

        public static bool Verificar(string clave, string claveEncriptada)
        {
            try
            {
                return BCrypt.Net.BCrypt.Verify(clave, claveEncriptada);
            }
            catch
            {
                return false; // la clave guardada no tiene formato BCrypt
            }
        }
    }
}
