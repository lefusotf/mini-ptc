using System.ComponentModel;

namespace ClinicaMedica.Modelo.Entidades
{
    public class Usuario
    {
        [DisplayName("ID")] public int IdUsuario { get; set; }
        [DisplayName("Usuario")] public string NombreUsuario { get; set; }
        [DisplayName("Nombre completo")] public string NombreCompleto { get; set; }
        public string Correo { get; set; }
        [Browsable(false)] public string ClaveHash { get; set; }   // nunca se muestra en pantalla
        [Browsable(false)] public int IdRol { get; set; }
        [DisplayName("Rol")] public string NombreRol { get; set; }
        public bool Activo { get; set; }
        [DisplayName("Intentos fallidos")] public int IntentosFallidos { get; set; }
        [DisplayName("Último acceso")] public DateTime? UltimoAcceso { get; set; }

        public override string ToString() => $"{NombreUsuario} - {NombreCompleto}";
    }
}
