using System;
using System.Windows.Forms;
using Modelos;

namespace Vistas
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
            MostrarPacientes();
            Limpiar();
        }

        private void MostrarPacientes()
        {
            try
            {
                dgvPacientes.DataSource = Paciente.Mostrar(txtBuscar.Text.Trim());
                dgvPacientes.Columns["IdPaciente"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool Validar()
        {
            errorProvider1.Clear();
            bool hayError = false;

            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                errorProvider1.SetError(txtNombre, "Ingrese el nombre del paciente.");
                hayError = true;
            }
            // El DUI es opcional (los niños no tienen), pero si se escribe debe estar completo
            if (!DuiVacio() && !mskDui.MaskCompleted)
            {
                errorProvider1.SetError(mskDui, "El DUI debe tener 9 dígitos.");
                hayError = true;
            }
            if (cmbGenero.SelectedIndex == -1)
            {
                errorProvider1.SetError(cmbGenero, "Seleccione el género.");
                hayError = true;
            }
            if (!mskTelefono.MaskCompleted)
            {
                errorProvider1.SetError(mskTelefono, "Ingrese un teléfono de 8 dígitos.");
                hayError = true;
            }

            if (hayError)
                MessageBox.Show("Complete correctamente los campos marcados.", "Campos requeridos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return !hayError;
        }

        private bool DuiVacio()
        {
            return mskDui.Text.Replace("-", "").Trim() == "";
        }

        private Paciente LeerFormulario()
        {
            Paciente p = new Paciente();
            p.IdPaciente = idSeleccionado;
            p.Nombre = txtNombre.Text.Trim();
            p.Dui = DuiVacio() ? "" : mskDui.Text;
            p.FechaNacimiento = dtpFechaNacimiento.Value.Date;
            p.Genero = cmbGenero.Text;
            p.Telefono = mskTelefono.Text;
            p.Direccion = txtDireccion.Text.Trim();
            return p;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (!Validar()) return;
            try
            {
                Paciente p = LeerFormulario();
                if (p.Agregar())
                {
                    Bitacora.Registrar("Agregó al paciente " + p.Nombre);
                    MessageBox.Show("Paciente agregado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MostrarPacientes();
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
                MessageBox.Show("Seleccione un paciente de la tabla.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!Validar()) return;
            try
            {
                Paciente p = LeerFormulario();
                if (p.Modificar())
                {
                    Bitacora.Registrar("Modificó al paciente " + p.Nombre);
                    MessageBox.Show("Paciente modificado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MostrarPacientes();
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
                MessageBox.Show("Seleccione un paciente de la tabla.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (MessageBox.Show("¿Está seguro de eliminar a este paciente?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;
            try
            {
                if (Paciente.Eliminar(idSeleccionado))
                {
                    Bitacora.Registrar("Eliminó al paciente " + txtNombre.Text);
                    MessageBox.Show("Paciente eliminado.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MostrarPacientes();
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
            MostrarPacientes();
        }

        private void dgvPacientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            DataGridViewRow fila = dgvPacientes.Rows[e.RowIndex];
            idSeleccionado = Convert.ToInt32(fila.Cells["IdPaciente"].Value);
            txtNombre.Text = fila.Cells["Nombre"].Value.ToString();
            mskDui.Text = fila.Cells["DUI"].Value.ToString();
            dtpFechaNacimiento.Value = Convert.ToDateTime(fila.Cells["FechaNacimiento"].Value);
            cmbGenero.Text = fila.Cells["Genero"].Value.ToString();
            mskTelefono.Text = fila.Cells["Telefono"].Value.ToString();
            txtDireccion.Text = fila.Cells["Direccion"].Value.ToString();
        }
    }
}
