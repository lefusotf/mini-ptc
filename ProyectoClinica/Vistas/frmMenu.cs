using System;
using System.Windows.Forms;
using Modelos;

namespace Vistas
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            lblBienvenido.Text = "Bienvenido, " + Sesion.Usuario;
            lblRol.Text = "Rol: " + Sesion.Rol;

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
            new frmPacientes().ShowDialog();
        }

        private void btnMedicos_Click(object sender, EventArgs e)
        {
            new frmMedicos().ShowDialog();
        }

        private void btnEspecialidades_Click(object sender, EventArgs e)
        {
            new frmEspecialidades().ShowDialog();
        }

        private void btnCitas_Click(object sender, EventArgs e)
        {
            new frmCitas().ShowDialog();
        }

        private void btnHistorial_Click(object sender, EventArgs e)
        {
            new frmHistorial().ShowDialog();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            new frmUsuarios().ShowDialog();
        }

        private void btnPermisos_Click(object sender, EventArgs e)
        {
            new frmPermisos().ShowDialog();
        }

        private void btnBitacora_Click(object sender, EventArgs e)
        {
            new frmBitacora().ShowDialog();
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("¿Desea cerrar sesión?", "Cerrar sesión", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
                this.Close();
        }
    }
}
