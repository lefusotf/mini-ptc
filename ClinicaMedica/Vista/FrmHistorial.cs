using ClinicaMedica.Modelo.DAO;
using ClinicaMedica.Modelo.Entidades;
using ClinicaMedica.Modelo.Utilidades;

namespace ClinicaMedica.Vista
{
    /// <summary>
    /// Historial clínico del paciente (seguimiento histórico).
    /// El médico registra el diagnóstico y tratamiento de cada consulta.
    /// </summary>
    public class FrmHistorial : FrmBaseCrud
    {
        private readonly HistorialDAO dao = new HistorialDAO();
        private readonly ComboBox cboPaciente, cboMedico;
        private readonly DateTimePicker dtpFecha;
        private readonly TextBox txtDiagnostico, txtTratamiento, txtObservaciones;
        private readonly Label lblInfoPaciente;
        private readonly bool puedeEditar = Sesion.TienePermiso(P.HistorialEditar);

        private readonly int? idPacienteInicial, idCitaInicial, idMedicoInicial;
        private HistorialClinico registroActual;

        public FrmHistorial() : this(null, null, null) { }

        public FrmHistorial(int? idPaciente, int? idCita, int? idMedico) : base("Historial Clínico")
        {
            idPacienteInicial = idPaciente;
            idCitaInicial = idCita;
            idMedicoInicial = idMedico;

            cboPaciente = Campo("Paciente *", new ComboBox());
            lblInfoPaciente = new Label { AutoSize = false, Width = 325, Height = 40, ForeColor = Estilos.Peligro };
            PanelCampos.Controls.Add(lblInfoPaciente);
            cboMedico = Campo("Médico que atiende *", new ComboBox());
            dtpFecha = Campo("Fecha y hora de la consulta *", new DateTimePicker
            {
                Format = DateTimePickerFormat.Custom,
                CustomFormat = "dd/MM/yyyy HH:mm"
            });
            txtDiagnostico = Campo("Diagnóstico *", TextoMultilinea(), 70);
            txtDiagnostico.MaxLength = 500;
            txtTratamiento = Campo("Tratamiento", TextoMultilinea(), 70);
            txtTratamiento.MaxLength = 500;
            txtObservaciones = Campo("Observaciones", TextoMultilinea(), 50);
            txtObservaciones.MaxLength = 500;

            // El buscador filtra por diagnóstico/tratamiento dentro del historial del paciente
            cboPaciente.SelectedIndexChanged += (s, e) => { Cargar(); Limpiar(); };

            if (!puedeEditar) ModoSoloLectura();
            cboPaciente.Enabled = idPaciente == null;   // si viene desde una cita, el paciente queda fijo
        }

        protected override void CargarListas()
        {
            try
            {
                cboMedico.DataSource = new MedicoDAO().Listar();
                cboMedico.ValueMember = "IdMedico";
                cboPaciente.DataSource = new PacienteDAO().Listar();
                cboPaciente.ValueMember = "IdPaciente";
                if (idPacienteInicial != null) cboPaciente.SelectedValue = idPacienteInicial.Value;
            }
            catch (Exception ex)
            {
                Logger.Error(ex, "Cargar listas de historial");
                Mensaje.Error("No se pudieron cargar pacientes/médicos: " + ex.Message);
            }
        }

