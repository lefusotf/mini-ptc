using System;
using System.Windows.Forms;
using Modelos;

namespace Vistas
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
            try
            {
                cmbRol.DataSource = Usuario.ObtenerRoles();
                cmbRol.DisplayMember = "NombreRol";
                cmbRol.ValueMember = "IdRol";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los roles: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            MostrarUsuarios();
            Limpiar();
        }

        private void MostrarUsuarios()
        {
            try
            {
                dgvUsuarios.DataSource = Usuario.Mostrar(txtBuscar.Text.Trim());
                dgvUsuarios.Columns["IdUsuario"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // esNuevo = true cuando se agrega (la contraseña es obligatoria)
        private bool Validar(bool esNuevo)
        {
            errorProvider1.Clear();
            bool hayError = false;

            if (string.IsNullOrWhiteSpace(txtUsuario.Text) || txtUsuario.Text.Contains(" "))
            {
                errorProvider1.SetError(txtUsuario, "Ingrese un usuario sin espacios.");
                hayError = true;
            }
            if (string.IsNullOrWhiteSpace(txtNombreCompleto.Text))
            {
                errorProvider1.SetError(txtNombreCompleto, "Ingrese el nombre completo.");
                hayError = true;
            }
            if (esNuevo && txtClave.Text.Length < 8)
            {
                errorProvider1.SetError(txtClave, "La contraseña debe tener al menos 8 caracteres.");
                hayError = true;
            }
            if (!esNuevo && txtClave.Text.Length > 0 && txtClave.Text.Length < 8)
            {
                errorProvider1.SetError(txtClave, "La contraseña debe tener al menos 8 caracteres.");
                hayError = true;
            }
            if (cmbRol.SelectedIndex == -1)
            {
                errorProvider1.SetError(cmbRol, "Seleccione un rol.");
                hayError = true;
            }

            if (hayError)
                MessageBox.Show("Complete correctamente los campos marcados.", "Campos requeridos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return !hayError;
        }

        private Usuario LeerFormulario()
        {
            Usuario u = new Usuario();
            u.IdUsuario = idSeleccionado;
            u.NombreUsuario = txtUsuario.Text.Trim();
            u.NombreCompleto = txtNombreCompleto.Text.Trim();
            u.Clave = txtClave.Text;          // se encripta dentro de la clase Usuario
            u.IdRol = Convert.ToInt32(cmbRol.SelectedValue);
            u.Activo = chkActivo.Checked;
            return u;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (!Validar(true)) return;
            try
            {
                Usuario u = LeerFormulario();
                if (u.Agregar())
                {
                    Bitacora.Registrar("Creó el usuario " + u.NombreUsuario + " con rol " + cmbRol.Text);
                    MessageBox.Show("Usuario creado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MostrarUsuarios();
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
                MessageBox.Show("Seleccione un usuario de la tabla.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!Validar(false)) return;
            try
            {
                Usuario u = LeerFormulario();
                if (u.Modificar())
                {
                    Bitacora.Registrar("Modificó el usuario " + u.NombreUsuario);
                    MessageBox.Show("Usuario modificado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MostrarUsuarios();
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
                MessageBox.Show("Seleccione un usuario de la tabla.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (idSeleccionado == Sesion.IdUsuario)
            {
                MessageBox.Show("No puede eliminar el usuario con el que inició sesión.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (MessageBox.Show("¿Está seguro de eliminar este usuario?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;
            try
            {
                if (Usuario.Eliminar(idSeleccionado))
                {
                    Bitacora.Registrar("Eliminó el usuario " + txtUsuario.Text);
                    MessageBox.Show("Usuario eliminado.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MostrarUsuarios();
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
            txtUsuario.Clear();
            txtNombreCompleto.Clear();
            txtClave.Clear();
            if (cmbRol.Items.Count > 0) cmbRol.SelectedIndex = 0;
            chkActivo.Checked = true;
            errorProvider1.Clear();
            dgvUsuarios.ClearSelection();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            MostrarUsuarios();
        }

        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            DataGridViewRow fila = dgvUsuarios.Rows[e.RowIndex];
            idSeleccionado = Convert.ToInt32(fila.Cells["IdUsuario"].Value);
            txtUsuario.Text = fila.Cells["Usuario"].Value.ToString();
            txtNombreCompleto.Text = fila.Cells["Nombre completo"].Value.ToString();
            cmbRol.Text = fila.Cells["Rol"].Value.ToString();
            chkActivo.Checked = Convert.ToBoolean(fila.Cells["Activo"].Value);
            txtClave.Clear(); // la contraseña no se muestra; si se deja vacía no se cambia
        }
    }
}
