using Modelos.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Vista.Gestion
{
    public partial class frmCitas : Form
    {
        public frmCitas()
        {
            InitializeComponent();
        }

        // El médico solo ve SUS citas y solo puede cambiar el estado
        private bool esMedico = false;

        private void frmCitas_Load(object sender, EventArgs e)
        {
            esMedico = Sesion.Rol == "Medico";
            cargarCombos();

            if (esMedico)
            {
                // Quitamos la pestaña de registrar y bloqueamos lo que no puede cambiar
                tabControl1.TabPages.Remove(tpRegistrar);
                cmbPacienteAct.Enabled = false;
                cmbMedicoAct.Enabled = false;
                dtpFechaAct.Enabled = false;
                cmbHoraAct.Enabled = false;
                txtMotivoAct.Enabled = false;
                btnEliminar.Enabled = false;
            }
            cargarDatagridCitas();
        }

        private void cargarDatagridCitas()
        {
            int idMedico = 0;   // 0 = todas las citas
            if (esMedico) idMedico = Sesion.IdMedico;

            dgvCitas.DataSource = null;
            dgvCitas.DataSource = Cita.cargarCitas(idMedico);
            dgvCitas.Columns["id_Medico"].Visible = false;
        }

        private void cargarCombos()
        {
            DataTable dtPacientes = Paciente.cargarCombo();
            cmbPaciente.DataSource = dtPacientes;
            cmbPaciente.DisplayMember = "nombrePaciente";
            cmbPaciente.ValueMember = "idPaciente";
            cmbPaciente.SelectedIndex = -1;

            cmbPacienteAct.DataSource = dtPacientes.Copy();
            cmbPacienteAct.DisplayMember = "nombrePaciente";
            cmbPacienteAct.ValueMember = "idPaciente";
            cmbPacienteAct.SelectedIndex = -1;

            DataTable dtMedicos = Medico.cargarCombo();
            cmbMedico.DataSource = dtMedicos;
            cmbMedico.DisplayMember = "nombreMedico";
            cmbMedico.ValueMember = "idMedico";
            cmbMedico.SelectedIndex = -1;

            cmbMedicoAct.DataSource = dtMedicos.Copy();
            cmbMedicoAct.DisplayMember = "nombreMedico";
            cmbMedicoAct.ValueMember = "idMedico";
            cmbMedicoAct.SelectedIndex = -1;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (cmbPaciente.SelectedIndex == -1 || cmbMedico.SelectedIndex == -1 || cmbHora.SelectedIndex == -1
                || string.IsNullOrWhiteSpace(txtMotivo.Text))
            {
                MessageBox.Show("Complete todos los campos (paciente, médico, hora y motivo)", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (dtpFecha.Value.Date < DateTime.Today)
            {
                errorProvider1.SetError(dtpFecha, "Fecha pasada");
                MessageBox.Show("No se puede agendar una cita en una fecha pasada", "Fecha inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Cita cita = new Cita();
            cita.IdPaciente = Convert.ToInt32(cmbPaciente.SelectedValue);
            cita.IdMedico = Convert.ToInt32(cmbMedico.SelectedValue);
            cita.Fecha = dtpFecha.Value.Date;
            cita.Hora = cmbHora.Text;
            cita.Motivo = txtMotivo.Text.Trim();
            cita.Estado = "Pendiente";

            // No se permiten dos citas del mismo médico a la misma hora
            if (cita.horarioOcupado())
            {
                MessageBox.Show("El médico ya tiene una cita en esa fecha y hora. Elija otro horario.", "Horario ocupado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cita.InsertarCita())
            {
                Bitacora.registrar("Agendó cita para " + cmbPaciente.Text + " el " + cita.Fecha.ToShortDateString() + " a las " + cita.Hora);
                MessageBox.Show("Cita agendada con éxito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cargarDatagridCitas();
                cmbPaciente.SelectedIndex = -1;
                cmbMedico.SelectedIndex = -1;
                cmbHora.SelectedIndex = -1;
                txtMotivo.Clear();
            }
        }

        private void dgvCitas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int idCita = Convert.ToInt32(dgvCitas.Rows[e.RowIndex].Cells["#"].Value);
                Cita cita = Cita.buscarCita(idCita);
                if (cita == null) return;

                cmbPacienteAct.SelectedValue = cita.IdPaciente;
                cmbMedicoAct.SelectedValue = cita.IdMedico;
                dtpFechaAct.Value = cita.Fecha;
                cmbHoraAct.Text = cita.Hora;
                txtMotivoAct.Text = cita.Motivo;
                cmbEstadoAct.Text = cita.Estado;
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (dgvCitas.CurrentRow == null || cmbPacienteAct.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione una cita de la lista", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Cita cita = new Cita();
            cita.IdCita = Convert.ToInt32(dgvCitas.CurrentRow.Cells["#"].Value);
            cita.IdPaciente = Convert.ToInt32(cmbPacienteAct.SelectedValue);
            cita.IdMedico = Convert.ToInt32(cmbMedicoAct.SelectedValue);
            cita.Fecha = dtpFechaAct.Value.Date;
            cita.Hora = cmbHoraAct.Text;
            cita.Motivo = txtMotivoAct.Text.Trim();
            cita.Estado = cmbEstadoAct.Text;

            if (cita.Estado != "Cancelada" && cita.horarioOcupado())
            {
                MessageBox.Show("El médico ya tiene una cita en esa fecha y hora. Elija otro horario.", "Horario ocupado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cita.ActualizarCita())
            {
                Bitacora.registrar("Actualizó la cita #" + cita.IdCita + " (estado: " + cita.Estado + ")");
                MessageBox.Show("Cita actualizada", "Actualizando datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cargarDatagridCitas();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvCitas.CurrentRow == null)
            {
                MessageBox.Show("Seleccione una cita de la lista", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int idCita = Convert.ToInt32(dgvCitas.CurrentRow.Cells["#"].Value);
            if (MessageBox.Show("¿Está seguro que desea eliminar esta cita?", "Confirmar eliminación",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (Cita.EliminarCita(idCita))
                {
                    Bitacora.registrar("Eliminó la cita #" + idCita);
                    MessageBox.Show("Cita eliminada exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cargarDatagridCitas();
                }
            }
        }

        // Pinta las pestañas del TabControl (igual que en el ejemplo del profe)
        private void tabControl1_DrawItem(object sender, DrawItemEventArgs e)
        {
            TabControl tabCtrl = (TabControl)sender;
            TabPage page = tabCtrl.TabPages[e.Index];

            Color backColor;
            Color textColor;

            if (tabCtrl.SelectedIndex == e.Index)
            {
                backColor = Color.FromArgb(41, 182, 182); // Turquesa (pestaña activa)
                textColor = Color.FromArgb(43, 48, 59);
            }
            else
            {
                backColor = Color.FromArgb(62, 68, 82);   // Gris oscuro (pestaña inactiva)
                textColor = Color.White;
            }

            using (SolidBrush brushFondo = new SolidBrush(backColor))
            {
                e.Graphics.FillRectangle(brushFondo, e.Bounds);
            }
            using (StringFormat sf = new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center })
            {
                using (SolidBrush brushTexto = new SolidBrush(textColor))
                {
                    e.Graphics.DrawString(page.Text, tabCtrl.Font, brushTexto, e.Bounds, sf);
                }
            }
        }
    }
}
