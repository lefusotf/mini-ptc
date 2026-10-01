using ClinicaMedica.Modelo.Entidades;
using Microsoft.Data.SqlClient;
using static ClinicaMedica.Modelo.Conexion;

namespace ClinicaMedica.Modelo.DAO
{
    public class RolDAO
    {
        private static Rol Mapear(SqlDataReader dr) => new Rol
        {
            IdRol = dr.Entero("IdRol"),
            Nombre = dr.Texto("Nombre"),
            Descripcion = dr.Texto("Descripcion")
        };

        public List<Rol> Listar() =>
            Consultar("SELECT IdRol, Nombre, Descripcion FROM Roles ORDER BY Nombre", Mapear);

        public int Insertar(Rol r) => Convert.ToInt32(EjecutarEscalar(
            "INSERT INTO Roles (Nombre, Descripcion) VALUES (@Nombre, @Descripcion); SELECT SCOPE_IDENTITY();",
            Param("@Nombre", r.Nombre), Param("@Descripcion", r.Descripcion)));

        public void Actualizar(Rol r) => Ejecutar(
            "UPDATE Roles SET Nombre = @Nombre, Descripcion = @Descripcion WHERE IdRol = @IdRol",
            Param("@Nombre", r.Nombre), Param("@Descripcion", r.Descripcion), Param("@IdRol", r.IdRol));

        public void Eliminar(int idRol) =>
            Ejecutar("DELETE FROM Roles WHERE IdRol = @IdRol", Param("@IdRol", idRol));

        // ---------------- Permisos del rol ----------------

        public List<Permiso> ListarPermisos() => Consultar(
            "SELECT IdPermiso, Codigo, Nombre, Descripcion FROM Permisos ORDER BY Nombre",
            dr => new Permiso
            {
                IdPermiso = dr.Entero("IdPermiso"),
                Codigo = dr.Texto("Codigo"),
                Nombre = dr.Texto("Nombre"),
                Descripcion = dr.Texto("Descripcion")
            });

        public List<int> ListarIdPermisosDeRol(int idRol) => Consultar(
            "SELECT IdPermiso FROM RolPermisos WHERE IdRol = @IdRol",
            dr => dr.Entero("IdPermiso"), Param("@IdRol", idRol));

        public List<string> ListarCodigosPermisoDeRol(int idRol) => Consultar(
            @"SELECT p.Codigo FROM RolPermisos rp
              JOIN Permisos p ON p.IdPermiso = rp.IdPermiso
              WHERE rp.IdRol = @IdRol",
            dr => dr.Texto("Codigo"), Param("@IdRol", idRol));

        /// <summary>
        /// Reemplaza los permisos de un rol dentro de una TRANSACCIÓN:
        /// si algo falla, se deshacen todos los cambios (Rollback).
        /// </summary>
        public void GuardarPermisos(int idRol, IEnumerable<int> idPermisos)
        {
            using (var cn = ObtenerConexion())
            using (var tx = cn.BeginTransaction())
            {
                try
                {
                    using (var del = new SqlCommand("DELETE FROM RolPermisos WHERE IdRol = @IdRol", cn, tx))
                    {
                        del.Parameters.AddWithValue("@IdRol", idRol);
                        del.ExecuteNonQuery();
                    }
                    foreach (int idPermiso in idPermisos)
                    {
                        using (var ins = new SqlCommand(
                            "INSERT INTO RolPermisos (IdRol, IdPermiso) VALUES (@IdRol, @IdPermiso)", cn, tx))
                        {
                            ins.Parameters.AddWithValue("@IdRol", idRol);
                            ins.Parameters.AddWithValue("@IdPermiso", idPermiso);
                            ins.ExecuteNonQuery();
                        }
                    }
                    tx.Commit();
                }
                catch (SqlException ex)
                {
                    tx.Rollback();
                    throw new Utilidades.ExcepcionDatos(TraducirError(ex), ex);
                }
            }
        }
    }
}
