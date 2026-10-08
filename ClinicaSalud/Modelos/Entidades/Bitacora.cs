using Modelos.Conexion_DB;
using System;
using System.Data;
using System.Data.SqlClient;

namespace Modelos.Entidades
{
    // Registro de actividades: guarda quién hizo cada acción y cuándo
    public class Bitacora
    {
        public static void registrar(string accion)
        {
            try
            {
                using (SqlConnection conexion = Conexion.conectar())
                {
                    if (conexion == null) return;
                    using (SqlCommand comandoObjeto = new SqlCommand("INSERT INTO Bitacora (usuario, accion) VALUES (@usuario, @accion);", conexion))
                    {
                        comandoObjeto.Parameters.AddWithValue("@usuario", Sesion.NombreUsuario ?? "Sin sesion");
                        comandoObjeto.Parameters.AddWithValue("@accion", accion);
                        comandoObjeto.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception)
            {
            }
        }

        public static DataTable cargarBitacora()
        {
            DataTable tablaVirtual = new DataTable();
            using (SqlConnection conexion = Conexion.conectar())
            {
                if (conexion == null) return tablaVirtual;
                string comandoSQL = "SELECT fecha AS [Fecha], usuario AS [Usuario], accion AS [Accion] FROM Bitacora ORDER BY fecha DESC;";
                SqlDataAdapter adaptador = new SqlDataAdapter(comandoSQL, conexion);
                adaptador.Fill(tablaVirtual);
            }
            return tablaVirtual;
        }
    }
}
