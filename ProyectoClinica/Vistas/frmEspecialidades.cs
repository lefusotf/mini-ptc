using System;
using System.Windows.Forms;
using Modelos;

namespace Vistas
{
    public partial class frmEspecialidades : Form
    {
        private int idSeleccionado = 0;

        public frmEspecialidades()
        {
            InitializeComponent();
        }

        private void frmEspecialidades_Load(object sender, EventArgs e)
        {
            MostrarEspecialidades();
        }

        private void MostrarEspecialidades()
        {
            try
            {
                dgvEspecialidades.DataSource = Especialidad.Mostrar();
                dgvEspecialidades.Columns["IdEspecialidad"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool Validar()
        {
            errorProvider1.Clear();
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                errorProvider1.SetError(txtNombre, "Ingrese el nombre de la especialidad.");
                MessageBox.Show("Ingrese el nombre de la especialidad.", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (!Validar()) return;
            try
            {
                Especialidad esp = new Especialidad();
                esp.NombreEspecialidad = txtNombre.Text.Trim();
                if (esp.Agregar())
                {
                    Bitacora.Registrar("Agregó la especialidad " + esp.NombreEspecialidad);
                    MessageBox.Show("Especialidad agregada.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MostrarEspecialidades();
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
                MessageBox.Show("Seleccione una especialidad de la tabla.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!Validar()) return;
            try
            {
                Especialidad esp = new Especialidad();
                esp.IdEspecialidad = idSeleccionado;
                esp.NombreEspecialidad = txtNombre.Text.Trim();
                if (esp.Modificar())
                {
                    Bitacora.Registrar("Modificó la especialidad " + esp.NombreEspecialidad);
                    MessageBox.Show("Especialidad modificada.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MostrarEspecialidades();
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
                MessageBox.Show("Seleccione una especialidad de la tabla.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (MessageBox.Show("¿Está seguro de eliminar esta especialidad?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;
            try
            {
                if (Especialidad.Eliminar(idSeleccionado))
                {
                    Bitacora.Registrar("Eliminó la especialidad " + txtNombre.Text);
                    MessageBox.Show("Especialidad eliminada.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MostrarEspecialidades();
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
            errorProvider1.Clear();
            dgvEspecialidades.ClearSelection();
        }

        private void dgvEspecialidades_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            DataGridViewRow fila = dgvEspecialidades.Rows[e.RowIndex];
            idSeleccionado = Convert.ToInt32(fila.Cells["IdEspecialidad"].Value);
            txtNombre.Text = fila.Cells["NombreEspecialidad"].Value.ToString();
        }
    }
}
