using ClinicaMedica.Modelo.DAO;
using ClinicaMedica.Modelo.Utilidades;

namespace ClinicaMedica.Vista
{
    /// <summary>Consulta de la bitácora (logging de actividades). Solo lectura.</summary>
    public class FrmBitacora : FrmBaseCrud
    {
        private readonly BitacoraDAO dao = new BitacoraDAO();

        public FrmBitacora() : base("Bitácora de Actividades")
        {
            PanelCampos.Controls.Add(new Label
            {
                AutoSize = false,
                Width = 325,
                Height = 160,
                Text = "Aquí se registran automáticamente las acciones de los usuarios:\n\n" +
                       "• Inicios y cierres de sesión\n• Intentos de acceso fallidos\n" +
                       "• Registros creados, modificados y eliminados\n\n" +
                       "Los errores técnicos se guardan en la carpeta \"Logs\" del programa."
            });
            BtnNuevo.Visible = BtnGuardar.Visible = BtnEliminar.Visible = BtnLimpiar.Visible = false;
            PanelBotones.Controls.Add(Estilos.CrearBoton("Actualizar", Estilos.Info, (s, e) => Cargar(), 160));
        }

        protected override void Cargar()
        {
            try
            {
                MostrarEnGrid(dao.Listar(TxtBuscar.Text.Trim()), "IdBitacora");
                Grid.Columns["Fecha"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm:ss";
                Grid.Columns["Descripcion"].FillWeight = 250;
            }
            catch (ExcepcionDatos ex) { Mensaje.Error(ex.Message); }
            catch (Exception ex)
            {
                Logger.Error(ex, "Cargar bitácora");
                Mensaje.Error("Error al cargar la bitácora: " + ex.Message);
            }
        }
    }
}
