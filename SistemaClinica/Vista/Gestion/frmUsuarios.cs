using Modelos.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Vista.Gestion
{
    public partial class frmUsuarios : Form
    {
        public frmUsuarios()
        {
            InitializeComponent();
        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            DataTable dtRoles = Usuario.cargarRoles();
            cmbRol.DataSource = dtRoles;
            cmbRol.DisplayMember = "nombreRol";
            cmbRol.ValueMember = "idRol";
            cmbRol.SelectedIndex = -1;

            cmbRolAct.DataSource = dtRoles.Copy();
            cmbRolAct.DisplayMember = "nombreRol";
            cmbRolAct.ValueMember = "idRol";
            cmbRolAct.SelectedIndex = -1;

            cargarDatagridUsuarios();
        }

        private void cargarDatagridUsuarios()
        {
            dgvUsuarios.DataSource = null;
            dgvUsuarios.DataSource = Usuario.cargarUsuarios();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (string.IsNullOrWhiteSpace(txtUsuario.Text) || string.IsNullOrWhiteSpace(txtNombreCompleto.Text))
            {
                MessageBox.Show("El usuario y el nombre completo son obligatorios", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtClave.Text.Length < 8)
            {
                errorProvider1.SetError(txtClave, "Mínimo 8 caracteres");
                MessageBox.Show("La contraseña debe tener al menos 8 caracteres", "Contraseña débil", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cmbRol.SelectedIndex == -1)
            {
                errorProvider1.SetError(cmbRol, "Seleccione un rol");
                MessageBox.Show("Seleccione un rol", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Usuario usuario = new Usuario();
            usuario.NombreUsuario = txtUsuario.Text.Trim();
            usuario.NombreCompleto = txtNombreCompleto.Text.Trim();
            usuario.Clave = txtClave.Text;          // se encripta dentro de la clase Usuario
            usuario.IdRol = Convert.ToInt32(cmbRol.SelectedValue);
            usuario.Activo = chkActivo.Checked;

            if (usuario.InsertarUsuario())
            {
                Bitacora.registrar("Creó el usuario " + usuario.NombreUsuario + " con rol " + cmbRol.Text);
                MessageBox.Show("Usuario registrado con éxito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cargarDatagridUsuarios();
                txtUsuario.Clear();
                txtNombreCompleto.Clear();
                txtClave.Clear();
                cmbRol.SelectedIndex = -1;
                chkActivo.Checked = true;
            }
        }

        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvUsuarios.Rows[e.RowIndex];
                txtUsuarioAct.Text = fila.Cells["Usuario"].Value.ToString();
                txtNombreCompletoAct.Text = fila.Cells["Nombre Completo"].Value.ToString();
                cmbRolAct.Text = fila.Cells["Rol"].Value.ToString();
                chkActivoAct.Checked = Convert.ToBoolean(fila.Cells["Activo"].Value);
                txtClaveAct.Clear();   // si se deja vacía, la contraseña no cambia
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un usuario de la lista", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtClaveAct.Text.Length > 0 && txtClaveAct.Text.Length < 8)
            {
                MessageBox.Show("La nueva contraseña debe tener al menos 8 caracteres (o déjela vacía para no cambiarla)", "Contraseña débil", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Usuario usuario = new Usuario();
            usuario.IdUsuario = Convert.ToInt32(dgvUsuarios.CurrentRow.Cells["#"].Value);
            usuario.NombreUsuario = txtUsuarioAct.Text.Trim();
            usuario.NombreCompleto = txtNombreCompletoAct.Text.Trim();
            usuario.Clave = txtClaveAct.Text;
            usuario.IdRol = Convert.ToInt32(cmbRolAct.SelectedValue);
            usuario.Activo = chkActivoAct.Checked;

            if (usuario.ActualizarUsuario())
            {
                Bitacora.registrar("Actualizó el usuario " + usuario.NombreUsuario);
                MessageBox.Show("Usuario actualizado", "Actualizando datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cargarDatagridUsuarios();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un usuario de la lista", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int idUsuario = Convert.ToInt32(dgvUsuarios.CurrentRow.Cells["#"].Value);
            string nombre = dgvUsuarios.CurrentRow.Cells["Usuario"].Value.ToString();
            if (idUsuario == Sesion.IdUsuario)
            {
                MessageBox.Show("No puede eliminar el usuario con el que inició sesión", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (MessageBox.Show($"¿Está seguro que desea eliminar el usuario '{nombre}'?", "Confirmar eliminación",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (Usuario.EliminarUsuario(idUsuario))
                {
                    Bitacora.registrar("Eliminó el usuario " + nombre);
                    MessageBox.Show("Usuario eliminado exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cargarDatagridUsuarios();
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
