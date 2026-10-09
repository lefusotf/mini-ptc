using Modelos.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Vista.Gestion
{
    public partial class frmBitacora : Form
    {
        public frmBitacora()
        {
            InitializeComponent();
        }

        private void frmBitacora_Load(object sender, EventArgs e)
        {
            dgvBitacora.DataSource = Bitacora.cargarBitacora();
        }
    }
}
