using System;
using System.Windows.Forms;
using Modelos;

namespace Vistas
{
    public partial class frmMedicos : Form
    {
        private int idSeleccionado = 0;

        public frmMedicos()
        {
            InitializeComponent();
        }

        private void frmMedicos_Load(object sender, EventArgs e)
        {
            CargarCombos();
            MostrarMedicos();
            Limpiar();
        }

        private void CargarCombos()
        {
            try
            {
                cmbEspecialidad.DataSource = Especialidad.Mostrar();
                cmbEspecialidad.DisplayMember = "NombreEspecialidad";
                cmbEspecialidad.ValueMember = "IdEspecialidad";

                cmbUsuario.DataSource = Medico.ObtenerUsuariosMedicos();
                cmbUsuario.DisplayMember = "Usuario";
                cmbUsuario.ValueMember = "IdUsuario";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las listas: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MostrarMedicos()
        {
            try
            {
                dgvMedicos.DataSource = Medico.Mostrar(txtBuscar.Text.Trim());
                dgvMedicos.Columns["IdMedico"].Visible = false;
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
                errorProvider1.SetError(txtNombre, "Ingrese el nombre del médico.");
                hayError = true;
            }
            if (!mskTelefono.MaskCompleted)
            {
                errorProvider1.SetError(mskTelefono, "Ingrese un teléfono de 8 dígitos.");
                hayError = true;
            }
            if (!string.IsNullOrWhiteSpace(txtCorreo.Text) && !txtCorreo.Text.Contains("@"))
            {
                errorProvider1.SetError(txtCorreo, "El correo no es válido.");
                hayError = true;
            }
            if (cmbEspecialidad.SelectedIndex == -1)
            {
                errorProvider1.SetError(cmbEspecialidad, "Seleccione una especialidad.");
                hayError = true;
            }

            if (hayError)
                MessageBox.Show("Complete correctamente los campos marcados.", "Campos requeridos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return !hayError;
        }

        private Medico LeerFormulario()
        {
            Medico m = new Medico();
            m.IdMedico = idSeleccionado;
            m.Nombre = txtNombre.Text.Trim();
            m.Telefono = mskTelefono.Text;
            m.Correo = txtCorreo.Text.Trim();
            m.IdEspecialidad = Convert.ToInt32(cmbEspecialidad.SelectedValue);
            m.IdUsuario = Convert.ToInt32(cmbUsuario.SelectedValue);
            return m;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (!Validar()) return;
            try
            {
                Medico m = LeerFormulario();
                if (m.Agregar())
                {
                    Bitacora.Registrar("Agregó al médico " + m.Nombre);
                    MessageBox.Show("Médico agregado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MostrarMedicos();
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
                MessageBox.Show("Seleccione un médico de la tabla.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!Validar()) return;
            try
            {
                Medico m = LeerFormulario();
                if (m.Modificar())
                {
                    Bitacora.Registrar("Modificó al médico " + m.Nombre);
                    MessageBox.Show("Médico modificado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MostrarMedicos();
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
                MessageBox.Show("Seleccione un médico de la tabla.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (MessageBox.Show("¿Está seguro de eliminar a este médico?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;
            try
            {
                if (Medico.Eliminar(idSeleccionado))
                {
                    Bitacora.Registrar("Eliminó al médico " + txtNombre.Text);
                    MessageBox.Show("Médico eliminado.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MostrarMedicos();
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
            mskTelefono.Clear();
            txtCorreo.Clear();
            if (cmbEspecialidad.Items.Count > 0) cmbEspecialidad.SelectedIndex = 0;
            if (cmbUsuario.Items.Count > 0) cmbUsuario.SelectedIndex = 0;
            errorProvider1.Clear();
            dgvMedicos.ClearSelection();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            MostrarMedicos();
        }

        private void dgvMedicos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            DataGridViewRow fila = dgvMedicos.Rows[e.RowIndex];
            idSeleccionado = Convert.ToInt32(fila.Cells["IdMedico"].Value);
            txtNombre.Text = fila.Cells["Nombre"].Value.ToString();
            mskTelefono.Text = fila.Cells["Telefono"].Value.ToString();
            txtCorreo.Text = fila.Cells["Correo"].Value.ToString();
            cmbEspecialidad.Text = fila.Cells["Especialidad"].Value.ToString();
            string usuario = fila.Cells["Usuario"].Value.ToString();
            cmbUsuario.Text = usuario == "" ? "(Sin usuario)" : usuario;
        }
    }
}
