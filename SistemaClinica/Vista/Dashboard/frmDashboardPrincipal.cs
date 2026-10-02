using Modelos.Entidades;
using System;
using System.Windows.Forms;
using Vista.Gestion;

namespace Vista.Dashboard
{
    public partial class frmDashboardPrincipal : Form
    {
        public frmDashboardPrincipal()
        {
            InitializeComponent();
        }

        #region "Mis Metodos"
        private Form activeForm = null;

        // Abre un formulario dentro del panel contenedor (igual que en el ejemplo del profe)
        private void abrirForm(Form formularioAbrir)
        {
            // Si el formulario ya está abierto no hacemos nada
            if (activeForm != null && activeForm.GetType() == formularioAbrir.GetType())
                return;

            // Cerramos y liberamos el formulario anterior
            if (activeForm != null)
            {
                activeForm.Close();
                pnlContenedor.Controls.Remove(activeForm);
                activeForm.Dispose();
            }

            activeForm = formularioAbrir;
            formularioAbrir.TopLevel = false;
            formularioAbrir.FormBorderStyle = FormBorderStyle.None;
            formularioAbrir.Dock = DockStyle.Fill;

            pnlContenedor.Controls.Add(formularioAbrir);
            formularioAbrir.BringToFront();
            formularioAbrir.Show();
        }
        #endregion

        private void frmDashboardPrincipal_Load(object sender, EventArgs e)
        {
            lblBienvenido.Text = "Bienvenido\n" + Sesion.NombreUsuario + "\n(" + Sesion.Rol + ")";

            // Solo se muestran los botones de las pantallas que el rol tiene permitidas
            btnPacientes.Visible = Sesion.TienePermiso("Pacientes");
            btnMedicos.Visible = Sesion.TienePermiso("Medicos");
            btnEspecialidades.Visible = Sesion.TienePermiso("Especialidades");
            btnCitas.Visible = Sesion.TienePermiso("Citas");
            btnHistorial.Visible = Sesion.TienePermiso("Historial");
            btnUsuarios.Visible = Sesion.TienePermiso("Usuarios");
            btnPermisos.Visible = Sesion.TienePermiso("Permisos");
            btnBitacora.Visible = Sesion.TienePermiso("Bitacora");
        }

        private void btnPacientes_Click(object sender, EventArgs e)
        {
            abrirForm(new frmPacientes());
        }

        private void btnMedicos_Click(object sender, EventArgs e)
        {
            abrirForm(new frmMedicos());
        }

        private void btnEspecialidades_Click(object sender, EventArgs e)
        {
            abrirForm(new frmEspecialidades());
        }

        private void btnCitas_Click(object sender, EventArgs e)
        {
            abrirForm(new frmCitas());
        }

        private void btnHistorial_Click(object sender, EventArgs e)
        {
            abrirForm(new frmHistorial());
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            abrirForm(new frmUsuarios());
        }

        private void btnPermisos_Click(object sender, EventArgs e)
        {
            abrirForm(new frmPermisos());
        }

        private void btnBitacora_Click(object sender, EventArgs e)
        {
            abrirForm(new frmBitacora());
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("¿Desea cerrar sesión?", "Cerrar sesión", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
                this.Close();
        }
    }
}
