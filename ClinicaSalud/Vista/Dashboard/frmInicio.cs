using Modelos.Entidades;
using System;
using System.Windows.Forms;

namespace Vista.Dashboard
{
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }

        private void frmInicio_Load(object sender, EventArgs e)
        {
            int idMedico = Sesion.Rol == "Medico" ? Sesion.IdMedico : 0;

            lblSaludo.Text = "Hola, " + Sesion.NombreUsuario;
            lblPacientesValor.Text = Paciente.contarPacientes().ToString();
            lblMedicosValor.Text = Medico.contarMedicos().ToString();
            lblCitasHoyValor.Text = Cita.contarCitas(idMedico, true, false).ToString();
            lblPendientesValor.Text = Cita.contarCitas(idMedico, false, true).ToString();

            dgvCitasHoy.DataSource = Cita.cargarCitasHoy(idMedico);
            dgvCitasHoy.Columns["id_Medico"].Visible = false;
        }
    }
}
