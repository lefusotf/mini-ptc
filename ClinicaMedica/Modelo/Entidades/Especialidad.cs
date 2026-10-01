using System.ComponentModel;

namespace ClinicaMedica.Modelo.Entidades
{
    public class Especialidad
    {
        [DisplayName("ID")] public int IdEspecialidad { get; set; }
        public string Nombre { get; set; }
        [DisplayName("Descripción")] public string Descripcion { get; set; }

        public override string ToString() => Nombre;
    }
}
