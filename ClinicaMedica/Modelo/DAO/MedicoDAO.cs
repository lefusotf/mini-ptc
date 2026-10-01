using ClinicaMedica.Modelo.Entidades;
using Microsoft.Data.SqlClient;
using static ClinicaMedica.Modelo.Conexion;

namespace ClinicaMedica.Modelo.DAO
{
    public class MedicoDAO
    {
        private const string SelectBase =
            @"SELECT m.IdMedico, m.Nombres, m.Apellidos, m.JVPM, m.Telefono, m.Correo, m.IdEspecialidad,
                     e.Nombre AS NombreEspecialidad, m.IdUsuario, u.NombreUsuario, m.Activo
              FROM Medicos m
              JOIN Especialidades e ON e.IdEspecialidad = m.IdEspecialidad
              LEFT JOIN Usuarios u  ON u.IdUsuario = m.IdUsuario ";

        private static Medico Mapear(SqlDataReader dr) => new Medico
        {
            IdMedico = dr.Entero("IdMedico"),
            Nombres = dr.Texto("Nombres"),
            Apellidos = dr.Texto("Apellidos"),
            JVPM = dr.Texto("JVPM"),
            Telefono = dr.Texto("Telefono"),
            Correo = dr.Texto("Correo"),
            IdEspecialidad = dr.Entero("IdEspecialidad"),
            NombreEspecialidad = dr.Texto("NombreEspecialidad"),
            IdUsuario = dr.EnteroNulo("IdUsuario"),
            NombreUsuario = dr.Texto("NombreUsuario"),
            Activo = dr.Booleano("Activo")
        };

        public List<Medico> Listar(string filtro = "", bool soloActivos = false) => Consultar(
            SelectBase + @"WHERE (m.Nombres LIKE @f OR m.Apellidos LIKE @f OR m.JVPM LIKE @f OR e.Nombre LIKE @f)
                             AND (@SoloActivos = 0 OR m.Activo = 1)
                           ORDER BY m.Apellidos, m.Nombres",
            Mapear, Param("@f", "%" + filtro + "%"), Param("@SoloActivos", soloActivos));

        public int? ObtenerIdPorUsuario(int idUsuario)
        {
            var valor = EjecutarEscalar("SELECT IdMedico FROM Medicos WHERE IdUsuario = @Id", Param("@Id", idUsuario));
            return valor == null ? (int?)null : Convert.ToInt32(valor);
        }

        public void Insertar(Medico m) => Ejecutar(
            @"INSERT INTO Medicos (Nombres, Apellidos, JVPM, Telefono, Correo, IdEspecialidad, IdUsuario, Activo)
              VALUES (@Nombres, @Apellidos, @JVPM, @Telefono, @Correo, @IdEspecialidad, @IdUsuario, @Activo)",
            Parametros(m));

        public void Actualizar(Medico m)
        {
            var p = Parametros(m).ToList();
            p.Add(Param("@IdMedico", m.IdMedico));
            Ejecutar(@"UPDATE Medicos SET Nombres = @Nombres, Apellidos = @Apellidos, JVPM = @JVPM,
                              Telefono = @Telefono, Correo = @Correo, IdEspecialidad = @IdEspecialidad,
                              IdUsuario = @IdUsuario, Activo = @Activo
                       WHERE IdMedico = @IdMedico", p.ToArray());
        }

        public void Eliminar(int id) =>
            Ejecutar("DELETE FROM Medicos WHERE IdMedico = @Id", Param("@Id", id));

        private static SqlParameter[] Parametros(Medico m) => new[]
        {
            Param("@Nombres", m.Nombres), Param("@Apellidos", m.Apellidos), Param("@JVPM", m.JVPM),
            Param("@Telefono", m.Telefono), Param("@Correo", m.Correo),
            Param("@IdEspecialidad", m.IdEspecialidad), Param("@IdUsuario", m.IdUsuario), Param("@Activo", m.Activo)
        };
    }
}
