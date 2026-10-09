using Modelos.Entidades;
using System;
using System.Drawing;
using System.Windows.Forms;
using Vista.Gestion;

namespace Vista.Dashboard
{
    public partial class frmDashboard : Form
    {
        private Form activeForm = null;
        private Button botonActivo = null;

        public frmDashboard()
        {
            InitializeComponent();
        }

        private void frmDashboard_Load(object sender, EventArgs e)
        {
            lblNombreUsuario.Text = Sesion.NombreUsuario;
            lblRolUsuario.Text = Sesion.Rol;
            lblFecha.Text = DateTime.Now.ToString("dddd, dd 'de' MMMM 'de' yyyy");

            btnPacientes.Visible = Sesion.TienePermiso("Pacientes");
            btnMedicos.Visible = Sesion.TienePermiso("Medicos");
            btnEspecialidades.Visible = Sesion.TienePermiso("Especialidades");
            btnCitas.Visible = Sesion.TienePermiso("Citas");
            btnHistorial.Visible = Sesion.TienePermiso("Historial");
            btnUsuarios.Visible = Sesion.TienePermiso("Usuarios");
            btnPermisos.Visible = Sesion.TienePermiso("Permisos");
            btnBitacora.Visible = Sesion.TienePermiso("Bitacora");

            abrirForm(new frmInicio(), "Inicio", btnInicio);
        }

        private void abrirForm(Form formularioAbrir, string titulo, Button boton)
        {
            if (activeForm != null && activeForm.GetType() == formularioAbrir.GetType())
                return;

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

            lblTituloModulo.Text = titulo;
            marcarBoton(boton);
        }

        private void marcarBoton(Button boton)
        {
            if (botonActivo != null)
            {
                botonActivo.BackColor = Color.FromArgb(15, 23, 42);
                botonActivo.ForeColor = Color.FromArgb(203, 213, 225);
            }
            botonActivo = boton;
            botonActivo.BackColor = Color.FromArgb(37, 99, 235);
            botonActivo.ForeColor = Color.White;
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            abrirForm(new frmInicio(), "Inicio", btnInicio);
        }

        private void btnPacientes_Click(object sender, EventArgs e)
        {
            abrirForm(new frmPacientes(), "Pacientes", btnPacientes);
        }

        private void btnMedicos_Click(object sender, EventArgs e)
        {
            abrirForm(new frmMedicos(), "Médicos", btnMedicos);
        }

        private void btnEspecialidades_Click(object sender, EventArgs e)
        {
            abrirForm(new frmEspecialidades(), "Especialidades", btnEspecialidades);
        }

        private void btnCitas_Click(object sender, EventArgs e)
        {
            abrirForm(new frmCitas(), "Citas", btnCitas);
        }

        private void btnHistorial_Click(object sender, EventArgs e)
        {
            abrirForm(new frmHistorial(), "Historial clínico", btnHistorial);
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            abrirForm(new frmUsuarios(), "Usuarios", btnUsuarios);
        }

        private void btnPermisos_Click(object sender, EventArgs e)
        {
            abrirForm(new frmPermisos(), "Roles y permisos", btnPermisos);
        }

        private void btnBitacora_Click(object sender, EventArgs e)
        {
            abrirForm(new frmBitacora(), "Bitácora", btnBitacora);
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea cerrar sesión?", "Cerrar sesión", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }
    }
}
