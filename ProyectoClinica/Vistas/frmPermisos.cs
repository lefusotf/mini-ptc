using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using Modelos;

namespace Vistas
{
    public partial class frmPermisos : Form
    {
        private DataTable permisos;
        private bool cargando = true;

        public frmPermisos()
        {
            InitializeComponent();
        }

        private void frmPermisos_Load(object sender, EventArgs e)
        {
            try
            {
                // Lista de todas las pantallas (permisos)
                permisos = Permiso.ObtenerPermisos();
                foreach (DataRow fila in permisos.Rows)
                    clbPermisos.Items.Add(fila["NombrePermiso"].ToString());

                cmbRol.DataSource = Usuario.ObtenerRoles();
                cmbRol.DisplayMember = "NombreRol";
                cmbRol.ValueMember = "IdRol";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            cargando = false;
            MarcarPermisosDelRol();
        }

        private void cmbRol_SelectedIndexChanged(object sender, EventArgs e)
        {
            MarcarPermisosDelRol();
        }

        // Marca con check los permisos que ya tiene el rol seleccionado
        private void MarcarPermisosDelRol()
        {
            if (cargando || cmbRol.SelectedValue == null) return;
            try
            {
                List<int> asignados = Permiso.IdPermisosDeRol(Convert.ToInt32(cmbRol.SelectedValue));
                for (int i = 0; i < permisos.Rows.Count; i++)
                {
                    int idPermiso = Convert.ToInt32(permisos.Rows[i]["IdPermiso"]);
                    clbPermisos.SetItemChecked(i, asignados.Contains(idPermiso));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (cmbRol.SelectedValue == null) return;
            if (clbPermisos.CheckedIndices.Count == 0)
            {
                MessageBox.Show("Marque al menos un permiso.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                List<int> seleccionados = new List<int>();
                foreach (int i in clbPermisos.CheckedIndices)
                    seleccionados.Add(Convert.ToInt32(permisos.Rows[i]["IdPermiso"]));

                Permiso.GuardarPermisos(Convert.ToInt32(cmbRol.SelectedValue), seleccionados);
                Bitacora.Registrar("Cambió los permisos del rol " + cmbRol.Text);
                MessageBox.Show("Permisos guardados.\nLos cambios se aplican la próxima vez que el usuario inicie sesión.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
