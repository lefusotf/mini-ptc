namespace Vista.Gestion
{
    partial class frmUsuarios
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
            this.lblUsuario = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblNombreCompleto = new System.Windows.Forms.Label();
            this.txtNombreCompleto = new System.Windows.Forms.TextBox();
            this.lblClave = new System.Windows.Forms.Label();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.lblRol = new System.Windows.Forms.Label();
            this.cmbRol = new System.Windows.Forms.ComboBox();
            this.lblActivo = new System.Windows.Forms.Label();
            this.chkActivo = new System.Windows.Forms.CheckBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.tpVer = new System.Windows.Forms.TabPage();
            this.pnlEditar = new System.Windows.Forms.Panel();
            this.lblEditar = new System.Windows.Forms.Label();
            this.lblUsuarioAct = new System.Windows.Forms.Label();
            this.txtUsuarioAct = new System.Windows.Forms.TextBox();
            this.lblNombreCompletoAct = new System.Windows.Forms.Label();
            this.txtNombreCompletoAct = new System.Windows.Forms.TextBox();
            this.lblClaveAct = new System.Windows.Forms.Label();
            this.txtClaveAct = new System.Windows.Forms.TextBox();
            this.lblRolAct = new System.Windows.Forms.Label();
            this.cmbRolAct = new System.Windows.Forms.ComboBox();
            this.lblActivoAct = new System.Windows.Forms.Label();
            this.chkActivoAct = new System.Windows.Forms.CheckBox();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lblLista = new System.Windows.Forms.Label();
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabControl1.SuspendLayout();
            this.tpRegistrar.SuspendLayout();
            this.pnlRegistrar.SuspendLayout();
            this.tpVer.SuspendLayout();
            this.pnlEditar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
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
            this.lblTituloRegistrar.Text = "Registrar usuario";
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
            this.pnlRegistrar.Controls.Add(this.lblUsuario);
            this.pnlRegistrar.Controls.Add(this.txtUsuario);
            this.pnlRegistrar.Controls.Add(this.lblNombreCompleto);
            this.pnlRegistrar.Controls.Add(this.txtNombreCompleto);
            this.pnlRegistrar.Controls.Add(this.lblClave);
            this.pnlRegistrar.Controls.Add(this.txtClave);
            this.pnlRegistrar.Controls.Add(this.lblRol);
            this.pnlRegistrar.Controls.Add(this.cmbRol);
            this.pnlRegistrar.Controls.Add(this.lblActivo);
            this.pnlRegistrar.Controls.Add(this.chkActivo);
            this.pnlRegistrar.Controls.Add(this.btnRegistrar);
            this.pnlRegistrar.BackColor = System.Drawing.Color.White;
            this.pnlRegistrar.Location = new System.Drawing.Point(30, 95);
            this.pnlRegistrar.Name = "pnlRegistrar";
            this.pnlRegistrar.Size = new System.Drawing.Size(690, 317);
            this.pnlRegistrar.TabIndex = 4;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblUsuario.ForeColor = System.Drawing.Color.FromArgb(((120)), ((128)), ((140)));
            this.lblUsuario.Location = new System.Drawing.Point(30, 30);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.TabIndex = 5;
            this.lblUsuario.Text = "USUARIO *";
            // 
            // txtUsuario
            // 
            this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsuario.MaxLength = 50;
            this.txtUsuario.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtUsuario.Location = new System.Drawing.Point(30, 51);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(300, 28);
            this.txtUsuario.TabIndex = 6;
            // 
            // lblNombreCompleto
            // 
            this.lblNombreCompleto.AutoSize = true;
            this.lblNombreCompleto.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblNombreCompleto.ForeColor = System.Drawing.Color.FromArgb(((120)), ((128)), ((140)));
            this.lblNombreCompleto.Location = new System.Drawing.Point(360, 30);
            this.lblNombreCompleto.Name = "lblNombreCompleto";
            this.lblNombreCompleto.TabIndex = 7;
            this.lblNombreCompleto.Text = "NOMBRE COMPLETO *";
            // 
            // txtNombreCompleto
            // 
            this.txtNombreCompleto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombreCompleto.MaxLength = 100;
            this.txtNombreCompleto.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtNombreCompleto.Location = new System.Drawing.Point(360, 51);
            this.txtNombreCompleto.Name = "txtNombreCompleto";
            this.txtNombreCompleto.Size = new System.Drawing.Size(300, 28);
            this.txtNombreCompleto.TabIndex = 8;
            // 
            // lblClave
            // 
            this.lblClave.AutoSize = true;
            this.lblClave.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblClave.ForeColor = System.Drawing.Color.FromArgb(((120)), ((128)), ((140)));
            this.lblClave.Location = new System.Drawing.Point(30, 97);
            this.lblClave.Name = "lblClave";
            this.lblClave.TabIndex = 9;
            this.lblClave.Text = "CONTRASEÑA * (MÍNIMO 8)";
            // 
            // txtClave
            // 
            this.txtClave.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtClave.MaxLength = 50;
            this.txtClave.UseSystemPasswordChar = true;
            this.txtClave.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtClave.Location = new System.Drawing.Point(30, 118);
            this.txtClave.Name = "txtClave";
            this.txtClave.Size = new System.Drawing.Size(300, 28);
            this.txtClave.TabIndex = 10;
            // 
            // lblRol
            // 
            this.lblRol.AutoSize = true;
            this.lblRol.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblRol.ForeColor = System.Drawing.Color.FromArgb(((120)), ((128)), ((140)));
            this.lblRol.Location = new System.Drawing.Point(360, 97);
            this.lblRol.Name = "lblRol";
            this.lblRol.TabIndex = 11;
            this.lblRol.Text = "ROL *";
            // 
            // cmbRol
            // 
            this.cmbRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbRol.FormattingEnabled = true;
            this.cmbRol.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.cmbRol.Location = new System.Drawing.Point(360, 118);
            this.cmbRol.Name = "cmbRol";
            this.cmbRol.Size = new System.Drawing.Size(300, 28);
            this.cmbRol.TabIndex = 12;
            // 
            // lblActivo
            // 
            this.lblActivo.AutoSize = true;
            this.lblActivo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblActivo.ForeColor = System.Drawing.Color.FromArgb(((120)), ((128)), ((140)));
            this.lblActivo.Location = new System.Drawing.Point(30, 164);
            this.lblActivo.Name = "lblActivo";
            this.lblActivo.TabIndex = 13;
            this.lblActivo.Text = "ESTADO";
            // 
            // chkActivo
            // 
            this.chkActivo.AutoSize = true;
            this.chkActivo.Checked = true;
            this.chkActivo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkActivo.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.chkActivo.Location = new System.Drawing.Point(30, 187);
            this.chkActivo.Name = "chkActivo";
            this.chkActivo.TabIndex = 14;
            this.chkActivo.Text = "Activo";
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
            this.btnRegistrar.Location = new System.Drawing.Point(460, 241);
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
            this.tpVer.Controls.Add(this.dgvUsuarios);
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
            this.pnlEditar.Controls.Add(this.lblUsuarioAct);
            this.pnlEditar.Controls.Add(this.txtUsuarioAct);
            this.pnlEditar.Controls.Add(this.lblNombreCompletoAct);
            this.pnlEditar.Controls.Add(this.txtNombreCompletoAct);
            this.pnlEditar.Controls.Add(this.lblClaveAct);
            this.pnlEditar.Controls.Add(this.txtClaveAct);
            this.pnlEditar.Controls.Add(this.lblRolAct);
            this.pnlEditar.Controls.Add(this.cmbRolAct);
            this.pnlEditar.Controls.Add(this.lblActivoAct);
            this.pnlEditar.Controls.Add(this.chkActivoAct);
            this.pnlEditar.Controls.Add(this.btnActualizar);
            this.pnlEditar.Controls.Add(this.btnEliminar);
            this.pnlEditar.BackColor = System.Drawing.Color.White;
            this.pnlEditar.Location = new System.Drawing.Point(20, 20);
            this.pnlEditar.Name = "pnlEditar";
            this.pnlEditar.Size = new System.Drawing.Size(310, 455);
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
            // lblUsuarioAct
            // 
            this.lblUsuarioAct.AutoSize = true;
            this.lblUsuarioAct.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblUsuarioAct.ForeColor = System.Drawing.Color.FromArgb(((120)), ((128)), ((140)));
            this.lblUsuarioAct.Location = new System.Drawing.Point(20, 60);
            this.lblUsuarioAct.Name = "lblUsuarioAct";
            this.lblUsuarioAct.TabIndex = 19;
            this.lblUsuarioAct.Text = "USUARIO";
            // 
            // txtUsuarioAct
            // 
            this.txtUsuarioAct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsuarioAct.MaxLength = 50;
            this.txtUsuarioAct.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtUsuarioAct.Location = new System.Drawing.Point(20, 81);
            this.txtUsuarioAct.Name = "txtUsuarioAct";
            this.txtUsuarioAct.Size = new System.Drawing.Size(270, 28);
            this.txtUsuarioAct.TabIndex = 20;
            // 
            // lblNombreCompletoAct
            // 
            this.lblNombreCompletoAct.AutoSize = true;
            this.lblNombreCompletoAct.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblNombreCompletoAct.ForeColor = System.Drawing.Color.FromArgb(((120)), ((128)), ((140)));
            this.lblNombreCompletoAct.Location = new System.Drawing.Point(20, 125);
            this.lblNombreCompletoAct.Name = "lblNombreCompletoAct";
            this.lblNombreCompletoAct.TabIndex = 21;
            this.lblNombreCompletoAct.Text = "NOMBRE COMPLETO";
            // 
            // txtNombreCompletoAct
            // 
            this.txtNombreCompletoAct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombreCompletoAct.MaxLength = 100;
            this.txtNombreCompletoAct.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtNombreCompletoAct.Location = new System.Drawing.Point(20, 146);
            this.txtNombreCompletoAct.Name = "txtNombreCompletoAct";
            this.txtNombreCompletoAct.Size = new System.Drawing.Size(270, 28);
            this.txtNombreCompletoAct.TabIndex = 22;
            // 
            // lblClaveAct
            // 
            this.lblClaveAct.AutoSize = true;
            this.lblClaveAct.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblClaveAct.ForeColor = System.Drawing.Color.FromArgb(((120)), ((128)), ((140)));
            this.lblClaveAct.Location = new System.Drawing.Point(20, 190);
            this.lblClaveAct.Name = "lblClaveAct";
            this.lblClaveAct.TabIndex = 23;
            this.lblClaveAct.Text = "NUEVA CONTRASEÑA (OPCIONAL)";
            // 
            // txtClaveAct
            // 
            this.txtClaveAct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtClaveAct.MaxLength = 50;
            this.txtClaveAct.UseSystemPasswordChar = true;
            this.txtClaveAct.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtClaveAct.Location = new System.Drawing.Point(20, 211);
            this.txtClaveAct.Name = "txtClaveAct";
            this.txtClaveAct.Size = new System.Drawing.Size(270, 28);
            this.txtClaveAct.TabIndex = 24;
            // 
            // lblRolAct
            // 
            this.lblRolAct.AutoSize = true;
            this.lblRolAct.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblRolAct.ForeColor = System.Drawing.Color.FromArgb(((120)), ((128)), ((140)));
            this.lblRolAct.Location = new System.Drawing.Point(20, 255);
            this.lblRolAct.Name = "lblRolAct";
            this.lblRolAct.TabIndex = 25;
            this.lblRolAct.Text = "ROL";
            // 
            // cmbRolAct
            // 
            this.cmbRolAct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRolAct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbRolAct.FormattingEnabled = true;
            this.cmbRolAct.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.cmbRolAct.Location = new System.Drawing.Point(20, 276);
            this.cmbRolAct.Name = "cmbRolAct";
            this.cmbRolAct.Size = new System.Drawing.Size(270, 28);
            this.cmbRolAct.TabIndex = 26;
            // 
            // lblActivoAct
            // 
            this.lblActivoAct.AutoSize = true;
            this.lblActivoAct.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblActivoAct.ForeColor = System.Drawing.Color.FromArgb(((120)), ((128)), ((140)));
            this.lblActivoAct.Location = new System.Drawing.Point(20, 320);
            this.lblActivoAct.Name = "lblActivoAct";
            this.lblActivoAct.TabIndex = 27;
            this.lblActivoAct.Text = "ESTADO";
            // 
            // chkActivoAct
            // 
            this.chkActivoAct.AutoSize = true;
            this.chkActivoAct.Checked = true;
            this.chkActivoAct.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkActivoAct.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.chkActivoAct.Location = new System.Drawing.Point(20, 343);
            this.chkActivoAct.Name = "chkActivoAct";
            this.chkActivoAct.TabIndex = 28;
            this.chkActivoAct.Text = "Activo";
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
            this.btnActualizar.Location = new System.Drawing.Point(20, 391);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(130, 42);
            this.btnActualizar.TabIndex = 29;
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
            this.btnEliminar.Location = new System.Drawing.Point(160, 391);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(130, 42);
            this.btnEliminar.TabIndex = 30;
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
            this.lblLista.TabIndex = 31;
            this.lblLista.Text = "Lista de usuarios";
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.AllowUserToAddRows = false;
            this.dgvUsuarios.AllowUserToDeleteRows = false;
            this.dgvUsuarios.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((248)), ((250)), ((252)));
            this.dgvUsuarios.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUsuarios.BackgroundColor = System.Drawing.Color.White;
            this.dgvUsuarios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvUsuarios.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvUsuarios.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((43)), ((48)), ((59)));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((43)), ((48)), ((59)));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUsuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvUsuarios.ColumnHeadersHeight = 42;
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((52)), ((58)), ((70)));
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((41)), ((182)), ((182)));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvUsuarios.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvUsuarios.EnableHeadersVisualStyles = false;
            this.dgvUsuarios.GridColor = System.Drawing.Color.FromArgb(((225)), ((230)), ((236)));
            this.dgvUsuarios.MultiSelect = false;
            this.dgvUsuarios.ReadOnly = true;
            this.dgvUsuarios.RowHeadersVisible = false;
            this.dgvUsuarios.RowTemplate.Height = 34;
            this.dgvUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsuarios.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvUsuarios.Location = new System.Drawing.Point(350, 64);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.Size = new System.Drawing.Size(722, 518);
            this.dgvUsuarios.TabIndex = 32;
            this.dgvUsuarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsuarios_CellClick);
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // frmUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((245)), ((247)), ((250)));
            this.ClientSize = new System.Drawing.Size(1100, 650);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ForeColor = System.Drawing.Color.FromArgb(((52)), ((58)), ((70)));
            this.Name = "frmUsuarios";
            this.Text = "usuarios";
            this.Load += new System.EventHandler(this.frmUsuarios_Load);
            this.pnlEditar.ResumeLayout(false);
            this.tpVer.ResumeLayout(false);
            this.pnlRegistrar.ResumeLayout(false);
            this.tpRegistrar.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tpRegistrar.PerformLayout();
            this.pnlRegistrar.PerformLayout();
            this.tpVer.PerformLayout();
            this.pnlEditar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
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
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lblNombreCompleto;
        private System.Windows.Forms.TextBox txtNombreCompleto;
        private System.Windows.Forms.Label lblClave;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.Label lblRol;
        private System.Windows.Forms.ComboBox cmbRol;
        private System.Windows.Forms.Label lblActivo;
        private System.Windows.Forms.CheckBox chkActivo;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.TabPage tpVer;
        private System.Windows.Forms.Panel pnlEditar;
        private System.Windows.Forms.Label lblEditar;
        private System.Windows.Forms.Label lblUsuarioAct;
        private System.Windows.Forms.TextBox txtUsuarioAct;
        private System.Windows.Forms.Label lblNombreCompletoAct;
        private System.Windows.Forms.TextBox txtNombreCompletoAct;
        private System.Windows.Forms.Label lblClaveAct;
        private System.Windows.Forms.TextBox txtClaveAct;
        private System.Windows.Forms.Label lblRolAct;
        private System.Windows.Forms.ComboBox cmbRolAct;
        private System.Windows.Forms.Label lblActivoAct;
        private System.Windows.Forms.CheckBox chkActivoAct;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lblLista;
        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
