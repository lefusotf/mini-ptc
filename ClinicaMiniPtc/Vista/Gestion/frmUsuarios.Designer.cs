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
            this.pnlFormulario = new System.Windows.Forms.Panel();
            this.lblTituloFormulario = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.pnlLineaFormulario = new System.Windows.Forms.Panel();
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
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.pnlLista = new System.Windows.Forms.Panel();
            this.lblTituloLista = new System.Windows.Forms.Label();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnlFormulario.SuspendLayout();
            this.pnlLineaFormulario.SuspendLayout();
            this.pnlLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlFormulario
            // 
            this.pnlFormulario.Controls.Add(this.lblTituloFormulario);
            this.pnlFormulario.Controls.Add(this.lblDescripcion);
            this.pnlFormulario.Controls.Add(this.pnlLineaFormulario);
            this.pnlFormulario.Controls.Add(this.lblUsuario);
            this.pnlFormulario.Controls.Add(this.txtUsuario);
            this.pnlFormulario.Controls.Add(this.lblNombreCompleto);
            this.pnlFormulario.Controls.Add(this.txtNombreCompleto);
            this.pnlFormulario.Controls.Add(this.lblClave);
            this.pnlFormulario.Controls.Add(this.txtClave);
            this.pnlFormulario.Controls.Add(this.lblRol);
            this.pnlFormulario.Controls.Add(this.cmbRol);
            this.pnlFormulario.Controls.Add(this.lblActivo);
            this.pnlFormulario.Controls.Add(this.chkActivo);
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
            this.lblTituloFormulario.Text = "Datos del usuario";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblDescripcion.ForeColor = System.Drawing.Color.FromArgb(((100)), ((116)), ((139)));
            this.lblDescripcion.Location = new System.Drawing.Point(20, 45);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.TabIndex = 2;
            this.lblDescripcion.Text = "Al actualizar, deje la contraseña vacía para no cambiarla.";
            // 
            // pnlLineaFormulario
            // 
            this.pnlLineaFormulario.BackColor = System.Drawing.Color.FromArgb(((226)), ((232)), ((240)));
            this.pnlLineaFormulario.Location = new System.Drawing.Point(20, 72);
            this.pnlLineaFormulario.Name = "pnlLineaFormulario";
            this.pnlLineaFormulario.Size = new System.Drawing.Size(300, 1);
            this.pnlLineaFormulario.TabIndex = 3;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblUsuario.ForeColor = System.Drawing.Color.FromArgb(((100)), ((116)), ((139)));
            this.lblUsuario.Location = new System.Drawing.Point(20, 88);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.TabIndex = 4;
            this.lblUsuario.Text = "USUARIO *";
            // 
            // txtUsuario
            // 
            this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsuario.MaxLength = 50;
            this.txtUsuario.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.txtUsuario.Location = new System.Drawing.Point(20, 108);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(300, 28);
            this.txtUsuario.TabIndex = 5;
            // 
            // lblNombreCompleto
            // 
            this.lblNombreCompleto.AutoSize = true;
            this.lblNombreCompleto.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblNombreCompleto.ForeColor = System.Drawing.Color.FromArgb(((100)), ((116)), ((139)));
            this.lblNombreCompleto.Location = new System.Drawing.Point(20, 148);
            this.lblNombreCompleto.Name = "lblNombreCompleto";
            this.lblNombreCompleto.TabIndex = 6;
            this.lblNombreCompleto.Text = "NOMBRE COMPLETO *";
            // 
            // txtNombreCompleto
            // 
            this.txtNombreCompleto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombreCompleto.MaxLength = 100;
            this.txtNombreCompleto.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.txtNombreCompleto.Location = new System.Drawing.Point(20, 168);
            this.txtNombreCompleto.Name = "txtNombreCompleto";
            this.txtNombreCompleto.Size = new System.Drawing.Size(300, 28);
            this.txtNombreCompleto.TabIndex = 7;
            // 
            // lblClave
            // 
            this.lblClave.AutoSize = true;
            this.lblClave.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblClave.ForeColor = System.Drawing.Color.FromArgb(((100)), ((116)), ((139)));
            this.lblClave.Location = new System.Drawing.Point(20, 208);
            this.lblClave.Name = "lblClave";
            this.lblClave.TabIndex = 8;
            this.lblClave.Text = "CONTRASEÑA (MÍNIMO 8)";
            // 
            // txtClave
            // 
            this.txtClave.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtClave.MaxLength = 50;
            this.txtClave.UseSystemPasswordChar = true;
            this.txtClave.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.txtClave.Location = new System.Drawing.Point(20, 228);
            this.txtClave.Name = "txtClave";
            this.txtClave.Size = new System.Drawing.Size(300, 28);
            this.txtClave.TabIndex = 9;
            // 
            // lblRol
            // 
            this.lblRol.AutoSize = true;
            this.lblRol.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblRol.ForeColor = System.Drawing.Color.FromArgb(((100)), ((116)), ((139)));
            this.lblRol.Location = new System.Drawing.Point(20, 268);
            this.lblRol.Name = "lblRol";
            this.lblRol.TabIndex = 10;
            this.lblRol.Text = "ROL *";
            // 
            // cmbRol
            // 
            this.cmbRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbRol.FormattingEnabled = true;
            this.cmbRol.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.cmbRol.Location = new System.Drawing.Point(20, 288);
            this.cmbRol.Name = "cmbRol";
            this.cmbRol.Size = new System.Drawing.Size(300, 28);
            this.cmbRol.TabIndex = 11;
            // 
            // lblActivo
            // 
            this.lblActivo.AutoSize = true;
            this.lblActivo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblActivo.ForeColor = System.Drawing.Color.FromArgb(((100)), ((116)), ((139)));
            this.lblActivo.Location = new System.Drawing.Point(20, 328);
            this.lblActivo.Name = "lblActivo";
            this.lblActivo.TabIndex = 12;
            this.lblActivo.Text = "ESTADO";
            // 
            // chkActivo
            // 
            this.chkActivo.AutoSize = true;
            this.chkActivo.Checked = true;
            this.chkActivo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkActivo.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.chkActivo.Location = new System.Drawing.Point(20, 350);
            this.chkActivo.Name = "chkActivo";
            this.chkActivo.TabIndex = 13;
            this.chkActivo.Text = "Activo";
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
            this.pnlLista.Controls.Add(this.dgvUsuarios);
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
            this.lblTituloLista.Text = "Usuarios del sistema";
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
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((15)), ((23)), ((42)));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((15)), ((23)), ((42)));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUsuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvUsuarios.ColumnHeadersHeight = 42;
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((30)), ((41)), ((59)));
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((37)), ((99)), ((235)));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvUsuarios.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvUsuarios.EnableHeadersVisualStyles = false;
            this.dgvUsuarios.GridColor = System.Drawing.Color.FromArgb(((226)), ((232)), ((240)));
            this.dgvUsuarios.MultiSelect = false;
            this.dgvUsuarios.ReadOnly = true;
            this.dgvUsuarios.RowHeadersVisible = false;
            this.dgvUsuarios.RowTemplate.Height = 34;
            this.dgvUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsuarios.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvUsuarios.Location = new System.Drawing.Point(20, 62);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.Size = new System.Drawing.Size(660, 528);
            this.dgvUsuarios.TabIndex = 22;
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
            this.BackColor = System.Drawing.Color.FromArgb(((241)), ((245)), ((249)));
            this.ClientSize = new System.Drawing.Size(1100, 650);
            this.Controls.Add(this.pnlFormulario);
            this.Controls.Add(this.pnlLista);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ForeColor = System.Drawing.Color.FromArgb(((30)), ((41)), ((59)));
            this.Name = "frmUsuarios";
            this.Text = "Usuarios del sistema";
            this.Load += new System.EventHandler(this.frmUsuarios_Load);
            this.pnlLista.ResumeLayout(false);
            this.pnlLineaFormulario.ResumeLayout(false);
            this.pnlFormulario.ResumeLayout(false);
            this.pnlFormulario.PerformLayout();
            this.pnlLineaFormulario.PerformLayout();
            this.pnlLista.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlFormulario;
        private System.Windows.Forms.Label lblTituloFormulario;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Panel pnlLineaFormulario;
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
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Panel pnlLista;
        private System.Windows.Forms.Label lblTituloLista;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
