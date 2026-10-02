namespace Vista.Gestion
{
    partial class frmCitas
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
            this.lblFecha = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.lblHora = new System.Windows.Forms.Label();
            this.cmbHora = new System.Windows.Forms.ComboBox();
            this.lblMotivo = new System.Windows.Forms.Label();
            this.txtMotivo = new System.Windows.Forms.TextBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.tpVer = new System.Windows.Forms.TabPage();
            this.lblPacienteAct = new System.Windows.Forms.Label();
            this.cmbPacienteAct = new System.Windows.Forms.ComboBox();
            this.lblMedicoAct = new System.Windows.Forms.Label();
            this.cmbMedicoAct = new System.Windows.Forms.ComboBox();
            this.lblFechaAct = new System.Windows.Forms.Label();
            this.dtpFechaAct = new System.Windows.Forms.DateTimePicker();
            this.lblHoraAct = new System.Windows.Forms.Label();
            this.cmbHoraAct = new System.Windows.Forms.ComboBox();
            this.lblMotivoAct = new System.Windows.Forms.Label();
            this.txtMotivoAct = new System.Windows.Forms.TextBox();
            this.lblEstadoAct = new System.Windows.Forms.Label();
            this.cmbEstadoAct = new System.Windows.Forms.ComboBox();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.dgvCitas = new System.Windows.Forms.DataGridView();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabControl1.SuspendLayout();
            this.tpRegistrar.SuspendLayout();
            this.tpVer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCitas)).BeginInit();
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
            this.tpRegistrar.Controls.Add(this.lblFecha);
            this.tpRegistrar.Controls.Add(this.dtpFecha);
            this.tpRegistrar.Controls.Add(this.lblHora);
            this.tpRegistrar.Controls.Add(this.cmbHora);
            this.tpRegistrar.Controls.Add(this.lblMotivo);
            this.tpRegistrar.Controls.Add(this.txtMotivo);
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
            this.lblTituloRegistrar.Text = "Registrar Citas";
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
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(40, 163);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.TabIndex = 7;
            this.lblFecha.Text = "Fecha:";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(230, 160);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(320, 25);
            this.dtpFecha.TabIndex = 8;
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Location = new System.Drawing.Point(40, 203);
            this.lblHora.Name = "lblHora";
            this.lblHora.TabIndex = 9;
            this.lblHora.Text = "Hora:";
            // 
            // cmbHora
            // 
            this.cmbHora.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHora.FormattingEnabled = true;
            this.cmbHora.Items.AddRange(new object[] {
            "07:00",
            "07:30",
            "08:00",
            "08:30",
            "09:00",
            "09:30",
            "10:00",
            "10:30",
            "11:00",
            "11:30",
            "12:00",
            "12:30",
            "13:00",
            "13:30",
            "14:00",
            "14:30",
            "15:00",
            "15:30",
            "16:00",
            "16:30"});
            this.cmbHora.Location = new System.Drawing.Point(230, 200);
            this.cmbHora.Name = "cmbHora";
            this.cmbHora.Size = new System.Drawing.Size(320, 25);
            this.cmbHora.TabIndex = 10;
            // 
            // lblMotivo
            // 
            this.lblMotivo.AutoSize = true;
            this.lblMotivo.Location = new System.Drawing.Point(40, 243);
            this.lblMotivo.Name = "lblMotivo";
            this.lblMotivo.TabIndex = 11;
            this.lblMotivo.Text = "Motivo:";
            // 
            // txtMotivo
            // 
            this.txtMotivo.MaxLength = 200;
            this.txtMotivo.Multiline = true;
            this.txtMotivo.Location = new System.Drawing.Point(230, 240);
            this.txtMotivo.Name = "txtMotivo";
            this.txtMotivo.Size = new System.Drawing.Size(320, 60);
            this.txtMotivo.TabIndex = 12;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistrar.FlatAppearance.BorderSize = 0;
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrar.ForeColor = System.Drawing.Color.White;
            this.btnRegistrar.BackColor = System.Drawing.Color.FromArgb(((40)), ((167)), ((69)));
            this.btnRegistrar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnRegistrar.Location = new System.Drawing.Point(230, 325);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(320, 40);
            this.btnRegistrar.TabIndex = 13;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // tpVer
            // 
            this.tpVer.Controls.Add(this.lblPacienteAct);
            this.tpVer.Controls.Add(this.cmbPacienteAct);
            this.tpVer.Controls.Add(this.lblMedicoAct);
            this.tpVer.Controls.Add(this.cmbMedicoAct);
            this.tpVer.Controls.Add(this.lblFechaAct);
            this.tpVer.Controls.Add(this.dtpFechaAct);
            this.tpVer.Controls.Add(this.lblHoraAct);
            this.tpVer.Controls.Add(this.cmbHoraAct);
            this.tpVer.Controls.Add(this.lblMotivoAct);
            this.tpVer.Controls.Add(this.txtMotivoAct);
            this.tpVer.Controls.Add(this.lblEstadoAct);
            this.tpVer.Controls.Add(this.cmbEstadoAct);
            this.tpVer.Controls.Add(this.btnActualizar);
            this.tpVer.Controls.Add(this.btnEliminar);
            this.tpVer.Controls.Add(this.dgvCitas);
            this.tpVer.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tpVer.Padding = new System.Windows.Forms.Padding(3);
            this.tpVer.Location = new System.Drawing.Point(4, 39);
            this.tpVer.Name = "tpVer";
            this.tpVer.Size = new System.Drawing.Size(1092, 607);
            this.tpVer.TabIndex = 14;
            this.tpVer.Text = "Ver / Actualizar / Eliminar";
            this.tpVer.UseVisualStyleBackColor = true;
            // 
            // lblPacienteAct
            // 
            this.lblPacienteAct.AutoSize = true;
            this.lblPacienteAct.Location = new System.Drawing.Point(20, 23);
            this.lblPacienteAct.Name = "lblPacienteAct";
            this.lblPacienteAct.TabIndex = 15;
            this.lblPacienteAct.Text = "Paciente:";
            // 
            // cmbPacienteAct
            // 
            this.cmbPacienteAct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPacienteAct.FormattingEnabled = true;
            this.cmbPacienteAct.Location = new System.Drawing.Point(170, 20);
            this.cmbPacienteAct.Name = "cmbPacienteAct";
            this.cmbPacienteAct.Size = new System.Drawing.Size(250, 25);
            this.cmbPacienteAct.TabIndex = 16;
            // 
            // lblMedicoAct
            // 
            this.lblMedicoAct.AutoSize = true;
            this.lblMedicoAct.Location = new System.Drawing.Point(20, 63);
            this.lblMedicoAct.Name = "lblMedicoAct";
            this.lblMedicoAct.TabIndex = 17;
            this.lblMedicoAct.Text = "Médico:";
            // 
            // cmbMedicoAct
            // 
            this.cmbMedicoAct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMedicoAct.FormattingEnabled = true;
            this.cmbMedicoAct.Location = new System.Drawing.Point(170, 60);
            this.cmbMedicoAct.Name = "cmbMedicoAct";
            this.cmbMedicoAct.Size = new System.Drawing.Size(250, 25);
            this.cmbMedicoAct.TabIndex = 18;
            // 
            // lblFechaAct
            // 
            this.lblFechaAct.AutoSize = true;
            this.lblFechaAct.Location = new System.Drawing.Point(20, 103);
            this.lblFechaAct.Name = "lblFechaAct";
            this.lblFechaAct.TabIndex = 19;
            this.lblFechaAct.Text = "Fecha:";
            // 
            // dtpFechaAct
            // 
            this.dtpFechaAct.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaAct.Location = new System.Drawing.Point(170, 100);
            this.dtpFechaAct.Name = "dtpFechaAct";
            this.dtpFechaAct.Size = new System.Drawing.Size(250, 25);
            this.dtpFechaAct.TabIndex = 20;
            // 
            // lblHoraAct
            // 
            this.lblHoraAct.AutoSize = true;
            this.lblHoraAct.Location = new System.Drawing.Point(20, 143);
            this.lblHoraAct.Name = "lblHoraAct";
            this.lblHoraAct.TabIndex = 21;
            this.lblHoraAct.Text = "Hora:";
            // 
            // cmbHoraAct
            // 
            this.cmbHoraAct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHoraAct.FormattingEnabled = true;
            this.cmbHoraAct.Items.AddRange(new object[] {
            "07:00",
            "07:30",
            "08:00",
            "08:30",
            "09:00",
            "09:30",
            "10:00",
            "10:30",
            "11:00",
            "11:30",
            "12:00",
            "12:30",
            "13:00",
            "13:30",
            "14:00",
            "14:30",
            "15:00",
            "15:30",
            "16:00",
            "16:30"});
            this.cmbHoraAct.Location = new System.Drawing.Point(170, 140);
            this.cmbHoraAct.Name = "cmbHoraAct";
            this.cmbHoraAct.Size = new System.Drawing.Size(250, 25);
            this.cmbHoraAct.TabIndex = 22;
            // 
            // lblMotivoAct
            // 
            this.lblMotivoAct.AutoSize = true;
            this.lblMotivoAct.Location = new System.Drawing.Point(20, 183);
            this.lblMotivoAct.Name = "lblMotivoAct";
            this.lblMotivoAct.TabIndex = 23;
            this.lblMotivoAct.Text = "Motivo:";
            // 
            // txtMotivoAct
            // 
            this.txtMotivoAct.MaxLength = 200;
            this.txtMotivoAct.Multiline = true;
            this.txtMotivoAct.Location = new System.Drawing.Point(170, 180);
            this.txtMotivoAct.Name = "txtMotivoAct";
            this.txtMotivoAct.Size = new System.Drawing.Size(250, 60);
            this.txtMotivoAct.TabIndex = 24;
            // 
            // lblEstadoAct
            // 
            this.lblEstadoAct.AutoSize = true;
            this.lblEstadoAct.Location = new System.Drawing.Point(20, 258);
            this.lblEstadoAct.Name = "lblEstadoAct";
            this.lblEstadoAct.TabIndex = 25;
            this.lblEstadoAct.Text = "Estado:";
            // 
            // cmbEstadoAct
            // 
            this.cmbEstadoAct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstadoAct.FormattingEnabled = true;
            this.cmbEstadoAct.Items.AddRange(new object[] {
            "Pendiente",
            "Atendida",
            "Cancelada"});
            this.cmbEstadoAct.Location = new System.Drawing.Point(170, 255);
            this.cmbEstadoAct.Name = "cmbEstadoAct";
            this.cmbEstadoAct.Size = new System.Drawing.Size(250, 25);
            this.cmbEstadoAct.TabIndex = 26;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActualizar.FlatAppearance.BorderSize = 0;
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.ForeColor = System.Drawing.Color.White;
            this.btnActualizar.BackColor = System.Drawing.Color.FromArgb(((0)), ((120)), ((212)));
            this.btnActualizar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnActualizar.Location = new System.Drawing.Point(20, 305);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(195, 40);
            this.btnActualizar.TabIndex = 27;
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
            this.btnEliminar.Location = new System.Drawing.Point(225, 305);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(195, 40);
            this.btnEliminar.TabIndex = 28;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // dgvCitas
            // 
            this.dgvCitas.AllowUserToAddRows = false;
            this.dgvCitas.AllowUserToDeleteRows = false;
            this.dgvCitas.ReadOnly = true;
            this.dgvCitas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCitas.BackgroundColor = System.Drawing.Color.White;
            this.dgvCitas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCitas.MultiSelect = false;
            this.dgvCitas.RowHeadersVisible = false;
            this.dgvCitas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCitas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCitas.Location = new System.Drawing.Point(450, 20);
            this.dgvCitas.Name = "dgvCitas";
            this.dgvCitas.Size = new System.Drawing.Size(630, 550);
            this.dgvCitas.TabIndex = 29;
            this.dgvCitas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCitas_CellClick);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmCitas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1100, 650);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Name = "frmCitas";
            this.Text = "Citas";
            this.Load += new System.EventHandler(this.frmCitas_Load);
            this.tpVer.ResumeLayout(false);
            this.tpRegistrar.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tpRegistrar.PerformLayout();
            this.tpVer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCitas)).EndInit();
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
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.ComboBox cmbHora;
        private System.Windows.Forms.Label lblMotivo;
        private System.Windows.Forms.TextBox txtMotivo;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.TabPage tpVer;
        private System.Windows.Forms.Label lblPacienteAct;
        private System.Windows.Forms.ComboBox cmbPacienteAct;
        private System.Windows.Forms.Label lblMedicoAct;
        private System.Windows.Forms.ComboBox cmbMedicoAct;
        private System.Windows.Forms.Label lblFechaAct;
        private System.Windows.Forms.DateTimePicker dtpFechaAct;
        private System.Windows.Forms.Label lblHoraAct;
        private System.Windows.Forms.ComboBox cmbHoraAct;
        private System.Windows.Forms.Label lblMotivoAct;
        private System.Windows.Forms.TextBox txtMotivoAct;
        private System.Windows.Forms.Label lblEstadoAct;
        private System.Windows.Forms.ComboBox cmbEstadoAct;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DataGridView dgvCitas;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
