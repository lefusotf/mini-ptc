using System.ComponentModel;

namespace ClinicaMedica.Modelo.Entidades
{
    public class Permiso
    {
        public int IdPermiso { get; set; }
        [DisplayName("Código")] public string Codigo { get; set; }
        public string Nombre { get; set; }
        [DisplayName("Descripción")] public string Descripcion { get; set; }

        public override string ToString() => Nombre;
    }
}
