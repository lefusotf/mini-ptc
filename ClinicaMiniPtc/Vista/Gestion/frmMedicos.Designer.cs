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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlFormulario = new System.Windows.Forms.Panel();
            this.lblTituloFormulario = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.pnlLineaFormulario = new System.Windows.Forms.Panel();
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
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.pnlLista = new System.Windows.Forms.Panel();
            this.lblTituloLista = new System.Windows.Forms.Label();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.dgvMedicos = new System.Windows.Forms.DataGridView();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnlFormulario.SuspendLayout();
            this.pnlLineaFormulario.SuspendLayout();
            this.pnlLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlFormulario
            // 
            this.pnlFormulario.Controls.Add(this.lblTituloFormulario);
            this.pnlFormulario.Controls.Add(this.lblDescripcion);
            this.pnlFormulario.Controls.Add(this.pnlLineaFormulario);
            this.pnlFormulario.Controls.Add(this.lblNombre);
            this.pnlFormulario.Controls.Add(this.txtNombre);
            this.pnlFormulario.Controls.Add(this.lblTelefono);
            this.pnlFormulario.Controls.Add(this.mskTelefono);
            this.pnlFormulario.Controls.Add(this.lblCorreo);
            this.pnlFormulario.Controls.Add(this.txtCorreo);
            this.pnlFormulario.Controls.Add(this.lblEspecialidad);
            this.pnlFormulario.Controls.Add(this.cmbEspecialidad);
            this.pnlFormulario.Controls.Add(this.lblUsuario);
            this.pnlFormulario.Controls.Add(this.cmbUsuario);
            this.pnlFormulario.Controls.Add(this.btnGuardar);
            this.pnlFormulario.Controls.Add(this.btnActualizar);
            this.pnlFormulario.Controls.Add(this.btnEliminar);
            this.pnlFormulario.Controls.Add(this.btnLimpiar);
            this.pnlFormulario.BackColor = System.Drawing.Color.White;
            this.pnlFormulario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlFormulario.Location = new System.Drawing.Point(20, 20);
            this.pnlFormulario.Name = "pnlFormulario";
            this.pnlFormulario.Size = new System.Drawing.Size(340, 610);
            this.pnlFormulario.TabIndex = 0;
            // 
            // lblTituloFormulario
            // 
            this.lblTituloFormulario.AutoSize = true;
            this.lblTituloFormulario.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblTituloFormulario.ForeColor = System.Drawing.Color.FromArgb(((15)), ((23)), ((42)));
            this.lblTituloFormulario.Location = new System.Drawing.Point(18, 16);
            this.lblTituloFormulario.Name = "lblTituloFormulario";
            this.lblTituloFormulario.TabIndex = 1;
            this.lblTituloFormulario.Text = "Datos del médico";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblDescripcion.ForeColor = System.Drawing.Color.FromArgb(((100)), ((116)), ((139)));
            this.lblDescripcion.Location = new System.Drawing.Point(20, 45);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.TabIndex = 2;
            this.lblDescripcion.Text = "Los campos con * son obligatorios.";
            // 
            // pnlLineaFormulario
            // 
            this.pnlLineaFormulario.BackColor = System.Drawing.Color.FromArgb(((226)), ((232)), ((240)));
            this.pnlLineaFormulario.Location = new System.Drawing.Point(20, 72);
            this.pnlLineaFormulario.Name = "pnlLineaFormulario";
            this.pnlLineaFormulario.Size = new System.Drawing.Size(300, 1);
            this.pnlLineaFormulario.TabIndex = 3;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblNombre.ForeColor = System.Drawing.Color.FromArgb(((100)), ((116)), ((139)));
            this.lblNombre.Location = new System.Drawing.Point(20, 88);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.TabIndex = 4;
            this.lblNombre.Text = "NOMBRE COMPLETO *";
            // 
            // txtNombre
            // 
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombre.MaxLength = 100;
            this.txtNombre.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.txtNombre.Location = new System.Drawing.Point(20, 108);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(300, 28);
            this.txtNombre.TabIndex = 5;
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTelefono.ForeColor = System.Drawing.Color.FromArgb(((100)), ((116)), ((139)));
            this.lblTelefono.Location = new System.Drawing.Point(20, 148);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.TabIndex = 6;
            this.lblTelefono.Text = "TELÉFONO *";
            // 
            // mskTelefono
            // 
            this.mskTelefono.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mskTelefono.Mask = "0000-0000";
            this.mskTelefono.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.mskTelefono.Location = new System.Drawing.Point(20, 168);
            this.mskTelefono.Name = "mskTelefono";
            this.mskTelefono.Size = new System.Drawing.Size(300, 28);
            this.mskTelefono.TabIndex = 7;
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblCorreo.ForeColor = System.Drawing.Color.FromArgb(((100)), ((116)), ((139)));
            this.lblCorreo.Location = new System.Drawing.Point(20, 208);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.TabIndex = 8;
            this.lblCorreo.Text = "CORREO";
            // 
            // txtCorreo
            // 
            this.txtCorreo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCorreo.MaxLength = 100;
            this.txtCorreo.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.txtCorreo.Location = new System.Drawing.Point(20, 228);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(300, 28);
            this.txtCorreo.TabIndex = 9;
            // 
            // lblEspecialidad
            // 
            this.lblEspecialidad.AutoSize = true;
            this.lblEspecialidad.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblEspecialidad.ForeColor = System.Drawing.Color.FromArgb(((100)), ((116)), ((139)));
            this.lblEspecialidad.Location = new System.Drawing.Point(20, 268);
            this.lblEspecialidad.Name = "lblEspecialidad";
            this.lblEspecialidad.TabIndex = 10;
            this.lblEspecialidad.Text = "ESPECIALIDAD *";
            // 
            // cmbEspecialidad
            // 
            this.cmbEspecialidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEspecialidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbEspecialidad.FormattingEnabled = true;
            this.cmbEspecialidad.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.cmbEspecialidad.Location = new System.Drawing.Point(20, 288);
            this.cmbEspecialidad.Name = "cmbEspecialidad";
            this.cmbEspecialidad.Size = new System.Drawing.Size(300, 28);
            this.cmbEspecialidad.TabIndex = 11;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblUsuario.ForeColor = System.Drawing.Color.FromArgb(((100)), ((116)), ((139)));
            this.lblUsuario.Location = new System.Drawing.Point(20, 328);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.TabIndex = 12;
            this.lblUsuario.Text = "USUARIO DEL SISTEMA";
            // 
            // cmbUsuario
            // 
            this.cmbUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbUsuario.FormattingEnabled = true;
            this.cmbUsuario.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.cmbUsuario.Location = new System.Drawing.Point(20, 348);
            this.cmbUsuario.Name = "cmbUsuario";
            this.cmbUsuario.Size = new System.Drawing.Size(300, 28);
            this.cmbUsuario.TabIndex = 13;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((16)), ((185)), ((129)));
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((13)), ((157)), ((109)));
            this.btnGuardar.Location = new System.Drawing.Point(20, 394);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(145, 40);
            this.btnGuardar.TabIndex = 14;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActualizar.FlatAppearance.BorderSize = 0;
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.BackColor = System.Drawing.Color.FromArgb(((37)), ((99)), ((235)));
            this.btnActualizar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnActualizar.ForeColor = System.Drawing.Color.White;
            this.btnActualizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((31)), ((84)), ((199)));
            this.btnActualizar.Location = new System.Drawing.Point(175, 394);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(145, 40);
            this.btnActualizar.TabIndex = 15;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((239)), ((68)), ((68)));
            this.btnEliminar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((203)), ((57)), ((57)));
            this.btnEliminar.Location = new System.Drawing.Point(20, 444);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(145, 40);
            this.btnEliminar.TabIndex = 16;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiar.FlatAppearance.BorderSize = 0;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.BackColor = System.Drawing.Color.White;
            this.btnLimpiar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((226)), ((232)), ((240)));
            this.btnLimpiar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((241)), ((245)), ((249)));
            this.btnLimpiar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnLimpiar.ForeColor = System.Drawing.Color.FromArgb(((100)), ((116)), ((139)));
            this.btnLimpiar.Location = new System.Drawing.Point(175, 444);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(145, 40);
            this.btnLimpiar.TabIndex = 17;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // pnlLista
            // 
            this.pnlLista.Controls.Add(this.lblTituloLista);
            this.pnlLista.Controls.Add(this.lblBuscar);
            this.pnlLista.Controls.Add(this.txtBuscar);
            this.pnlLista.Controls.Add(this.dgvMedicos);
            this.pnlLista.BackColor = System.Drawing.Color.White;
            this.pnlLista.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlLista.Location = new System.Drawing.Point(380, 20);
            this.pnlLista.Name = "pnlLista";
            this.pnlLista.Size = new System.Drawing.Size(700, 610);
            this.pnlLista.TabIndex = 18;
            // 
            // lblTituloLista
            // 
            this.lblTituloLista.AutoSize = true;
            this.lblTituloLista.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblTituloLista.ForeColor = System.Drawing.Color.FromArgb(((15)), ((23)), ((42)));
            this.lblTituloLista.Location = new System.Drawing.Point(18, 18);
            this.lblTituloLista.Name = "lblTituloLista";
            this.lblTituloLista.TabIndex = 19;
            this.lblTituloLista.Text = "Médicos registrados";
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblBuscar.ForeColor = System.Drawing.Color.FromArgb(((100)), ((116)), ((139)));
            this.lblBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBuscar.Location = new System.Drawing.Point(360, 22);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.TabIndex = 20;
            this.lblBuscar.Text = "Buscar:";
            // 
            // txtBuscar
            // 
            this.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBuscar.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.txtBuscar.Location = new System.Drawing.Point(420, 18);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(260, 28);
            this.txtBuscar.TabIndex = 21;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // dgvMedicos
            // 
            this.dgvMedicos.AllowUserToAddRows = false;
            this.dgvMedicos.AllowUserToDeleteRows = false;
            this.dgvMedicos.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((248)), ((250)), ((252)));
            this.dgvMedicos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMedicos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMedicos.BackgroundColor = System.Drawing.Color.White;
            this.dgvMedicos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvMedicos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvMedicos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((15)), ((23)), ((42)));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((15)), ((23)), ((42)));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMedicos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMedicos.ColumnHeadersHeight = 42;
            this.dgvMedicos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((30)), ((41)), ((59)));
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((37)), ((99)), ((235)));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMedicos.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvMedicos.EnableHeadersVisualStyles = false;
            this.dgvMedicos.GridColor = System.Drawing.Color.FromArgb(((226)), ((232)), ((240)));
            this.dgvMedicos.MultiSelect = false;
            this.dgvMedicos.ReadOnly = true;
            this.dgvMedicos.RowHeadersVisible = false;
            this.dgvMedicos.RowTemplate.Height = 34;
            this.dgvMedicos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMedicos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMedicos.Location = new System.Drawing.Point(20, 62);
            this.dgvMedicos.Name = "dgvMedicos";
            this.dgvMedicos.Size = new System.Drawing.Size(660, 528);
            this.dgvMedicos.TabIndex = 22;
            this.dgvMedicos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMedicos_CellClick);
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // frmMedicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((241)), ((245)), ((249)));
            this.ClientSize = new System.Drawing.Size(1100, 650);
            this.Controls.Add(this.pnlFormulario);
            this.Controls.Add(this.pnlLista);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ForeColor = System.Drawing.Color.FromArgb(((30)), ((41)), ((59)));
            this.Name = "frmMedicos";
            this.Text = "Médicos registrados";
            this.Load += new System.EventHandler(this.frmMedicos_Load);
            this.pnlLista.ResumeLayout(false);
            this.pnlLineaFormulario.ResumeLayout(false);
            this.pnlFormulario.ResumeLayout(false);
            this.pnlFormulario.PerformLayout();
            this.pnlLineaFormulario.PerformLayout();
            this.pnlLista.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlFormulario;
        private System.Windows.Forms.Label lblTituloFormulario;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Panel pnlLineaFormulario;
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
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Panel pnlLista;
        private System.Windows.Forms.Label lblTituloLista;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.DataGridView dgvMedicos;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
