using Modelos.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Vista.Gestion
{
    public partial class frmPacientes : Form
    {
        private int idSeleccionado = 0;

        public frmPacientes()
        {
            InitializeComponent();
        }

        private void frmPacientes_Load(object sender, EventArgs e)
        {
            dtpFechaNacimiento.MaxDate = DateTime.Today;
            cargarDatagridPacientes();
            limpiar();
        }

        private void cargarDatagridPacientes()
        {
            dgvPacientes.DataSource = null;
            dgvPacientes.DataSource = Paciente.buscarPacientes(txtBuscar.Text.Trim());
        }

        private bool validar()
        {
            errorProvider1.Clear();
            bool valido = true;
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                errorProvider1.SetError(txtNombre, "Ingrese el nombre");
                valido = false;
            }
            if (cmbGenero.SelectedIndex == -1)
            {
                errorProvider1.SetError(cmbGenero, "Seleccione el género");
                valido = false;
            }
            if (!mskTelefono.MaskCompleted)
            {
                errorProvider1.SetError(mskTelefono, "Teléfono incompleto");
                valido = false;
            }
            if (!valido)
                MessageBox.Show("Complete los campos marcados", "Campos requeridos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return valido;
        }

        private Paciente leerFormulario()
        {
            Paciente paciente = new Paciente();
            paciente.IdPaciente = idSeleccionado;
            paciente.NombrePaciente = txtNombre.Text.Trim();
            paciente.Dui = mskDui.MaskCompleted ? mskDui.Text : "";
            paciente.FechaNacimiento = dtpFechaNacimiento.Value.Date;
            paciente.Genero = cmbGenero.Text;
            paciente.Telefono = mskTelefono.Text;
            paciente.Direccion = txtDireccion.Text.Trim();
            return paciente;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!validar()) return;
            Paciente paciente = leerFormulario();
            if (paciente.InsertarPaciente())
            {
                Bitacora.registrar("Registró al paciente " + paciente.NombrePaciente);
                MessageBox.Show("Paciente registrado con éxito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cargarDatagridPacientes();
                limpiar();
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (idSeleccionado == 0)
            {
                MessageBox.Show("Seleccione un paciente de la lista", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!validar()) return;
            Paciente paciente = leerFormulario();
            if (paciente.ActualizarPaciente())
            {
                Bitacora.registrar("Actualizó al paciente " + paciente.NombrePaciente);
                MessageBox.Show("Paciente actualizado", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cargarDatagridPacientes();
                limpiar();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (idSeleccionado == 0)
            {
                MessageBox.Show("Seleccione un paciente de la lista", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult respuesta = MessageBox.Show($"¿Desea eliminar a '{txtNombre.Text}'?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes && Paciente.EliminarPaciente(idSeleccionado))
            {
                Bitacora.registrar("Eliminó al paciente " + txtNombre.Text);
                MessageBox.Show("Paciente eliminado", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cargarDatagridPacientes();
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
            txtNombre.Clear();
            mskDui.Clear();
            dtpFechaNacimiento.Value = DateTime.Today;
            cmbGenero.SelectedIndex = -1;
            mskTelefono.Clear();
            txtDireccion.Clear();
            errorProvider1.Clear();
            dgvPacientes.ClearSelection();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            cargarDatagridPacientes();
        }

        private void dgvPacientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            DataGridViewRow fila = dgvPacientes.Rows[e.RowIndex];
            idSeleccionado = Convert.ToInt32(fila.Cells["#"].Value);
            txtNombre.Text = fila.Cells["Paciente"].Value.ToString();
            mskDui.Text = fila.Cells["DUI"].Value.ToString();
            dtpFechaNacimiento.Value = Convert.ToDateTime(fila.Cells["Fecha Nacimiento"].Value);
            cmbGenero.Text = fila.Cells["Genero"].Value.ToString();
            mskTelefono.Text = fila.Cells["Telefono"].Value.ToString();
            txtDireccion.Text = fila.Cells["Direccion"].Value.ToString();
        }
    }
}
