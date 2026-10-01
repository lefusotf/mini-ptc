using System.Text.RegularExpressions;

namespace ClinicaMedica.Modelo.Utilidades
{
    /// <summary>Validaciones de formato reutilizables por todas las vistas.</summary>
    public static class Validaciones
    {
        public static bool EsCorreo(string texto) =>
            string.IsNullOrWhiteSpace(texto) || Regex.IsMatch(texto.Trim(), @"^[^@\s]+@[^@\s]+\.[^@\s]+$");

        public static bool EsTelefono(string texto) =>
            string.IsNullOrWhiteSpace(texto) || Regex.IsMatch(texto.Trim(), @"^[267]\d{3}-?\d{4}$");

        public static bool EsDui(string texto) =>
            string.IsNullOrWhiteSpace(texto) || Regex.IsMatch(texto.Trim(), @"^\d{8}-\d$");

        public static bool EsNombreUsuario(string texto) =>
            !string.IsNullOrWhiteSpace(texto) && Regex.IsMatch(texto.Trim(), @"^[a-zA-Z0-9_.]{4,50}$");
    }
}
