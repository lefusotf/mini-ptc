using Modelos.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Vista.Gestion
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
            txtNombre.KeyPress += soloLetras_KeyPress;
            cargarDatagridEspecialidades();
        }

        private void cargarDatagridEspecialidades()
        {
            dgvEspecialidades.DataSource = null;
            dgvEspecialidades.DataSource = Especialidad.cargarEspecialidades();
        }

        private bool validar()
        {
            errorProvider1.Clear();
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                errorProvider1.SetError(txtNombre, "Ingrese el nombre");
                MessageBox.Show("Ingrese el nombre de la especialidad", "Campos requeridos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!esSoloLetras(txtNombre.Text))
            {
                errorProvider1.SetError(txtNombre, "Solo se permiten letras");
                MessageBox.Show("El nombre de la especialidad solo puede tener letras", "Dato inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!validar()) return;
            Especialidad especialidad = new Especialidad();
            especialidad.NombreEspecialidad = txtNombre.Text.Trim();
            if (especialidad.InsertarEspecialidad())
            {
                Bitacora.registrar("Registró la especialidad " + especialidad.NombreEspecialidad);
                MessageBox.Show("Especialidad registrada", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cargarDatagridEspecialidades();
                limpiar();
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (idSeleccionado == 0)
            {
                MessageBox.Show("Seleccione una especialidad de la lista", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!validar()) return;
            Especialidad especialidad = new Especialidad();
            especialidad.IdEspecialidad = idSeleccionado;
            especialidad.NombreEspecialidad = txtNombre.Text.Trim();
            if (especialidad.ActualizarEspecialidad())
            {
                Bitacora.registrar("Actualizó la especialidad " + especialidad.NombreEspecialidad);
                MessageBox.Show("Especialidad actualizada", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cargarDatagridEspecialidades();
                limpiar();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (idSeleccionado == 0)
            {
                MessageBox.Show("Seleccione una especialidad de la lista", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult respuesta = MessageBox.Show($"¿Desea eliminar '{txtNombre.Text}'?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes && Especialidad.EliminarEspecialidad(idSeleccionado))
            {
                Bitacora.registrar("Eliminó la especialidad " + txtNombre.Text);
                MessageBox.Show("Especialidad eliminada", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cargarDatagridEspecialidades();
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
            errorProvider1.Clear();
            dgvEspecialidades.ClearSelection();
        }

        private void dgvEspecialidades_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            DataGridViewRow fila = dgvEspecialidades.Rows[e.RowIndex];
            idSeleccionado = Convert.ToInt32(fila.Cells["#"].Value);
            txtNombre.Text = fila.Cells["Especialidad"].Value.ToString();
        }

        private void soloLetras_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
                e.Handled = true;
        }

        private bool esSoloLetras(string texto)
        {
            foreach (char letra in texto)
            {
                if (!char.IsLetter(letra) && letra != ' ')
                    return false;
            }
            return true;
        }
    }
}
