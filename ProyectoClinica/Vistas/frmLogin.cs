using System;
using System.Windows.Forms;
using Modelos;

namespace Vistas
{
    public partial class frmLogin : Form
    {
        private int intentos = 0; // a los 3 intentos fallidos se cierra el programa

        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            txtUsuario.Focus();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            bool hayError = false;

            // Validaciones
            if (string.IsNullOrWhiteSpace(txtUsuario.Text))
            {
                errorProvider1.SetError(txtUsuario, "Ingrese su usuario.");
                hayError = true;
            }
            if (string.IsNullOrWhiteSpace(txtClave.Text))
            {
                errorProvider1.SetError(txtClave, "Ingrese su contraseña.");
                hayError = true;
            }
            if (hayError)
            {
                MessageBox.Show("Complete los campos marcados.", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                if (Usuario.IniciarSesion(txtUsuario.Text.Trim(), txtClave.Text))
                {
                    intentos = 0;
                    Bitacora.Registrar("Inició sesión");
                    MessageBox.Show("Bienvenido " + Sesion.Usuario + "\nRol: " + Sesion.Rol, "Acceso correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Se esconde el login y se abre el menú
                    this.Hide();
                    frmMenu menu = new frmMenu();
                    menu.ShowDialog();

                    // Cuando se cierra el menú (cerrar sesión) se vuelve a mostrar el login
                    Bitacora.Registrar("Cerró sesión");
                    Sesion.Cerrar();
                    txtUsuario.Clear();
                    txtClave.Clear();
                    this.Show();
                    txtUsuario.Focus();
                }
                else
                {
                    intentos++;
                    if (intentos >= 3)
                    {
                        MessageBox.Show("Ha fallado 3 veces. El programa se cerrará.", "Acceso denegado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Application.Exit();
                        return;
                    }
                    MessageBox.Show("Usuario o contraseña incorrectos.\nIntentos restantes: " + (3 - intentos), "Acceso denegado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtClave.Clear();
                    txtClave.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void chkMostrar_CheckedChanged(object sender, EventArgs e)
        {
            txtClave.UseSystemPasswordChar = !chkMostrar.Checked;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
