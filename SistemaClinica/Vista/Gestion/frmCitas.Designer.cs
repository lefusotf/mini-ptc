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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpRegistrar = new System.Windows.Forms.TabPage();
            this.lblTituloRegistrar = new System.Windows.Forms.Label();
            this.lblSubRegistrar = new System.Windows.Forms.Label();
            this.pnlRegistrar = new System.Windows.Forms.Panel();
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
            this.pnlEditar = new System.Windows.Forms.Panel();
            this.lblEditar = new System.Windows.Forms.Label();
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
            this.lblLista = new System.Windows.Forms.Label();
            this.dgvCitas = new System.Windows.Forms.DataGridView();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabControl1.SuspendLayout();
            this.tpRegistrar.SuspendLayout();
            this.pnlRegistrar.SuspendLayout();
            this.tpVer.SuspendLayout();
            this.pnlEditar.SuspendLayout();
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
            this.tabControl1.ItemSize = new System.Drawing.Size(240, 40);
            this.tabControl1.Padding = new System.Drawing.Point(12, 6);
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
            this.tpRegistrar.Controls.Add(this.lblSubRegistrar);
            this.tpRegistrar.Controls.Add(this.pnlRegistrar);
            this.tpRegistrar.BackColor = System.Drawing.Color.FromArgb(((245)), ((247)), ((250)));
            this.tpRegistrar.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tpRegistrar.Padding = new System.Windows.Forms.Padding(3);
            this.tpRegistrar.Location = new System.Drawing.Point(4, 44);
            this.tpRegistrar.Name = "tpRegistrar";
            this.tpRegistrar.Size = new System.Drawing.Size(1092, 602);
            this.tpRegistrar.TabIndex = 1;
            this.tpRegistrar.Text = "Registrar";
            this.tpRegistrar.UseVisualStyleBackColor = false;
            // 
            // lblTituloRegistrar
            // 
            this.lblTituloRegistrar.AutoSize = true;
            this.lblTituloRegistrar.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTituloRegistrar.ForeColor = System.Drawing.Color.FromArgb(((43)), ((48)), ((59)));
            this.lblTituloRegistrar.Location = new System.Drawing.Point(30, 18);
            this.lblTituloRegistrar.Name = "lblTituloRegistrar";
            this.lblTituloRegistrar.TabIndex = 2;
            this.lblTituloRegistrar.Text = "Registrar cita";
            // 
            // lblSubRegistrar
            // 
            this.lblSubRegistrar.AutoSize = true;
            this.lblSubRegistrar.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSubRegistrar.ForeColor = System.Drawing.Color.FromArgb(((120)), ((128)), ((140)));
            this.lblSubRegistrar.Location = new System.Drawing.Point(32, 58);
            this.lblSubRegistrar.Name = "lblSubRegistrar";
            this.lblSubRegistrar.TabIndex = 3;
            this.lblSubRegistrar.Text = "Complete los datos y presione «Registrar». Los campos con * son obligatorios.";
            // 
            // pnlRegistrar
            // 
            this.pnlRegistrar.Controls.Add(this.lblPaciente);
            this.pnlRegistrar.Controls.Add(this.cmbPaciente);
            this.pnlRegistrar.Controls.Add(this.lblMedico);
            this.pnlRegistrar.Controls.Add(this.cmbMedico);
            this.pnlRegistrar.Controls.Add(this.lblFecha);
            this.pnlRegistrar.Controls.Add(this.dtpFecha);
            this.pnlRegistrar.Controls.Add(this.lblHora);
            this.pnlRegistrar.Controls.Add(this.cmbHora);
            this.pnlRegistrar.Controls.Add(this.lblMotivo);
            this.pnlRegistrar.Controls.Add(this.txtMotivo);
            this.pnlRegistrar.Controls.Add(this.btnRegistrar);
            this.pnlRegistrar.BackColor = System.Drawing.Color.White;
            this.pnlRegistrar.Location = new System.Drawing.Point(30, 95);
            this.pnlRegistrar.Name = "pnlRegistrar";
            this.pnlRegistrar.Size = new System.Drawing.Size(690, 349);
            this.pnlRegistrar.TabIndex = 4;
            // 
            // lblPaciente
            // 
            this.lblPaciente.AutoSize = true;
            this.lblPaciente.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblPaciente.ForeColor = System.Drawing.Color.FromArgb(((120)), ((128)), ((140)));
            this.lblPaciente.Location = new System.Drawing.Point(30, 30);
            this.lblPaciente.Name = "lblPaciente";
            this.lblPaciente.TabIndex = 5;
            this.lblPaciente.Text = "PACIENTE *";
            // 
            // cmbPaciente
            // 
            this.cmbPaciente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPaciente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbPaciente.FormattingEnabled = true;
            this.cmbPaciente.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.cmbPaciente.Location = new System.Drawing.Point(30, 51);
            this.cmbPaciente.Name = "cmbPaciente";
            this.cmbPaciente.Size = new System.Drawing.Size(300, 28);
            this.cmbPaciente.TabIndex = 6;
            // 
            // lblMedico
            // 
            this.lblMedico.AutoSize = true;
            this.lblMedico.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblMedico.ForeColor = System.Drawing.Color.FromArgb(((120)), ((128)), ((140)));
            this.lblMedico.Location = new System.Drawing.Point(360, 30);
            this.lblMedico.Name = "lblMedico";
            this.lblMedico.TabIndex = 7;
            this.lblMedico.Text = "MÉDICO *";
            // 
            // cmbMedico
            // 
            this.cmbMedico.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMedico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbMedico.FormattingEnabled = true;
            this.cmbMedico.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.cmbMedico.Location = new System.Drawing.Point(360, 51);
            this.cmbMedico.Name = "cmbMedico";
            this.cmbMedico.Size = new System.Drawing.Size(300, 28);
            this.cmbMedico.TabIndex = 8;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblFecha.ForeColor = System.Drawing.Color.FromArgb(((120)), ((128)), ((140)));
            this.lblFecha.Location = new System.Drawing.Point(30, 97);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.TabIndex = 9;
            this.lblFecha.Text = "FECHA *";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.dtpFecha.Location = new System.Drawing.Point(30, 118);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(300, 28);
            this.dtpFecha.TabIndex = 10;
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblHora.ForeColor = System.Drawing.Color.FromArgb(((120)), ((128)), ((140)));
            this.lblHora.Location = new System.Drawing.Point(360, 97);
            this.lblHora.Name = "lblHora";
            this.lblHora.TabIndex = 11;
            this.lblHora.Text = "HORA *";
            // 
            // cmbHora
            // 
            this.cmbHora.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHora.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
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
            this.cmbHora.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.cmbHora.Location = new System.Drawing.Point(360, 118);
            this.cmbHora.Name = "cmbHora";
            this.cmbHora.Size = new System.Drawing.Size(300, 28);
            this.cmbHora.TabIndex = 12;
            // 
            // lblMotivo
            // 
            this.lblMotivo.AutoSize = true;
            this.lblMotivo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblMotivo.ForeColor = System.Drawing.Color.FromArgb(((120)), ((128)), ((140)));
            this.lblMotivo.Location = new System.Drawing.Point(30, 164);
            this.lblMotivo.Name = "lblMotivo";
            this.lblMotivo.TabIndex = 13;
            this.lblMotivo.Text = "MOTIVO DE LA CONSULTA *";
            // 
            // txtMotivo
            // 
            this.txtMotivo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMotivo.MaxLength = 200;
            this.txtMotivo.Multiline = true;
            this.txtMotivo.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtMotivo.Location = new System.Drawing.Point(30, 185);
            this.txtMotivo.Name = "txtMotivo";
            this.txtMotivo.Size = new System.Drawing.Size(630, 60);
            this.txtMotivo.TabIndex = 14;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistrar.FlatAppearance.BorderSize = 0;
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrar.BackColor = System.Drawing.Color.FromArgb(((39)), ((174)), ((96)));
            this.btnRegistrar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnRegistrar.ForeColor = System.Drawing.Color.White;
            this.btnRegistrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((33)), ((147)), ((81)));
            this.btnRegistrar.Location = new System.Drawing.Point(460, 273);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(200, 46);
            this.btnRegistrar.TabIndex = 15;
            this.btnRegistrar.Text = "✔  Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // tpVer
            // 
            this.tpVer.Controls.Add(this.pnlEditar);
            this.tpVer.Controls.Add(this.lblLista);
            this.tpVer.Controls.Add(this.dgvCitas);
            this.tpVer.BackColor = System.Drawing.Color.FromArgb(((245)), ((247)), ((250)));
            this.tpVer.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tpVer.Padding = new System.Windows.Forms.Padding(3);
            this.tpVer.Location = new System.Drawing.Point(4, 44);
            this.tpVer.Name = "tpVer";
            this.tpVer.Size = new System.Drawing.Size(1092, 602);
            this.tpVer.TabIndex = 16;
            this.tpVer.Text = "Ver / Actualizar / Eliminar";
            this.tpVer.UseVisualStyleBackColor = false;
            // 
            // pnlEditar
            // 
            this.pnlEditar.Controls.Add(this.lblEditar);
            this.pnlEditar.Controls.Add(this.lblPacienteAct);
            this.pnlEditar.Controls.Add(this.cmbPacienteAct);
            this.pnlEditar.Controls.Add(this.lblMedicoAct);
            this.pnlEditar.Controls.Add(this.cmbMedicoAct);
            this.pnlEditar.Controls.Add(this.lblFechaAct);
            this.pnlEditar.Controls.Add(this.dtpFechaAct);
            this.pnlEditar.Controls.Add(this.lblHoraAct);
            this.pnlEditar.Controls.Add(this.cmbHoraAct);
            this.pnlEditar.Controls.Add(this.lblMotivoAct);
            this.pnlEditar.Controls.Add(this.txtMotivoAct);
            this.pnlEditar.Controls.Add(this.lblEstadoAct);
            this.pnlEditar.Controls.Add(this.cmbEstadoAct);
            this.pnlEditar.Controls.Add(this.btnActualizar);
            this.pnlEditar.Controls.Add(this.btnEliminar);
            this.pnlEditar.BackColor = System.Drawing.Color.White;
            this.pnlEditar.Location = new System.Drawing.Point(20, 20);
            this.pnlEditar.Name = "pnlEditar";
            this.pnlEditar.Size = new System.Drawing.Size(310, 552);
            this.pnlEditar.TabIndex = 17;
            // 
            // lblEditar
            // 
            this.lblEditar.AutoSize = true;
            this.lblEditar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblEditar.ForeColor = System.Drawing.Color.FromArgb(((43)), ((48)), ((59)));
            this.lblEditar.Location = new System.Drawing.Point(20, 18);
            this.lblEditar.Name = "lblEditar";
            this.lblEditar.TabIndex = 18;
            this.lblEditar.Text = "Editar seleccionado";
            // 
            // lblPacienteAct
            // 
            this.lblPacienteAct.AutoSize = true;
            this.lblPacienteAct.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblPacienteAct.ForeColor = System.Drawing.Color.FromArgb(((120)), ((128)), ((140)));
            this.lblPacienteAct.Location = new System.Drawing.Point(20, 60);
            this.lblPacienteAct.Name = "lblPacienteAct";
            this.lblPacienteAct.TabIndex = 19;
            this.lblPacienteAct.Text = "PACIENTE";
            // 
            // cmbPacienteAct
            // 
            this.cmbPacienteAct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPacienteAct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbPacienteAct.FormattingEnabled = true;
            this.cmbPacienteAct.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.cmbPacienteAct.Location = new System.Drawing.Point(20, 81);
            this.cmbPacienteAct.Name = "cmbPacienteAct";
            this.cmbPacienteAct.Size = new System.Drawing.Size(270, 28);
            this.cmbPacienteAct.TabIndex = 20;
            // 
            // lblMedicoAct
            // 
            this.lblMedicoAct.AutoSize = true;
            this.lblMedicoAct.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblMedicoAct.ForeColor = System.Drawing.Color.FromArgb(((120)), ((128)), ((140)));
            this.lblMedicoAct.Location = new System.Drawing.Point(20, 125);
            this.lblMedicoAct.Name = "lblMedicoAct";
            this.lblMedicoAct.TabIndex = 21;
            this.lblMedicoAct.Text = "MÉDICO";
            // 
            // cmbMedicoAct
            // 
            this.cmbMedicoAct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMedicoAct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbMedicoAct.FormattingEnabled = true;
            this.cmbMedicoAct.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.cmbMedicoAct.Location = new System.Drawing.Point(20, 146);
            this.cmbMedicoAct.Name = "cmbMedicoAct";
            this.cmbMedicoAct.Size = new System.Drawing.Size(270, 28);
            this.cmbMedicoAct.TabIndex = 22;
            // 
            // lblFechaAct
            // 
            this.lblFechaAct.AutoSize = true;
            this.lblFechaAct.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblFechaAct.ForeColor = System.Drawing.Color.FromArgb(((120)), ((128)), ((140)));
            this.lblFechaAct.Location = new System.Drawing.Point(20, 190);
            this.lblFechaAct.Name = "lblFechaAct";
            this.lblFechaAct.TabIndex = 23;
            this.lblFechaAct.Text = "FECHA";
            // 
            // dtpFechaAct
            // 
            this.dtpFechaAct.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaAct.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.dtpFechaAct.Location = new System.Drawing.Point(20, 211);
            this.dtpFechaAct.Name = "dtpFechaAct";
            this.dtpFechaAct.Size = new System.Drawing.Size(270, 28);
            this.dtpFechaAct.TabIndex = 24;
            // 
            // lblHoraAct
            // 
            this.lblHoraAct.AutoSize = true;
            this.lblHoraAct.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblHoraAct.ForeColor = System.Drawing.Color.FromArgb(((120)), ((128)), ((140)));
            this.lblHoraAct.Location = new System.Drawing.Point(20, 255);
            this.lblHoraAct.Name = "lblHoraAct";
            this.lblHoraAct.TabIndex = 25;
            this.lblHoraAct.Text = "HORA";
            // 
            // cmbHoraAct
            // 
            this.cmbHoraAct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHoraAct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
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
            this.cmbHoraAct.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.cmbHoraAct.Location = new System.Drawing.Point(20, 276);
            this.cmbHoraAct.Name = "cmbHoraAct";
            this.cmbHoraAct.Size = new System.Drawing.Size(270, 28);
            this.cmbHoraAct.TabIndex = 26;
            // 
            // lblMotivoAct
            // 
            this.lblMotivoAct.AutoSize = true;
            this.lblMotivoAct.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblMotivoAct.ForeColor = System.Drawing.Color.FromArgb(((120)), ((128)), ((140)));
            this.lblMotivoAct.Location = new System.Drawing.Point(20, 320);
            this.lblMotivoAct.Name = "lblMotivoAct";
            this.lblMotivoAct.TabIndex = 27;
            this.lblMotivoAct.Text = "MOTIVO DE LA CONSULTA";
            // 
            // txtMotivoAct
            // 
            this.txtMotivoAct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMotivoAct.MaxLength = 200;
            this.txtMotivoAct.Multiline = true;
            this.txtMotivoAct.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtMotivoAct.Location = new System.Drawing.Point(20, 341);
            this.txtMotivoAct.Name = "txtMotivoAct";
            this.txtMotivoAct.Size = new System.Drawing.Size(270, 60);
            this.txtMotivoAct.TabIndex = 28;
            // 
            // lblEstadoAct
            // 
            this.lblEstadoAct.AutoSize = true;
            this.lblEstadoAct.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblEstadoAct.ForeColor = System.Drawing.Color.FromArgb(((120)), ((128)), ((140)));
            this.lblEstadoAct.Location = new System.Drawing.Point(20, 417);
            this.lblEstadoAct.Name = "lblEstadoAct";
            this.lblEstadoAct.TabIndex = 29;
            this.lblEstadoAct.Text = "ESTADO";
            // 
            // cmbEstadoAct
            // 
            this.cmbEstadoAct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstadoAct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbEstadoAct.FormattingEnabled = true;
            this.cmbEstadoAct.Items.AddRange(new object[] {
            "Pendiente",
            "Atendida",
            "Cancelada"});
            this.cmbEstadoAct.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.cmbEstadoAct.Location = new System.Drawing.Point(20, 438);
            this.cmbEstadoAct.Name = "cmbEstadoAct";
            this.cmbEstadoAct.Size = new System.Drawing.Size(270, 28);
            this.cmbEstadoAct.TabIndex = 30;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActualizar.FlatAppearance.BorderSize = 0;
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.BackColor = System.Drawing.Color.FromArgb(((52)), ((120)), ((210)));
            this.btnActualizar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnActualizar.ForeColor = System.Drawing.Color.White;
            this.btnActualizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((44)), ((102)), ((178)));
            this.btnActualizar.Location = new System.Drawing.Point(20, 488);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(130, 42);
            this.btnActualizar.TabIndex = 31;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((214)), ((69)), ((65)));
            this.btnEliminar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((181)), ((58)), ((55)));
            this.btnEliminar.Location = new System.Drawing.Point(160, 488);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(130, 42);
            this.btnEliminar.TabIndex = 32;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // lblLista
            // 
            this.lblLista.AutoSize = true;
            this.lblLista.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblLista.ForeColor = System.Drawing.Color.FromArgb(((43)), ((48)), ((59)));
            this.lblLista.Location = new System.Drawing.Point(350, 24);
            this.lblLista.Name = "lblLista";
            this.lblLista.TabIndex = 33;
            this.lblLista.Text = "Lista de citas";
            // 
            // dgvCitas
            // 
            this.dgvCitas.AllowUserToAddRows = false;
            this.dgvCitas.AllowUserToDeleteRows = false;
            this.dgvCitas.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((248)), ((250)), ((252)));
            this.dgvCitas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCitas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCitas.BackgroundColor = System.Drawing.Color.White;
            this.dgvCitas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCitas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvCitas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((43)), ((48)), ((59)));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((43)), ((48)), ((59)));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCitas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCitas.ColumnHeadersHeight = 42;
            this.dgvCitas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((52)), ((58)), ((70)));
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((41)), ((182)), ((182)));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCitas.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCitas.EnableHeadersVisualStyles = false;
            this.dgvCitas.GridColor = System.Drawing.Color.FromArgb(((225)), ((230)), ((236)));
            this.dgvCitas.MultiSelect = false;
            this.dgvCitas.ReadOnly = true;
            this.dgvCitas.RowHeadersVisible = false;
            this.dgvCitas.RowTemplate.Height = 34;
            this.dgvCitas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCitas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCitas.Location = new System.Drawing.Point(350, 64);
            this.dgvCitas.Name = "dgvCitas";
            this.dgvCitas.Size = new System.Drawing.Size(722, 518);
            this.dgvCitas.TabIndex = 34;
            this.dgvCitas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCitas_CellClick);
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // frmCitas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((245)), ((247)), ((250)));
            this.ClientSize = new System.Drawing.Size(1100, 650);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ForeColor = System.Drawing.Color.FromArgb(((52)), ((58)), ((70)));
            this.Name = "frmCitas";
            this.Text = "citas";
            this.Load += new System.EventHandler(this.frmCitas_Load);
            this.pnlEditar.ResumeLayout(false);
            this.tpVer.ResumeLayout(false);
            this.pnlRegistrar.ResumeLayout(false);
            this.tpRegistrar.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tpRegistrar.PerformLayout();
            this.pnlRegistrar.PerformLayout();
            this.tpVer.PerformLayout();
            this.pnlEditar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCitas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpRegistrar;
        private System.Windows.Forms.Label lblTituloRegistrar;
        private System.Windows.Forms.Label lblSubRegistrar;
        private System.Windows.Forms.Panel pnlRegistrar;
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
        private System.Windows.Forms.Panel pnlEditar;
        private System.Windows.Forms.Label lblEditar;
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
        private System.Windows.Forms.Label lblLista;
        private System.Windows.Forms.DataGridView dgvCitas;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
