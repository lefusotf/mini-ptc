using Modelos.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Vista.Gestion
{
    public partial class frmHistorial : Form
    {
        public frmHistorial()
        {
            InitializeComponent();
        }

        private bool cargando = true;

        private void frmHistorial_Load(object sender, EventArgs e)
        {
            DataTable dtPacientes = Paciente.cargarCombo();
            cmbPaciente.DataSource = dtPacientes;
            cmbPaciente.DisplayMember = "nombrePaciente";
            cmbPaciente.ValueMember = "idPaciente";
            cmbPaciente.SelectedIndex = -1;

            cmbPacienteVer.DataSource = dtPacientes.Copy();
            cmbPacienteVer.DisplayMember = "nombrePaciente";
            cmbPacienteVer.ValueMember = "idPaciente";

            cmbMedico.DataSource = Medico.cargarCombo();
            cmbMedico.DisplayMember = "nombreMedico";
            cmbMedico.ValueMember = "idMedico";
            cmbMedico.SelectedIndex = -1;

            // Si entró un médico, la consulta queda registrada a su nombre
            if (Sesion.IdMedico > 0)
            {
                cmbMedico.SelectedValue = Sesion.IdMedico;
                cmbMedico.Enabled = false;
            }

            cargando = false;
            cargarDatagridHistorial();
        }

        // Muestra todas las consultas del paciente elegido arriba
        private void cargarDatagridHistorial()
        {
            if (cargando || cmbPacienteVer.SelectedValue == null) return;
            dgvHistorial.DataSource = null;
            dgvHistorial.DataSource = Historial.cargarHistorial(Convert.ToInt32(cmbPacienteVer.SelectedValue));
            dgvHistorial.Columns["id_Paciente"].Visible = false;
        }

        private void cmbPacienteVer_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargarDatagridHistorial();
            txtDiagnosticoAct.Clear();
            txtTratamientoAct.Clear();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (cmbPaciente.SelectedIndex == -1 || cmbMedico.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione el paciente y el médico", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(txtDiagnostico.Text))
            {
                errorProvider1.SetError(txtDiagnostico, "Escriba el diagnóstico");
                MessageBox.Show("El diagnóstico es obligatorio", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Historial historial = new Historial();
            historial.IdPaciente = Convert.ToInt32(cmbPaciente.SelectedValue);
            historial.IdMedico = Convert.ToInt32(cmbMedico.SelectedValue);
            historial.Diagnostico = txtDiagnostico.Text.Trim();
            historial.Tratamiento = txtTratamiento.Text.Trim();

            if (historial.InsertarHistorial())
            {
                Bitacora.registrar("Registró consulta en el historial de " + cmbPaciente.Text);
                MessageBox.Show("Consulta registrada en el historial", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmbPacienteVer.SelectedValue = historial.IdPaciente;   // mostramos su historial
                cargarDatagridHistorial();
                txtDiagnostico.Clear();
                txtTratamiento.Clear();
            }
        }

        private void dgvHistorial_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvHistorial.Rows[e.RowIndex];
                txtDiagnosticoAct.Text = fila.Cells["Diagnostico"].Value.ToString();
                txtTratamientoAct.Text = fila.Cells["Tratamiento"].Value.ToString();
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (dgvHistorial.CurrentRow == null || string.IsNullOrWhiteSpace(txtDiagnosticoAct.Text))
            {
                MessageBox.Show("Seleccione una consulta y escriba el diagnóstico", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Historial historial = new Historial();
            historial.IdHistorial = Convert.ToInt32(dgvHistorial.CurrentRow.Cells["#"].Value);
            historial.Diagnostico = txtDiagnosticoAct.Text.Trim();
            historial.Tratamiento = txtTratamientoAct.Text.Trim();
            if (historial.ActualizarHistorial())
            {
                Bitacora.registrar("Actualizó el historial de " + cmbPacienteVer.Text);
                MessageBox.Show("Historial actualizado", "Actualizando datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cargarDatagridHistorial();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvHistorial.CurrentRow == null)
            {
                MessageBox.Show("Seleccione una consulta de la lista", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int id = Convert.ToInt32(dgvHistorial.CurrentRow.Cells["#"].Value);
            if (MessageBox.Show("¿Está seguro que desea eliminar esta consulta del historial?", "Confirmar eliminación",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (Historial.EliminarHistorial(id))
                {
                    Bitacora.registrar("Eliminó una consulta del historial de " + cmbPacienteVer.Text);
                    MessageBox.Show("Registro eliminado exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cargarDatagridHistorial();
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
