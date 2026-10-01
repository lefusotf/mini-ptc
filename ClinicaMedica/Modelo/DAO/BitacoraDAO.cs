using ClinicaMedica.Modelo.Entidades;
using static ClinicaMedica.Modelo.Conexion;

namespace ClinicaMedica.Modelo.DAO
{
    public class BitacoraDAO
    {
        public void Registrar(int? idUsuario, string accion, string modulo, string descripcion) => Ejecutar(
            "INSERT INTO Bitacora (IdUsuario, Accion, Modulo, Descripcion) VALUES (@IdUsuario, @Accion, @Modulo, @Descripcion)",
            Param("@IdUsuario", idUsuario), Param("@Accion", accion), Param("@Modulo", modulo),
            Param("@Descripcion", descripcion?.Length > 500 ? descripcion.Substring(0, 500) : descripcion));

        public List<Bitacora> Listar(string filtro = "") => Consultar(
            @"SELECT TOP 500 b.IdBitacora, b.Fecha, ISNULL(u.NombreUsuario, '(desconocido)') AS NombreUsuario,
                     b.Accion, b.Modulo, b.Descripcion
              FROM Bitacora b LEFT JOIN Usuarios u ON u.IdUsuario = b.IdUsuario
              WHERE u.NombreUsuario LIKE @f OR b.Accion LIKE @f OR b.Modulo LIKE @f OR b.Descripcion LIKE @f
              ORDER BY b.Fecha DESC",
            dr => new Bitacora
            {
                IdBitacora = dr.Entero("IdBitacora"),
                Fecha = dr.Fecha("Fecha"),
                NombreUsuario = dr.Texto("NombreUsuario"),
                Accion = dr.Texto("Accion"),
                Modulo = dr.Texto("Modulo"),
                Descripcion = dr.Texto("Descripcion")
            },
            Param("@f", "%" + filtro + "%"));
    }
}
