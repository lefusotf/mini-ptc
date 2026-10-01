using ClinicaMedica.Modelo.DAO;
using ClinicaMedica.Modelo.Entidades;
using ClinicaMedica.Modelo.Utilidades;

namespace ClinicaMedica.Vista
{
    public class FrmMedicos : FrmBaseCrud
    {
        private readonly MedicoDAO dao = new MedicoDAO();
        private readonly TextBox txtNombres, txtApellidos, txtJvpm, txtTelefono, txtCorreo;
        private readonly ComboBox cboEspecialidad, cboUsuario;
        private readonly CheckBox chkActivo;

        public FrmMedicos() : base("Médicos")
        {
            txtNombres = Campo("Nombres *", new TextBox { MaxLength = 100 });
            txtApellidos = Campo("Apellidos *", new TextBox { MaxLength = 100 });
            txtJvpm = Campo("N° JVPM *", new TextBox { MaxLength = 20 });
            cboEspecialidad = Campo("Especialidad *", new ComboBox());
            txtTelefono = Campo("Teléfono (0000-0000)", new TextBox { MaxLength = 15 });
            txtCorreo = Campo("Correo", new TextBox { MaxLength = 100 });
            cboUsuario = Campo("Usuario del sistema (rol Médico)", new ComboBox());
            chkActivo = Campo("Estado", new CheckBox { Text = "Activo", Checked = true });
        }

        protected override void CargarListas()
        {
            try
            {
                cboEspecialidad.DataSource = new EspecialidadDAO().Listar();
                CargarUsuarios(null);
            }
            catch (Exception ex)
            {
                Logger.Error(ex, "Cargar listas de médicos");
                Mensaje.Error("No se pudieron cargar las especialidades/usuarios: " + ex.Message);
            }
        }

        /// <summary>Muestra solo usuarios con rol Médico que aún no tienen un médico asignado.</summary>
        private void CargarUsuarios(int? idMedico)
        {
            var lista = new List<Usuario> { new Usuario { IdUsuario = 0, NombreUsuario = "(Sin usuario)", NombreCompleto = "" } };
            lista.AddRange(new UsuarioDAO().ListarMedicosDisponibles(idMedico));
            cboUsuario.DataSource = lista;
            cboUsuario.DisplayMember = "NombreUsuario";
            cboUsuario.ValueMember = "IdUsuario";
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
                Logger.Error(ex, "Cargar médicos");
                Mensaje.Error("Error al cargar médicos: " + ex.Message);
            }
        }

        protected override void MostrarRegistro(object registro)
        {
            var m = (Medico)registro;
            CargarUsuarios(m.IdMedico);
            txtNombres.Text = m.Nombres;
            txtApellidos.Text = m.Apellidos;
            txtJvpm.Text = m.JVPM;
            cboEspecialidad.SelectedValue = m.IdEspecialidad;
            txtTelefono.Text = m.Telefono;
            txtCorreo.Text = m.Correo;
            cboUsuario.SelectedValue = m.IdUsuario ?? 0;
            chkActivo.Checked = m.Activo;
            ModoEdicion(m.IdMedico);
        }

        protected override void Guardar()
        {
            Errores.Clear();
            if (!Requerido(txtNombres, "Nombres") || !Requerido(txtApellidos, "Apellidos") || !Requerido(txtJvpm, "N° JVPM"))
                return;
            if (!txtJvpm.Text.Trim().All(char.IsDigit)) { MarcarError(txtJvpm, "El número JVPM solo debe contener dígitos."); return; }
            if (cboEspecialidad.SelectedValue == null) { MarcarError(cboEspecialidad, "Seleccione una especialidad."); return; }
            if (!Validaciones.EsTelefono(txtTelefono.Text)) { MarcarError(txtTelefono, "Teléfono inválido. Use el formato 7000-0000."); return; }
            if (!Validaciones.EsCorreo(txtCorreo.Text)) { MarcarError(txtCorreo, "El correo no tiene un formato válido."); return; }

            int idUsuario = Convert.ToInt32(cboUsuario.SelectedValue ?? 0);
            var m = new Medico
            {
                IdMedico = IdSeleccionado,
                Nombres = txtNombres.Text.Trim(),
                Apellidos = txtApellidos.Text.Trim(),
                JVPM = txtJvpm.Text.Trim(),
                IdEspecialidad = (int)cboEspecialidad.SelectedValue,
                Telefono = txtTelefono.Text.Trim(),
                Correo = txtCorreo.Text.Trim(),
                IdUsuario = idUsuario == 0 ? (int?)null : idUsuario,
                Activo = chkActivo.Checked
            };
            try
            {
                if (IdSeleccionado == 0)
                {
                    dao.Insertar(m);
                    Logger.Actividad("INSERTAR", "Médicos", $"Médico registrado: {m.Nombres} {m.Apellidos}");
                    Mensaje.Info("Médico registrado correctamente.");
                }
                else
                {
                    dao.Actualizar(m);
                    Logger.Actividad("ACTUALIZAR", "Médicos", $"Médico #{m.IdMedico} modificado: {m.Nombres} {m.Apellidos}");
                    Mensaje.Info("Médico actualizado correctamente.");
                }
                Cargar();
                Limpiar();
            }
            catch (ExcepcionDatos ex) { Mensaje.Advertencia(ex.Message); }
            catch (Exception ex)
            {
                Logger.Error(ex, "Guardar médico");
                Mensaje.Error("Error inesperado: " + ex.Message);
            }
        }

        protected override void Eliminar()
        {
            if (IdSeleccionado == 0) return;
            if (!Mensaje.Confirmar($"¿Eliminar al médico {txtNombres.Text} {txtApellidos.Text}?\n" +
                                   "Si tiene citas registradas, se recomienda solo desactivarlo.")) return;
            try
            {
                dao.Eliminar(IdSeleccionado);
                Logger.Actividad("ELIMINAR", "Médicos", $"Médico #{IdSeleccionado} eliminado");
                Mensaje.Info("Médico eliminado.");
                Cargar();
                Limpiar();
            }
            catch (ExcepcionDatos ex) { Mensaje.Advertencia(ex.Message); }
            catch (Exception ex)
            {
                Logger.Error(ex, "Eliminar médico");
                Mensaje.Error("Error inesperado: " + ex.Message);
            }
        }

        protected override void Limpiar()
        {
            try { CargarUsuarios(null); }
            catch (Exception ex) { Logger.Error(ex, "Cargar usuarios médicos"); }
            base.Limpiar();
        }
    }
}
