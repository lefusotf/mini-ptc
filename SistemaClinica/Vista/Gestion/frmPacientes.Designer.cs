namespace Vista.Gestion
{
    partial class frmPacientes
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
            this.pnlRegistrar = new System.Windows.Forms.Panel();
            this.lblTituloRegistrar = new System.Windows.Forms.Label();
            this.lblSubRegistrar = new System.Windows.Forms.Label();
            this.pnlLineaRegistrar = new System.Windows.Forms.Panel();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblDui = new System.Windows.Forms.Label();
            this.mskDui = new System.Windows.Forms.MaskedTextBox();
            this.lblFechaNacimiento = new System.Windows.Forms.Label();
            this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.lblGenero = new System.Windows.Forms.Label();
            this.cmbGenero = new System.Windows.Forms.ComboBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.mskTelefono = new System.Windows.Forms.MaskedTextBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.tpVer = new System.Windows.Forms.TabPage();
            this.pnlEditar = new System.Windows.Forms.Panel();
            this.lblEditar = new System.Windows.Forms.Label();
            this.lblNombreAct = new System.Windows.Forms.Label();
            this.txtNombreAct = new System.Windows.Forms.TextBox();
            this.lblDuiAct = new System.Windows.Forms.Label();
            this.mskDuiAct = new System.Windows.Forms.MaskedTextBox();
            this.lblFechaNacimientoAct = new System.Windows.Forms.Label();
            this.dtpFechaNacimientoAct = new System.Windows.Forms.DateTimePicker();
            this.lblGeneroAct = new System.Windows.Forms.Label();
            this.cmbGeneroAct = new System.Windows.Forms.ComboBox();
            this.lblTelefonoAct = new System.Windows.Forms.Label();
            this.mskTelefonoAct = new System.Windows.Forms.MaskedTextBox();
            this.lblDireccionAct = new System.Windows.Forms.Label();
            this.txtDireccionAct = new System.Windows.Forms.TextBox();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lblLista = new System.Windows.Forms.Label();
            this.dgvPacientes = new System.Windows.Forms.DataGridView();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabControl1.SuspendLayout();
            this.tpRegistrar.SuspendLayout();
            this.pnlRegistrar.SuspendLayout();
            this.pnlLineaRegistrar.SuspendLayout();
            this.tpVer.SuspendLayout();
            this.pnlEditar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacientes)).BeginInit();
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
            // pnlRegistrar
            // 
            this.pnlRegistrar.Controls.Add(this.lblTituloRegistrar);
            this.pnlRegistrar.Controls.Add(this.lblSubRegistrar);
            this.pnlRegistrar.Controls.Add(this.pnlLineaRegistrar);
            this.pnlRegistrar.Controls.Add(this.lblNombre);
            this.pnlRegistrar.Controls.Add(this.txtNombre);
            this.pnlRegistrar.Controls.Add(this.lblDui);
            this.pnlRegistrar.Controls.Add(this.mskDui);
            this.pnlRegistrar.Controls.Add(this.lblFechaNacimiento);
            this.pnlRegistrar.Controls.Add(this.dtpFechaNacimiento);
            this.pnlRegistrar.Controls.Add(this.lblGenero);
            this.pnlRegistrar.Controls.Add(this.cmbGenero);
            this.pnlRegistrar.Controls.Add(this.lblTelefono);
            this.pnlRegistrar.Controls.Add(this.mskTelefono);
            this.pnlRegistrar.Controls.Add(this.lblDireccion);
            this.pnlRegistrar.Controls.Add(this.txtDireccion);
            this.pnlRegistrar.Controls.Add(this.btnRegistrar);
            this.pnlRegistrar.BackColor = System.Drawing.Color.White;
            this.pnlRegistrar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlRegistrar.Location = new System.Drawing.Point(201, 105);
            this.pnlRegistrar.Name = "pnlRegistrar";
            this.pnlRegistrar.Size = new System.Drawing.Size(690, 392);
            this.pnlRegistrar.TabIndex = 2;
            // 
            // lblTituloRegistrar
            // 
            this.lblTituloRegistrar.AutoSize = true;
            this.lblTituloRegistrar.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTituloRegistrar.ForeColor = System.Drawing.Color.FromArgb(((43)), ((48)), ((59)));
            this.lblTituloRegistrar.Location = new System.Drawing.Point(27, 22);
            this.lblTituloRegistrar.Name = "lblTituloRegistrar";
            this.lblTituloRegistrar.TabIndex = 3;
            this.lblTituloRegistrar.Text = "Registrar paciente";
            // 
            // lblSubRegistrar
            // 
            this.lblSubRegistrar.AutoSize = true;
            this.lblSubRegistrar.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSubRegistrar.ForeColor = System.Drawing.Color.FromArgb(((120)), ((128)), ((140)));
            this.lblSubRegistrar.Location = new System.Drawing.Point(30, 62);
            this.lblSubRegistrar.Name = "lblSubRegistrar";
            this.lblSubRegistrar.TabIndex = 4;
            this.lblSubRegistrar.Text = "Los campos con * son obligatorios.";
            // 
            // pnlLineaRegistrar
            // 
            this.pnlLineaRegistrar.BackColor = System.Drawing.Color.FromArgb(((41)), ((182)), ((182)));
            this.pnlLineaRegistrar.Location = new System.Drawing.Point(30, 88);
            this.pnlLineaRegistrar.Name = "pnlLineaRegistrar";
            this.pnlLineaRegistrar.Size = new System.Drawing.Size(630, 2);
            this.pnlLineaRegistrar.TabIndex = 5;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblNombre.ForeColor = System.Drawing.Color.FromArgb(((120)), ((128)), ((140)));
            this.lblNombre.Location = new System.Drawing.Point(30, 105);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.TabIndex = 6;
            this.lblNombre.Text = "NOMBRE COMPLETO *";
            // 
            // txtNombre
            // 
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombre.MaxLength = 100;
            this.txtNombre.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtNombre.Location = new System.Drawing.Point(30, 126);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(300, 28);
            this.txtNombre.TabIndex = 7;
            // 
            // lblDui
            // 
            this.lblDui.AutoSize = true;
            this.lblDui.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblDui.ForeColor = System.Drawing.Color.FromArgb(((120)), ((128)), ((140)));
            this.lblDui.Location = new System.Drawing.Point(360, 105);
            this.lblDui.Name = "lblDui";
            this.lblDui.TabIndex = 8;
            this.lblDui.Text = "DUI (OPCIONAL)";
            // 
            // mskDui
            // 
            this.mskDui.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mskDui.Mask = "00000000-0";
            this.mskDui.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.mskDui.Location = new System.Drawing.Point(360, 126);
            this.mskDui.Name = "mskDui";
            this.mskDui.Size = new System.Drawing.Size(300, 28);
            this.mskDui.TabIndex = 9;
            // 
            // lblFechaNacimiento
            // 
            this.lblFechaNacimiento.AutoSize = true;
            this.lblFechaNacimiento.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblFechaNacimiento.ForeColor = System.Drawing.Color.FromArgb(((120)), ((128)), ((140)));
            this.lblFechaNacimiento.Location = new System.Drawing.Point(30, 172);
            this.lblFechaNacimiento.Name = "lblFechaNacimiento";
            this.lblFechaNacimiento.TabIndex = 10;
            this.lblFechaNacimiento.Text = "FECHA DE NACIMIENTO *";
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaNacimiento.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(30, 193);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(300, 28);
            this.dtpFechaNacimiento.TabIndex = 11;
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblGenero.ForeColor = System.Drawing.Color.FromArgb(((120)), ((128)), ((140)));
            this.lblGenero.Location = new System.Drawing.Point(360, 172);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.TabIndex = 12;
            this.lblGenero.Text = "GÉNERO *";
            // 
            // cmbGenero
            // 
            this.cmbGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGenero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbGenero.FormattingEnabled = true;
            this.cmbGenero.Items.AddRange(new object[] {
            "Masculino",
            "Femenino"});
            this.cmbGenero.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.cmbGenero.Location = new System.Drawing.Point(360, 193);
            this.cmbGenero.Name = "cmbGenero";
            this.cmbGenero.Size = new System.Drawing.Size(300, 28);
            this.cmbGenero.TabIndex = 13;
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTelefono.ForeColor = System.Drawing.Color.FromArgb(((120)), ((128)), ((140)));
            this.lblTelefono.Location = new System.Drawing.Point(30, 239);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.TabIndex = 14;
            this.lblTelefono.Text = "TELÉFONO *";
            // 
            // mskTelefono
            // 
            this.mskTelefono.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mskTelefono.Mask = "0000-0000";
            this.mskTelefono.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.mskTelefono.Location = new System.Drawing.Point(30, 260);
            this.mskTelefono.Name = "mskTelefono";
            this.mskTelefono.Size = new System.Drawing.Size(300, 28);
            this.mskTelefono.TabIndex = 15;
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblDireccion.ForeColor = System.Drawing.Color.FromArgb(((120)), ((128)), ((140)));
            this.lblDireccion.Location = new System.Drawing.Point(360, 239);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.TabIndex = 16;
            this.lblDireccion.Text = "DIRECCIÓN";
            // 
            // txtDireccion
            // 
            this.txtDireccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDireccion.MaxLength = 200;
            this.txtDireccion.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtDireccion.Location = new System.Drawing.Point(360, 260);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(300, 28);
            this.txtDireccion.TabIndex = 17;
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
            this.btnRegistrar.Location = new System.Drawing.Point(460, 316);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(200, 46);
            this.btnRegistrar.TabIndex = 18;
            this.btnRegistrar.Text = "✔  Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // tpVer
            // 
            this.tpVer.Controls.Add(this.pnlEditar);
            this.tpVer.Controls.Add(this.lblLista);
            this.tpVer.Controls.Add(this.dgvPacientes);
            this.tpVer.BackColor = System.Drawing.Color.FromArgb(((245)), ((247)), ((250)));
            this.tpVer.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tpVer.Padding = new System.Windows.Forms.Padding(3);
            this.tpVer.Location = new System.Drawing.Point(4, 44);
            this.tpVer.Name = "tpVer";
            this.tpVer.Size = new System.Drawing.Size(1092, 602);
            this.tpVer.TabIndex = 19;
            this.tpVer.Text = "Ver / Actualizar / Eliminar";
            this.tpVer.UseVisualStyleBackColor = false;
            // 
            // pnlEditar
            // 
            this.pnlEditar.Controls.Add(this.lblEditar);
            this.pnlEditar.Controls.Add(this.lblNombreAct);
            this.pnlEditar.Controls.Add(this.txtNombreAct);
            this.pnlEditar.Controls.Add(this.lblDuiAct);
            this.pnlEditar.Controls.Add(this.mskDuiAct);
            this.pnlEditar.Controls.Add(this.lblFechaNacimientoAct);
            this.pnlEditar.Controls.Add(this.dtpFechaNacimientoAct);
            this.pnlEditar.Controls.Add(this.lblGeneroAct);
            this.pnlEditar.Controls.Add(this.cmbGeneroAct);
            this.pnlEditar.Controls.Add(this.lblTelefonoAct);
            this.pnlEditar.Controls.Add(this.mskTelefonoAct);
            this.pnlEditar.Controls.Add(this.lblDireccionAct);
            this.pnlEditar.Controls.Add(this.txtDireccionAct);
            this.pnlEditar.Controls.Add(this.btnActualizar);
            this.pnlEditar.Controls.Add(this.btnEliminar);
            this.pnlEditar.BackColor = System.Drawing.Color.White;
            this.pnlEditar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlEditar.Location = new System.Drawing.Point(20, 20);
            this.pnlEditar.Name = "pnlEditar";
            this.pnlEditar.Size = new System.Drawing.Size(310, 562);
            this.pnlEditar.TabIndex = 20;
            // 
            // lblEditar
            // 
            this.lblEditar.AutoSize = true;
            this.lblEditar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblEditar.ForeColor = System.Drawing.Color.FromArgb(((43)), ((48)), ((59)));
            this.lblEditar.Location = new System.Drawing.Point(20, 18);
            this.lblEditar.Name = "lblEditar";
            this.lblEditar.TabIndex = 21;
            this.lblEditar.Text = "Editar seleccionado";
            // 
            // lblNombreAct
            // 
            this.lblNombreAct.AutoSize = true;
            this.lblNombreAct.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblNombreAct.ForeColor = System.Drawing.Color.FromArgb(((120)), ((128)), ((140)));
            this.lblNombreAct.Location = new System.Drawing.Point(20, 60);
            this.lblNombreAct.Name = "lblNombreAct";
            this.lblNombreAct.TabIndex = 22;
            this.lblNombreAct.Text = "NOMBRE COMPLETO";
            // 
            // txtNombreAct
            // 
            this.txtNombreAct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombreAct.MaxLength = 100;
            this.txtNombreAct.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtNombreAct.Location = new System.Drawing.Point(20, 81);
            this.txtNombreAct.Name = "txtNombreAct";
            this.txtNombreAct.Size = new System.Drawing.Size(270, 28);
            this.txtNombreAct.TabIndex = 23;
            // 
            // lblDuiAct
            // 
            this.lblDuiAct.AutoSize = true;
            this.lblDuiAct.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblDuiAct.ForeColor = System.Drawing.Color.FromArgb(((120)), ((128)), ((140)));
            this.lblDuiAct.Location = new System.Drawing.Point(20, 125);
            this.lblDuiAct.Name = "lblDuiAct";
            this.lblDuiAct.TabIndex = 24;
            this.lblDuiAct.Text = "DUI (OPCIONAL)";
            // 
            // mskDuiAct
            // 
            this.mskDuiAct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mskDuiAct.Mask = "00000000-0";
            this.mskDuiAct.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.mskDuiAct.Location = new System.Drawing.Point(20, 146);
            this.mskDuiAct.Name = "mskDuiAct";
            this.mskDuiAct.Size = new System.Drawing.Size(270, 28);
            this.mskDuiAct.TabIndex = 25;
            // 
            // lblFechaNacimientoAct
            // 
            this.lblFechaNacimientoAct.AutoSize = true;
            this.lblFechaNacimientoAct.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblFechaNacimientoAct.ForeColor = System.Drawing.Color.FromArgb(((120)), ((128)), ((140)));
            this.lblFechaNacimientoAct.Location = new System.Drawing.Point(20, 190);
            this.lblFechaNacimientoAct.Name = "lblFechaNacimientoAct";
            this.lblFechaNacimientoAct.TabIndex = 26;
            this.lblFechaNacimientoAct.Text = "FECHA DE NACIMIENTO";
            // 
            // dtpFechaNacimientoAct
            // 
            this.dtpFechaNacimientoAct.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaNacimientoAct.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.dtpFechaNacimientoAct.Location = new System.Drawing.Point(20, 211);
            this.dtpFechaNacimientoAct.Name = "dtpFechaNacimientoAct";
            this.dtpFechaNacimientoAct.Size = new System.Drawing.Size(270, 28);
            this.dtpFechaNacimientoAct.TabIndex = 27;
            // 
            // lblGeneroAct
            // 
            this.lblGeneroAct.AutoSize = true;
            this.lblGeneroAct.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblGeneroAct.ForeColor = System.Drawing.Color.FromArgb(((120)), ((128)), ((140)));
            this.lblGeneroAct.Location = new System.Drawing.Point(20, 255);
            this.lblGeneroAct.Name = "lblGeneroAct";
            this.lblGeneroAct.TabIndex = 28;
            this.lblGeneroAct.Text = "GÉNERO";
            // 
            // cmbGeneroAct
            // 
            this.cmbGeneroAct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGeneroAct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbGeneroAct.FormattingEnabled = true;
            this.cmbGeneroAct.Items.AddRange(new object[] {
            "Masculino",
            "Femenino"});
            this.cmbGeneroAct.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.cmbGeneroAct.Location = new System.Drawing.Point(20, 276);
            this.cmbGeneroAct.Name = "cmbGeneroAct";
            this.cmbGeneroAct.Size = new System.Drawing.Size(270, 28);
            this.cmbGeneroAct.TabIndex = 29;
            // 
            // lblTelefonoAct
            // 
            this.lblTelefonoAct.AutoSize = true;
            this.lblTelefonoAct.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTelefonoAct.ForeColor = System.Drawing.Color.FromArgb(((120)), ((128)), ((140)));
            this.lblTelefonoAct.Location = new System.Drawing.Point(20, 320);
            this.lblTelefonoAct.Name = "lblTelefonoAct";
            this.lblTelefonoAct.TabIndex = 30;
            this.lblTelefonoAct.Text = "TELÉFONO";
            // 
            // mskTelefonoAct
            // 
            this.mskTelefonoAct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mskTelefonoAct.Mask = "0000-0000";
            this.mskTelefonoAct.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.mskTelefonoAct.Location = new System.Drawing.Point(20, 341);
            this.mskTelefonoAct.Name = "mskTelefonoAct";
            this.mskTelefonoAct.Size = new System.Drawing.Size(270, 28);
            this.mskTelefonoAct.TabIndex = 31;
            // 
            // lblDireccionAct
            // 
            this.lblDireccionAct.AutoSize = true;
            this.lblDireccionAct.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblDireccionAct.ForeColor = System.Drawing.Color.FromArgb(((120)), ((128)), ((140)));
            this.lblDireccionAct.Location = new System.Drawing.Point(20, 385);
            this.lblDireccionAct.Name = "lblDireccionAct";
            this.lblDireccionAct.TabIndex = 32;
            this.lblDireccionAct.Text = "DIRECCIÓN";
            // 
            // txtDireccionAct
            // 
            this.txtDireccionAct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDireccionAct.MaxLength = 200;
            this.txtDireccionAct.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtDireccionAct.Location = new System.Drawing.Point(20, 406);
            this.txtDireccionAct.Name = "txtDireccionAct";
            this.txtDireccionAct.Size = new System.Drawing.Size(270, 28);
            this.txtDireccionAct.TabIndex = 33;
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
            this.btnActualizar.Location = new System.Drawing.Point(20, 456);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(130, 42);
            this.btnActualizar.TabIndex = 34;
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
            this.btnEliminar.Location = new System.Drawing.Point(160, 456);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(130, 42);
            this.btnEliminar.TabIndex = 35;
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
            this.lblLista.TabIndex = 36;
            this.lblLista.Text = "Lista de pacientes";
            // 
            // dgvPacientes
            // 
            this.dgvPacientes.AllowUserToAddRows = false;
            this.dgvPacientes.AllowUserToDeleteRows = false;
            this.dgvPacientes.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((248)), ((250)), ((252)));
            this.dgvPacientes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPacientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPacientes.BackgroundColor = System.Drawing.Color.White;
            this.dgvPacientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPacientes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvPacientes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((43)), ((48)), ((59)));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((43)), ((48)), ((59)));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPacientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPacientes.ColumnHeadersHeight = 42;
            this.dgvPacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((52)), ((58)), ((70)));
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((41)), ((182)), ((182)));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPacientes.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPacientes.EnableHeadersVisualStyles = false;
            this.dgvPacientes.GridColor = System.Drawing.Color.FromArgb(((225)), ((230)), ((236)));
            this.dgvPacientes.MultiSelect = false;
            this.dgvPacientes.ReadOnly = true;
            this.dgvPacientes.RowHeadersVisible = false;
            this.dgvPacientes.RowTemplate.Height = 34;
            this.dgvPacientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPacientes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPacientes.Location = new System.Drawing.Point(350, 64);
            this.dgvPacientes.Name = "dgvPacientes";
            this.dgvPacientes.Size = new System.Drawing.Size(722, 518);
            this.dgvPacientes.TabIndex = 37;
            this.dgvPacientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPacientes_CellClick);
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // frmPacientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((245)), ((247)), ((250)));
            this.ClientSize = new System.Drawing.Size(1100, 650);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ForeColor = System.Drawing.Color.FromArgb(((52)), ((58)), ((70)));
            this.Name = "frmPacientes";
            this.Text = "pacientes";
            this.Load += new System.EventHandler(this.frmPacientes_Load);
            this.pnlEditar.ResumeLayout(false);
            this.tpVer.ResumeLayout(false);
            this.pnlLineaRegistrar.ResumeLayout(false);
            this.pnlRegistrar.ResumeLayout(false);
            this.tpRegistrar.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tpRegistrar.PerformLayout();
            this.pnlRegistrar.PerformLayout();
            this.pnlLineaRegistrar.PerformLayout();
            this.tpVer.PerformLayout();
            this.pnlEditar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpRegistrar;
        private System.Windows.Forms.Panel pnlRegistrar;
        private System.Windows.Forms.Label lblTituloRegistrar;
        private System.Windows.Forms.Label lblSubRegistrar;
        private System.Windows.Forms.Panel pnlLineaRegistrar;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblDui;
        private System.Windows.Forms.MaskedTextBox mskDui;
        private System.Windows.Forms.Label lblFechaNacimiento;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.ComboBox cmbGenero;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.MaskedTextBox mskTelefono;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.TabPage tpVer;
        private System.Windows.Forms.Panel pnlEditar;
        private System.Windows.Forms.Label lblEditar;
        private System.Windows.Forms.Label lblNombreAct;
        private System.Windows.Forms.TextBox txtNombreAct;
        private System.Windows.Forms.Label lblDuiAct;
        private System.Windows.Forms.MaskedTextBox mskDuiAct;
        private System.Windows.Forms.Label lblFechaNacimientoAct;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimientoAct;
        private System.Windows.Forms.Label lblGeneroAct;
        private System.Windows.Forms.ComboBox cmbGeneroAct;
        private System.Windows.Forms.Label lblTelefonoAct;
        private System.Windows.Forms.MaskedTextBox mskTelefonoAct;
        private System.Windows.Forms.Label lblDireccionAct;
        private System.Windows.Forms.TextBox txtDireccionAct;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lblLista;
        private System.Windows.Forms.DataGridView dgvPacientes;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
