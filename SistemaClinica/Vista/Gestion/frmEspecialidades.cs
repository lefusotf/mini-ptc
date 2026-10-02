using Modelos.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Vista.Gestion
{
    public partial class frmEspecialidades : Form
    {
        public frmEspecialidades()
        {
            InitializeComponent();
        }

        private void frmEspecialidades_Load(object sender, EventArgs e)
        {
            cargarDatagridEspecialidades();
        }

        private void cargarDatagridEspecialidades()
        {
            dgvEspecialidades.DataSource = null;
            dgvEspecialidades.DataSource = Especialidad.cargarEspecialidades();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                errorProvider1.SetError(txtNombre, "Ingrese el nombre");
                MessageBox.Show("El nombre es obligatorio", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Especialidad especialidad = new Especialidad();
            especialidad.NombreEspecialidad = txtNombre.Text.Trim();
            if (especialidad.InsertarEspecialidad())
            {
                Bitacora.registrar("Registró la especialidad " + especialidad.NombreEspecialidad);
                MessageBox.Show("Especialidad registrada con éxito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cargarDatagridEspecialidades();
                txtNombre.Clear();
            }
        }

        private void dgvEspecialidades_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtNombreAct.Text = dgvEspecialidades.Rows[e.RowIndex].Cells["Especialidad"].Value.ToString();
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (dgvEspecialidades.CurrentRow == null || string.IsNullOrWhiteSpace(txtNombreAct.Text))
            {
                MessageBox.Show("Seleccione una especialidad y escriba el nombre", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Especialidad especialidad = new Especialidad();
            especialidad.IdEspecialidad = Convert.ToInt32(dgvEspecialidades.CurrentRow.Cells["#"].Value);
            especialidad.NombreEspecialidad = txtNombreAct.Text.Trim();
            if (especialidad.ActualizarEspecialidad())
            {
                Bitacora.registrar("Actualizó la especialidad " + especialidad.NombreEspecialidad);
                MessageBox.Show("Registro actualizado", "Actualizando datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cargarDatagridEspecialidades();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvEspecialidades.CurrentRow == null)
            {
                MessageBox.Show("Seleccione una especialidad de la lista", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int id = Convert.ToInt32(dgvEspecialidades.CurrentRow.Cells["#"].Value);
            string nombre = dgvEspecialidades.CurrentRow.Cells["Especialidad"].Value.ToString();
            if (MessageBox.Show($"¿Está seguro que desea eliminar '{nombre}'?", "Confirmar eliminación",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (Especialidad.EliminarEspecialidad(id))
                {
                    Bitacora.registrar("Eliminó la especialidad " + nombre);
                    MessageBox.Show("Registro eliminado exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cargarDatagridEspecialidades();
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
