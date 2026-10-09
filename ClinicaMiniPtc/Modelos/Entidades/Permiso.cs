using Modelos.Conexion_DB;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Modelos.Entidades
{
    public class Permiso
    {
        private int idPermiso;
        private string nombrePermiso;

        public int IdPermiso { get => idPermiso; set => idPermiso = value; }
        public string NombrePermiso { get => nombrePermiso; set => nombrePermiso = value; }

        public static DataTable cargarPermisos()
        {
            DataTable tablaVirtual = new DataTable();
            using (SqlConnection conexion = Conexion.conectar())
            {
                if (conexion == null) return tablaVirtual;
                SqlDataAdapter adaptador = new SqlDataAdapter("SELECT idPermiso, nombrePermiso FROM Permiso;", conexion);
                adaptador.Fill(tablaVirtual);
            }
            return tablaVirtual;
        }

        public static List<string> cargarPermisosDeRol(int idRol)
        {
            List<string> lista = new List<string>();
            string comandoSQL = @"SELECT p.nombrePermiso FROM RolPermiso rp
                                  INNER JOIN Permiso p ON rp.id_Permiso = p.idPermiso
                                  WHERE rp.id_Rol = @idRol;";
            using (SqlConnection conexion = Conexion.conectar())
            {
                if (conexion == null) return lista;
                using (SqlCommand comandoObjeto = new SqlCommand(comandoSQL, conexion))
                {
                    comandoObjeto.Parameters.AddWithValue("@idRol", idRol);
                    using (SqlDataReader lector = comandoObjeto.ExecuteReader())
                    {
                        while (lector.Read())
                            lista.Add(lector["nombrePermiso"].ToString());
                    }
                }
            }
            return lista;
        }

        public static List<int> cargarIdPermisosDeRol(int idRol)
        {
            List<int> lista = new List<int>();
            using (SqlConnection conexion = Conexion.conectar())
            {
                if (conexion == null) return lista;
                using (SqlCommand comandoObjeto = new SqlCommand("SELECT id_Permiso FROM RolPermiso WHERE id_Rol = @idRol;", conexion))
                {
                    comandoObjeto.Parameters.AddWithValue("@idRol", idRol);
                    using (SqlDataReader lector = comandoObjeto.ExecuteReader())
                    {
                        while (lector.Read())
                            lista.Add(Convert.ToInt32(lector["id_Permiso"]));
                    }
                }
            }
            return lista;
        }

        public static bool GuardarPermisos(int idRol, List<int> idPermisos)
        {
            try
            {
                using (SqlConnection conexion = Conexion.conectar())
                {
                    if (conexion == null) return false;

                    using (SqlCommand borrar = new SqlCommand("DELETE FROM RolPermiso WHERE id_Rol = @idRol;", conexion))
                    {
                        borrar.Parameters.AddWithValue("@idRol", idRol);
                        borrar.ExecuteNonQuery();
                    }

                    foreach (int idPermiso in idPermisos)
                    {
                        using (SqlCommand insertar = new SqlCommand("INSERT INTO RolPermiso (id_Rol, id_Permiso) VALUES (@idRol, @idPermiso);", conexion))
                        {
                            insertar.Parameters.AddWithValue("@idRol", idRol);
                            insertar.Parameters.AddWithValue("@idPermiso", idPermiso);
                            insertar.ExecuteNonQuery();
                        }
                    }
                    return true;
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error al guardar los permisos: " + ex.Message, "Error BD", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
