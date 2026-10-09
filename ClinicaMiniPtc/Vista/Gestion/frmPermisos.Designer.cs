namespace Vista.Gestion
{
    partial class frmPermisos
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
            this.pnlPermisos = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblSubtitulo = new System.Windows.Forms.Label();
            this.pnlLineaPermisos = new System.Windows.Forms.Panel();
            this.lblRol = new System.Windows.Forms.Label();
            this.cmbRol = new System.Windows.Forms.ComboBox();
            this.lblPermisos = new System.Windows.Forms.Label();
            this.clbPermisos = new System.Windows.Forms.CheckedListBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.pnlPermisos.SuspendLayout();
            this.pnlLineaPermisos.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlPermisos
            // 
            this.pnlPermisos.Controls.Add(this.lblTitulo);
            this.pnlPermisos.Controls.Add(this.lblSubtitulo);
            this.pnlPermisos.Controls.Add(this.pnlLineaPermisos);
            this.pnlPermisos.Controls.Add(this.lblRol);
            this.pnlPermisos.Controls.Add(this.cmbRol);
            this.pnlPermisos.Controls.Add(this.lblPermisos);
            this.pnlPermisos.Controls.Add(this.clbPermisos);
            this.pnlPermisos.Controls.Add(this.btnGuardar);
            this.pnlPermisos.BackColor = System.Drawing.Color.White;
            this.pnlPermisos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlPermisos.Location = new System.Drawing.Point(320, 30);
            this.pnlPermisos.Name = "pnlPermisos";
            this.pnlPermisos.Size = new System.Drawing.Size(460, 590);
            this.pnlPermisos.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((15)), ((23)), ((42)));
            this.lblTitulo.Location = new System.Drawing.Point(22, 20);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Roles y permisos";
            // 
            // lblSubtitulo
            // 
            this.lblSubtitulo.AutoSize = true;
            this.lblSubtitulo.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblSubtitulo.ForeColor = System.Drawing.Color.FromArgb(((100)), ((116)), ((139)));
            this.lblSubtitulo.Location = new System.Drawing.Point(25, 55);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.TabIndex = 2;
            this.lblSubtitulo.Text = "Elija un rol y marque las pantallas que puede usar.";
            // 
            // pnlLineaPermisos
            // 
            this.pnlLineaPermisos.BackColor = System.Drawing.Color.FromArgb(((226)), ((232)), ((240)));
            this.pnlLineaPermisos.Location = new System.Drawing.Point(25, 85);
            this.pnlLineaPermisos.Name = "pnlLineaPermisos";
            this.pnlLineaPermisos.Size = new System.Drawing.Size(410, 1);
            this.pnlLineaPermisos.TabIndex = 3;
            // 
            // lblRol
            // 
            this.lblRol.AutoSize = true;
            this.lblRol.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblRol.ForeColor = System.Drawing.Color.FromArgb(((100)), ((116)), ((139)));
            this.lblRol.Location = new System.Drawing.Point(25, 105);
            this.lblRol.Name = "lblRol";
            this.lblRol.TabIndex = 4;
            this.lblRol.Text = "ROL";
            // 
            // cmbRol
            // 
            this.cmbRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbRol.FormattingEnabled = true;
            this.cmbRol.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.cmbRol.Location = new System.Drawing.Point(25, 126);
            this.cmbRol.Name = "cmbRol";
            this.cmbRol.Size = new System.Drawing.Size(410, 28);
            this.cmbRol.TabIndex = 5;
            this.cmbRol.SelectedIndexChanged += new System.EventHandler(this.cmbRol_SelectedIndexChanged);
            // 
            // lblPermisos
            // 
            this.lblPermisos.AutoSize = true;
            this.lblPermisos.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblPermisos.ForeColor = System.Drawing.Color.FromArgb(((100)), ((116)), ((139)));
            this.lblPermisos.Location = new System.Drawing.Point(25, 175);
            this.lblPermisos.Name = "lblPermisos";
            this.lblPermisos.TabIndex = 6;
            this.lblPermisos.Text = "PANTALLAS PERMITIDAS";
            // 
            // clbPermisos
            // 
            this.clbPermisos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.clbPermisos.CheckOnClick = true;
            this.clbPermisos.FormattingEnabled = true;
            this.clbPermisos.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.clbPermisos.Location = new System.Drawing.Point(25, 200);
            this.clbPermisos.Name = "clbPermisos";
            this.clbPermisos.Size = new System.Drawing.Size(410, 290);
            this.clbPermisos.TabIndex = 7;
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
            this.btnGuardar.Location = new System.Drawing.Point(25, 515);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(410, 46);
            this.btnGuardar.TabIndex = 8;
            this.btnGuardar.Text = "Guardar permisos";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // frmPermisos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((241)), ((245)), ((249)));
            this.ClientSize = new System.Drawing.Size(1100, 650);
            this.Controls.Add(this.pnlPermisos);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ForeColor = System.Drawing.Color.FromArgb(((30)), ((41)), ((59)));
            this.Name = "frmPermisos";
            this.Text = "Roles y permisos";
            this.Load += new System.EventHandler(this.frmPermisos_Load);
            this.pnlLineaPermisos.ResumeLayout(false);
            this.pnlPermisos.ResumeLayout(false);
            this.pnlPermisos.PerformLayout();
            this.pnlLineaPermisos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlPermisos;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.Panel pnlLineaPermisos;
        private System.Windows.Forms.Label lblRol;
        private System.Windows.Forms.ComboBox cmbRol;
        private System.Windows.Forms.Label lblPermisos;
        private System.Windows.Forms.CheckedListBox clbPermisos;
        private System.Windows.Forms.Button btnGuardar;
    }
}
