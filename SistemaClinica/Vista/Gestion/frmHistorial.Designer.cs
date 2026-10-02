namespace Vista.Gestion
{
    partial class frmHistorial
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
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpRegistrar = new System.Windows.Forms.TabPage();
            this.lblTituloRegistrar = new System.Windows.Forms.Label();
            this.lblPaciente = new System.Windows.Forms.Label();
            this.cmbPaciente = new System.Windows.Forms.ComboBox();
            this.lblMedico = new System.Windows.Forms.Label();
            this.cmbMedico = new System.Windows.Forms.ComboBox();
            this.lblDiagnostico = new System.Windows.Forms.Label();
            this.txtDiagnostico = new System.Windows.Forms.TextBox();
            this.lblTratamiento = new System.Windows.Forms.Label();
            this.txtTratamiento = new System.Windows.Forms.TextBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.tpVer = new System.Windows.Forms.TabPage();
            this.lblPacienteVer = new System.Windows.Forms.Label();
            this.cmbPacienteVer = new System.Windows.Forms.ComboBox();
            this.lblDiagnosticoAct = new System.Windows.Forms.Label();
            this.txtDiagnosticoAct = new System.Windows.Forms.TextBox();
            this.lblTratamientoAct = new System.Windows.Forms.Label();
            this.txtTratamientoAct = new System.Windows.Forms.TextBox();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.dgvHistorial = new System.Windows.Forms.DataGridView();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabControl1.SuspendLayout();
            this.tpRegistrar.SuspendLayout();
            this.tpVer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpRegistrar);
            this.tabControl1.Controls.Add(this.tpVer);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.tabControl1.ItemSize = new System.Drawing.Size(250, 35);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Size = new System.Drawing.Size(1100, 650);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.tabControl1_DrawItem);
            // 
            // tpRegistrar
            // 
            this.tpRegistrar.Controls.Add(this.lblTituloRegistrar);
            this.tpRegistrar.Controls.Add(this.lblPaciente);
            this.tpRegistrar.Controls.Add(this.cmbPaciente);
            this.tpRegistrar.Controls.Add(this.lblMedico);
            this.tpRegistrar.Controls.Add(this.cmbMedico);
            this.tpRegistrar.Controls.Add(this.lblDiagnostico);
            this.tpRegistrar.Controls.Add(this.txtDiagnostico);
            this.tpRegistrar.Controls.Add(this.lblTratamiento);
            this.tpRegistrar.Controls.Add(this.txtTratamiento);
            this.tpRegistrar.Controls.Add(this.btnRegistrar);
            this.tpRegistrar.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tpRegistrar.Padding = new System.Windows.Forms.Padding(3);
            this.tpRegistrar.Location = new System.Drawing.Point(4, 39);
            this.tpRegistrar.Name = "tpRegistrar";
            this.tpRegistrar.Size = new System.Drawing.Size(1092, 607);
            this.tpRegistrar.TabIndex = 1;
            this.tpRegistrar.Text = "Registrar";
            this.tpRegistrar.UseVisualStyleBackColor = true;
            // 
            // lblTituloRegistrar
            // 
            this.lblTituloRegistrar.AutoSize = true;
            this.lblTituloRegistrar.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTituloRegistrar.ForeColor = System.Drawing.Color.FromArgb(((43)), ((48)), ((59)));
            this.lblTituloRegistrar.Location = new System.Drawing.Point(30, 20);
            this.lblTituloRegistrar.Name = "lblTituloRegistrar";
            this.lblTituloRegistrar.TabIndex = 2;
            this.lblTituloRegistrar.Text = "Registrar Historial clínico";
            // 
            // lblPaciente
            // 
            this.lblPaciente.AutoSize = true;
            this.lblPaciente.Location = new System.Drawing.Point(40, 83);
            this.lblPaciente.Name = "lblPaciente";
            this.lblPaciente.TabIndex = 3;
            this.lblPaciente.Text = "Paciente:";
            // 
            // cmbPaciente
            // 
            this.cmbPaciente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPaciente.FormattingEnabled = true;
            this.cmbPaciente.Location = new System.Drawing.Point(230, 80);
            this.cmbPaciente.Name = "cmbPaciente";
            this.cmbPaciente.Size = new System.Drawing.Size(320, 25);
            this.cmbPaciente.TabIndex = 4;
            // 
            // lblMedico
            // 
            this.lblMedico.AutoSize = true;
            this.lblMedico.Location = new System.Drawing.Point(40, 123);
            this.lblMedico.Name = "lblMedico";
            this.lblMedico.TabIndex = 5;
            this.lblMedico.Text = "Médico:";
            // 
            // cmbMedico
            // 
            this.cmbMedico.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMedico.FormattingEnabled = true;
            this.cmbMedico.Location = new System.Drawing.Point(230, 120);
            this.cmbMedico.Name = "cmbMedico";
            this.cmbMedico.Size = new System.Drawing.Size(320, 25);
            this.cmbMedico.TabIndex = 6;
            // 
            // lblDiagnostico
            // 
            this.lblDiagnostico.AutoSize = true;
            this.lblDiagnostico.Location = new System.Drawing.Point(40, 163);
            this.lblDiagnostico.Name = "lblDiagnostico";
            this.lblDiagnostico.TabIndex = 7;
            this.lblDiagnostico.Text = "Diagnóstico:";
            // 
            // txtDiagnostico
            // 
            this.txtDiagnostico.MaxLength = 300;
            this.txtDiagnostico.Multiline = true;
            this.txtDiagnostico.Location = new System.Drawing.Point(230, 160);
            this.txtDiagnostico.Name = "txtDiagnostico";
            this.txtDiagnostico.Size = new System.Drawing.Size(320, 80);
            this.txtDiagnostico.TabIndex = 8;
            // 
            // lblTratamiento
            // 
            this.lblTratamiento.AutoSize = true;
            this.lblTratamiento.Location = new System.Drawing.Point(40, 258);
            this.lblTratamiento.Name = "lblTratamiento";
            this.lblTratamiento.TabIndex = 9;
            this.lblTratamiento.Text = "Tratamiento:";
            // 
            // txtTratamiento
            // 
            this.txtTratamiento.MaxLength = 300;
            this.txtTratamiento.Multiline = true;
            this.txtTratamiento.Location = new System.Drawing.Point(230, 255);
            this.txtTratamiento.Name = "txtTratamiento";
            this.txtTratamiento.Size = new System.Drawing.Size(320, 80);
            this.txtTratamiento.TabIndex = 10;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistrar.FlatAppearance.BorderSize = 0;
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrar.ForeColor = System.Drawing.Color.White;
            this.btnRegistrar.BackColor = System.Drawing.Color.FromArgb(((40)), ((167)), ((69)));
            this.btnRegistrar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnRegistrar.Location = new System.Drawing.Point(230, 360);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(320, 40);
            this.btnRegistrar.TabIndex = 11;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // tpVer
            // 
            this.tpVer.Controls.Add(this.lblPacienteVer);
            this.tpVer.Controls.Add(this.cmbPacienteVer);
            this.tpVer.Controls.Add(this.lblDiagnosticoAct);
            this.tpVer.Controls.Add(this.txtDiagnosticoAct);
            this.tpVer.Controls.Add(this.lblTratamientoAct);
            this.tpVer.Controls.Add(this.txtTratamientoAct);
            this.tpVer.Controls.Add(this.btnActualizar);
            this.tpVer.Controls.Add(this.btnEliminar);
            this.tpVer.Controls.Add(this.dgvHistorial);
            this.tpVer.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tpVer.Padding = new System.Windows.Forms.Padding(3);
            this.tpVer.Location = new System.Drawing.Point(4, 39);
            this.tpVer.Name = "tpVer";
            this.tpVer.Size = new System.Drawing.Size(1092, 607);
            this.tpVer.TabIndex = 12;
            this.tpVer.Text = "Ver / Actualizar / Eliminar";
            this.tpVer.UseVisualStyleBackColor = true;
            // 
            // lblPacienteVer
            // 
            this.lblPacienteVer.AutoSize = true;
            this.lblPacienteVer.Location = new System.Drawing.Point(20, 23);
            this.lblPacienteVer.Name = "lblPacienteVer";
            this.lblPacienteVer.TabIndex = 13;
            this.lblPacienteVer.Text = "Paciente:";
            // 
            // cmbPacienteVer
            // 
            this.cmbPacienteVer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPacienteVer.FormattingEnabled = true;
            this.cmbPacienteVer.Location = new System.Drawing.Point(170, 20);
            this.cmbPacienteVer.Name = "cmbPacienteVer";
            this.cmbPacienteVer.Size = new System.Drawing.Size(250, 25);
            this.cmbPacienteVer.TabIndex = 14;
            this.cmbPacienteVer.SelectedIndexChanged += new System.EventHandler(this.cmbPacienteVer_SelectedIndexChanged);
            // 
            // lblDiagnosticoAct
            // 
            this.lblDiagnosticoAct.AutoSize = true;
            this.lblDiagnosticoAct.Location = new System.Drawing.Point(20, 63);
            this.lblDiagnosticoAct.Name = "lblDiagnosticoAct";
            this.lblDiagnosticoAct.TabIndex = 15;
            this.lblDiagnosticoAct.Text = "Diagnóstico:";
            // 
            // txtDiagnosticoAct
            // 
            this.txtDiagnosticoAct.MaxLength = 300;
            this.txtDiagnosticoAct.Multiline = true;
            this.txtDiagnosticoAct.Location = new System.Drawing.Point(170, 60);
            this.txtDiagnosticoAct.Name = "txtDiagnosticoAct";
            this.txtDiagnosticoAct.Size = new System.Drawing.Size(250, 100);
            this.txtDiagnosticoAct.TabIndex = 16;
            // 
            // lblTratamientoAct
            // 
            this.lblTratamientoAct.AutoSize = true;
            this.lblTratamientoAct.Location = new System.Drawing.Point(20, 178);
            this.lblTratamientoAct.Name = "lblTratamientoAct";
            this.lblTratamientoAct.TabIndex = 17;
            this.lblTratamientoAct.Text = "Tratamiento:";
            // 
            // txtTratamientoAct
            // 
            this.txtTratamientoAct.MaxLength = 300;
            this.txtTratamientoAct.Multiline = true;
            this.txtTratamientoAct.Location = new System.Drawing.Point(170, 175);
            this.txtTratamientoAct.Name = "txtTratamientoAct";
            this.txtTratamientoAct.Size = new System.Drawing.Size(250, 100);
            this.txtTratamientoAct.TabIndex = 18;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActualizar.FlatAppearance.BorderSize = 0;
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.ForeColor = System.Drawing.Color.White;
            this.btnActualizar.BackColor = System.Drawing.Color.FromArgb(((0)), ((120)), ((212)));
            this.btnActualizar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnActualizar.Location = new System.Drawing.Point(20, 300);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(195, 40);
            this.btnActualizar.TabIndex = 19;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((220)), ((53)), ((69)));
            this.btnEliminar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnEliminar.Location = new System.Drawing.Point(225, 300);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(195, 40);
            this.btnEliminar.TabIndex = 20;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // dgvHistorial
            // 
            this.dgvHistorial.AllowUserToAddRows = false;
            this.dgvHistorial.AllowUserToDeleteRows = false;
            this.dgvHistorial.ReadOnly = true;
            this.dgvHistorial.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHistorial.BackgroundColor = System.Drawing.Color.White;
            this.dgvHistorial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistorial.MultiSelect = false;
            this.dgvHistorial.RowHeadersVisible = false;
            this.dgvHistorial.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHistorial.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvHistorial.Location = new System.Drawing.Point(450, 60);
            this.dgvHistorial.Name = "dgvHistorial";
            this.dgvHistorial.Size = new System.Drawing.Size(630, 510);
            this.dgvHistorial.TabIndex = 21;
            this.dgvHistorial.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHistorial_CellClick);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmHistorial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1100, 650);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Name = "frmHistorial";
            this.Text = "Historial clínico";
            this.Load += new System.EventHandler(this.frmHistorial_Load);
            this.tpVer.ResumeLayout(false);
            this.tpRegistrar.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tpRegistrar.PerformLayout();
            this.tpVer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpRegistrar;
        private System.Windows.Forms.Label lblTituloRegistrar;
        private System.Windows.Forms.Label lblPaciente;
        private System.Windows.Forms.ComboBox cmbPaciente;
        private System.Windows.Forms.Label lblMedico;
        private System.Windows.Forms.ComboBox cmbMedico;
        private System.Windows.Forms.Label lblDiagnostico;
        private System.Windows.Forms.TextBox txtDiagnostico;
        private System.Windows.Forms.Label lblTratamiento;
        private System.Windows.Forms.TextBox txtTratamiento;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.TabPage tpVer;
        private System.Windows.Forms.Label lblPacienteVer;
        private System.Windows.Forms.ComboBox cmbPacienteVer;
        private System.Windows.Forms.Label lblDiagnosticoAct;
        private System.Windows.Forms.TextBox txtDiagnosticoAct;
        private System.Windows.Forms.Label lblTratamientoAct;
        private System.Windows.Forms.TextBox txtTratamientoAct;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DataGridView dgvHistorial;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
