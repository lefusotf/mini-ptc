using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Modelos
{
    public class Usuario
    {
        private int idUsuario;
        private string nombreUsuario;
        private string clave;
        private string nombreCompleto;
        private int idRol;
        private bool activo;

        public int IdUsuario { get { return idUsuario; } set { idUsuario = value; } }
        public string NombreUsuario { get { return nombreUsuario; } set { nombreUsuario = value; } }
        public string Clave { get { return clave; } set { clave = value; } }
        public string NombreCompleto { get { return nombreCompleto; } set { nombreCompleto = value; } }
        public int IdRol { get { return idRol; } set { idRol = value; } }
        public bool Activo { get { return activo; } set { activo = value; } }

        // ---------------- LOGIN ----------------

        // Devuelve true si el usuario y la contraseña son correctos y llena la Sesion
        public static bool IniciarSesion(string usuario, string clave)
        {
            try
            {
                using (SqlConnection con = Conexion.Conectar())
                {
                    string consulta = @"SELECT u.IdUsuario, u.Usuario, u.Clave, u.Activo, u.IdRol, r.NombreRol
                                        FROM Usuarios u
                                        INNER JOIN Roles r ON u.IdRol = r.IdRol
                                        WHERE u.Usuario = @usuario";
                    SqlCommand cmd = new SqlCommand(consulta, con);
                    cmd.Parameters.AddWithValue("@usuario", usuario);

                    int idUsuario = 0, idRol = 0;
                    string claveGuardada = null, rol = null;
                    bool activo = false;

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (!dr.Read())
                            return false; // el usuario no existe

                        idUsuario = Convert.ToInt32(dr["IdUsuario"]);
                        claveGuardada = dr["Clave"].ToString();
                        activo = Convert.ToBoolean(dr["Activo"]);
                        idRol = Convert.ToInt32(dr["IdRol"]);
                        rol = dr["NombreRol"].ToString();
                    }

                    if (!activo)
                        throw new Exception("El usuario está desactivado. Hable con el administrador.");

                    // Se compara la contraseña escrita con la encriptada en la base
                    if (!Encriptacion.Verificar(clave, claveGuardada))
                        return false;

                    Sesion.IdUsuario = idUsuario;
                    Sesion.Usuario = usuario;
                    Sesion.Rol = rol;
                    Sesion.Permisos = Permiso.PermisosDeRol(idRol);
                    Sesion.IdMedico = Medico.ObtenerIdMedicoDeUsuario(idUsuario);
                    return true;
                }
            }
            catch (SqlException ex)
            {
                throw new Exception(Conexion.MensajeError(ex));
            }
        }

        // ---------------- CRUD ----------------

        public static DataTable Mostrar(string buscar)
        {
            try
            {
                using (SqlConnection con = Conexion.Conectar())
                {
                    string consulta = @"SELECT u.IdUsuario, u.Usuario, u.NombreCompleto AS [Nombre completo],
                                               r.NombreRol AS Rol, u.Activo
                                        FROM Usuarios u
                                        INNER JOIN Roles r ON u.IdRol = r.IdRol
                                        WHERE u.Usuario LIKE @buscar OR u.NombreCompleto LIKE @buscar";
                    SqlCommand cmd = new SqlCommand(consulta, con);
                    cmd.Parameters.AddWithValue("@buscar", "%" + buscar + "%");
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
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

        public bool Agregar()
        {
            try
            {
                using (SqlConnection con = Conexion.Conectar())
                {
                    SqlCommand cmd = new SqlCommand(@"INSERT INTO Usuarios (Usuario, Clave, NombreCompleto, IdRol, Activo)
                                                      VALUES (@usuario, @clave, @nombre, @idRol, @activo)", con);
                    cmd.Parameters.AddWithValue("@usuario", nombreUsuario);
                    cmd.Parameters.AddWithValue("@clave", Encriptacion.Encriptar(clave)); // se guarda encriptada
                    cmd.Parameters.AddWithValue("@nombre", nombreCompleto);
                    cmd.Parameters.AddWithValue("@idRol", idRol);
                    cmd.Parameters.AddWithValue("@activo", activo);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            catch (SqlException ex)
            {
                throw new Exception(Conexion.MensajeError(ex));
            }
        }

        // Si la clave viene vacía se deja la contraseña que ya tenía
        public bool Modificar()
        {
            try
            {
                using (SqlConnection con = Conexion.Conectar())
                {
                    string consulta = "UPDATE Usuarios SET Usuario = @usuario, NombreCompleto = @nombre, IdRol = @idRol, Activo = @activo";
                    if (!string.IsNullOrEmpty(clave))
                        consulta += ", Clave = @clave";
                    consulta += " WHERE IdUsuario = @id";

                    SqlCommand cmd = new SqlCommand(consulta, con);
                    cmd.Parameters.AddWithValue("@usuario", nombreUsuario);
                    cmd.Parameters.AddWithValue("@nombre", nombreCompleto);
                    cmd.Parameters.AddWithValue("@idRol", idRol);
                    cmd.Parameters.AddWithValue("@activo", activo);
                    cmd.Parameters.AddWithValue("@id", idUsuario);
                    if (!string.IsNullOrEmpty(clave))
                        cmd.Parameters.AddWithValue("@clave", Encriptacion.Encriptar(clave));
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            catch (SqlException ex)
            {
                throw new Exception(Conexion.MensajeError(ex));
            }
        }

        public static bool Eliminar(int idUsuario)
        {
            try
            {
                using (SqlConnection con = Conexion.Conectar())
                {
                    SqlCommand cmd = new SqlCommand("DELETE FROM Usuarios WHERE IdUsuario = @id", con);
                    cmd.Parameters.AddWithValue("@id", idUsuario);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            catch (SqlException ex)
            {
                throw new Exception(Conexion.MensajeError(ex));
            }
        }

        public static DataTable ObtenerRoles()
        {
            try
            {
                using (SqlConnection con = Conexion.Conectar())
                {
                    SqlDataAdapter da = new SqlDataAdapter("SELECT IdRol, NombreRol FROM Roles", con);
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
    }
}
