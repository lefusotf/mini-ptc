using System.ComponentModel;

namespace ClinicaMedica.Modelo.Entidades
{
    public class Rol
    {
        [DisplayName("ID")] public int IdRol { get; set; }
        public string Nombre { get; set; }
        [DisplayName("Descripción")] public string Descripcion { get; set; }

        public override string ToString() => Nombre;
    }
}
