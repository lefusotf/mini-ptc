using System;
using System.Windows.Forms;
using Modelos;

namespace Vistas
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
            try
            {
                cmbMedico.DataSource = Medico.ObtenerMedicos();
                cmbMedico.DisplayMember = "Nombre";
                cmbMedico.ValueMember = "IdMedico";

                cmbPaciente.DataSource = Paciente.ObtenerPacientes();
                cmbPaciente.DisplayMember = "Nombre";
                cmbPaciente.ValueMember = "IdPaciente";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las listas: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            cargando = false;
            MostrarHistorial();
            Limpiar();
        }

        // Muestra todas las consultas del paciente seleccionado
        private void MostrarHistorial()
        {
            if (cargando || cmbPaciente.SelectedValue == null) return;
            try
            {
                dgvHistorial.DataSource = Historial.MostrarPorPaciente(Convert.ToInt32(cmbPaciente.SelectedValue));
                dgvHistorial.Columns["IdHistorial"].Visible = false;
                dgvHistorial.Columns["IdMedico"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbPaciente_SelectedIndexChanged(object sender, EventArgs e)
        {
            MostrarHistorial();
            Limpiar();
        }

        private bool Validar()
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
                errorProvider1.SetError(cmbMedico, "Seleccione el médico.");
                hayError = true;
            }
            if (string.IsNullOrWhiteSpace(txtDiagnostico.Text))
            {
                errorProvider1.SetError(txtDiagnostico, "Escriba el diagnóstico.");
                hayError = true;
            }

            if (hayError)
                MessageBox.Show("Complete correctamente los campos marcados.", "Campos requeridos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return !hayError;
        }

        private Historial LeerFormulario()
        {
            Historial h = new Historial();
            h.IdHistorial = idSeleccionado;
            h.IdPaciente = Convert.ToInt32(cmbPaciente.SelectedValue);
            h.IdMedico = Convert.ToInt32(cmbMedico.SelectedValue);
            h.Diagnostico = txtDiagnostico.Text.Trim();
            h.Tratamiento = txtTratamiento.Text.Trim();
            return h;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (!Validar()) return;
            try
            {
                Historial h = LeerFormulario();
                if (h.Agregar())
                {
                    Bitacora.Registrar("Agregó una consulta al historial de " + cmbPaciente.Text);
                    MessageBox.Show("Consulta registrada en el historial.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MostrarHistorial();
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
                MessageBox.Show("Seleccione una consulta de la tabla.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!Validar()) return;
            try
            {
                Historial h = LeerFormulario();
                if (h.Modificar())
                {
                    Bitacora.Registrar("Modificó el historial de " + cmbPaciente.Text);
                    MessageBox.Show("Historial actualizado.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MostrarHistorial();
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
                MessageBox.Show("Seleccione una consulta de la tabla.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (MessageBox.Show("¿Está seguro de eliminar esta consulta del historial?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;
            try
            {
                if (Historial.Eliminar(idSeleccionado))
                {
                    Bitacora.Registrar("Eliminó una consulta del historial de " + cmbPaciente.Text);
                    MessageBox.Show("Consulta eliminada.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MostrarHistorial();
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
            txtDiagnostico.Clear();
            txtTratamiento.Clear();
            errorProvider1.Clear();
            dgvHistorial.ClearSelection();

            // Si el que entró es un médico, la consulta queda a su nombre
            if (Sesion.IdMedico > 0)
            {
                cmbMedico.SelectedValue = Sesion.IdMedico;
                cmbMedico.Enabled = false;
            }
        }

        private void dgvHistorial_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            DataGridViewRow fila = dgvHistorial.Rows[e.RowIndex];
            idSeleccionado = Convert.ToInt32(fila.Cells["IdHistorial"].Value);
            cmbMedico.SelectedValue = Convert.ToInt32(fila.Cells["IdMedico"].Value);
            txtDiagnostico.Text = fila.Cells["Diagnostico"].Value.ToString();
            txtTratamiento.Text = fila.Cells["Tratamiento"].Value.ToString();
        }
    }
}
