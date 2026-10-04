namespace Vista.Gestion
{
    partial class frmEspecialidades
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.tpVer = new System.Windows.Forms.TabPage();
            this.pnlEditar = new System.Windows.Forms.Panel();
            this.lblEditar = new System.Windows.Forms.Label();
            this.lblNombreAct = new System.Windows.Forms.Label();
            this.txtNombreAct = new System.Windows.Forms.TextBox();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lblLista = new System.Windows.Forms.Label();
            this.dgvEspecialidades = new System.Windows.Forms.DataGridView();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabControl1.SuspendLayout();
            this.tpRegistrar.SuspendLayout();
            this.pnlRegistrar.SuspendLayout();
            this.tpVer.SuspendLayout();
            this.pnlEditar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEspecialidades)).BeginInit();
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
            this.lblTituloRegistrar.Text = "Registrar especialidad";
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
            this.pnlRegistrar.Controls.Add(this.lblNombre);
            this.pnlRegistrar.Controls.Add(this.txtNombre);
            this.pnlRegistrar.Controls.Add(this.btnRegistrar);
            this.pnlRegistrar.BackColor = System.Drawing.Color.White;
            this.pnlRegistrar.Location = new System.Drawing.Point(30, 95);
            this.pnlRegistrar.Name = "pnlRegistrar";
            this.pnlRegistrar.Size = new System.Drawing.Size(420, 181);
            this.pnlRegistrar.TabIndex = 4;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblNombre.ForeColor = System.Drawing.Color.FromArgb(((120)), ((128)), ((140)));
            this.lblNombre.Location = new System.Drawing.Point(30, 30);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.TabIndex = 5;
            this.lblNombre.Text = "NOMBRE DE LA ESPECIALIDAD *";
            // 
            // txtNombre
            // 
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombre.MaxLength = 100;
            this.txtNombre.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtNombre.Location = new System.Drawing.Point(30, 51);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(360, 28);
            this.txtNombre.TabIndex = 6;
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
            this.btnRegistrar.Location = new System.Drawing.Point(190, 105);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(200, 46);
            this.btnRegistrar.TabIndex = 7;
            this.btnRegistrar.Text = "✔  Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // tpVer
            // 
            this.tpVer.Controls.Add(this.pnlEditar);
            this.tpVer.Controls.Add(this.lblLista);
            this.tpVer.Controls.Add(this.dgvEspecialidades);
            this.tpVer.BackColor = System.Drawing.Color.FromArgb(((245)), ((247)), ((250)));
            this.tpVer.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tpVer.Padding = new System.Windows.Forms.Padding(3);
            this.tpVer.Location = new System.Drawing.Point(4, 44);
            this.tpVer.Name = "tpVer";
            this.tpVer.Size = new System.Drawing.Size(1092, 602);
            this.tpVer.TabIndex = 8;
            this.tpVer.Text = "Ver / Actualizar / Eliminar";
            this.tpVer.UseVisualStyleBackColor = false;
            // 
            // pnlEditar
            // 
            this.pnlEditar.Controls.Add(this.lblEditar);
            this.pnlEditar.Controls.Add(this.lblNombreAct);
            this.pnlEditar.Controls.Add(this.txtNombreAct);
            this.pnlEditar.Controls.Add(this.btnActualizar);
            this.pnlEditar.Controls.Add(this.btnEliminar);
            this.pnlEditar.BackColor = System.Drawing.Color.White;
            this.pnlEditar.Location = new System.Drawing.Point(20, 20);
            this.pnlEditar.Name = "pnlEditar";
            this.pnlEditar.Size = new System.Drawing.Size(310, 195);
            this.pnlEditar.TabIndex = 9;
            // 
            // lblEditar
            // 
            this.lblEditar.AutoSize = true;
            this.lblEditar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblEditar.ForeColor = System.Drawing.Color.FromArgb(((43)), ((48)), ((59)));
            this.lblEditar.Location = new System.Drawing.Point(20, 18);
            this.lblEditar.Name = "lblEditar";
            this.lblEditar.TabIndex = 10;
            this.lblEditar.Text = "Editar seleccionado";
            // 
            // lblNombreAct
            // 
            this.lblNombreAct.AutoSize = true;
            this.lblNombreAct.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblNombreAct.ForeColor = System.Drawing.Color.FromArgb(((120)), ((128)), ((140)));
            this.lblNombreAct.Location = new System.Drawing.Point(20, 60);
            this.lblNombreAct.Name = "lblNombreAct";
            this.lblNombreAct.TabIndex = 11;
            this.lblNombreAct.Text = "NOMBRE";
            // 
            // txtNombreAct
            // 
            this.txtNombreAct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombreAct.MaxLength = 100;
            this.txtNombreAct.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtNombreAct.Location = new System.Drawing.Point(20, 81);
            this.txtNombreAct.Name = "txtNombreAct";
            this.txtNombreAct.Size = new System.Drawing.Size(270, 28);
            this.txtNombreAct.TabIndex = 12;
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
            this.btnActualizar.Location = new System.Drawing.Point(20, 131);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(130, 42);
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
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((214)), ((69)), ((65)));
            this.btnEliminar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((181)), ((58)), ((55)));
            this.btnEliminar.Location = new System.Drawing.Point(160, 131);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(130, 42);
            this.btnEliminar.TabIndex = 14;
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
            this.lblLista.TabIndex = 15;
            this.lblLista.Text = "Lista de especialidades";
            // 
            // dgvEspecialidades
            // 
            this.dgvEspecialidades.AllowUserToAddRows = false;
            this.dgvEspecialidades.AllowUserToDeleteRows = false;
            this.dgvEspecialidades.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((248)), ((250)), ((252)));
            this.dgvEspecialidades.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvEspecialidades.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEspecialidades.BackgroundColor = System.Drawing.Color.White;
            this.dgvEspecialidades.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvEspecialidades.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvEspecialidades.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((43)), ((48)), ((59)));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((43)), ((48)), ((59)));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEspecialidades.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvEspecialidades.ColumnHeadersHeight = 42;
            this.dgvEspecialidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((52)), ((58)), ((70)));
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((41)), ((182)), ((182)));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEspecialidades.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvEspecialidades.EnableHeadersVisualStyles = false;
            this.dgvEspecialidades.GridColor = System.Drawing.Color.FromArgb(((225)), ((230)), ((236)));
            this.dgvEspecialidades.MultiSelect = false;
            this.dgvEspecialidades.ReadOnly = true;
            this.dgvEspecialidades.RowHeadersVisible = false;
            this.dgvEspecialidades.RowTemplate.Height = 34;
            this.dgvEspecialidades.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEspecialidades.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvEspecialidades.Location = new System.Drawing.Point(350, 64);
            this.dgvEspecialidades.Name = "dgvEspecialidades";
            this.dgvEspecialidades.Size = new System.Drawing.Size(722, 518);
            this.dgvEspecialidades.TabIndex = 16;
            this.dgvEspecialidades.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEspecialidades_CellClick);
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // frmEspecialidades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((245)), ((247)), ((250)));
            this.ClientSize = new System.Drawing.Size(1100, 650);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ForeColor = System.Drawing.Color.FromArgb(((52)), ((58)), ((70)));
            this.Name = "frmEspecialidades";
            this.Text = "especialidades";
            this.Load += new System.EventHandler(this.frmEspecialidades_Load);
            this.pnlEditar.ResumeLayout(false);
            this.tpVer.ResumeLayout(false);
            this.pnlRegistrar.ResumeLayout(false);
            this.tpRegistrar.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tpRegistrar.PerformLayout();
            this.pnlRegistrar.PerformLayout();
            this.tpVer.PerformLayout();
            this.pnlEditar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEspecialidades)).EndInit();
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
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.TabPage tpVer;
        private System.Windows.Forms.Panel pnlEditar;
        private System.Windows.Forms.Label lblEditar;
        private System.Windows.Forms.Label lblNombreAct;
        private System.Windows.Forms.TextBox txtNombreAct;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lblLista;
        private System.Windows.Forms.DataGridView dgvEspecialidades;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
