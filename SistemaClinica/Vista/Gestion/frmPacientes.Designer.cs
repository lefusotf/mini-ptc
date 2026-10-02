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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpRegistrar = new System.Windows.Forms.TabPage();
            this.lblTituloRegistrar = new System.Windows.Forms.Label();
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
            this.dgvPacientes = new System.Windows.Forms.DataGridView();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabControl1.SuspendLayout();
            this.tpRegistrar.SuspendLayout();
            this.tpVer.SuspendLayout();
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
            this.tpRegistrar.Controls.Add(this.lblDui);
            this.tpRegistrar.Controls.Add(this.mskDui);
            this.tpRegistrar.Controls.Add(this.lblFechaNacimiento);
            this.tpRegistrar.Controls.Add(this.dtpFechaNacimiento);
            this.tpRegistrar.Controls.Add(this.lblGenero);
            this.tpRegistrar.Controls.Add(this.cmbGenero);
            this.tpRegistrar.Controls.Add(this.lblTelefono);
            this.tpRegistrar.Controls.Add(this.mskTelefono);
            this.tpRegistrar.Controls.Add(this.lblDireccion);
            this.tpRegistrar.Controls.Add(this.txtDireccion);
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
            this.lblTituloRegistrar.Text = "Registrar Pacientes";
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
            // lblDui
            // 
            this.lblDui.AutoSize = true;
            this.lblDui.Location = new System.Drawing.Point(40, 123);
            this.lblDui.Name = "lblDui";
            this.lblDui.TabIndex = 5;
            this.lblDui.Text = "DUI:";
            // 
            // mskDui
            // 
            this.mskDui.Mask = "00000000-0";
            this.mskDui.Location = new System.Drawing.Point(230, 120);
            this.mskDui.Name = "mskDui";
            this.mskDui.Size = new System.Drawing.Size(320, 25);
            this.mskDui.TabIndex = 6;
            // 
            // lblFechaNacimiento
            // 
            this.lblFechaNacimiento.AutoSize = true;
            this.lblFechaNacimiento.Location = new System.Drawing.Point(40, 163);
            this.lblFechaNacimiento.Name = "lblFechaNacimiento";
            this.lblFechaNacimiento.TabIndex = 7;
            this.lblFechaNacimiento.Text = "Fecha nacimiento:";
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(230, 160);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(320, 25);
            this.dtpFechaNacimiento.TabIndex = 8;
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.Location = new System.Drawing.Point(40, 203);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.TabIndex = 9;
            this.lblGenero.Text = "Género:";
            // 
            // cmbGenero
            // 
            this.cmbGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGenero.FormattingEnabled = true;
            this.cmbGenero.Items.AddRange(new object[] {
            "Masculino",
            "Femenino"});
            this.cmbGenero.Location = new System.Drawing.Point(230, 200);
            this.cmbGenero.Name = "cmbGenero";
            this.cmbGenero.Size = new System.Drawing.Size(320, 25);
            this.cmbGenero.TabIndex = 10;
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(40, 243);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.TabIndex = 11;
            this.lblTelefono.Text = "Teléfono:";
            // 
            // mskTelefono
            // 
            this.mskTelefono.Mask = "0000-0000";
            this.mskTelefono.Location = new System.Drawing.Point(230, 240);
            this.mskTelefono.Name = "mskTelefono";
            this.mskTelefono.Size = new System.Drawing.Size(320, 25);
            this.mskTelefono.TabIndex = 12;
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(40, 283);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.TabIndex = 13;
            this.lblDireccion.Text = "Dirección:";
            // 
            // txtDireccion
            // 
            this.txtDireccion.MaxLength = 200;
            this.txtDireccion.Location = new System.Drawing.Point(230, 280);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(320, 25);
            this.txtDireccion.TabIndex = 14;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistrar.FlatAppearance.BorderSize = 0;
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrar.ForeColor = System.Drawing.Color.White;
            this.btnRegistrar.BackColor = System.Drawing.Color.FromArgb(((40)), ((167)), ((69)));
            this.btnRegistrar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnRegistrar.Location = new System.Drawing.Point(230, 330);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(320, 40);
            this.btnRegistrar.TabIndex = 15;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // tpVer
            // 
            this.tpVer.Controls.Add(this.lblNombreAct);
            this.tpVer.Controls.Add(this.txtNombreAct);
            this.tpVer.Controls.Add(this.lblDuiAct);
            this.tpVer.Controls.Add(this.mskDuiAct);
            this.tpVer.Controls.Add(this.lblFechaNacimientoAct);
            this.tpVer.Controls.Add(this.dtpFechaNacimientoAct);
            this.tpVer.Controls.Add(this.lblGeneroAct);
            this.tpVer.Controls.Add(this.cmbGeneroAct);
            this.tpVer.Controls.Add(this.lblTelefonoAct);
            this.tpVer.Controls.Add(this.mskTelefonoAct);
            this.tpVer.Controls.Add(this.lblDireccionAct);
            this.tpVer.Controls.Add(this.txtDireccionAct);
            this.tpVer.Controls.Add(this.btnActualizar);
            this.tpVer.Controls.Add(this.btnEliminar);
            this.tpVer.Controls.Add(this.dgvPacientes);
            this.tpVer.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tpVer.Padding = new System.Windows.Forms.Padding(3);
            this.tpVer.Location = new System.Drawing.Point(4, 39);
            this.tpVer.Name = "tpVer";
            this.tpVer.Size = new System.Drawing.Size(1092, 607);
            this.tpVer.TabIndex = 16;
            this.tpVer.Text = "Ver / Actualizar / Eliminar";
            this.tpVer.UseVisualStyleBackColor = true;
            // 
            // lblNombreAct
            // 
            this.lblNombreAct.AutoSize = true;
            this.lblNombreAct.Location = new System.Drawing.Point(20, 23);
            this.lblNombreAct.Name = "lblNombreAct";
            this.lblNombreAct.TabIndex = 17;
            this.lblNombreAct.Text = "Nombre completo:";
            // 
            // txtNombreAct
            // 
            this.txtNombreAct.MaxLength = 100;
            this.txtNombreAct.Location = new System.Drawing.Point(170, 20);
            this.txtNombreAct.Name = "txtNombreAct";
            this.txtNombreAct.Size = new System.Drawing.Size(250, 25);
            this.txtNombreAct.TabIndex = 18;
            // 
            // lblDuiAct
            // 
            this.lblDuiAct.AutoSize = true;
            this.lblDuiAct.Location = new System.Drawing.Point(20, 63);
            this.lblDuiAct.Name = "lblDuiAct";
            this.lblDuiAct.TabIndex = 19;
            this.lblDuiAct.Text = "DUI:";
            // 
            // mskDuiAct
            // 
            this.mskDuiAct.Mask = "00000000-0";
            this.mskDuiAct.Location = new System.Drawing.Point(170, 60);
            this.mskDuiAct.Name = "mskDuiAct";
            this.mskDuiAct.Size = new System.Drawing.Size(250, 25);
            this.mskDuiAct.TabIndex = 20;
            // 
            // lblFechaNacimientoAct
            // 
            this.lblFechaNacimientoAct.AutoSize = true;
            this.lblFechaNacimientoAct.Location = new System.Drawing.Point(20, 103);
            this.lblFechaNacimientoAct.Name = "lblFechaNacimientoAct";
            this.lblFechaNacimientoAct.TabIndex = 21;
            this.lblFechaNacimientoAct.Text = "Fecha nacimiento:";
            // 
            // dtpFechaNacimientoAct
            // 
            this.dtpFechaNacimientoAct.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaNacimientoAct.Location = new System.Drawing.Point(170, 100);
            this.dtpFechaNacimientoAct.Name = "dtpFechaNacimientoAct";
            this.dtpFechaNacimientoAct.Size = new System.Drawing.Size(250, 25);
            this.dtpFechaNacimientoAct.TabIndex = 22;
            // 
            // lblGeneroAct
            // 
            this.lblGeneroAct.AutoSize = true;
            this.lblGeneroAct.Location = new System.Drawing.Point(20, 143);
            this.lblGeneroAct.Name = "lblGeneroAct";
            this.lblGeneroAct.TabIndex = 23;
            this.lblGeneroAct.Text = "Género:";
            // 
            // cmbGeneroAct
            // 
            this.cmbGeneroAct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGeneroAct.FormattingEnabled = true;
            this.cmbGeneroAct.Items.AddRange(new object[] {
            "Masculino",
            "Femenino"});
            this.cmbGeneroAct.Location = new System.Drawing.Point(170, 140);
            this.cmbGeneroAct.Name = "cmbGeneroAct";
            this.cmbGeneroAct.Size = new System.Drawing.Size(250, 25);
            this.cmbGeneroAct.TabIndex = 24;
            // 
            // lblTelefonoAct
            // 
            this.lblTelefonoAct.AutoSize = true;
            this.lblTelefonoAct.Location = new System.Drawing.Point(20, 183);
            this.lblTelefonoAct.Name = "lblTelefonoAct";
            this.lblTelefonoAct.TabIndex = 25;
            this.lblTelefonoAct.Text = "Teléfono:";
            // 
            // mskTelefonoAct
            // 
            this.mskTelefonoAct.Mask = "0000-0000";
            this.mskTelefonoAct.Location = new System.Drawing.Point(170, 180);
            this.mskTelefonoAct.Name = "mskTelefonoAct";
            this.mskTelefonoAct.Size = new System.Drawing.Size(250, 25);
            this.mskTelefonoAct.TabIndex = 26;
            // 
            // lblDireccionAct
            // 
            this.lblDireccionAct.AutoSize = true;
            this.lblDireccionAct.Location = new System.Drawing.Point(20, 223);
            this.lblDireccionAct.Name = "lblDireccionAct";
            this.lblDireccionAct.TabIndex = 27;
            this.lblDireccionAct.Text = "Dirección:";
            // 
            // txtDireccionAct
            // 
            this.txtDireccionAct.MaxLength = 200;
            this.txtDireccionAct.Location = new System.Drawing.Point(170, 220);
            this.txtDireccionAct.Name = "txtDireccionAct";
            this.txtDireccionAct.Size = new System.Drawing.Size(250, 25);
            this.txtDireccionAct.TabIndex = 28;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActualizar.FlatAppearance.BorderSize = 0;
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.ForeColor = System.Drawing.Color.White;
            this.btnActualizar.BackColor = System.Drawing.Color.FromArgb(((0)), ((120)), ((212)));
            this.btnActualizar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnActualizar.Location = new System.Drawing.Point(20, 270);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(195, 40);
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
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((220)), ((53)), ((69)));
            this.btnEliminar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnEliminar.Location = new System.Drawing.Point(225, 270);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(195, 40);
            this.btnEliminar.TabIndex = 30;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // dgvPacientes
            // 
            this.dgvPacientes.AllowUserToAddRows = false;
            this.dgvPacientes.AllowUserToDeleteRows = false;
            this.dgvPacientes.ReadOnly = true;
            this.dgvPacientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPacientes.BackgroundColor = System.Drawing.Color.White;
            this.dgvPacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPacientes.MultiSelect = false;
            this.dgvPacientes.RowHeadersVisible = false;
            this.dgvPacientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPacientes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPacientes.Location = new System.Drawing.Point(450, 20);
            this.dgvPacientes.Name = "dgvPacientes";
            this.dgvPacientes.Size = new System.Drawing.Size(630, 550);
            this.dgvPacientes.TabIndex = 31;
            this.dgvPacientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPacientes_CellClick);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmPacientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1100, 650);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Name = "frmPacientes";
            this.Text = "Pacientes";
            this.Load += new System.EventHandler(this.frmPacientes_Load);
            this.tpVer.ResumeLayout(false);
            this.tpRegistrar.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tpRegistrar.PerformLayout();
            this.tpVer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacientes)).EndInit();
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
        private System.Windows.Forms.DataGridView dgvPacientes;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
