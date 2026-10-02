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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpRegistrar = new System.Windows.Forms.TabPage();
            this.lblTituloRegistrar = new System.Windows.Forms.Label();
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
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabControl1.SuspendLayout();
            this.tpRegistrar.SuspendLayout();
            this.tpVer.SuspendLayout();
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
            this.tpRegistrar.Controls.Add(this.lblUsuario);
            this.tpRegistrar.Controls.Add(this.txtUsuario);
            this.tpRegistrar.Controls.Add(this.lblNombreCompleto);
            this.tpRegistrar.Controls.Add(this.txtNombreCompleto);
            this.tpRegistrar.Controls.Add(this.lblClave);
            this.tpRegistrar.Controls.Add(this.txtClave);
            this.tpRegistrar.Controls.Add(this.lblRol);
            this.tpRegistrar.Controls.Add(this.cmbRol);
            this.tpRegistrar.Controls.Add(this.lblActivo);
            this.tpRegistrar.Controls.Add(this.chkActivo);
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
            this.lblTituloRegistrar.Text = "Registrar Usuarios";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(40, 83);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.TabIndex = 3;
            this.lblUsuario.Text = "Usuario:";
            // 
            // txtUsuario
            // 
            this.txtUsuario.MaxLength = 50;
            this.txtUsuario.Location = new System.Drawing.Point(230, 80);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(320, 25);
            this.txtUsuario.TabIndex = 4;
            // 
            // lblNombreCompleto
            // 
            this.lblNombreCompleto.AutoSize = true;
            this.lblNombreCompleto.Location = new System.Drawing.Point(40, 123);
            this.lblNombreCompleto.Name = "lblNombreCompleto";
            this.lblNombreCompleto.TabIndex = 5;
            this.lblNombreCompleto.Text = "Nombre completo:";
            // 
            // txtNombreCompleto
            // 
            this.txtNombreCompleto.MaxLength = 100;
            this.txtNombreCompleto.Location = new System.Drawing.Point(230, 120);
            this.txtNombreCompleto.Name = "txtNombreCompleto";
            this.txtNombreCompleto.Size = new System.Drawing.Size(320, 25);
            this.txtNombreCompleto.TabIndex = 6;
            // 
            // lblClave
            // 
            this.lblClave.AutoSize = true;
            this.lblClave.Location = new System.Drawing.Point(40, 163);
            this.lblClave.Name = "lblClave";
            this.lblClave.TabIndex = 7;
            this.lblClave.Text = "Contraseña:";
            // 
            // txtClave
            // 
            this.txtClave.MaxLength = 50;
            this.txtClave.UseSystemPasswordChar = true;
            this.txtClave.Location = new System.Drawing.Point(230, 160);
            this.txtClave.Name = "txtClave";
            this.txtClave.Size = new System.Drawing.Size(320, 25);
            this.txtClave.TabIndex = 8;
            // 
            // lblRol
            // 
            this.lblRol.AutoSize = true;
            this.lblRol.Location = new System.Drawing.Point(40, 203);
            this.lblRol.Name = "lblRol";
            this.lblRol.TabIndex = 9;
            this.lblRol.Text = "Rol:";
            // 
            // cmbRol
            // 
            this.cmbRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRol.FormattingEnabled = true;
            this.cmbRol.Location = new System.Drawing.Point(230, 200);
            this.cmbRol.Name = "cmbRol";
            this.cmbRol.Size = new System.Drawing.Size(320, 25);
            this.cmbRol.TabIndex = 10;
            // 
            // lblActivo
            // 
            this.lblActivo.AutoSize = true;
            this.lblActivo.Location = new System.Drawing.Point(40, 243);
            this.lblActivo.Name = "lblActivo";
            this.lblActivo.TabIndex = 11;
            this.lblActivo.Text = "Estado:";
            // 
            // chkActivo
            // 
            this.chkActivo.AutoSize = true;
            this.chkActivo.Checked = true;
            this.chkActivo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkActivo.Location = new System.Drawing.Point(230, 240);
            this.chkActivo.Name = "chkActivo";
            this.chkActivo.Size = new System.Drawing.Size(320, 25);
            this.chkActivo.TabIndex = 12;
            this.chkActivo.Text = "Activo";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistrar.FlatAppearance.BorderSize = 0;
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrar.ForeColor = System.Drawing.Color.White;
            this.btnRegistrar.BackColor = System.Drawing.Color.FromArgb(((40)), ((167)), ((69)));
            this.btnRegistrar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnRegistrar.Location = new System.Drawing.Point(230, 290);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(320, 40);
            this.btnRegistrar.TabIndex = 13;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // tpVer
            // 
            this.tpVer.Controls.Add(this.lblUsuarioAct);
            this.tpVer.Controls.Add(this.txtUsuarioAct);
            this.tpVer.Controls.Add(this.lblNombreCompletoAct);
            this.tpVer.Controls.Add(this.txtNombreCompletoAct);
            this.tpVer.Controls.Add(this.lblClaveAct);
            this.tpVer.Controls.Add(this.txtClaveAct);
            this.tpVer.Controls.Add(this.lblRolAct);
            this.tpVer.Controls.Add(this.cmbRolAct);
            this.tpVer.Controls.Add(this.lblActivoAct);
            this.tpVer.Controls.Add(this.chkActivoAct);
            this.tpVer.Controls.Add(this.btnActualizar);
            this.tpVer.Controls.Add(this.btnEliminar);
            this.tpVer.Controls.Add(this.dgvUsuarios);
            this.tpVer.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tpVer.Padding = new System.Windows.Forms.Padding(3);
            this.tpVer.Location = new System.Drawing.Point(4, 39);
            this.tpVer.Name = "tpVer";
            this.tpVer.Size = new System.Drawing.Size(1092, 607);
            this.tpVer.TabIndex = 14;
            this.tpVer.Text = "Ver / Actualizar / Eliminar";
            this.tpVer.UseVisualStyleBackColor = true;
            // 
            // lblUsuarioAct
            // 
            this.lblUsuarioAct.AutoSize = true;
            this.lblUsuarioAct.Location = new System.Drawing.Point(20, 23);
            this.lblUsuarioAct.Name = "lblUsuarioAct";
            this.lblUsuarioAct.TabIndex = 15;
            this.lblUsuarioAct.Text = "Usuario:";
            // 
            // txtUsuarioAct
            // 
            this.txtUsuarioAct.MaxLength = 50;
            this.txtUsuarioAct.Location = new System.Drawing.Point(170, 20);
            this.txtUsuarioAct.Name = "txtUsuarioAct";
            this.txtUsuarioAct.Size = new System.Drawing.Size(250, 25);
            this.txtUsuarioAct.TabIndex = 16;
            // 
            // lblNombreCompletoAct
            // 
            this.lblNombreCompletoAct.AutoSize = true;
            this.lblNombreCompletoAct.Location = new System.Drawing.Point(20, 63);
            this.lblNombreCompletoAct.Name = "lblNombreCompletoAct";
            this.lblNombreCompletoAct.TabIndex = 17;
            this.lblNombreCompletoAct.Text = "Nombre completo:";
            // 
            // txtNombreCompletoAct
            // 
            this.txtNombreCompletoAct.MaxLength = 100;
            this.txtNombreCompletoAct.Location = new System.Drawing.Point(170, 60);
            this.txtNombreCompletoAct.Name = "txtNombreCompletoAct";
            this.txtNombreCompletoAct.Size = new System.Drawing.Size(250, 25);
            this.txtNombreCompletoAct.TabIndex = 18;
            // 
            // lblClaveAct
            // 
            this.lblClaveAct.AutoSize = true;
            this.lblClaveAct.Location = new System.Drawing.Point(20, 103);
            this.lblClaveAct.Name = "lblClaveAct";
            this.lblClaveAct.TabIndex = 19;
            this.lblClaveAct.Text = "Contraseña:";
            // 
            // txtClaveAct
            // 
            this.txtClaveAct.MaxLength = 50;
            this.txtClaveAct.UseSystemPasswordChar = true;
            this.txtClaveAct.Location = new System.Drawing.Point(170, 100);
            this.txtClaveAct.Name = "txtClaveAct";
            this.txtClaveAct.Size = new System.Drawing.Size(250, 25);
            this.txtClaveAct.TabIndex = 20;
            // 
            // lblRolAct
            // 
            this.lblRolAct.AutoSize = true;
            this.lblRolAct.Location = new System.Drawing.Point(20, 143);
            this.lblRolAct.Name = "lblRolAct";
            this.lblRolAct.TabIndex = 21;
            this.lblRolAct.Text = "Rol:";
            // 
            // cmbRolAct
            // 
            this.cmbRolAct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRolAct.FormattingEnabled = true;
            this.cmbRolAct.Location = new System.Drawing.Point(170, 140);
            this.cmbRolAct.Name = "cmbRolAct";
            this.cmbRolAct.Size = new System.Drawing.Size(250, 25);
            this.cmbRolAct.TabIndex = 22;
            // 
            // lblActivoAct
            // 
            this.lblActivoAct.AutoSize = true;
            this.lblActivoAct.Location = new System.Drawing.Point(20, 183);
            this.lblActivoAct.Name = "lblActivoAct";
            this.lblActivoAct.TabIndex = 23;
            this.lblActivoAct.Text = "Estado:";
            // 
            // chkActivoAct
            // 
            this.chkActivoAct.AutoSize = true;
            this.chkActivoAct.Checked = true;
            this.chkActivoAct.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkActivoAct.Location = new System.Drawing.Point(170, 180);
            this.chkActivoAct.Name = "chkActivoAct";
            this.chkActivoAct.Size = new System.Drawing.Size(250, 25);
            this.chkActivoAct.TabIndex = 24;
            this.chkActivoAct.Text = "Activo";
            // 
            // btnActualizar
            // 
            this.btnActualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActualizar.FlatAppearance.BorderSize = 0;
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.ForeColor = System.Drawing.Color.White;
            this.btnActualizar.BackColor = System.Drawing.Color.FromArgb(((0)), ((120)), ((212)));
            this.btnActualizar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnActualizar.Location = new System.Drawing.Point(20, 230);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(195, 40);
            this.btnActualizar.TabIndex = 25;
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
            this.btnEliminar.Location = new System.Drawing.Point(225, 230);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(195, 40);
            this.btnEliminar.TabIndex = 26;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.AllowUserToAddRows = false;
            this.dgvUsuarios.AllowUserToDeleteRows = false;
            this.dgvUsuarios.ReadOnly = true;
            this.dgvUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUsuarios.BackgroundColor = System.Drawing.Color.White;
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.MultiSelect = false;
            this.dgvUsuarios.RowHeadersVisible = false;
            this.dgvUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsuarios.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvUsuarios.Location = new System.Drawing.Point(450, 20);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.Size = new System.Drawing.Size(630, 550);
            this.dgvUsuarios.TabIndex = 27;
            this.dgvUsuarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsuarios_CellClick);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1100, 650);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Name = "frmUsuarios";
            this.Text = "Usuarios";
            this.Load += new System.EventHandler(this.frmUsuarios_Load);
            this.tpVer.ResumeLayout(false);
            this.tpRegistrar.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tpRegistrar.PerformLayout();
            this.tpVer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpRegistrar;
        private System.Windows.Forms.Label lblTituloRegistrar;
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
        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
