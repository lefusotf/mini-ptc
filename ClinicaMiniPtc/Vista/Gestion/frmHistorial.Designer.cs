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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlFormulario = new System.Windows.Forms.Panel();
            this.lblTituloFormulario = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.pnlLineaFormulario = new System.Windows.Forms.Panel();
            this.lblPaciente = new System.Windows.Forms.Label();
            this.cmbPaciente = new System.Windows.Forms.ComboBox();
            this.lblMedico = new System.Windows.Forms.Label();
            this.cmbMedico = new System.Windows.Forms.ComboBox();
            this.lblDiagnostico = new System.Windows.Forms.Label();
            this.txtDiagnostico = new System.Windows.Forms.TextBox();
            this.lblTratamiento = new System.Windows.Forms.Label();
            this.txtTratamiento = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.pnlLista = new System.Windows.Forms.Panel();
            this.lblTituloLista = new System.Windows.Forms.Label();
            this.dgvHistorial = new System.Windows.Forms.DataGridView();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnlFormulario.SuspendLayout();
            this.pnlLineaFormulario.SuspendLayout();
            this.pnlLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlFormulario
            // 
            this.pnlFormulario.Controls.Add(this.lblTituloFormulario);
            this.pnlFormulario.Controls.Add(this.lblDescripcion);
            this.pnlFormulario.Controls.Add(this.pnlLineaFormulario);
            this.pnlFormulario.Controls.Add(this.lblPaciente);
            this.pnlFormulario.Controls.Add(this.cmbPaciente);
            this.pnlFormulario.Controls.Add(this.lblMedico);
            this.pnlFormulario.Controls.Add(this.cmbMedico);
            this.pnlFormulario.Controls.Add(this.lblDiagnostico);
            this.pnlFormulario.Controls.Add(this.txtDiagnostico);
            this.pnlFormulario.Controls.Add(this.lblTratamiento);
            this.pnlFormulario.Controls.Add(this.txtTratamiento);
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
            this.lblTituloFormulario.Text = "Consulta médica";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblDescripcion.ForeColor = System.Drawing.Color.FromArgb(((100)), ((116)), ((139)));
            this.lblDescripcion.Location = new System.Drawing.Point(20, 45);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.TabIndex = 2;
            this.lblDescripcion.Text = "Elija el paciente para ver su historial.";
            // 
            // pnlLineaFormulario
            // 
            this.pnlLineaFormulario.BackColor = System.Drawing.Color.FromArgb(((226)), ((232)), ((240)));
            this.pnlLineaFormulario.Location = new System.Drawing.Point(20, 72);
            this.pnlLineaFormulario.Name = "pnlLineaFormulario";
            this.pnlLineaFormulario.Size = new System.Drawing.Size(300, 1);
            this.pnlLineaFormulario.TabIndex = 3;
            // 
            // lblPaciente
            // 
            this.lblPaciente.AutoSize = true;
            this.lblPaciente.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblPaciente.ForeColor = System.Drawing.Color.FromArgb(((100)), ((116)), ((139)));
            this.lblPaciente.Location = new System.Drawing.Point(20, 88);
            this.lblPaciente.Name = "lblPaciente";
            this.lblPaciente.TabIndex = 4;
            this.lblPaciente.Text = "PACIENTE *";
            // 
            // cmbPaciente
            // 
            this.cmbPaciente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPaciente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbPaciente.FormattingEnabled = true;
            this.cmbPaciente.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.cmbPaciente.Location = new System.Drawing.Point(20, 108);
            this.cmbPaciente.Name = "cmbPaciente";
            this.cmbPaciente.Size = new System.Drawing.Size(300, 28);
            this.cmbPaciente.TabIndex = 5;
            // 
            // lblMedico
            // 
            this.lblMedico.AutoSize = true;
            this.lblMedico.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblMedico.ForeColor = System.Drawing.Color.FromArgb(((100)), ((116)), ((139)));
            this.lblMedico.Location = new System.Drawing.Point(20, 148);
            this.lblMedico.Name = "lblMedico";
            this.lblMedico.TabIndex = 6;
            this.lblMedico.Text = "MÉDICO *";
            // 
            // cmbMedico
            // 
            this.cmbMedico.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMedico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbMedico.FormattingEnabled = true;
            this.cmbMedico.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.cmbMedico.Location = new System.Drawing.Point(20, 168);
            this.cmbMedico.Name = "cmbMedico";
            this.cmbMedico.Size = new System.Drawing.Size(300, 28);
            this.cmbMedico.TabIndex = 7;
            // 
            // lblDiagnostico
            // 
            this.lblDiagnostico.AutoSize = true;
            this.lblDiagnostico.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblDiagnostico.ForeColor = System.Drawing.Color.FromArgb(((100)), ((116)), ((139)));
            this.lblDiagnostico.Location = new System.Drawing.Point(20, 208);
            this.lblDiagnostico.Name = "lblDiagnostico";
            this.lblDiagnostico.TabIndex = 8;
            this.lblDiagnostico.Text = "DIAGNÓSTICO *";
            // 
            // txtDiagnostico
            // 
            this.txtDiagnostico.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDiagnostico.MaxLength = 300;
            this.txtDiagnostico.Multiline = true;
            this.txtDiagnostico.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.txtDiagnostico.Location = new System.Drawing.Point(20, 228);
            this.txtDiagnostico.Name = "txtDiagnostico";
            this.txtDiagnostico.Size = new System.Drawing.Size(300, 90);
            this.txtDiagnostico.TabIndex = 9;
            // 
            // lblTratamiento
            // 
            this.lblTratamiento.AutoSize = true;
            this.lblTratamiento.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTratamiento.ForeColor = System.Drawing.Color.FromArgb(((100)), ((116)), ((139)));
            this.lblTratamiento.Location = new System.Drawing.Point(20, 330);
            this.lblTratamiento.Name = "lblTratamiento";
            this.lblTratamiento.TabIndex = 10;
            this.lblTratamiento.Text = "TRATAMIENTO";
            // 
            // txtTratamiento
            // 
            this.txtTratamiento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTratamiento.MaxLength = 300;
            this.txtTratamiento.Multiline = true;
            this.txtTratamiento.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.txtTratamiento.Location = new System.Drawing.Point(20, 350);
            this.txtTratamiento.Name = "txtTratamiento";
            this.txtTratamiento.Size = new System.Drawing.Size(300, 90);
            this.txtTratamiento.TabIndex = 11;
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
            this.btnGuardar.Location = new System.Drawing.Point(20, 458);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(145, 40);
            this.btnGuardar.TabIndex = 12;
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
            this.btnActualizar.Location = new System.Drawing.Point(175, 458);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(145, 40);
            this.btnActualizar.TabIndex = 13;
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
            this.btnEliminar.Location = new System.Drawing.Point(20, 508);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(145, 40);
            this.btnEliminar.TabIndex = 14;
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
            this.btnLimpiar.Location = new System.Drawing.Point(175, 508);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(145, 40);
            this.btnLimpiar.TabIndex = 15;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // pnlLista
            // 
            this.pnlLista.Controls.Add(this.lblTituloLista);
            this.pnlLista.Controls.Add(this.dgvHistorial);
            this.pnlLista.BackColor = System.Drawing.Color.White;
            this.pnlLista.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlLista.Location = new System.Drawing.Point(380, 20);
            this.pnlLista.Name = "pnlLista";
            this.pnlLista.Size = new System.Drawing.Size(700, 610);
            this.pnlLista.TabIndex = 16;
            // 
            // lblTituloLista
            // 
            this.lblTituloLista.AutoSize = true;
            this.lblTituloLista.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblTituloLista.ForeColor = System.Drawing.Color.FromArgb(((15)), ((23)), ((42)));
            this.lblTituloLista.Location = new System.Drawing.Point(18, 18);
            this.lblTituloLista.Name = "lblTituloLista";
            this.lblTituloLista.TabIndex = 17;
            this.lblTituloLista.Text = "Historial del paciente";
            // 
            // dgvHistorial
            // 
            this.dgvHistorial.AllowUserToAddRows = false;
            this.dgvHistorial.AllowUserToDeleteRows = false;
            this.dgvHistorial.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((248)), ((250)), ((252)));
            this.dgvHistorial.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvHistorial.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHistorial.BackgroundColor = System.Drawing.Color.White;
            this.dgvHistorial.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvHistorial.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvHistorial.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((15)), ((23)), ((42)));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((15)), ((23)), ((42)));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHistorial.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvHistorial.ColumnHeadersHeight = 42;
            this.dgvHistorial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((30)), ((41)), ((59)));
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((37)), ((99)), ((235)));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvHistorial.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvHistorial.EnableHeadersVisualStyles = false;
            this.dgvHistorial.GridColor = System.Drawing.Color.FromArgb(((226)), ((232)), ((240)));
            this.dgvHistorial.MultiSelect = false;
            this.dgvHistorial.ReadOnly = true;
            this.dgvHistorial.RowHeadersVisible = false;
            this.dgvHistorial.RowTemplate.Height = 34;
            this.dgvHistorial.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHistorial.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvHistorial.Location = new System.Drawing.Point(20, 62);
            this.dgvHistorial.Name = "dgvHistorial";
            this.dgvHistorial.Size = new System.Drawing.Size(660, 528);
            this.dgvHistorial.TabIndex = 18;
            this.dgvHistorial.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHistorial_CellClick);
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // frmHistorial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((241)), ((245)), ((249)));
            this.ClientSize = new System.Drawing.Size(1100, 650);
            this.Controls.Add(this.pnlFormulario);
            this.Controls.Add(this.pnlLista);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ForeColor = System.Drawing.Color.FromArgb(((30)), ((41)), ((59)));
            this.Name = "frmHistorial";
            this.Text = "Historial del paciente";
            this.Load += new System.EventHandler(this.frmHistorial_Load);
            this.pnlLista.ResumeLayout(false);
            this.pnlLineaFormulario.ResumeLayout(false);
            this.pnlFormulario.ResumeLayout(false);
            this.pnlFormulario.PerformLayout();
            this.pnlLineaFormulario.PerformLayout();
            this.pnlLista.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlFormulario;
        private System.Windows.Forms.Label lblTituloFormulario;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Panel pnlLineaFormulario;
        private System.Windows.Forms.Label lblPaciente;
        private System.Windows.Forms.ComboBox cmbPaciente;
        private System.Windows.Forms.Label lblMedico;
        private System.Windows.Forms.ComboBox cmbMedico;
        private System.Windows.Forms.Label lblDiagnostico;
        private System.Windows.Forms.TextBox txtDiagnostico;
        private System.Windows.Forms.Label lblTratamiento;
        private System.Windows.Forms.TextBox txtTratamiento;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Panel pnlLista;
        private System.Windows.Forms.Label lblTituloLista;
        private System.Windows.Forms.DataGridView dgvHistorial;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
