using Modelos.Entidades;
using System;
using System.Windows.Forms;
using Vista.Dashboard;

namespace Vista.Login
{
    public partial class frmLogin : Form
    {
        private int intentos = 0;   // a los 3 intentos fallidos se cierra el programa

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

            // Validamos que no haya campos vacíos
            if (string.IsNullOrWhiteSpace(txtUsuario.Text))
            {
                errorProvider1.SetError(txtUsuario, "Por favor, ingrese el usuario.");
                hayError = true;
            }
            if (string.IsNullOrWhiteSpace(txtClave.Text))
            {
                errorProvider1.SetError(txtClave, "Por favor, ingrese la contraseña.");
                hayError = true;
            }
            if (hayError) return;

            if (Usuario.iniciarSesion(txtUsuario.Text.Trim(), txtClave.Text))
            {
                intentos = 0;
                Bitacora.registrar("Inició sesión");
                MessageBox.Show("Bienvenido " + Sesion.NombreUsuario + "\nRol: " + Sesion.Rol, "Acceso correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Escondemos el login y abrimos el menú principal
                this.Hide();
                frmDashboardPrincipal dashboard = new frmDashboardPrincipal();
                dashboard.ShowDialog();

                // Cuando se cierra el menú (cerrar sesión) volvemos al login
                Bitacora.registrar("Cerró sesión");
                Sesion.cerrarSesion();
                txtUsuario.Clear();
                txtClave.Clear();
                this.Show();
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
                MessageBox.Show("Usuario o contraseña incorrectos. Intentos restantes: " + (3 - intentos), "Acceso denegado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtClave.Clear();
                txtClave.Focus();
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
