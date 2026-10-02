using Modelos.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Vista.Gestion
{
    public partial class frmMedicos : Form
    {
        public frmMedicos()
        {
            InitializeComponent();
        }

        private void frmMedicos_Load(object sender, EventArgs e)
        {
            cargarCombos();
            cargarDatagridMedicos();
        }

        private void cargarDatagridMedicos()
        {
            dgvMedicos.DataSource = null;
            dgvMedicos.DataSource = Medico.cargarMedicos();
        }

        private void cargarCombos()
        {
            // Especialidades
            DataTable dtEspecialidades = Especialidad.cargarCombo();
            cmbEspecialidad.DataSource = dtEspecialidades;
            cmbEspecialidad.DisplayMember = "nombreEspecialidad";   // lo que se muestra
            cmbEspecialidad.ValueMember = "idEspecialidad";         // lo que va a la base de datos
            cmbEspecialidad.SelectedIndex = -1;

            cmbEspecialidadAct.DataSource = dtEspecialidades.Copy();
            cmbEspecialidadAct.DisplayMember = "nombreEspecialidad";
            cmbEspecialidadAct.ValueMember = "idEspecialidad";
            cmbEspecialidadAct.SelectedIndex = -1;

            // Usuarios con rol Medico
            DataTable dtUsuarios = Medico.cargarUsuariosMedicos();
            cmbUsuario.DataSource = dtUsuarios;
            cmbUsuario.DisplayMember = "nombreUsuario";
            cmbUsuario.ValueMember = "idUsuario";

            cmbUsuarioAct.DataSource = dtUsuarios.Copy();
            cmbUsuarioAct.DisplayMember = "nombreUsuario";
            cmbUsuarioAct.ValueMember = "idUsuario";
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
            if (!mskTelefono.MaskCompleted)
            {
                errorProvider1.SetError(mskTelefono, "Teléfono incompleto");
                MessageBox.Show("Ingrese un teléfono de 8 dígitos", "Dato inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cmbEspecialidad.SelectedIndex == -1)
            {
                errorProvider1.SetError(cmbEspecialidad, "Seleccione la especialidad");
                MessageBox.Show("Seleccione la especialidad", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Medico medico = new Medico();
            medico.NombreMedico = txtNombre.Text.Trim();
            medico.Telefono = mskTelefono.Text;
            medico.Correo = txtCorreo.Text.Trim();
            medico.IdEspecialidad = Convert.ToInt32(cmbEspecialidad.SelectedValue);
            medico.IdUsuario = Convert.ToInt32(cmbUsuario.SelectedValue);

            if (medico.InsertarMedico())
            {
                Bitacora.registrar("Registró al médico " + medico.NombreMedico);
                MessageBox.Show("Médico registrado con éxito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cargarDatagridMedicos();
                txtNombre.Clear();
                mskTelefono.Clear();
                txtCorreo.Clear();
                cmbEspecialidad.SelectedIndex = -1;
                cmbUsuario.SelectedIndex = 0;
            }
        }

        private void dgvMedicos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvMedicos.Rows[e.RowIndex];
                txtNombreAct.Text = fila.Cells["Medico"].Value.ToString();
                mskTelefonoAct.Text = fila.Cells["Telefono"].Value.ToString();
                txtCorreoAct.Text = fila.Cells["Correo"].Value.ToString();
                cmbEspecialidadAct.Text = fila.Cells["Especialidad"].Value.ToString();
                string usuario = fila.Cells["Usuario"].Value.ToString();
                cmbUsuarioAct.Text = usuario == "" ? "(Sin usuario)" : usuario;
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (dgvMedicos.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un médico de la lista", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(txtNombreAct.Text) || cmbEspecialidadAct.SelectedIndex == -1)
            {
                MessageBox.Show("El nombre y la especialidad son obligatorios", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Medico medico = new Medico();
            medico.IdMedico = Convert.ToInt32(dgvMedicos.CurrentRow.Cells["#"].Value);
            medico.NombreMedico = txtNombreAct.Text.Trim();
            medico.Telefono = mskTelefonoAct.Text;
            medico.Correo = txtCorreoAct.Text.Trim();
            medico.IdEspecialidad = Convert.ToInt32(cmbEspecialidadAct.SelectedValue);
            medico.IdUsuario = Convert.ToInt32(cmbUsuarioAct.SelectedValue);

            if (medico.ActualizarMedico())
            {
                Bitacora.registrar("Actualizó al médico " + medico.NombreMedico);
                MessageBox.Show("Registro actualizado", "Actualizando datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cargarDatagridMedicos();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvMedicos.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un médico de la lista", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int idMedico = Convert.ToInt32(dgvMedicos.CurrentRow.Cells["#"].Value);
            string nombre = dgvMedicos.CurrentRow.Cells["Medico"].Value.ToString();

            DialogResult respuesta = MessageBox.Show($"¿Está seguro que desea eliminar a '{nombre}'?", "Confirmar eliminación",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                if (Medico.EliminarMedico(idMedico))
                {
                    Bitacora.registrar("Eliminó al médico " + nombre);
                    MessageBox.Show("Registro eliminado exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cargarDatagridMedicos();
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
