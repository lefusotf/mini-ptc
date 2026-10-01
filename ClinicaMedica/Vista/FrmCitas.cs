using ClinicaMedica.Modelo.DAO;
using ClinicaMedica.Modelo.Entidades;
using ClinicaMedica.Modelo.Utilidades;

namespace ClinicaMedica.Vista
{
    /// <summary>
    /// Recepcionista / Administrador: agenda, reprograma y cancela citas de todos los médicos.
    /// Médico: solo ve SUS citas y puede cambiar el estado y registrar la consulta en el historial.
    /// </summary>
    public class FrmCitas : FrmBaseCrud
    {
        private readonly CitaDAO dao = new CitaDAO();
        private readonly ComboBox cboPaciente, cboMedico, cboHora, cboEstado;
        private readonly DateTimePicker dtpFecha, dtpFiltro;
        private readonly CheckBox chkFiltrarFecha;
        private readonly TextBox txtMotivo, txtObservaciones;
        private readonly Button btnHistorial;

        private readonly bool puedeAgendar = Sesion.TienePermiso(P.CitasAgendar);
        private readonly bool puedeAtender = Sesion.TienePermiso(P.CitasAtender);
        private readonly bool verSoloPropias = !Sesion.TienePermiso(P.CitasVerTodas);

        private Cita citaActual;

        public FrmCitas() : base("Citas Médicas")
        {
            if (verSoloPropias) LblTitulo.Text = "Mis Citas";

            cboPaciente = Campo("Paciente *", new ComboBox());
            cboMedico = Campo("Médico *", new ComboBox());
            dtpFecha = Campo("Fecha *", new DateTimePicker { Format = DateTimePickerFormat.Long });
            cboHora = Campo("Hora *", new ComboBox());
            for (var h = new TimeSpan(7, 0, 0); h <= new TimeSpan(17, 0, 0); h = h.Add(TimeSpan.FromMinutes(30)))
                cboHora.Items.Add(h.ToString(@"hh\:mm"));
            txtMotivo = Campo("Motivo de la consulta *", TextoMultilinea(), 50);
            txtMotivo.MaxLength = 250;
            cboEstado = Campo("Estado", new ComboBox());
            cboEstado.Items.AddRange(Cita.Estados);
            txtObservaciones = Campo("Observaciones", TextoMultilinea(), 50);
            txtObservaciones.MaxLength = 500;

            // Filtro por fecha (junto al buscador)
            chkFiltrarFecha = new CheckBox { Text = "Solo el día:", AutoSize = true, Location = new Point(490, 9) };
            dtpFiltro = new DateTimePicker { Format = DateTimePickerFormat.Short, Location = new Point(590, 7), Width = 120 };
            chkFiltrarFecha.CheckedChanged += (s, e) => Cargar();
            dtpFiltro.ValueChanged += (s, e) => { if (chkFiltrarFecha.Checked) Cargar(); };
            TxtBuscar.Parent.Controls.AddRange(new Control[] { chkFiltrarFecha, dtpFiltro });

            btnHistorial = Estilos.CrearBoton("Registrar consulta", Estilos.PrimarioOscuro, (s, e) => AbrirHistorial(), 325);
            btnHistorial.Visible = Sesion.TienePermiso(P.HistorialEditar);
            PanelBotones.Controls.Add(btnHistorial);

            AplicarPermisos();
        }

        private void AplicarPermisos()
        {
            if (puedeAgendar) return;

            // Médico: no crea ni elimina citas; solo cambia estado y observaciones
            BtnNuevo.Visible = BtnEliminar.Visible = false;
            BtnGuardar.Visible = puedeAtender;
            cboPaciente.Enabled = cboMedico.Enabled = dtpFecha.Enabled = cboHora.Enabled = txtMotivo.Enabled = false;
            cboEstado.Enabled = txtObservaciones.Enabled = puedeAtender;
        }

        protected override void CargarListas()
        {
            try
            {
                cboPaciente.DataSource = new PacienteDAO().Listar();
                cboPaciente.ValueMember = "IdPaciente";
                cboMedico.DataSource = new MedicoDAO().Listar("", soloActivos: true);
                cboMedico.ValueMember = "IdMedico";
            }
            catch (Exception ex)
            {
                Logger.Error(ex, "Cargar listas de citas");
                Mensaje.Error("No se pudieron cargar pacientes/médicos: " + ex.Message);
            }
        }

        protected override void Cargar()
        {
            try
            {
                if (verSoloPropias && Sesion.IdMedico == null)
                {
                    Mensaje.Advertencia("Su usuario no está vinculado a ningún médico. Pida al administrador que lo asigne.");
                    MostrarEnGrid(new List<Cita>());
                    return;
                }
                DateTime? fecha = chkFiltrarFecha.Checked ? dtpFiltro.Value.Date : (DateTime?)null;
                int? idMedico = verSoloPropias ? Sesion.IdMedico : null;
                MostrarEnGrid(dao.Listar(TxtBuscar.Text.Trim(), fecha, idMedico));
                Grid.Columns["Fecha"].DefaultCellStyle.Format = "dd/MM/yyyy";
                Grid.Columns["Hora"].DefaultCellStyle.Format = @"hh\:mm";
            }
            catch (ExcepcionDatos ex) { Mensaje.Error(ex.Message); }
            catch (Exception ex)
            {
                Logger.Error(ex, "Cargar citas");
                Mensaje.Error("Error al cargar citas: " + ex.Message);
            }
        }

