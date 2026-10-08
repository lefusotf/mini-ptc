using Modelos.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Vista.Gestion
{
    public partial class frmHistorial : Form
    {
        private int idSeleccionado = 0;
        private bool cargando = true;

        public frmHistorial()
        {
            InitializeComponent();
        }

        private void frmHistorial_Load(object sender, EventArgs e)
        {
            cmbMedico.DataSource = Medico.cargarCombo();
            cmbMedico.DisplayMember = "nombreMedico";
            cmbMedico.ValueMember = "idMedico";

            cmbPaciente.DataSource = Paciente.cargarCombo();
            cmbPaciente.DisplayMember = "nombrePaciente";
            cmbPaciente.ValueMember = "idPaciente";

            if (Sesion.IdMedico > 0)
            {
                cmbMedico.SelectedValue = Sesion.IdMedico;
                cmbMedico.Enabled = false;
            }

            cargando = false;
            cmbPaciente.SelectedIndexChanged += cmbPaciente_SelectedIndexChanged;
            cargarDatagridHistorial();
        }

        private void cmbPaciente_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargarDatagridHistorial();
            limpiar();
        }

        private void cargarDatagridHistorial()
        {
            if (cargando || cmbPaciente.SelectedValue == null) return;
            dgvHistorial.DataSource = null;
            dgvHistorial.DataSource = Historial.cargarHistorial(Convert.ToInt32(cmbPaciente.SelectedValue));
            dgvHistorial.Columns["id_Paciente"].Visible = false;
        }

        private bool validar()
        {
            errorProvider1.Clear();
            bool valido = true;
            if (cmbPaciente.SelectedIndex == -1)
            {
                errorProvider1.SetError(cmbPaciente, "Seleccione el paciente");
                valido = false;
            }
            if (cmbMedico.SelectedIndex == -1)
            {
                errorProvider1.SetError(cmbMedico, "Seleccione el médico");
                valido = false;
            }
            if (string.IsNullOrWhiteSpace(txtDiagnostico.Text))
            {
                errorProvider1.SetError(txtDiagnostico, "Escriba el diagnóstico");
                valido = false;
            }
            if (!valido)
                MessageBox.Show("Complete los campos marcados", "Campos requeridos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return valido;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!validar()) return;
            Historial historial = new Historial();
            historial.IdPaciente = Convert.ToInt32(cmbPaciente.SelectedValue);
            historial.IdMedico = Convert.ToInt32(cmbMedico.SelectedValue);
            historial.Diagnostico = txtDiagnostico.Text.Trim();
            historial.Tratamiento = txtTratamiento.Text.Trim();
            if (historial.InsertarHistorial())
            {
                Bitacora.registrar("Registró consulta para " + cmbPaciente.Text);
                MessageBox.Show("Consulta registrada en el historial", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cargarDatagridHistorial();
                limpiar();
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (idSeleccionado == 0)
            {
                MessageBox.Show("Seleccione una consulta de la lista", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!validar()) return;
            Historial historial = new Historial();
            historial.IdHistorial = idSeleccionado;
            historial.Diagnostico = txtDiagnostico.Text.Trim();
            historial.Tratamiento = txtTratamiento.Text.Trim();
            if (historial.ActualizarHistorial())
            {
                Bitacora.registrar("Actualizó el historial de " + cmbPaciente.Text);
                MessageBox.Show("Historial actualizado", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cargarDatagridHistorial();
                limpiar();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (idSeleccionado == 0)
            {
                MessageBox.Show("Seleccione una consulta de la lista", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult respuesta = MessageBox.Show("¿Desea eliminar esta consulta?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes && Historial.EliminarHistorial(idSeleccionado))
            {
                Bitacora.registrar("Eliminó una consulta de " + cmbPaciente.Text);
                MessageBox.Show("Consulta eliminada", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cargarDatagridHistorial();
                limpiar();
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void limpiar()
        {
            idSeleccionado = 0;
            txtDiagnostico.Clear();
            txtTratamiento.Clear();
            errorProvider1.Clear();
            dgvHistorial.ClearSelection();
        }

        private void dgvHistorial_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            DataGridViewRow fila = dgvHistorial.Rows[e.RowIndex];
            idSeleccionado = Convert.ToInt32(fila.Cells["#"].Value);
            txtDiagnostico.Text = fila.Cells["Diagnostico"].Value.ToString();
            txtTratamiento.Text = fila.Cells["Tratamiento"].Value.ToString();
        }
    }
}
