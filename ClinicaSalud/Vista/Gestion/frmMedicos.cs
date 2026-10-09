using Modelos.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Vista.Gestion
{
    public partial class frmMedicos : Form
    {
        private int idSeleccionado = 0;

        public frmMedicos()
        {
            InitializeComponent();
        }

        private void frmMedicos_Load(object sender, EventArgs e)
        {
            txtNombre.KeyPress += soloLetras_KeyPress;
            cmbEspecialidad.DataSource = Especialidad.cargarCombo();
            cmbEspecialidad.DisplayMember = "nombreEspecialidad";
            cmbEspecialidad.ValueMember = "idEspecialidad";


            cargarDatagridMedicos();
            limpiar();
        }

        private void cargarComboUsuarios(int idMedico)
        {
            cmbUsuario.DataSource = Medico.cargarUsuariosMedicos(idMedico);
            cmbUsuario.DisplayMember = "nombreUsuario";
            cmbUsuario.ValueMember = "idUsuario";
        }

        private void cargarDatagridMedicos()
        {
            dgvMedicos.DataSource = null;
            dgvMedicos.DataSource = Medico.buscarMedicos(txtBuscar.Text.Trim());
        }

        private bool validar()
        {
            errorProvider1.Clear();
            bool valido = true;
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                errorProvider1.SetError(txtNombre, "Ingrese el nombre");
                valido = false;
            }
            else if (!esSoloLetras(txtNombre.Text))
            {
                errorProvider1.SetError(txtNombre, "Solo se permiten letras");
                valido = false;
            }
            if (!mskTelefono.MaskCompleted)
            {
                errorProvider1.SetError(mskTelefono, "Teléfono incompleto");
                valido = false;
            }
            if (txtCorreo.Text.Trim() != "" && !txtCorreo.Text.Contains("@"))
            {
                errorProvider1.SetError(txtCorreo, "Correo no válido");
                valido = false;
            }
            if (cmbEspecialidad.SelectedIndex == -1)
            {
                errorProvider1.SetError(cmbEspecialidad, "Seleccione la especialidad");
                valido = false;
            }
            if (!valido)
                MessageBox.Show("Complete los campos marcados", "Campos requeridos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return valido;
        }

        private Medico leerFormulario()
        {
            Medico medico = new Medico();
            medico.IdMedico = idSeleccionado;
            medico.NombreMedico = txtNombre.Text.Trim();
            medico.Telefono = mskTelefono.Text;
            medico.Correo = txtCorreo.Text.Trim();
            medico.IdEspecialidad = Convert.ToInt32(cmbEspecialidad.SelectedValue);
            medico.IdUsuario = Convert.ToInt32(cmbUsuario.SelectedValue);
            return medico;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!validar()) return;
            Medico medico = leerFormulario();
            if (medico.InsertarMedico())
            {
                Bitacora.registrar("Registró al médico " + medico.NombreMedico);
                MessageBox.Show("Médico registrado con éxito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cargarDatagridMedicos();
                limpiar();
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (idSeleccionado == 0)
            {
                MessageBox.Show("Seleccione un médico de la lista", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!validar()) return;
            Medico medico = leerFormulario();
            if (medico.ActualizarMedico())
            {
                Bitacora.registrar("Actualizó al médico " + medico.NombreMedico);
                MessageBox.Show("Médico actualizado", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cargarDatagridMedicos();
                limpiar();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (idSeleccionado == 0)
            {
                MessageBox.Show("Seleccione un médico de la lista", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult respuesta = MessageBox.Show($"¿Desea eliminar a '{txtNombre.Text}'?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes && Medico.EliminarMedico(idSeleccionado))
            {
                Bitacora.registrar("Eliminó al médico " + txtNombre.Text);
                MessageBox.Show("Médico eliminado", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cargarDatagridMedicos();
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
            txtNombre.Clear();
            mskTelefono.Clear();
            txtCorreo.Clear();
            cmbEspecialidad.SelectedIndex = -1;
            cargarComboUsuarios(0);
            cmbUsuario.SelectedIndex = 0;
            errorProvider1.Clear();
            dgvMedicos.ClearSelection();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            cargarDatagridMedicos();
        }

        private void dgvMedicos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            DataGridViewRow fila = dgvMedicos.Rows[e.RowIndex];
            idSeleccionado = Convert.ToInt32(fila.Cells["#"].Value);
            cargarComboUsuarios(idSeleccionado);
            txtNombre.Text = fila.Cells["Medico"].Value.ToString();
            mskTelefono.Text = fila.Cells["Telefono"].Value.ToString();
            txtCorreo.Text = fila.Cells["Correo"].Value.ToString();
            cmbEspecialidad.Text = fila.Cells["Especialidad"].Value.ToString();
            string usuario = fila.Cells["Usuario"].Value.ToString();
            cmbUsuario.Text = usuario == "" ? "(Sin usuario)" : usuario;
        }

        private void soloLetras_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
                e.Handled = true;
        }

        private bool esSoloLetras(string texto)
        {
            foreach (char letra in texto)
            {
                if (!char.IsLetter(letra) && letra != ' ')
                    return false;
            }
            return true;
        }
    }
}
