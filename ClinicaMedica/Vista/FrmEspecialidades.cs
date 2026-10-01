using ClinicaMedica.Modelo.DAO;
using ClinicaMedica.Modelo.Entidades;
using ClinicaMedica.Modelo.Utilidades;

namespace ClinicaMedica.Vista
{
    public class FrmEspecialidades : FrmBaseCrud
    {
        private readonly EspecialidadDAO dao = new EspecialidadDAO();
        private readonly TextBox txtNombre;
        private readonly TextBox txtDescripcion;

        public FrmEspecialidades() : base("Especialidades")
        {
            txtNombre = Campo("Nombre *", new TextBox { MaxLength = 100 });
            txtDescripcion = Campo("Descripción", TextoMultilinea(), 80);
            txtDescripcion.MaxLength = 250;
        }

        protected override void Cargar()
        {
            try
            {
                MostrarEnGrid(dao.Listar(TxtBuscar.Text.Trim()));
            }
            catch (ExcepcionDatos ex) { Mensaje.Error(ex.Message); }
            catch (Exception ex)
            {
                Logger.Error(ex, "Cargar especialidades");
                Mensaje.Error("Error al cargar especialidades: " + ex.Message);
            }
        }

        protected override void MostrarRegistro(object registro)
        {
            var e = (Especialidad)registro;
            txtNombre.Text = e.Nombre;
            txtDescripcion.Text = e.Descripcion;
            ModoEdicion(e.IdEspecialidad);
        }

        protected override void Guardar()
        {
            Errores.Clear();
            if (!Requerido(txtNombre, "Nombre")) return;

            var esp = new Especialidad
            {
                IdEspecialidad = IdSeleccionado,
                Nombre = txtNombre.Text.Trim(),
                Descripcion = txtDescripcion.Text.Trim()
            };
            try
            {
                if (IdSeleccionado == 0)
                {
                    dao.Insertar(esp);
                    Logger.Actividad("INSERTAR", "Especialidades", $"Especialidad creada: {esp.Nombre}");
                    Mensaje.Info("Especialidad registrada correctamente.");
                }
                else
                {
                    dao.Actualizar(esp);
                    Logger.Actividad("ACTUALIZAR", "Especialidades", $"Especialidad #{esp.IdEspecialidad} modificada: {esp.Nombre}");
                    Mensaje.Info("Especialidad actualizada correctamente.");
                }
                Cargar();
                Limpiar();
            }
            catch (ExcepcionDatos ex) { Mensaje.Advertencia(ex.Message); }
            catch (Exception ex)
            {
                Logger.Error(ex, "Guardar especialidad");
                Mensaje.Error("Error inesperado: " + ex.Message);
            }
        }

        protected override void Eliminar()
        {
            if (IdSeleccionado == 0) return;
            if (!Mensaje.Confirmar($"¿Eliminar la especialidad '{txtNombre.Text}'?")) return;
            try
            {
                dao.Eliminar(IdSeleccionado);
                Logger.Actividad("ELIMINAR", "Especialidades", $"Especialidad #{IdSeleccionado} eliminada: {txtNombre.Text}");
                Mensaje.Info("Especialidad eliminada.");
                Cargar();
                Limpiar();
            }
            catch (ExcepcionDatos ex) { Mensaje.Advertencia(ex.Message); }
            catch (Exception ex)
            {
                Logger.Error(ex, "Eliminar especialidad");
                Mensaje.Error("Error inesperado: " + ex.Message);
            }
        }
    }
}
