namespace Vista.Dashboard
{
    partial class frmInicio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblSaludo = new System.Windows.Forms.Label();
            this.lblResumen = new System.Windows.Forms.Label();
            this.pnlPacientes = new System.Windows.Forms.Panel();
            this.pnlColorPacientes = new System.Windows.Forms.Panel();
            this.lblPacientesValor = new System.Windows.Forms.Label();
            this.lblPacientesTexto = new System.Windows.Forms.Label();
            this.pnlMedicos = new System.Windows.Forms.Panel();
            this.pnlColorMedicos = new System.Windows.Forms.Panel();
            this.lblMedicosValor = new System.Windows.Forms.Label();
            this.lblMedicosTexto = new System.Windows.Forms.Label();
            this.pnlCitasHoy = new System.Windows.Forms.Panel();
            this.pnlColorCitasHoy = new System.Windows.Forms.Panel();
            this.lblCitasHoyValor = new System.Windows.Forms.Label();
            this.lblCitasHoyTexto = new System.Windows.Forms.Label();
            this.pnlPendientes = new System.Windows.Forms.Panel();
            this.pnlColorPendientes = new System.Windows.Forms.Panel();
            this.lblPendientesValor = new System.Windows.Forms.Label();
            this.lblPendientesTexto = new System.Windows.Forms.Label();
            this.pnlAgendaHoy = new System.Windows.Forms.Panel();
            this.lblAgendaHoy = new System.Windows.Forms.Label();
            this.dgvCitasHoy = new System.Windows.Forms.DataGridView();
            this.pnlPacientes.SuspendLayout();
            this.pnlColorPacientes.SuspendLayout();
            this.pnlMedicos.SuspendLayout();
            this.pnlColorMedicos.SuspendLayout();
            this.pnlCitasHoy.SuspendLayout();
            this.pnlColorCitasHoy.SuspendLayout();
            this.pnlPendientes.SuspendLayout();
            this.pnlColorPendientes.SuspendLayout();
            this.pnlAgendaHoy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCitasHoy)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSaludo
            // 
            this.lblSaludo.AutoSize = true;
            this.lblSaludo.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblSaludo.ForeColor = System.Drawing.Color.FromArgb(((15)), ((23)), ((42)));
            this.lblSaludo.Location = new System.Drawing.Point(18, 18);
            this.lblSaludo.Name = "lblSaludo";
            this.lblSaludo.TabIndex = 0;
            this.lblSaludo.Text = "Hola";
            // 
            // lblResumen
            // 
            this.lblResumen.AutoSize = true;
            this.lblResumen.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.lblResumen.ForeColor = System.Drawing.Color.FromArgb(((100)), ((116)), ((139)));
            this.lblResumen.Location = new System.Drawing.Point(21, 60);
            this.lblResumen.Name = "lblResumen";
            this.lblResumen.TabIndex = 1;
            this.lblResumen.Text = "Este es el resumen de la clínica para hoy.";
            // 
            // pnlPacientes
            // 
            this.pnlPacientes.Controls.Add(this.pnlColorPacientes);
            this.pnlPacientes.Controls.Add(this.lblPacientesValor);
            this.pnlPacientes.Controls.Add(this.lblPacientesTexto);
            this.pnlPacientes.BackColor = System.Drawing.Color.White;
            this.pnlPacientes.Location = new System.Drawing.Point(20, 100);
            this.pnlPacientes.Name = "pnlPacientes";
            this.pnlPacientes.Size = new System.Drawing.Size(245, 110);
            this.pnlPacientes.TabIndex = 2;
            // 
            // pnlColorPacientes
            // 
            this.pnlColorPacientes.BackColor = System.Drawing.Color.FromArgb(((37)), ((99)), ((235)));
            this.pnlColorPacientes.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlColorPacientes.Name = "pnlColorPacientes";
            this.pnlColorPacientes.Size = new System.Drawing.Size(6, 110);
            this.pnlColorPacientes.TabIndex = 3;
            // 
            // lblPacientesValor
            // 
            this.lblPacientesValor.AutoSize = true;
            this.lblPacientesValor.Font = new System.Drawing.Font("Segoe UI", 26F, System.Drawing.FontStyle.Bold);
            this.lblPacientesValor.ForeColor = System.Drawing.Color.FromArgb(((15)), ((23)), ((42)));
            this.lblPacientesValor.Location = new System.Drawing.Point(24, 14);
            this.lblPacientesValor.Name = "lblPacientesValor";
            this.lblPacientesValor.TabIndex = 4;
            this.lblPacientesValor.Text = "0";
            // 
            // lblPacientesTexto
            // 
            this.lblPacientesTexto.AutoSize = true;
            this.lblPacientesTexto.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblPacientesTexto.ForeColor = System.Drawing.Color.FromArgb(((100)), ((116)), ((139)));
            this.lblPacientesTexto.Location = new System.Drawing.Point(27, 70);
            this.lblPacientesTexto.Name = "lblPacientesTexto";
            this.lblPacientesTexto.TabIndex = 5;
            this.lblPacientesTexto.Text = "Pacientes registrados";
            // 
            // pnlMedicos
            // 
            this.pnlMedicos.Controls.Add(this.pnlColorMedicos);
            this.pnlMedicos.Controls.Add(this.lblMedicosValor);
            this.pnlMedicos.Controls.Add(this.lblMedicosTexto);
            this.pnlMedicos.BackColor = System.Drawing.Color.White;
            this.pnlMedicos.Location = new System.Drawing.Point(282, 100);
            this.pnlMedicos.Name = "pnlMedicos";
            this.pnlMedicos.Size = new System.Drawing.Size(245, 110);
            this.pnlMedicos.TabIndex = 6;
            // 
            // pnlColorMedicos
            // 
            this.pnlColorMedicos.BackColor = System.Drawing.Color.FromArgb(((16)), ((185)), ((129)));
            this.pnlColorMedicos.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlColorMedicos.Name = "pnlColorMedicos";
            this.pnlColorMedicos.Size = new System.Drawing.Size(6, 110);
            this.pnlColorMedicos.TabIndex = 7;
            // 
            // lblMedicosValor
            // 
            this.lblMedicosValor.AutoSize = true;
            this.lblMedicosValor.Font = new System.Drawing.Font("Segoe UI", 26F, System.Drawing.FontStyle.Bold);
            this.lblMedicosValor.ForeColor = System.Drawing.Color.FromArgb(((15)), ((23)), ((42)));
            this.lblMedicosValor.Location = new System.Drawing.Point(24, 14);
            this.lblMedicosValor.Name = "lblMedicosValor";
            this.lblMedicosValor.TabIndex = 8;
            this.lblMedicosValor.Text = "0";
            // 
            // lblMedicosTexto
            // 
            this.lblMedicosTexto.AutoSize = true;
            this.lblMedicosTexto.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblMedicosTexto.ForeColor = System.Drawing.Color.FromArgb(((100)), ((116)), ((139)));
            this.lblMedicosTexto.Location = new System.Drawing.Point(27, 70);
            this.lblMedicosTexto.Name = "lblMedicosTexto";
            this.lblMedicosTexto.TabIndex = 9;
            this.lblMedicosTexto.Text = "Médicos";
            // 
            // pnlCitasHoy
            // 
            this.pnlCitasHoy.Controls.Add(this.pnlColorCitasHoy);
            this.pnlCitasHoy.Controls.Add(this.lblCitasHoyValor);
            this.pnlCitasHoy.Controls.Add(this.lblCitasHoyTexto);
            this.pnlCitasHoy.BackColor = System.Drawing.Color.White;
            this.pnlCitasHoy.Location = new System.Drawing.Point(544, 100);
            this.pnlCitasHoy.Name = "pnlCitasHoy";
            this.pnlCitasHoy.Size = new System.Drawing.Size(245, 110);
            this.pnlCitasHoy.TabIndex = 10;
            // 
            // pnlColorCitasHoy
            // 
            this.pnlColorCitasHoy.BackColor = System.Drawing.Color.FromArgb(((6)), ((182)), ((212)));
            this.pnlColorCitasHoy.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlColorCitasHoy.Name = "pnlColorCitasHoy";
            this.pnlColorCitasHoy.Size = new System.Drawing.Size(6, 110);
            this.pnlColorCitasHoy.TabIndex = 11;
            // 
            // lblCitasHoyValor
            // 
            this.lblCitasHoyValor.AutoSize = true;
            this.lblCitasHoyValor.Font = new System.Drawing.Font("Segoe UI", 26F, System.Drawing.FontStyle.Bold);
            this.lblCitasHoyValor.ForeColor = System.Drawing.Color.FromArgb(((15)), ((23)), ((42)));
            this.lblCitasHoyValor.Location = new System.Drawing.Point(24, 14);
            this.lblCitasHoyValor.Name = "lblCitasHoyValor";
            this.lblCitasHoyValor.TabIndex = 12;
            this.lblCitasHoyValor.Text = "0";
            // 
            // lblCitasHoyTexto
            // 
            this.lblCitasHoyTexto.AutoSize = true;
            this.lblCitasHoyTexto.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblCitasHoyTexto.ForeColor = System.Drawing.Color.FromArgb(((100)), ((116)), ((139)));
            this.lblCitasHoyTexto.Location = new System.Drawing.Point(27, 70);
            this.lblCitasHoyTexto.Name = "lblCitasHoyTexto";
            this.lblCitasHoyTexto.TabIndex = 13;
            this.lblCitasHoyTexto.Text = "Citas para hoy";
            // 
            // pnlPendientes
            // 
            this.pnlPendientes.Controls.Add(this.pnlColorPendientes);
            this.pnlPendientes.Controls.Add(this.lblPendientesValor);
            this.pnlPendientes.Controls.Add(this.lblPendientesTexto);
            this.pnlPendientes.BackColor = System.Drawing.Color.White;
            this.pnlPendientes.Location = new System.Drawing.Point(806, 100);
            this.pnlPendientes.Name = "pnlPendientes";
            this.pnlPendientes.Size = new System.Drawing.Size(245, 110);
            this.pnlPendientes.TabIndex = 14;
            // 
            // pnlColorPendientes
            // 
            this.pnlColorPendientes.BackColor = System.Drawing.Color.FromArgb(((245)), ((158)), ((11)));
            this.pnlColorPendientes.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlColorPendientes.Name = "pnlColorPendientes";
            this.pnlColorPendientes.Size = new System.Drawing.Size(6, 110);
            this.pnlColorPendientes.TabIndex = 15;
            // 
            // lblPendientesValor
            // 
            this.lblPendientesValor.AutoSize = true;
            this.lblPendientesValor.Font = new System.Drawing.Font("Segoe UI", 26F, System.Drawing.FontStyle.Bold);
            this.lblPendientesValor.ForeColor = System.Drawing.Color.FromArgb(((15)), ((23)), ((42)));
            this.lblPendientesValor.Location = new System.Drawing.Point(24, 14);
            this.lblPendientesValor.Name = "lblPendientesValor";
            this.lblPendientesValor.TabIndex = 16;
            this.lblPendientesValor.Text = "0";
            // 
            // lblPendientesTexto
            // 
            this.lblPendientesTexto.AutoSize = true;
            this.lblPendientesTexto.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblPendientesTexto.ForeColor = System.Drawing.Color.FromArgb(((100)), ((116)), ((139)));
            this.lblPendientesTexto.Location = new System.Drawing.Point(27, 70);
            this.lblPendientesTexto.Name = "lblPendientesTexto";
            this.lblPendientesTexto.TabIndex = 17;
            this.lblPendientesTexto.Text = "Citas pendientes";
            // 
            // pnlAgendaHoy
            // 
            this.pnlAgendaHoy.Controls.Add(this.lblAgendaHoy);
            this.pnlAgendaHoy.Controls.Add(this.dgvCitasHoy);
            this.pnlAgendaHoy.BackColor = System.Drawing.Color.White;
            this.pnlAgendaHoy.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlAgendaHoy.Location = new System.Drawing.Point(20, 230);
            this.pnlAgendaHoy.Name = "pnlAgendaHoy";
            this.pnlAgendaHoy.Size = new System.Drawing.Size(1060, 400);
            this.pnlAgendaHoy.TabIndex = 18;
            // 
            // lblAgendaHoy
            // 
            this.lblAgendaHoy.AutoSize = true;
            this.lblAgendaHoy.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblAgendaHoy.ForeColor = System.Drawing.Color.FromArgb(((15)), ((23)), ((42)));
            this.lblAgendaHoy.Location = new System.Drawing.Point(18, 16);
            this.lblAgendaHoy.Name = "lblAgendaHoy";
            this.lblAgendaHoy.TabIndex = 19;
            this.lblAgendaHoy.Text = "Citas de hoy";
            // 
            // dgvCitasHoy
            // 
            this.dgvCitasHoy.AllowUserToAddRows = false;
            this.dgvCitasHoy.AllowUserToDeleteRows = false;
            this.dgvCitasHoy.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((248)), ((250)), ((252)));
            this.dgvCitasHoy.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCitasHoy.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCitasHoy.BackgroundColor = System.Drawing.Color.White;
            this.dgvCitasHoy.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCitasHoy.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvCitasHoy.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((15)), ((23)), ((42)));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((15)), ((23)), ((42)));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCitasHoy.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCitasHoy.ColumnHeadersHeight = 42;
            this.dgvCitasHoy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((30)), ((41)), ((59)));
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((37)), ((99)), ((235)));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCitasHoy.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCitasHoy.EnableHeadersVisualStyles = false;
            this.dgvCitasHoy.GridColor = System.Drawing.Color.FromArgb(((226)), ((232)), ((240)));
            this.dgvCitasHoy.MultiSelect = false;
            this.dgvCitasHoy.ReadOnly = true;
            this.dgvCitasHoy.RowHeadersVisible = false;
            this.dgvCitasHoy.RowTemplate.Height = 34;
            this.dgvCitasHoy.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCitasHoy.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCitasHoy.Location = new System.Drawing.Point(20, 55);
            this.dgvCitasHoy.Name = "dgvCitasHoy";
            this.dgvCitasHoy.Size = new System.Drawing.Size(1020, 325);
            this.dgvCitasHoy.TabIndex = 20;
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((241)), ((245)), ((249)));
            this.ClientSize = new System.Drawing.Size(1100, 650);
            this.Controls.Add(this.lblSaludo);
            this.Controls.Add(this.lblResumen);
            this.Controls.Add(this.pnlPacientes);
            this.Controls.Add(this.pnlMedicos);
            this.Controls.Add(this.pnlCitasHoy);
            this.Controls.Add(this.pnlPendientes);
            this.Controls.Add(this.pnlAgendaHoy);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ForeColor = System.Drawing.Color.FromArgb(((30)), ((41)), ((59)));
            this.Name = "frmInicio";
            this.Text = "Inicio";
            this.Load += new System.EventHandler(this.frmInicio_Load);
            this.pnlAgendaHoy.ResumeLayout(false);
            this.pnlColorPendientes.ResumeLayout(false);
            this.pnlPendientes.ResumeLayout(false);
            this.pnlColorCitasHoy.ResumeLayout(false);
            this.pnlCitasHoy.ResumeLayout(false);
            this.pnlColorMedicos.ResumeLayout(false);
            this.pnlMedicos.ResumeLayout(false);
            this.pnlColorPacientes.ResumeLayout(false);
            this.pnlPacientes.ResumeLayout(false);
            this.pnlPacientes.PerformLayout();
            this.pnlColorPacientes.PerformLayout();
            this.pnlMedicos.PerformLayout();
            this.pnlColorMedicos.PerformLayout();
            this.pnlCitasHoy.PerformLayout();
            this.pnlColorCitasHoy.PerformLayout();
            this.pnlPendientes.PerformLayout();
            this.pnlColorPendientes.PerformLayout();
            this.pnlAgendaHoy.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCitasHoy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSaludo;
        private System.Windows.Forms.Label lblResumen;
        private System.Windows.Forms.Panel pnlPacientes;
        private System.Windows.Forms.Panel pnlColorPacientes;
        private System.Windows.Forms.Label lblPacientesValor;
        private System.Windows.Forms.Label lblPacientesTexto;
        private System.Windows.Forms.Panel pnlMedicos;
        private System.Windows.Forms.Panel pnlColorMedicos;
        private System.Windows.Forms.Label lblMedicosValor;
        private System.Windows.Forms.Label lblMedicosTexto;
        private System.Windows.Forms.Panel pnlCitasHoy;
        private System.Windows.Forms.Panel pnlColorCitasHoy;
        private System.Windows.Forms.Label lblCitasHoyValor;
        private System.Windows.Forms.Label lblCitasHoyTexto;
        private System.Windows.Forms.Panel pnlPendientes;
        private System.Windows.Forms.Panel pnlColorPendientes;
        private System.Windows.Forms.Label lblPendientesValor;
        private System.Windows.Forms.Label lblPendientesTexto;
        private System.Windows.Forms.Panel pnlAgendaHoy;
        private System.Windows.Forms.Label lblAgendaHoy;
        private System.Windows.Forms.DataGridView dgvCitasHoy;
    }
}
