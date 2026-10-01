using System;
using System.Windows.Forms;
using Modelos;

namespace Vistas
{
    public partial class frmCitas : Form
    {
        private int idSeleccionado = 0;
        private bool esMedico = false; // el médico solo ve SUS citas y solo cambia el estado

        public frmCitas()
        {
            InitializeComponent();
        }

        private void frmCitas_Load(object sender, EventArgs e)
        {
            esMedico = Sesion.Rol == "Médico";
            CargarCombos();

            if (esMedico)
            {
                lblTitulo.Text = "Mis citas";
                btnAgregar.Enabled = false;
                btnEliminar.Enabled = false;
                cmbPaciente.Enabled = false;
                cmbMedico.Enabled = false;
                dtpFecha.Enabled = false;
                cmbHora.Enabled = false;
                txtMotivo.Enabled = false;
            }

            MostrarCitas();
            Limpiar();
        }

        private void CargarCombos()
        {
            try
            {
                cmbPaciente.DataSource = Paciente.ObtenerPacientes();
                cmbPaciente.DisplayMember = "Nombre";
                cmbPaciente.ValueMember = "IdPaciente";

                cmbMedico.DataSource = Medico.ObtenerMedicos();
                cmbMedico.DisplayMember = "Nombre";
                cmbMedico.ValueMember = "IdMedico";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las listas: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MostrarCitas()
        {
            try
            {
                // Si es médico se manda su IdMedico; si no, 0 = todas las citas
                int idMedico = esMedico ? Sesion.IdMedico : 0;
                if (esMedico && idMedico == 0)
                {
                    MessageBox.Show("Su usuario no está asignado a ningún médico. Hable con el administrador.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                dgvCitas.DataSource = Cita.Mostrar(txtBuscar.Text.Trim(), idMedico);
                dgvCitas.Columns["IdCita"].Visible = false;
                dgvCitas.Columns["IdPaciente"].Visible = false;
                dgvCitas.Columns["IdMedico"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool Validar(bool esNueva)
        {
            errorProvider1.Clear();
            bool hayError = false;

            if (cmbPaciente.SelectedIndex == -1)
            {
                errorProvider1.SetError(cmbPaciente, "Seleccione un paciente.");
                hayError = true;
            }
            if (cmbMedico.SelectedIndex == -1)
            {
                errorProvider1.SetError(cmbMedico, "Seleccione un médico.");
                hayError = true;
            }
            if (cmbHora.SelectedIndex == -1)
            {
                errorProvider1.SetError(cmbHora, "Seleccione la hora.");
                hayError = true;
            }
            if (string.IsNullOrWhiteSpace(txtMotivo.Text))
            {
                errorProvider1.SetError(txtMotivo, "Escriba el motivo de la cita.");
                hayError = true;
            }
            if (esNueva && dtpFecha.Value.Date < DateTime.Today)
            {
                errorProvider1.SetError(dtpFecha, "No se puede agendar en una fecha pasada.");
                hayError = true;
            }

            if (hayError)
                MessageBox.Show("Complete correctamente los campos marcados.", "Campos requeridos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return !hayError;
        }

        private Cita LeerFormulario()
        {
            Cita c = new Cita();
            c.IdCita = idSeleccionado;
            c.IdPaciente = Convert.ToInt32(cmbPaciente.SelectedValue);
            c.IdMedico = Convert.ToInt32(cmbMedico.SelectedValue);
            c.Fecha = dtpFecha.Value.Date;
            c.Hora = cmbHora.Text;
            c.Motivo = txtMotivo.Text.Trim();
            c.Estado = cmbEstado.Text;
            return c;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (!Validar(true)) return;
            try
            {
                Cita c = LeerFormulario();

                // No se permiten dos citas del mismo médico a la misma hora
                if (c.HorarioOcupado())
                {
                    MessageBox.Show("El médico ya tiene una cita en esa fecha y hora. Elija otro horario.", "Horario ocupado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (c.Agregar())
                {
                    Bitacora.Registrar("Agendó una cita para " + cmbPaciente.Text + " el " + c.Fecha.ToShortDateString() + " a las " + c.Hora);
                    MessageBox.Show("Cita agendada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MostrarCitas();
                    Limpiar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (idSeleccionado == 0)
            {
                MessageBox.Show("Seleccione una cita de la tabla.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!Validar(false)) return;
            try
            {
                Cita c = LeerFormulario();
                if (c.Estado != "Cancelada" && c.HorarioOcupado())
                {
                    MessageBox.Show("El médico ya tiene una cita en esa fecha y hora. Elija otro horario.", "Horario ocupado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (c.Modificar())
                {
                    Bitacora.Registrar("Modificó la cita de " + cmbPaciente.Text + " (estado: " + c.Estado + ")");
                    MessageBox.Show("Cita modificada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MostrarCitas();
                    Limpiar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (idSeleccionado == 0)
            {
                MessageBox.Show("Seleccione una cita de la tabla.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (MessageBox.Show("¿Está seguro de eliminar esta cita?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;
            try
            {
                if (Cita.Eliminar(idSeleccionado))
                {
                    Bitacora.Registrar("Eliminó la cita de " + cmbPaciente.Text);
                    MessageBox.Show("Cita eliminada.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MostrarCitas();
                    Limpiar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Limpiar()
        {
            idSeleccionado = 0;
            if (cmbPaciente.Items.Count > 0) cmbPaciente.SelectedIndex = 0;
            if (cmbMedico.Items.Count > 0) cmbMedico.SelectedIndex = 0;
            dtpFecha.Value = DateTime.Today;
            cmbHora.SelectedIndex = -1;
            txtMotivo.Clear();
            cmbEstado.SelectedIndex = 0; // Pendiente
            errorProvider1.Clear();
            dgvCitas.ClearSelection();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            MostrarCitas();
        }

        private void dgvCitas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            DataGridViewRow fila = dgvCitas.Rows[e.RowIndex];
            idSeleccionado = Convert.ToInt32(fila.Cells["IdCita"].Value);
            cmbPaciente.SelectedValue = Convert.ToInt32(fila.Cells["IdPaciente"].Value);
            cmbMedico.SelectedValue = Convert.ToInt32(fila.Cells["IdMedico"].Value);
            dtpFecha.Value = Convert.ToDateTime(fila.Cells["Fecha"].Value);
            cmbHora.Text = fila.Cells["Hora"].Value.ToString();
            txtMotivo.Text = fila.Cells["Motivo"].Value.ToString();
            cmbEstado.Text = fila.Cells["Estado"].Value.ToString();
        }
    }
}
