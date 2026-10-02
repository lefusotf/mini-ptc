namespace Vista.Gestion
{
    partial class frmMedicos
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.mskTelefono = new System.Windows.Forms.MaskedTextBox();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.lblEspecialidad = new System.Windows.Forms.Label();
            this.cmbEspecialidad = new System.Windows.Forms.ComboBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.cmbUsuario = new System.Windows.Forms.ComboBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.tpVer = new System.Windows.Forms.TabPage();
            this.lblNombreAct = new System.Windows.Forms.Label();
            this.txtNombreAct = new System.Windows.Forms.TextBox();
            this.lblTelefonoAct = new System.Windows.Forms.Label();
            this.mskTelefonoAct = new System.Windows.Forms.MaskedTextBox();
            this.lblCorreoAct = new System.Windows.Forms.Label();
            this.txtCorreoAct = new System.Windows.Forms.TextBox();
            this.lblEspecialidadAct = new System.Windows.Forms.Label();
            this.cmbEspecialidadAct = new System.Windows.Forms.ComboBox();
            this.lblUsuarioAct = new System.Windows.Forms.Label();
            this.cmbUsuarioAct = new System.Windows.Forms.ComboBox();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.dgvMedicos = new System.Windows.Forms.DataGridView();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabControl1.SuspendLayout();
            this.tpRegistrar.SuspendLayout();
            this.tpVer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicos)).BeginInit();
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
            this.tpRegistrar.Controls.Add(this.lblNombre);
            this.tpRegistrar.Controls.Add(this.txtNombre);
            this.tpRegistrar.Controls.Add(this.lblTelefono);
            this.tpRegistrar.Controls.Add(this.mskTelefono);
            this.tpRegistrar.Controls.Add(this.lblCorreo);
            this.tpRegistrar.Controls.Add(this.txtCorreo);
            this.tpRegistrar.Controls.Add(this.lblEspecialidad);
            this.tpRegistrar.Controls.Add(this.cmbEspecialidad);
            this.tpRegistrar.Controls.Add(this.lblUsuario);
            this.tpRegistrar.Controls.Add(this.cmbUsuario);
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
            this.lblTituloRegistrar.Text = "Registrar Médicos";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(40, 83);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.TabIndex = 3;
            this.lblNombre.Text = "Nombre completo:";
            // 
            // txtNombre
            // 
            this.txtNombre.MaxLength = 100;
            this.txtNombre.Location = new System.Drawing.Point(230, 80);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(320, 25);
            this.txtNombre.TabIndex = 4;
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(40, 123);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.TabIndex = 5;
            this.lblTelefono.Text = "Teléfono:";
            // 
            // mskTelefono
            // 
            this.mskTelefono.Mask = "0000-0000";
            this.mskTelefono.Location = new System.Drawing.Point(230, 120);
            this.mskTelefono.Name = "mskTelefono";
            this.mskTelefono.Size = new System.Drawing.Size(320, 25);
            this.mskTelefono.TabIndex = 6;
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Location = new System.Drawing.Point(40, 163);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.TabIndex = 7;
            this.lblCorreo.Text = "Correo:";
            // 
            // txtCorreo
            // 
            this.txtCorreo.MaxLength = 100;
            this.txtCorreo.Location = new System.Drawing.Point(230, 160);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(320, 25);
            this.txtCorreo.TabIndex = 8;
            // 
            // lblEspecialidad
            // 
            this.lblEspecialidad.AutoSize = true;
            this.lblEspecialidad.Location = new System.Drawing.Point(40, 203);
            this.lblEspecialidad.Name = "lblEspecialidad";
            this.lblEspecialidad.TabIndex = 9;
            this.lblEspecialidad.Text = "Especialidad:";
            // 
            // cmbEspecialidad
            // 
            this.cmbEspecialidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEspecialidad.FormattingEnabled = true;
            this.cmbEspecialidad.Location = new System.Drawing.Point(230, 200);
            this.cmbEspecialidad.Name = "cmbEspecialidad";
            this.cmbEspecialidad.Size = new System.Drawing.Size(320, 25);
            this.cmbEspecialidad.TabIndex = 10;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(40, 243);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.TabIndex = 11;
            this.lblUsuario.Text = "Usuario sistema:";
            // 
            // cmbUsuario
            // 
            this.cmbUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUsuario.FormattingEnabled = true;
            this.cmbUsuario.Location = new System.Drawing.Point(230, 240);
            this.cmbUsuario.Name = "cmbUsuario";
            this.cmbUsuario.Size = new System.Drawing.Size(320, 25);
            this.cmbUsuario.TabIndex = 12;
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
            this.tpVer.Controls.Add(this.lblNombreAct);
            this.tpVer.Controls.Add(this.txtNombreAct);
            this.tpVer.Controls.Add(this.lblTelefonoAct);
            this.tpVer.Controls.Add(this.mskTelefonoAct);
            this.tpVer.Controls.Add(this.lblCorreoAct);
            this.tpVer.Controls.Add(this.txtCorreoAct);
            this.tpVer.Controls.Add(this.lblEspecialidadAct);
            this.tpVer.Controls.Add(this.cmbEspecialidadAct);
            this.tpVer.Controls.Add(this.lblUsuarioAct);
            this.tpVer.Controls.Add(this.cmbUsuarioAct);
            this.tpVer.Controls.Add(this.btnActualizar);
            this.tpVer.Controls.Add(this.btnEliminar);
            this.tpVer.Controls.Add(this.dgvMedicos);
            this.tpVer.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tpVer.Padding = new System.Windows.Forms.Padding(3);
            this.tpVer.Location = new System.Drawing.Point(4, 39);
            this.tpVer.Name = "tpVer";
            this.tpVer.Size = new System.Drawing.Size(1092, 607);
            this.tpVer.TabIndex = 14;
            this.tpVer.Text = "Ver / Actualizar / Eliminar";
            this.tpVer.UseVisualStyleBackColor = true;
            // 
            // lblNombreAct
            // 
            this.lblNombreAct.AutoSize = true;
            this.lblNombreAct.Location = new System.Drawing.Point(20, 23);
            this.lblNombreAct.Name = "lblNombreAct";
            this.lblNombreAct.TabIndex = 15;
            this.lblNombreAct.Text = "Nombre completo:";
            // 
            // txtNombreAct
            // 
            this.txtNombreAct.MaxLength = 100;
            this.txtNombreAct.Location = new System.Drawing.Point(170, 20);
            this.txtNombreAct.Name = "txtNombreAct";
            this.txtNombreAct.Size = new System.Drawing.Size(250, 25);
            this.txtNombreAct.TabIndex = 16;
            // 
            // lblTelefonoAct
            // 
            this.lblTelefonoAct.AutoSize = true;
            this.lblTelefonoAct.Location = new System.Drawing.Point(20, 63);
            this.lblTelefonoAct.Name = "lblTelefonoAct";
            this.lblTelefonoAct.TabIndex = 17;
            this.lblTelefonoAct.Text = "Teléfono:";
            // 
            // mskTelefonoAct
            // 
            this.mskTelefonoAct.Mask = "0000-0000";
            this.mskTelefonoAct.Location = new System.Drawing.Point(170, 60);
            this.mskTelefonoAct.Name = "mskTelefonoAct";
            this.mskTelefonoAct.Size = new System.Drawing.Size(250, 25);
            this.mskTelefonoAct.TabIndex = 18;
            // 
            // lblCorreoAct
            // 
            this.lblCorreoAct.AutoSize = true;
            this.lblCorreoAct.Location = new System.Drawing.Point(20, 103);
            this.lblCorreoAct.Name = "lblCorreoAct";
            this.lblCorreoAct.TabIndex = 19;
            this.lblCorreoAct.Text = "Correo:";
            // 
            // txtCorreoAct
            // 
            this.txtCorreoAct.MaxLength = 100;
            this.txtCorreoAct.Location = new System.Drawing.Point(170, 100);
            this.txtCorreoAct.Name = "txtCorreoAct";
            this.txtCorreoAct.Size = new System.Drawing.Size(250, 25);
            this.txtCorreoAct.TabIndex = 20;
            // 
            // lblEspecialidadAct
            // 
            this.lblEspecialidadAct.AutoSize = true;
            this.lblEspecialidadAct.Location = new System.Drawing.Point(20, 143);
            this.lblEspecialidadAct.Name = "lblEspecialidadAct";
            this.lblEspecialidadAct.TabIndex = 21;
            this.lblEspecialidadAct.Text = "Especialidad:";
            // 
            // cmbEspecialidadAct
            // 
            this.cmbEspecialidadAct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEspecialidadAct.FormattingEnabled = true;
            this.cmbEspecialidadAct.Location = new System.Drawing.Point(170, 140);
            this.cmbEspecialidadAct.Name = "cmbEspecialidadAct";
            this.cmbEspecialidadAct.Size = new System.Drawing.Size(250, 25);
            this.cmbEspecialidadAct.TabIndex = 22;
            // 
            // lblUsuarioAct
            // 
            this.lblUsuarioAct.AutoSize = true;
            this.lblUsuarioAct.Location = new System.Drawing.Point(20, 183);
            this.lblUsuarioAct.Name = "lblUsuarioAct";
            this.lblUsuarioAct.TabIndex = 23;
            this.lblUsuarioAct.Text = "Usuario sistema:";
            // 
            // cmbUsuarioAct
            // 
            this.cmbUsuarioAct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUsuarioAct.FormattingEnabled = true;
            this.cmbUsuarioAct.Location = new System.Drawing.Point(170, 180);
            this.cmbUsuarioAct.Name = "cmbUsuarioAct";
            this.cmbUsuarioAct.Size = new System.Drawing.Size(250, 25);
            this.cmbUsuarioAct.TabIndex = 24;
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
            // dgvMedicos
            // 
            this.dgvMedicos.AllowUserToAddRows = false;
            this.dgvMedicos.AllowUserToDeleteRows = false;
            this.dgvMedicos.ReadOnly = true;
            this.dgvMedicos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMedicos.BackgroundColor = System.Drawing.Color.White;
            this.dgvMedicos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMedicos.MultiSelect = false;
            this.dgvMedicos.RowHeadersVisible = false;
            this.dgvMedicos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMedicos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMedicos.Location = new System.Drawing.Point(450, 20);
            this.dgvMedicos.Name = "dgvMedicos";
            this.dgvMedicos.Size = new System.Drawing.Size(630, 550);
            this.dgvMedicos.TabIndex = 27;
            this.dgvMedicos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMedicos_CellClick);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmMedicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1100, 650);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Name = "frmMedicos";
            this.Text = "Médicos";
            this.Load += new System.EventHandler(this.frmMedicos_Load);
            this.tpVer.ResumeLayout(false);
            this.tpRegistrar.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tpRegistrar.PerformLayout();
            this.tpVer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpRegistrar;
        private System.Windows.Forms.Label lblTituloRegistrar;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.MaskedTextBox mskTelefono;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label lblEspecialidad;
        private System.Windows.Forms.ComboBox cmbEspecialidad;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.ComboBox cmbUsuario;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.TabPage tpVer;
        private System.Windows.Forms.Label lblNombreAct;
        private System.Windows.Forms.TextBox txtNombreAct;
        private System.Windows.Forms.Label lblTelefonoAct;
        private System.Windows.Forms.MaskedTextBox mskTelefonoAct;
        private System.Windows.Forms.Label lblCorreoAct;
        private System.Windows.Forms.TextBox txtCorreoAct;
        private System.Windows.Forms.Label lblEspecialidadAct;
        private System.Windows.Forms.ComboBox cmbEspecialidadAct;
        private System.Windows.Forms.Label lblUsuarioAct;
        private System.Windows.Forms.ComboBox cmbUsuarioAct;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DataGridView dgvMedicos;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
