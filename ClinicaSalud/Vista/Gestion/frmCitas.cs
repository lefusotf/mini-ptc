using Modelos.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Vista.Gestion
{
    public partial class frmCitas : Form
    {
        private int idSeleccionado = 0;
        private bool esMedico = false;

        public frmCitas()
        {
            InitializeComponent();
        }

        private void frmCitas_Load(object sender, EventArgs e)
        {
            esMedico = Sesion.Rol == "Medico";

            cmbPaciente.DataSource = Paciente.cargarCombo();
            cmbPaciente.DisplayMember = "nombrePaciente";
            cmbPaciente.ValueMember = "idPaciente";

            cmbMedico.DataSource = Medico.cargarCombo();
            cmbMedico.DisplayMember = "nombreMedico";
            cmbMedico.ValueMember = "idMedico";

            // El médico solo ve sus citas y solo puede cambiar el estado
            if (esMedico)
            {
                btnGuardar.Visible = false;
                btnEliminar.Visible = false;
                cmbPaciente.Enabled = false;
                cmbMedico.Enabled = false;
                dtpFecha.Enabled = false;
                cmbHora.Enabled = false;
                txtMotivo.Enabled = false;
            }

            cargarDatagridCitas();
            limpiar();
        }

        private void cargarDatagridCitas()
        {
            int idMedico = esMedico ? Sesion.IdMedico : 0;
            dgvCitas.DataSource = null;
            dgvCitas.DataSource = Cita.buscarCitas(txtBuscar.Text.Trim(), idMedico);
            dgvCitas.Columns["id_Medico"].Visible = false;
        }

        private bool validar(bool esNueva)
        {
            errorProvider1.Clear();
            bool valido = true;
            if (cmbPaciente.SelectedIndex == -1)
            {
                errorProvider1.SetError(cmbPaciente, "Seleccione el paciente");
                valido = false;
            }
            if (cmbMedico.SelectedIndex == -1)
            {
                errorProvider1.SetError(cmbMedico, "Seleccione el médico");
                valido = false;
            }
            if (cmbHora.SelectedIndex == -1)
            {
                errorProvider1.SetError(cmbHora, "Seleccione la hora");
                valido = false;
            }
            if (string.IsNullOrWhiteSpace(txtMotivo.Text))
            {
                errorProvider1.SetError(txtMotivo, "Escriba el motivo");
                valido = false;
            }
            if (esNueva && dtpFecha.Value.Date < DateTime.Today)
            {
                errorProvider1.SetError(dtpFecha, "La fecha ya pasó");
                valido = false;
            }
            if (!valido)
                MessageBox.Show("Complete los campos marcados", "Campos requeridos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return valido;
        }

        private Cita leerFormulario()
        {
            Cita cita = new Cita();
            cita.IdCita = idSeleccionado;
            cita.IdPaciente = Convert.ToInt32(cmbPaciente.SelectedValue);
            cita.IdMedico = Convert.ToInt32(cmbMedico.SelectedValue);
            cita.Fecha = dtpFecha.Value.Date;
            cita.Hora = cmbHora.Text;
            cita.Motivo = txtMotivo.Text.Trim();
            cita.Estado = cmbEstado.Text;
            return cita;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!validar(true)) return;
            Cita cita = leerFormulario();
            if (cita.horarioOcupado())
            {
                MessageBox.Show("El médico ya tiene una cita en esa fecha y hora", "Horario ocupado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cita.InsertarCita())
            {
                Bitacora.registrar("Agendó una cita para " + cmbPaciente.Text);
                MessageBox.Show("Cita agendada con éxito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cargarDatagridCitas();
                limpiar();
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (idSeleccionado == 0)
            {
                MessageBox.Show("Seleccione una cita de la lista", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!validar(false)) return;
            Cita cita = leerFormulario();
            if (cita.Estado != "Cancelada" && cita.horarioOcupado())
            {
                MessageBox.Show("El médico ya tiene una cita en esa fecha y hora", "Horario ocupado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cita.ActualizarCita())
            {
                Bitacora.registrar("Actualizó la cita #" + cita.IdCita + " (" + cita.Estado + ")");
                MessageBox.Show("Cita actualizada", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cargarDatagridCitas();
                limpiar();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (idSeleccionado == 0)
            {
                MessageBox.Show("Seleccione una cita de la lista", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult respuesta = MessageBox.Show("¿Desea eliminar esta cita?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes && Cita.EliminarCita(idSeleccionado))
            {
                Bitacora.registrar("Eliminó la cita #" + idSeleccionado);
                MessageBox.Show("Cita eliminada", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cargarDatagridCitas();
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
            if (!esMedico)
            {
                cmbPaciente.SelectedIndex = -1;
                cmbMedico.SelectedIndex = -1;
                cmbHora.SelectedIndex = -1;
                txtMotivo.Clear();
                dtpFecha.Value = DateTime.Today;
            }
            cmbEstado.SelectedIndex = 0;
            errorProvider1.Clear();
            dgvCitas.ClearSelection();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            cargarDatagridCitas();
        }

        private void dgvCitas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            Cita cita = Cita.buscarCita(Convert.ToInt32(dgvCitas.Rows[e.RowIndex].Cells["#"].Value));
            if (cita == null) return;
            idSeleccionado = cita.IdCita;
            cmbPaciente.SelectedValue = cita.IdPaciente;
            cmbMedico.SelectedValue = cita.IdMedico;
            dtpFecha.Value = cita.Fecha;
            cmbHora.Text = cita.Hora;
            txtMotivo.Text = cita.Motivo;
            cmbEstado.Text = cita.Estado;
        }
    }
}
