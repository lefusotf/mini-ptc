using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Modelos
{
    public class Permiso
    {
        // Lista de nombres de permisos que tiene un rol (se usa al iniciar sesión)
        public static List<string> PermisosDeRol(int idRol)
        {
            List<string> lista = new List<string>();
            using (SqlConnection con = Conexion.Conectar())
            {
                SqlCommand cmd = new SqlCommand(@"SELECT p.NombrePermiso FROM RolPermisos rp
                                                  INNER JOIN Permisos p ON rp.IdPermiso = p.IdPermiso
                                                  WHERE rp.IdRol = @idRol", con);
                cmd.Parameters.AddWithValue("@idRol", idRol);
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                        lista.Add(dr["NombrePermiso"].ToString());
                }
            }
            return lista;
        }

        public static DataTable ObtenerPermisos()
        {
            try
            {
                using (SqlConnection con = Conexion.Conectar())
                {
                    SqlDataAdapter da = new SqlDataAdapter("SELECT IdPermiso, NombrePermiso FROM Permisos", con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
            }
            catch (SqlException ex)
            {
                throw new Exception(Conexion.MensajeError(ex));
            }
        }

        // Guarda los permisos de un rol: borra los anteriores e inserta los marcados.
        // Se usa una TRANSACCIÓN: si algo falla, no se guarda nada (Rollback).
        public static void GuardarPermisos(int idRol, List<int> idPermisos)
        {
            using (SqlConnection con = Conexion.Conectar())
            {
                SqlTransaction transaccion = con.BeginTransaction();
                try
                {
                    SqlCommand borrar = new SqlCommand("DELETE FROM RolPermisos WHERE IdRol = @idRol", con, transaccion);
                    borrar.Parameters.AddWithValue("@idRol", idRol);
                    borrar.ExecuteNonQuery();

                    foreach (int idPermiso in idPermisos)
                    {
                        SqlCommand insertar = new SqlCommand("INSERT INTO RolPermisos (IdRol, IdPermiso) VALUES (@idRol, @idPermiso)", con, transaccion);
                        insertar.Parameters.AddWithValue("@idRol", idRol);
                        insertar.Parameters.AddWithValue("@idPermiso", idPermiso);
                        insertar.ExecuteNonQuery();
                    }
                    transaccion.Commit();
                }
                catch (SqlException ex)
                {
                    transaccion.Rollback();
                    throw new Exception(Conexion.MensajeError(ex));
                }
            }
        }

        public static List<int> IdPermisosDeRol(int idRol)
        {
            List<int> lista = new List<int>();
            using (SqlConnection con = Conexion.Conectar())
            {
                SqlCommand cmd = new SqlCommand("SELECT IdPermiso FROM RolPermisos WHERE IdRol = @idRol", con);
                cmd.Parameters.AddWithValue("@idRol", idRol);
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                        lista.Add(Convert.ToInt32(dr["IdPermiso"]));
                }
            }
            return lista;
        }
    }
}