        protected override void Cargar()
        {
            if (cboPaciente?.SelectedItem is not Paciente p) { MostrarEnGrid(new List<HistorialClinico>()); return; }
            try
            {
                lblInfoPaciente.Text = $"Edad: {p.Edad} años   Sangre: {p.TipoSangre ?? "-"}\nAlergias: {p.Alergias ?? "Ninguna registrada"}";
                string f = TxtBuscar.Text.Trim();
                var lista = dao.ListarPorPaciente(p.IdPaciente)
                    .Where(h => f == "" || (h.Diagnostico + " " + h.Tratamiento + " " + h.NombreMedico)
                                .Contains(f, StringComparison.OrdinalIgnoreCase))
                    .ToList();
                MostrarEnGrid(lista, "NombrePaciente");
                Grid.Columns["FechaConsulta"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";
            }
            catch (ExcepcionDatos ex) { Mensaje.Error(ex.Message); }
            catch (Exception ex)
            {
                Logger.Error(ex, "Cargar historial");
                Mensaje.Error("Error al cargar el historial: " + ex.Message);
            }
        }

        protected override void MostrarRegistro(object registro)
        {
            registroActual = (HistorialClinico)registro;
            cboMedico.SelectedValue = registroActual.IdMedico;
            dtpFecha.Value = registroActual.FechaConsulta;
            txtDiagnostico.Text = registroActual.Diagnostico;
            txtTratamiento.Text = registroActual.Tratamiento;
            txtObservaciones.Text = registroActual.Observaciones;
            ModoEdicion(registroActual.IdHistorial);

            // Un médico solo puede modificar las consultas que él mismo registró
            bool esPropio = Sesion.IdMedico == null || Sesion.IdMedico == registroActual.IdMedico;
            BtnGuardar.Enabled = BtnEliminar.Enabled = esPropio;
        }

        protected override void Guardar()
        {
            Errores.Clear();
            if (cboPaciente.SelectedValue == null) { MarcarError(cboPaciente, "Seleccione un paciente."); return; }
            if (cboMedico.SelectedValue == null) { MarcarError(cboMedico, "Seleccione el médico."); return; }
            if (!Requerido(txtDiagnostico, "Diagnóstico")) return;
            if (dtpFecha.Value > DateTime.Now.AddMinutes(5)) { MarcarError(dtpFecha, "La fecha de la consulta no puede ser futura."); return; }

            var h = new HistorialClinico
            {
                IdHistorial = IdSeleccionado,
                IdPaciente = (int)cboPaciente.SelectedValue,
                IdMedico = (int)cboMedico.SelectedValue,
                IdCita = IdSeleccionado == 0 ? idCitaInicial : registroActual?.IdCita,
                FechaConsulta = dtpFecha.Value,
                Diagnostico = txtDiagnostico.Text.Trim(),
                Tratamiento = txtTratamiento.Text.Trim(),
                Observaciones = txtObservaciones.Text.Trim()
            };
            try
            {
                if (IdSeleccionado == 0)
                {
                    dao.Insertar(h);
                    // Si la consulta viene de una cita, la cita pasa a "Atendida"
                    if (h.IdCita != null)
                        new CitaDAO().ActualizarEstado(h.IdCita.Value, "Atendida", "Consulta registrada en historial");
                    Logger.Actividad("INSERTAR", "Historial", $"Consulta registrada para {cboPaciente.Text}");
                    Mensaje.Info("Consulta registrada en el historial.");
                }
                else
                {
                    dao.Actualizar(h);
                    Logger.Actividad("ACTUALIZAR", "Historial", $"Historial #{h.IdHistorial} actualizado ({cboPaciente.Text})");
                    Mensaje.Info("Historial actualizado.");
                }
                Cargar();
                Limpiar();
            }
            catch (ExcepcionDatos ex) { Mensaje.Advertencia(ex.Message); }
            catch (Exception ex)
            {
                Logger.Error(ex, "Guardar historial");
                Mensaje.Error("Error inesperado: " + ex.Message);
            }
        }

        protected override void Eliminar()
        {
            if (IdSeleccionado == 0) return;
            if (!Mensaje.Confirmar("¿Eliminar este registro del historial clínico?")) return;
            try
            {
                dao.Eliminar(IdSeleccionado);
                Logger.Actividad("ELIMINAR", "Historial", $"Historial #{IdSeleccionado} eliminado ({cboPaciente.Text})");
                Mensaje.Info("Registro eliminado.");
                Cargar();
                Limpiar();
            }
            catch (ExcepcionDatos ex) { Mensaje.Advertencia(ex.Message); }
            catch (Exception ex)
            {
                Logger.Error(ex, "Eliminar historial");
                Mensaje.Error("Error inesperado: " + ex.Message);
            }
        }

        protected override void Limpiar()
        {
            // No se usa base.Limpiar() completo para no reiniciar el paciente seleccionado
            IdSeleccionado = 0;
            registroActual = null;
            Errores.Clear();
            txtDiagnostico.Clear();
            txtTratamiento.Clear();
            txtObservaciones.Clear();
            dtpFecha.Value = DateTime.Now;
            Grid.ClearSelection();
            BtnGuardar.Text = "Guardar";
            BtnGuardar.Enabled = true;
            BtnEliminar.Enabled = false;

            // El médico registra a su nombre; el admin puede elegir
            int? medico = Sesion.IdMedico ?? idMedicoInicial;
            if (medico != null && cboMedico.Items.Count > 0) cboMedico.SelectedValue = medico.Value;
            cboMedico.Enabled = puedeEditar && Sesion.IdMedico == null;
        }
    }
}
