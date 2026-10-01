using ClinicaMedica.Modelo.DAO;
using ClinicaMedica.Modelo.Entidades;
using ClinicaMedica.Modelo.Utilidades;

namespace ClinicaMedica.Vista
{
    /// <summary>Permite al Administrador crear roles y asignarles permisos desde el sistema.</summary>
    public class FrmRolesPermisos : FrmBaseCrud
    {
        private readonly RolDAO dao = new RolDAO();
        private readonly TextBox txtNombre, txtDescripcion;
        private readonly CheckedListBox lstPermisos;
        private List<Permiso> permisos = new List<Permiso>();

        public FrmRolesPermisos() : base("Roles y Permisos")
        {
            txtNombre = Campo("Nombre del rol *", new TextBox { MaxLength = 50 });
            txtDescripcion = Campo("Descripción", new TextBox { MaxLength = 200 });
            lstPermisos = Campo("Permisos del rol (marque los que aplican)", new CheckedListBox { CheckOnClick = true }, 300);
        }

        protected override void CargarListas()
        {
            try
            {
                permisos = dao.ListarPermisos();
                lstPermisos.Items.Clear();
                foreach (var p in permisos) lstPermisos.Items.Add(p);
            }
            catch (Exception ex)
            {
                Logger.Error(ex, "Cargar permisos");
                Mensaje.Error("No se pudieron cargar los permisos: " + ex.Message);
            }
        }

        protected override void Cargar()
        {
            try
            {
                string f = TxtBuscar.Text.Trim();
                MostrarEnGrid(dao.Listar().Where(r => r.Nombre.Contains(f, StringComparison.OrdinalIgnoreCase)).ToList());
            }
            catch (ExcepcionDatos ex) { Mensaje.Error(ex.Message); }
            catch (Exception ex)
            {
                Logger.Error(ex, "Cargar roles");
                Mensaje.Error("Error al cargar roles: " + ex.Message);
            }
        }

        protected override void MostrarRegistro(object registro)
        {
            var r = (Rol)registro;
            txtNombre.Text = r.Nombre;
            txtDescripcion.Text = r.Descripcion;
            var asignados = dao.ListarIdPermisosDeRol(r.IdRol);
            for (int i = 0; i < lstPermisos.Items.Count; i++)
                lstPermisos.SetItemChecked(i, asignados.Contains(((Permiso)lstPermisos.Items[i]).IdPermiso));
            ModoEdicion(r.IdRol);
        }

        protected override void Guardar()
        {
            Errores.Clear();
            if (!Requerido(txtNombre, "Nombre del rol")) return;
            if (lstPermisos.CheckedItems.Count == 0) { MarcarError(lstPermisos, "Asigne al menos un permiso al rol."); return; }

            var rol = new Rol { IdRol = IdSeleccionado, Nombre = txtNombre.Text.Trim(), Descripcion = txtDescripcion.Text.Trim() };
            var seleccionados = lstPermisos.CheckedItems.Cast<Permiso>().ToList();
            try
            {
                if (IdSeleccionado == 0)
                    rol.IdRol = dao.Insertar(rol);
                else
                    dao.Actualizar(rol);

                dao.GuardarPermisos(rol.IdRol, seleccionados.Select(p => p.IdPermiso));
                Logger.Actividad(IdSeleccionado == 0 ? "INSERTAR" : "ACTUALIZAR", "Roles",
                    $"Rol '{rol.Nombre}' guardado con permisos: {string.Join(", ", seleccionados.Select(p => p.Codigo))}");
                Mensaje.Info("Rol y permisos guardados correctamente.\nLos cambios se aplican la próxima vez que el usuario inicie sesión.");
                Cargar();
                Limpiar();
            }
            catch (ExcepcionDatos ex) { Mensaje.Advertencia(ex.Message); }
            catch (Exception ex)
            {
                Logger.Error(ex, "Guardar rol");
                Mensaje.Error("Error inesperado: " + ex.Message);
            }
        }

        protected override void Eliminar()
        {
            if (IdSeleccionado == 0) return;
            if (IdSeleccionado == Sesion.Usuario.IdRol)
            {
                Mensaje.Advertencia("No puede eliminar el rol con el que inició sesión.");
                return;
            }
            if (!Mensaje.Confirmar($"¿Eliminar el rol '{txtNombre.Text}'?")) return;
            try
            {
                dao.Eliminar(IdSeleccionado);
                Logger.Actividad("ELIMINAR", "Roles", $"Rol #{IdSeleccionado} eliminado: {txtNombre.Text}");
                Mensaje.Info("Rol eliminado.");
                Cargar();
                Limpiar();
            }
            catch (ExcepcionDatos ex) { Mensaje.Advertencia(ex.Message + "\n(Hay usuarios que tienen este rol asignado.)"); }
            catch (Exception ex)
            {
                Logger.Error(ex, "Eliminar rol");
                Mensaje.Error("Error inesperado: " + ex.Message);
            }
        }

        protected override void Limpiar()
        {
            base.Limpiar();
            for (int i = 0; i < lstPermisos.Items.Count; i++) lstPermisos.SetItemChecked(i, false);
        }
    }
}
