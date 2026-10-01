using ClinicaMedica.Modelo.Entidades;
using Microsoft.Data.SqlClient;
using static ClinicaMedica.Modelo.Conexion;

namespace ClinicaMedica.Modelo.DAO
{
    public class PacienteDAO
    {
        private static Paciente Mapear(SqlDataReader dr) => new Paciente
        {
            IdPaciente = dr.Entero("IdPaciente"),
            Nombres = dr.Texto("Nombres"),
            Apellidos = dr.Texto("Apellidos"),
            DUI = dr.Texto("DUI"),
            FechaNacimiento = dr.Fecha("FechaNacimiento"),
            Genero = dr.Texto("Genero"),
            Telefono = dr.Texto("Telefono"),
            Correo = dr.Texto("Correo"),
            Direccion = dr.Texto("Direccion"),
            TipoSangre = dr.Texto("TipoSangre"),
            Alergias = dr.Texto("Alergias"),
            FechaRegistro = dr.Fecha("FechaRegistro")
        };

        public List<Paciente> Listar(string filtro = "") => Consultar(
            @"SELECT * FROM Pacientes
              WHERE Nombres LIKE @f OR Apellidos LIKE @f OR DUI LIKE @f OR Telefono LIKE @f
              ORDER BY Apellidos, Nombres",
            Mapear, Param("@f", "%" + filtro + "%"));

        public void Insertar(Paciente p) => Ejecutar(
            @"INSERT INTO Pacientes (Nombres, Apellidos, DUI, FechaNacimiento, Genero, Telefono, Correo,
                                     Direccion, TipoSangre, Alergias)
              VALUES (@Nombres, @Apellidos, @DUI, @FechaNacimiento, @Genero, @Telefono, @Correo,
                      @Direccion, @TipoSangre, @Alergias)",
            Parametros(p));

        public void Actualizar(Paciente p)
        {
            var lista = Parametros(p).ToList();
            lista.Add(Param("@IdPaciente", p.IdPaciente));
            Ejecutar(@"UPDATE Pacientes SET Nombres = @Nombres, Apellidos = @Apellidos, DUI = @DUI,
                              FechaNacimiento = @FechaNacimiento, Genero = @Genero, Telefono = @Telefono,
                              Correo = @Correo, Direccion = @Direccion, TipoSangre = @TipoSangre,
                              Alergias = @Alergias
                       WHERE IdPaciente = @IdPaciente", lista.ToArray());
        }

        public void Eliminar(int id) =>
            Ejecutar("DELETE FROM Pacientes WHERE IdPaciente = @Id", Param("@Id", id));

        private static SqlParameter[] Parametros(Paciente p) => new[]
        {
            Param("@Nombres", p.Nombres), Param("@Apellidos", p.Apellidos), Param("@DUI", p.DUI),
            Param("@FechaNacimiento", p.FechaNacimiento.Date), Param("@Genero", p.Genero),
            Param("@Telefono", p.Telefono), Param("@Correo", p.Correo), Param("@Direccion", p.Direccion),
            Param("@TipoSangre", p.TipoSangre), Param("@Alergias", p.Alergias)
        };
    }
}
