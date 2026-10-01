using System.ComponentModel;

namespace ClinicaMedica.Modelo.Entidades
{
    public class Bitacora
    {
        [DisplayName("ID")] public int IdBitacora { get; set; }
        public DateTime Fecha { get; set; }
        [DisplayName("Usuario")] public string NombreUsuario { get; set; }
        [DisplayName("Acción")] public string Accion { get; set; }
        [DisplayName("Módulo")] public string Modulo { get; set; }
        [DisplayName("Descripción")] public string Descripcion { get; set; }
    }
}
