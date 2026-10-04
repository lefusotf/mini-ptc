namespace Vista.Gestion
{
    partial class frmBitacora
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblSubtitulo = new System.Windows.Forms.Label();
            this.dgvBitacora = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBitacora)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((43)), ((48)), ((59)));
            this.lblTitulo.Location = new System.Drawing.Point(30, 18);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Bitácora de actividades";
            // 
            // lblSubtitulo
            // 
            this.lblSubtitulo.AutoSize = true;
            this.lblSubtitulo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSubtitulo.ForeColor = System.Drawing.Color.FromArgb(((120)), ((128)), ((140)));
            this.lblSubtitulo.Location = new System.Drawing.Point(32, 58);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.TabIndex = 1;
            this.lblSubtitulo.Text = "Registro de las acciones realizadas por los usuarios del sistema.";
            // 
            // dgvBitacora
            // 
            this.dgvBitacora.AllowUserToAddRows = false;
            this.dgvBitacora.AllowUserToDeleteRows = false;
            this.dgvBitacora.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((248)), ((250)), ((252)));
            this.dgvBitacora.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBitacora.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBitacora.BackgroundColor = System.Drawing.Color.White;
            this.dgvBitacora.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvBitacora.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvBitacora.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((43)), ((48)), ((59)));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((43)), ((48)), ((59)));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBitacora.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvBitacora.ColumnHeadersHeight = 42;
            this.dgvBitacora.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((52)), ((58)), ((70)));
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((41)), ((182)), ((182)));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBitacora.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvBitacora.EnableHeadersVisualStyles = false;
            this.dgvBitacora.GridColor = System.Drawing.Color.FromArgb(((225)), ((230)), ((236)));
            this.dgvBitacora.MultiSelect = false;
            this.dgvBitacora.ReadOnly = true;
            this.dgvBitacora.RowHeadersVisible = false;
            this.dgvBitacora.RowTemplate.Height = 34;
            this.dgvBitacora.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBitacora.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvBitacora.Location = new System.Drawing.Point(30, 95);
            this.dgvBitacora.Name = "dgvBitacora";
            this.dgvBitacora.Size = new System.Drawing.Size(1040, 535);
            this.dgvBitacora.TabIndex = 2;
            // 
            // frmBitacora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((245)), ((247)), ((250)));
            this.ClientSize = new System.Drawing.Size(1100, 650);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblSubtitulo);
            this.Controls.Add(this.dgvBitacora);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ForeColor = System.Drawing.Color.FromArgb(((52)), ((58)), ((70)));
            this.Name = "frmBitacora";
            this.Text = "Bitácora";
            this.Load += new System.EventHandler(this.frmBitacora_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBitacora)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.DataGridView dgvBitacora;
    }
}
