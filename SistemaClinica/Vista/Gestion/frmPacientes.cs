using Modelos.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Vista.Gestion
{
    public partial class frmPacientes : Form
    {
        public frmPacientes()
        {
            InitializeComponent();
        }

        private void frmPacientes_Load(object sender, EventArgs e)
        {
            dtpFechaNacimiento.MaxDate = DateTime.Today;
            dtpFechaNacimientoAct.MaxDate = DateTime.Today;
            cargarDatagridPacientes();
        }

        private void cargarDatagridPacientes()
        {
            dgvPacientes.DataSource = null;
            dgvPacientes.DataSource = Paciente.cargarPacientes();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            // Validaciones
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                errorProvider1.SetError(txtNombre, "Ingrese el nombre");
                MessageBox.Show("El nombre es obligatorio", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cmbGenero.SelectedIndex == -1)
            {
                errorProvider1.SetError(cmbGenero, "Seleccione el género");
                MessageBox.Show("Seleccione el género", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!mskTelefono.MaskCompleted)
            {
                errorProvider1.SetError(mskTelefono, "Teléfono incompleto");
                MessageBox.Show("Ingrese un teléfono de 8 dígitos", "Dato inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Paciente paciente = new Paciente();
            paciente.NombrePaciente = txtNombre.Text.Trim();
            paciente.Dui = mskDui.MaskCompleted ? mskDui.Text : "";   // el DUI es opcional (niños)
            paciente.FechaNacimiento = dtpFechaNacimiento.Value.Date;
            paciente.Genero = cmbGenero.Text;
            paciente.Telefono = mskTelefono.Text;
            paciente.Direccion = txtDireccion.Text.Trim();

            if (paciente.InsertarPaciente())
            {
                Bitacora.registrar("Registró al paciente " + paciente.NombrePaciente);
                MessageBox.Show("Paciente registrado con éxito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cargarDatagridPacientes();
                limpiar();
            }
        }

        private void limpiar()
        {
            txtNombre.Clear();
            mskDui.Clear();
            dtpFechaNacimiento.Value = DateTime.Today;
            cmbGenero.SelectedIndex = -1;
            mskTelefono.Clear();
            txtDireccion.Clear();
            errorProvider1.Clear();
        }

        private void dgvPacientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Evitar click en los encabezados
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvPacientes.Rows[e.RowIndex];
                txtNombreAct.Text = fila.Cells["Paciente"].Value.ToString();
                mskDuiAct.Text = fila.Cells["DUI"].Value.ToString();
                dtpFechaNacimientoAct.Value = Convert.ToDateTime(fila.Cells["Fecha Nacimiento"].Value);
                cmbGeneroAct.Text = fila.Cells["Genero"].Value.ToString();
                mskTelefonoAct.Text = fila.Cells["Telefono"].Value.ToString();
                txtDireccionAct.Text = fila.Cells["Direccion"].Value.ToString();
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (dgvPacientes.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un paciente de la lista", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(txtNombreAct.Text) || !mskTelefonoAct.MaskCompleted)
            {
                MessageBox.Show("El nombre y el teléfono son obligatorios", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Paciente paciente = new Paciente();
            paciente.IdPaciente = Convert.ToInt32(dgvPacientes.CurrentRow.Cells["#"].Value);
            paciente.NombrePaciente = txtNombreAct.Text.Trim();
            paciente.Dui = mskDuiAct.MaskCompleted ? mskDuiAct.Text : "";
            paciente.FechaNacimiento = dtpFechaNacimientoAct.Value.Date;
            paciente.Genero = cmbGeneroAct.Text;
            paciente.Telefono = mskTelefonoAct.Text;
            paciente.Direccion = txtDireccionAct.Text.Trim();

            if (paciente.ActualizarPaciente())
            {
                Bitacora.registrar("Actualizó al paciente " + paciente.NombrePaciente);
                MessageBox.Show("Registro actualizado", "Actualizando datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cargarDatagridPacientes();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvPacientes.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un paciente de la lista", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int idPaciente = Convert.ToInt32(dgvPacientes.CurrentRow.Cells["#"].Value);
            string nombre = dgvPacientes.CurrentRow.Cells["Paciente"].Value.ToString();

            DialogResult respuesta = MessageBox.Show($"¿Está seguro que desea eliminar a '{nombre}'?", "Confirmar eliminación",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                if (Paciente.EliminarPaciente(idPaciente))
                {
                    Bitacora.registrar("Eliminó al paciente " + nombre);
                    MessageBox.Show("Registro eliminado exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cargarDatagridPacientes();
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
