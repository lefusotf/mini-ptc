using System;
using System.Data;
using System.Data.SqlClient;

namespace Modelos
{
    // Registro de actividades (logging)
    public class Bitacora
    {
        public static void Registrar(string accion)
        {
            try
            {
                using (SqlConnection con = Conexion.Conectar())
                {
                    SqlCommand cmd = new SqlCommand("INSERT INTO Bitacora (Usuario, Accion) VALUES (@usuario, @accion)", con);
                    cmd.Parameters.AddWithValue("@usuario", Sesion.Usuario ?? "Sin sesión");
                    cmd.Parameters.AddWithValue("@accion", accion);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {
                // Si falla la bitácora no detenemos el programa
            }
        }

        public static DataTable Mostrar()
        {
            try
            {
                using (SqlConnection con = Conexion.Conectar())
                {
                    SqlDataAdapter da = new SqlDataAdapter("SELECT Fecha, Usuario, Accion FROM Bitacora ORDER BY Fecha DESC", con);
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
