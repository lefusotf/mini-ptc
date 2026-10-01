using ClinicaMedica.Modelo.DAO;
using ClinicaMedica.Modelo.Entidades;
using ClinicaMedica.Modelo.Utilidades;

namespace ClinicaMedica.Vista
{
    public class FrmPacientes : FrmBaseCrud
    {
        private readonly PacienteDAO dao = new PacienteDAO();
        private readonly TextBox txtNombres, txtApellidos, txtDui, txtTelefono, txtCorreo, txtDireccion, txtAlergias;
        private readonly DateTimePicker dtpNacimiento;
        private readonly ComboBox cboGenero, cboSangre;

        public FrmPacientes() : base("Pacientes")
        {
            txtNombres = Campo("Nombres *", new TextBox { MaxLength = 100 });
            txtApellidos = Campo("Apellidos *", new TextBox { MaxLength = 100 });
            txtDui = Campo("DUI (00000000-0)", new TextBox { MaxLength = 10 });
            dtpNacimiento = Campo("Fecha de nacimiento *", new DateTimePicker { Format = DateTimePickerFormat.Short });
            dtpNacimiento.MaxDate = DateTime.Today;
            cboGenero = Campo("Género *", new ComboBox());
            cboGenero.Items.AddRange(new object[] { "M - Masculino", "F - Femenino" });
            txtTelefono = Campo("Teléfono (0000-0000)", new TextBox { MaxLength = 15 });
            txtCorreo = Campo("Correo", new TextBox { MaxLength = 100 });
            txtDireccion = Campo("Dirección", new TextBox { MaxLength = 250 });
            cboSangre = Campo("Tipo de sangre", new ComboBox());
            cboSangre.Items.AddRange(new object[] { "", "O+", "O-", "A+", "A-", "B+", "B-", "AB+", "AB-" });
            txtAlergias = Campo("Alergias", TextoMultilinea(), 50);
            txtAlergias.MaxLength = 250;

            // El médico solo puede consultar pacientes
            if (!Sesion.TienePermiso(P.PacientesGestionar))
                ModoSoloLectura();
        }

        protected override void Cargar()
        {
            try
            {
                MostrarEnGrid(dao.Listar(TxtBuscar.Text.Trim()), "FechaRegistro");
            }
            catch (ExcepcionDatos ex) { Mensaje.Error(ex.Message); }
            catch (Exception ex)
            {
                Logger.Error(ex, "Cargar pacientes");
                Mensaje.Error("Error al cargar pacientes: " + ex.Message);
            }
        }

        protected override void MostrarRegistro(object registro)
        {
            var p = (Paciente)registro;
            txtNombres.Text = p.Nombres;
            txtApellidos.Text = p.Apellidos;
            txtDui.Text = p.DUI;
            dtpNacimiento.Value = p.FechaNacimiento;
            cboGenero.SelectedIndex = p.Genero == "F" ? 1 : 0;
            txtTelefono.Text = p.Telefono;
            txtCorreo.Text = p.Correo;
            txtDireccion.Text = p.Direccion;
            cboSangre.SelectedItem = p.TipoSangre ?? "";
            txtAlergias.Text = p.Alergias;
            ModoEdicion(p.IdPaciente);
        }

        private bool Validar()
        {
            Errores.Clear();
            if (!Requerido(txtNombres, "Nombres")) return false;
            if (!Requerido(txtApellidos, "Apellidos")) return false;
            if (!Validaciones.EsDui(txtDui.Text)) return MarcarError(txtDui, "El DUI debe tener el formato 00000000-0.");
            if (dtpNacimiento.Value.Date > DateTime.Today) return MarcarError(dtpNacimiento, "La fecha de nacimiento no puede ser futura.");
            if (!Validaciones.EsTelefono(txtTelefono.Text)) return MarcarError(txtTelefono, "Teléfono inválido. Use el formato 7000-0000.");
            if (!Validaciones.EsCorreo(txtCorreo.Text)) return MarcarError(txtCorreo, "El correo no tiene un formato válido.");
            return true;
        }

        protected override void Guardar()
        {
            if (!Validar()) return;

            var p = new Paciente
            {
                IdPaciente = IdSeleccionado,
                Nombres = txtNombres.Text.Trim(),
                Apellidos = txtApellidos.Text.Trim(),
                DUI = txtDui.Text.Trim(),
                FechaNacimiento = dtpNacimiento.Value.Date,
                Genero = cboGenero.SelectedIndex == 1 ? "F" : "M",
                Telefono = txtTelefono.Text.Trim(),
                Correo = txtCorreo.Text.Trim(),
                Direccion = txtDireccion.Text.Trim(),
                TipoSangre = cboSangre.SelectedItem?.ToString(),
                Alergias = txtAlergias.Text.Trim()
            };
            try
            {
                if (IdSeleccionado == 0)
                {
                    dao.Insertar(p);
                    Logger.Actividad("INSERTAR", "Pacientes", $"Paciente registrado: {p.NombreCompleto}");
                    Mensaje.Info("Paciente registrado correctamente.");
                }
                else
                {
                    dao.Actualizar(p);
                    Logger.Actividad("ACTUALIZAR", "Pacientes", $"Paciente #{p.IdPaciente} modificado: {p.NombreCompleto}");
                    Mensaje.Info("Paciente actualizado correctamente.");
                }
                Cargar();
                Limpiar();
            }
            catch (ExcepcionDatos ex) { Mensaje.Advertencia(ex.Message); }
            catch (Exception ex)
            {
                Logger.Error(ex, "Guardar paciente");
                Mensaje.Error("Error inesperado: " + ex.Message);
            }
        }

        protected override void Eliminar()
        {
            if (IdSeleccionado == 0) return;
            if (!Mensaje.Confirmar($"¿Eliminar al paciente {txtNombres.Text} {txtApellidos.Text}?")) return;
            try
            {
                dao.Eliminar(IdSeleccionado);
                Logger.Actividad("ELIMINAR", "Pacientes", $"Paciente #{IdSeleccionado} eliminado: {txtNombres.Text} {txtApellidos.Text}");
                Mensaje.Info("Paciente eliminado.");
                Cargar();
                Limpiar();
            }
            catch (ExcepcionDatos ex) { Mensaje.Advertencia(ex.Message); }
            catch (Exception ex)
            {
                Logger.Error(ex, "Eliminar paciente");
                Mensaje.Error("Error inesperado: " + ex.Message);
            }
        }

        protected override void Limpiar()
        {
            base.Limpiar();
            dtpNacimiento.Value = DateTime.Today.AddYears(-30);
        }
    }
}
