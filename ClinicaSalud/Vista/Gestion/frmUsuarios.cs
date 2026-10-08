using Modelos.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Vista.Gestion
{
    public partial class frmUsuarios : Form
    {
        private int idSeleccionado = 0;

        public frmUsuarios()
        {
            InitializeComponent();
        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            cmbRol.DataSource = Usuario.cargarRoles();
            cmbRol.DisplayMember = "nombreRol";
            cmbRol.ValueMember = "idRol";
            cargarDatagridUsuarios();
            limpiar();
        }

        private void cargarDatagridUsuarios()
        {
            dgvUsuarios.DataSource = null;
            dgvUsuarios.DataSource = Usuario.buscarUsuarios(txtBuscar.Text.Trim());
        }

        private bool validar(bool esNuevo)
        {
            errorProvider1.Clear();
            bool valido = true;
            if (string.IsNullOrWhiteSpace(txtUsuario.Text) || txtUsuario.Text.Contains(" "))
            {
                errorProvider1.SetError(txtUsuario, "Usuario sin espacios");
                valido = false;
            }
            if (string.IsNullOrWhiteSpace(txtNombreCompleto.Text))
            {
                errorProvider1.SetError(txtNombreCompleto, "Ingrese el nombre");
                valido = false;
            }
            if ((esNuevo || txtClave.Text.Length > 0) && txtClave.Text.Length < 8)
            {
                errorProvider1.SetError(txtClave, "Mínimo 8 caracteres");
                valido = false;
            }
            if (cmbRol.SelectedIndex == -1)
            {
                errorProvider1.SetError(cmbRol, "Seleccione el rol");
                valido = false;
            }
            if (!valido)
                MessageBox.Show("Complete los campos marcados", "Campos requeridos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return valido;
        }

        private Usuario leerFormulario()
        {
            Usuario usuario = new Usuario();
            usuario.IdUsuario = idSeleccionado;
            usuario.NombreUsuario = txtUsuario.Text.Trim();
            usuario.NombreCompleto = txtNombreCompleto.Text.Trim();
            usuario.Clave = txtClave.Text;
            usuario.IdRol = Convert.ToInt32(cmbRol.SelectedValue);
            usuario.Activo = chkActivo.Checked;
            return usuario;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!validar(true)) return;
            Usuario usuario = leerFormulario();
            if (usuario.InsertarUsuario())
            {
                Bitacora.registrar("Creó el usuario " + usuario.NombreUsuario);
                MessageBox.Show("Usuario registrado con éxito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cargarDatagridUsuarios();
                limpiar();
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (idSeleccionado == 0)
            {
                MessageBox.Show("Seleccione un usuario de la lista", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!validar(false)) return;
            Usuario usuario = leerFormulario();
            if (usuario.ActualizarUsuario())
            {
                Bitacora.registrar("Actualizó el usuario " + usuario.NombreUsuario);
                MessageBox.Show("Usuario actualizado", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cargarDatagridUsuarios();
                limpiar();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (idSeleccionado == 0)
            {
                MessageBox.Show("Seleccione un usuario de la lista", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (idSeleccionado == Sesion.IdUsuario)
            {
                MessageBox.Show("No puede eliminar el usuario con el que inició sesión", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult respuesta = MessageBox.Show($"¿Desea eliminar el usuario '{txtUsuario.Text}'?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes && Usuario.EliminarUsuario(idSeleccionado))
            {
                Bitacora.registrar("Eliminó el usuario " + txtUsuario.Text);
                MessageBox.Show("Usuario eliminado", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cargarDatagridUsuarios();
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
            txtUsuario.Clear();
            txtNombreCompleto.Clear();
            txtClave.Clear();
            cmbRol.SelectedIndex = -1;
            chkActivo.Checked = true;
            errorProvider1.Clear();
            dgvUsuarios.ClearSelection();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            cargarDatagridUsuarios();
        }

        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            DataGridViewRow fila = dgvUsuarios.Rows[e.RowIndex];
            idSeleccionado = Convert.ToInt32(fila.Cells["#"].Value);
            txtUsuario.Text = fila.Cells["Usuario"].Value.ToString();
            txtNombreCompleto.Text = fila.Cells["Nombre Completo"].Value.ToString();
            cmbRol.Text = fila.Cells["Rol"].Value.ToString();
            chkActivo.Checked = Convert.ToBoolean(fila.Cells["Activo"].Value);
            txtClave.Clear();
        }
    }
}
