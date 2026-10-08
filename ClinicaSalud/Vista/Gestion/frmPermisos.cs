using Modelos.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Vista.Gestion
{
    public partial class frmPermisos : Form
    {
        private DataTable dtPermisos;
        private bool cargando = true;

        public frmPermisos()
        {
            InitializeComponent();
        }

        private void frmPermisos_Load(object sender, EventArgs e)
        {
            dtPermisos = Permiso.cargarPermisos();
            foreach (DataRow fila in dtPermisos.Rows)
                clbPermisos.Items.Add(fila["nombrePermiso"].ToString());

            cmbRol.DataSource = Usuario.cargarRoles();
            cmbRol.DisplayMember = "nombreRol";
            cmbRol.ValueMember = "idRol";

            cargando = false;
            marcarPermisos();
        }

        private void cmbRol_SelectedIndexChanged(object sender, EventArgs e)
        {
            marcarPermisos();
        }

        private void marcarPermisos()
        {
            if (cargando || cmbRol.SelectedValue == null) return;
            List<int> asignados = Permiso.cargarIdPermisosDeRol(Convert.ToInt32(cmbRol.SelectedValue));
            for (int i = 0; i < dtPermisos.Rows.Count; i++)
            {
                int idPermiso = Convert.ToInt32(dtPermisos.Rows[i]["idPermiso"]);
                clbPermisos.SetItemChecked(i, asignados.Contains(idPermiso));
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (clbPermisos.CheckedIndices.Count == 0)
            {
                MessageBox.Show("Marque al menos un permiso", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            List<int> seleccionados = new List<int>();
            foreach (int i in clbPermisos.CheckedIndices)
                seleccionados.Add(Convert.ToInt32(dtPermisos.Rows[i]["idPermiso"]));

            if (Permiso.GuardarPermisos(Convert.ToInt32(cmbRol.SelectedValue), seleccionados))
            {
                Bitacora.registrar("Cambió los permisos del rol " + cmbRol.Text);
                MessageBox.Show("Permisos guardados. Se aplican al volver a iniciar sesión.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
