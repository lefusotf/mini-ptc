using ClinicaMedica.Modelo.Entidades;
using static ClinicaMedica.Modelo.Conexion;

namespace ClinicaMedica.Modelo.DAO
{
    public class EspecialidadDAO
    {
        public List<Especialidad> Listar(string filtro = "") => Consultar(
            @"SELECT IdEspecialidad, Nombre, Descripcion FROM Especialidades
              WHERE Nombre LIKE @f ORDER BY Nombre",
            dr => new Especialidad
            {
                IdEspecialidad = dr.Entero("IdEspecialidad"),
                Nombre = dr.Texto("Nombre"),
                Descripcion = dr.Texto("Descripcion")
            },
            Param("@f", "%" + filtro + "%"));

        public void Insertar(Especialidad e) => Ejecutar(
            "INSERT INTO Especialidades (Nombre, Descripcion) VALUES (@Nombre, @Descripcion)",
            Param("@Nombre", e.Nombre), Param("@Descripcion", e.Descripcion));

        public void Actualizar(Especialidad e) => Ejecutar(
            "UPDATE Especialidades SET Nombre = @Nombre, Descripcion = @Descripcion WHERE IdEspecialidad = @Id",
            Param("@Nombre", e.Nombre), Param("@Descripcion", e.Descripcion), Param("@Id", e.IdEspecialidad));

        public void Eliminar(int id) =>
            Ejecutar("DELETE FROM Especialidades WHERE IdEspecialidad = @Id", Param("@Id", id));
    }
}
