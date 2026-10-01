namespace ClinicaMedica.Modelo.Utilidades
{
    /// <summary>
    /// Excepción propia del sistema. Se lanza cuando hay un error de base de datos
    /// o una regla de negocio no se cumple; su mensaje ya es entendible para el usuario.
    /// </summary>
    public class ExcepcionDatos : Exception
    {
        public ExcepcionDatos(string mensaje) : base(mensaje) { }
        public ExcepcionDatos(string mensaje, Exception interna) : base(mensaje, interna) { }
    }
}