        protected override void MostrarRegistro(object registro)
        {
            citaActual = (Cita)registro;
            cboPaciente.SelectedValue = citaActual.IdPaciente;
            cboMedico.SelectedValue = citaActual.IdMedico;
            dtpFecha.MinDate = DateTimePicker.MinimumDateTime;  // permite ver citas pasadas
            dtpFecha.Value = citaActual.Fecha;
            string hora = citaActual.Hora.ToString(@"hh\:mm");
            if (!cboHora.Items.Contains(hora)) cboHora.Items.Add(hora);
            cboHora.SelectedItem = hora;
            txtMotivo.Text = citaActual.Motivo;
            cboEstado.SelectedItem = citaActual.Estado;
            txtObservaciones.Text = citaActual.Observaciones;
            ModoEdicion(citaActual.IdCita);
            BtnEliminar.Enabled = puedeAgendar;
            btnHistorial.Enabled = true;
        }

        private bool Validar()
        {
            Errores.Clear();
            if (cboPaciente.SelectedValue == null) return MarcarError(cboPaciente, "Seleccione un paciente.");
            if (cboMedico.SelectedValue == null) return MarcarError(cboMedico, "Seleccione un médico.");
            if (cboHora.SelectedItem == null) return MarcarError(cboHora, "Seleccione la hora de la cita.");
            if (!Requerido(txtMotivo, "Motivo")) return false;

            var fechaHora = dtpFecha.Value.Date + TimeSpan.Parse(cboHora.SelectedItem.ToString());
            bool esNueva = IdSeleccionado == 0;
            if (esNueva && fechaHora < DateTime.Now)
                return MarcarError(dtpFecha, "No se puede agendar una cita en una fecha u hora pasada.");
            if (dtpFecha.Value.DayOfWeek == DayOfWeek.Sunday)
                return MarcarError(dtpFecha, "La clínica no atiende los domingos.");
            return true;
        }

        protected override void Guardar()
        {
            try
            {
                // ----- Médico: solo actualiza estado / observaciones -----
                if (!puedeAgendar)
                {
                    if (IdSeleccionado == 0) { Mensaje.Advertencia("Seleccione una cita de la lista."); return; }
                    dao.ActualizarEstado(IdSeleccionado, cboEstado.SelectedItem.ToString(), txtObservaciones.Text.Trim());
                    Logger.Actividad("ACTUALIZAR", "Citas", $"Cita #{IdSeleccionado} cambiada a estado {cboEstado.SelectedItem}");
                    Mensaje.Info("Cita actualizada.");
                    Cargar();
                    Limpiar();
                    return;
                }

                // ----- Recepcionista / Administrador -----
                if (!Validar()) return;
                var c = new Cita
                {
                    IdCita = IdSeleccionado,
                    IdPaciente = (int)cboPaciente.SelectedValue,
                    IdMedico = (int)cboMedico.SelectedValue,
                    Fecha = dtpFecha.Value.Date,
                    Hora = TimeSpan.Parse(cboHora.SelectedItem.ToString()),
                    Motivo = txtMotivo.Text.Trim(),
                    Estado = cboEstado.SelectedItem?.ToString() ?? "Pendiente",
                    Observaciones = txtObservaciones.Text.Trim()
                };

                if (IdSeleccionado == 0)
                {
                    dao.Insertar(c);
                    Logger.Actividad("INSERTAR", "Citas", $"Cita agendada: {cboPaciente.Text} con {cboMedico.Text} el {c.Fecha:dd/MM/yyyy} {c.Hora:hh\\:mm}");
                    Mensaje.Info("Cita agendada correctamente.");
                }
                else
                {
                    dao.Actualizar(c);
                    Logger.Actividad("ACTUALIZAR", "Citas", $"Cita #{c.IdCita} modificada ({c.Estado}) {c.Fecha:dd/MM/yyyy} {c.Hora:hh\\:mm}");
                    Mensaje.Info("Cita actualizada correctamente.");
                }
                Cargar();
                Limpiar();
            }
            catch (ExcepcionDatos ex) { Mensaje.Advertencia(ex.Message); }
            catch (Exception ex)
            {
                Logger.Error(ex, "Guardar cita");
                Mensaje.Error("Error inesperado: " + ex.Message);
            }
        }

        protected override void Eliminar()
        {
            if (IdSeleccionado == 0) return;
            if (!Mensaje.Confirmar("¿Eliminar definitivamente esta cita?\nSugerencia: puede cambiar su estado a 'Cancelada' para conservar el historial."))
                return;
            try
            {
                dao.Eliminar(IdSeleccionado);
                Logger.Actividad("ELIMINAR", "Citas", $"Cita #{IdSeleccionado} eliminada");
                Mensaje.Info("Cita eliminada.");
                Cargar();
                Limpiar();
            }
            catch (ExcepcionDatos ex) { Mensaje.Advertencia(ex.Message); }
            catch (Exception ex)
            {
                Logger.Error(ex, "Eliminar cita");
                Mensaje.Error("Error inesperado: " + ex.Message);
            }
        }

        /// <summary>Abre el historial del paciente de la cita seleccionada para registrar la consulta.</summary>
        private void AbrirHistorial()
        {
            if (citaActual == null || IdSeleccionado == 0)
            {
                Mensaje.Advertencia("Seleccione primero una cita de la lista.");
                return;
            }
            using (var frm = new FrmHistorial(citaActual.IdPaciente, citaActual.IdCita, citaActual.IdMedico))
                frm.ShowDialog(this);
            Cargar();
        }

        protected override void Limpiar()
        {
            base.Limpiar();
            citaActual = null;
            dtpFecha.MinDate = DateTimePicker.MinimumDateTime;
            dtpFecha.Value = DateTime.Today;
            cboHora.SelectedIndex = -1;
            cboEstado.SelectedItem = "Pendiente";
            btnHistorial.Enabled = false;
            if (!puedeAgendar) BtnGuardar.Text = "Actualizar estado";
        }
    }
}
