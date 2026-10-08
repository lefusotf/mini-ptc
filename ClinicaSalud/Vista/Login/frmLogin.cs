using Modelos.Entidades;
using System;
using System.Windows.Forms;
using Vista.Dashboard;

namespace Vista.Login
{
    public partial class frmLogin : Form
    {
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
            if (string.IsNullOrWhiteSpace(txtUsuario.Text))
            {
                errorProvider1.SetError(txtUsuario, "Ingrese el usuario");
                hayError = true;
            }
            if (string.IsNullOrWhiteSpace(txtClave.Text))
            {
                errorProvider1.SetError(txtClave, "Ingrese la contraseña");
                hayError = true;
            }
            if (hayError) return;

            // La contraseña se verifica con BCrypt dentro de Usuario.iniciarSesion
            if (Usuario.iniciarSesion(txtUsuario.Text.Trim(), txtClave.Text))
            {
                Bitacora.registrar("Inició sesión");
                this.Hide();
                frmDashboard dashboard = new frmDashboard();
                dashboard.ShowDialog();

                Bitacora.registrar("Cerró sesión");
                Sesion.cerrarSesion();
                txtUsuario.Clear();
                txtClave.Clear();
                this.Show();
                txtUsuario.Focus();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos", "Acceso denegado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtClave.Clear();
                txtClave.Focus();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
