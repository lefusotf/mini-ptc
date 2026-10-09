using Modelos.Conexion_DB;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Modelos.Entidades
{
    public class Usuario
    {
        private int idUsuario;
        private string nombreUsuario;
        private string clave;
        private string nombreCompleto;
        private int idRol;
        private bool activo;

        public int IdUsuario { get => idUsuario; set => idUsuario = value; }
        public string NombreUsuario { get => nombreUsuario; set => nombreUsuario = value; }
        public string Clave { get => clave; set => clave = value; }
        public string NombreCompleto { get => nombreCompleto; set => nombreCompleto = value; }
        public int IdRol { get => idRol; set => idRol = value; }
        public bool Activo { get => activo; set => activo = value; }

        public static string encriptar(string clave)
        {
            return BCrypt.Net.BCrypt.HashPassword(clave);
        }

        public static bool verificarClave(string clave, string claveEncriptada)
        {
            try
            {
                return BCrypt.Net.BCrypt.Verify(clave, claveEncriptada);
            }
            catch
            {
                return false;
            }
        }

        public static bool iniciarSesion(string usuario, string clave)
        {
            string comandoSQL = @"SELECT u.idUsuario, u.clave, u.activo, u.id_Rol, r.nombreRol
                                  FROM Usuario u
                                  INNER JOIN Rol r ON u.id_Rol = r.idRol
                                  WHERE u.nombreUsuario = @usuario;";
            try
            {
                using (SqlConnection conexion = Conexion.conectar())
                {
                    if (conexion == null) return false;

                    int idUsuario, idRol;
                    string claveGuardada, rol;
                    bool activo;

                    using (SqlCommand comandoObjeto = new SqlCommand(comandoSQL, conexion))
                    {
                        comandoObjeto.Parameters.AddWithValue("@usuario", usuario);
                        using (SqlDataReader lector = comandoObjeto.ExecuteReader())
                        {
                            if (!lector.Read())
                                return false;

                            idUsuario = Convert.ToInt32(lector["idUsuario"]);
                            claveGuardada = lector["clave"].ToString();
                            activo = Convert.ToBoolean(lector["activo"]);
                            idRol = Convert.ToInt32(lector["id_Rol"]);
                            rol = lector["nombreRol"].ToString();
                        }
                    }

                    if (!activo)
                    {
                        MessageBox.Show("El usuario está desactivado. Habla con el administrador.", "Usuario inactivo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }

                    if (!verificarClave(clave, claveGuardada))
                        return false;

                    Sesion.IdUsuario = idUsuario;
                    Sesion.NombreUsuario = usuario;
                    Sesion.Rol = rol;
                    Sesion.Permisos = Permiso.cargarPermisosDeRol(idRol);
                    Sesion.IdMedico = Medico.obtenerIdMedico(idUsuario);
                    return true;
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error al iniciar sesión: " + ex.Message, "Error BD", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public static DataTable cargarUsuarios()
        {
            DataTable tablaVirtual = new DataTable();
            using (SqlConnection conexion = Conexion.conectar())
            {
                if (conexion == null) return tablaVirtual;
                SqlDataAdapter adaptador = new SqlDataAdapter("SELECT * FROM vistaUsuarios;", conexion);
                adaptador.Fill(tablaVirtual);
            }
            return tablaVirtual;
        }

        public static DataTable cargarRoles()
        {
            DataTable tablaVirtual = new DataTable();
            using (SqlConnection conexion = Conexion.conectar())
            {
                if (conexion == null) return tablaVirtual;
                SqlDataAdapter adaptador = new SqlDataAdapter("SELECT idRol, nombreRol FROM Rol;", conexion);
                adaptador.Fill(tablaVirtual);
            }
            return tablaVirtual;
        }

        public bool InsertarUsuario()
        {
            string comandoSQL = "INSERT INTO Usuario (nombreUsuario, clave, nombreCompleto, id_Rol, activo) " +
                                "VALUES (@nombreUsuario, @clave, @nombreCompleto, @id_Rol, @activo);";
            try
            {
                using (SqlConnection conexion = Conexion.conectar())
                {
                    if (conexion == null) return false;
                    using (SqlCommand comandoObjeto = new SqlCommand(comandoSQL, conexion))
                    {
                        comandoObjeto.Parameters.AddWithValue("@nombreUsuario", nombreUsuario);
                        comandoObjeto.Parameters.AddWithValue("@clave", encriptar(clave));
                        comandoObjeto.Parameters.AddWithValue("@nombreCompleto", nombreCompleto);
                        comandoObjeto.Parameters.AddWithValue("@id_Rol", idRol);
                        comandoObjeto.Parameters.AddWithValue("@activo", activo);
                        return comandoObjeto.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627 || ex.Number == 2601)
                    MessageBox.Show("Ese nombre de usuario ya existe. Usa otro.", "Registro duplicado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                    MessageBox.Show("Error al registrar el usuario: " + ex.Message, "Error BD", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public bool ActualizarUsuario()
        {
            string comandoSQL = "UPDATE Usuario SET nombreUsuario = @nombreUsuario, nombreCompleto = @nombreCompleto, " +
                                "id_Rol = @id_Rol, activo = @activo";
            if (!string.IsNullOrEmpty(clave))
                comandoSQL += ", clave = @clave";
            comandoSQL += " WHERE idUsuario = @idUsuario;";
            try
            {
                using (SqlConnection conexion = Conexion.conectar())
                {
                    if (conexion == null) return false;
                    using (SqlCommand comandoObjeto = new SqlCommand(comandoSQL, conexion))
                    {
                        comandoObjeto.Parameters.AddWithValue("@nombreUsuario", nombreUsuario);
                        comandoObjeto.Parameters.AddWithValue("@nombreCompleto", nombreCompleto);
                        comandoObjeto.Parameters.AddWithValue("@id_Rol", idRol);
                        comandoObjeto.Parameters.AddWithValue("@activo", activo);
                        comandoObjeto.Parameters.AddWithValue("@idUsuario", idUsuario);
                        if (!string.IsNullOrEmpty(clave))
                            comandoObjeto.Parameters.AddWithValue("@clave", encriptar(clave));
                        return comandoObjeto.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error al actualizar el usuario: " + ex.Message, "Error BD", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public static bool EliminarUsuario(int idUsuario)
        {
            try
            {
                using (SqlConnection conexion = Conexion.conectar())
                {
                    if (conexion == null) return false;
                    using (SqlCommand comandoObjeto = new SqlCommand("DELETE FROM Usuario WHERE idUsuario = @idUsuario;", conexion))
                    {
                        comandoObjeto.Parameters.AddWithValue("@idUsuario", idUsuario);
                        return comandoObjeto.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (SqlException ex)
            {
                if (ex.Number == 547)
                    MessageBox.Show("No se puede eliminar porque el usuario está asignado a un médico. Mejor desactívelo.", "Conflicto de Referencias", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                else
                    MessageBox.Show("Error al eliminar el usuario: " + ex.Message, "Error BD", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public static DataTable buscarUsuarios(string texto)
        {
            DataTable tablaVirtual = new DataTable();
            using (SqlConnection conexion = Conexion.conectar())
            {
                if (conexion == null) return tablaVirtual;
                SqlCommand comandoObjeto = new SqlCommand("SELECT * FROM vistaUsuarios WHERE Usuario LIKE @texto OR [Nombre Completo] LIKE @texto OR Rol LIKE @texto;", conexion);
                comandoObjeto.Parameters.AddWithValue("@texto", "%" + texto + "%");
                SqlDataAdapter adaptador = new SqlDataAdapter(comandoObjeto);
                adaptador.Fill(tablaVirtual);
            }
            return tablaVirtual;
        }
    }
}
