using System.Text.RegularExpressions;

namespace ClinicaMedica.Modelo.Utilidades
{
    /// <summary>
    /// Encriptación de contraseñas con la librería BCrypt.Net.
    /// BCrypt genera un "salt" aleatorio por cada contraseña, por lo que dos usuarios
    /// con la misma clave tendrán hashes distintos. El hash NO se puede revertir.
    /// </summary>
    public static class Seguridad
    {
        private const int FactorTrabajo = 11; // a mayor número, más lento (y seguro) es el hash

        public static string Encriptar(string clave)
        {
            return BCrypt.Net.BCrypt.HashPassword(clave, FactorTrabajo);
        }

        public static bool Verificar(string clave, string hash)
        {
            try
            {
                return BCrypt.Net.BCrypt.Verify(clave, hash);
            }
            catch (BCrypt.Net.SaltParseException ex)
            {
                // El hash guardado en la BD no tiene formato BCrypt válido
                Logger.Error(ex, "Hash de contraseña inválido");
                return false;
            }
        }

        /// <summary>Reglas: mínimo 8 caracteres, una mayúscula, una minúscula y un número.</summary>
        public static string ValidarFortaleza(string clave)
        {
            if (string.IsNullOrEmpty(clave) || clave.Length < 8)
                return "La contraseña debe tener al menos 8 caracteres.";
            if (!Regex.IsMatch(clave, "[A-Z]"))
                return "La contraseña debe tener al menos una letra mayúscula.";
            if (!Regex.IsMatch(clave, "[a-z]"))
                return "La contraseña debe tener al menos una letra minúscula.";
            if (!Regex.IsMatch(clave, "[0-9]"))
                return "La contraseña debe tener al menos un número.";
            return null; // null = la contraseña es válida
        }
    }
}
