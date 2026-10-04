namespace Vista.Login
{
    partial class frmLogin
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
            this.pnlLateral = new System.Windows.Forms.Panel();
            this.lblIcono = new System.Windows.Forms.Label();
            this.lblNombreSistema = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.pnlLineaLogin = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblSubtitulo = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblClave = new System.Windows.Forms.Label();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnlLateral.SuspendLayout();
            this.pnlLineaLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlLateral
            // 
            this.pnlLateral.Controls.Add(this.lblIcono);
            this.pnlLateral.Controls.Add(this.lblNombreSistema);
            this.pnlLateral.Controls.Add(this.lblDescripcion);
            this.pnlLateral.Controls.Add(this.pnlLineaLogin);
            this.pnlLateral.BackColor = System.Drawing.Color.FromArgb(((43)), ((48)), ((59)));
            this.pnlLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLateral.Name = "pnlLateral";
            this.pnlLateral.Size = new System.Drawing.Size(320, 440);
            this.pnlLateral.TabIndex = 0;
            // 
            // lblIcono
            // 
            this.lblIcono.AutoSize = false;
            this.lblIcono.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Bold);
            this.lblIcono.ForeColor = System.Drawing.Color.FromArgb(((41)), ((182)), ((182)));
            this.lblIcono.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblIcono.Location = new System.Drawing.Point(0, 70);
            this.lblIcono.Name = "lblIcono";
            this.lblIcono.Size = new System.Drawing.Size(320, 90);
            this.lblIcono.TabIndex = 1;
            this.lblIcono.Text = "✚";
            // 
            // lblNombreSistema
            // 
            this.lblNombreSistema.AutoSize = false;
            this.lblNombreSistema.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblNombreSistema.ForeColor = System.Drawing.Color.White;
            this.lblNombreSistema.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblNombreSistema.Location = new System.Drawing.Point(0, 170);
            this.lblNombreSistema.Name = "lblNombreSistema";
            this.lblNombreSistema.Size = new System.Drawing.Size(320, 45);
            this.lblNombreSistema.TabIndex = 2;
            this.lblNombreSistema.Text = "Clínica Médica";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = false;
            this.lblDescripcion.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblDescripcion.ForeColor = System.Drawing.Color.FromArgb(((180)), ((188)), ((200)));
            this.lblDescripcion.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblDescripcion.Location = new System.Drawing.Point(30, 225);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(260, 60);
            this.lblDescripcion.TabIndex = 3;
            this.lblDescripcion.Text = "Sistema de gestión de pacientes,\r\nmédicos y citas";
            // 
            // pnlLineaLogin
            // 
            this.pnlLineaLogin.BackColor = System.Drawing.Color.FromArgb(((41)), ((182)), ((182)));
            this.pnlLineaLogin.Location = new System.Drawing.Point(130, 300);
            this.pnlLineaLogin.Name = "pnlLineaLogin";
            this.pnlLineaLogin.Size = new System.Drawing.Size(60, 3);
            this.pnlLineaLogin.TabIndex = 4;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((43)), ((48)), ((59)));
            this.lblTitulo.Location = new System.Drawing.Point(367, 55);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.TabIndex = 5;
            this.lblTitulo.Text = "Iniciar sesión";
            // 
            // lblSubtitulo
            // 
            this.lblSubtitulo.AutoSize = true;
            this.lblSubtitulo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSubtitulo.ForeColor = System.Drawing.Color.FromArgb(((120)), ((128)), ((140)));
            this.lblSubtitulo.Location = new System.Drawing.Point(370, 102);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.TabIndex = 6;
            this.lblSubtitulo.Text = "Ingrese sus credenciales para continuar";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblUsuario.ForeColor = System.Drawing.Color.FromArgb(((120)), ((128)), ((140)));
            this.lblUsuario.Location = new System.Drawing.Point(370, 150);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.TabIndex = 7;
            this.lblUsuario.Text = "USUARIO";
            // 
            // txtUsuario
            // 
            this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsuario.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtUsuario.MaxLength = 50;
            this.txtUsuario.Location = new System.Drawing.Point(370, 172);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(340, 32);
            this.txtUsuario.TabIndex = 8;
            // 
            // lblClave
            // 
            this.lblClave.AutoSize = true;
            this.lblClave.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblClave.ForeColor = System.Drawing.Color.FromArgb(((120)), ((128)), ((140)));
            this.lblClave.Location = new System.Drawing.Point(370, 222);
            this.lblClave.Name = "lblClave";
            this.lblClave.TabIndex = 9;
            this.lblClave.Text = "CONTRASEÑA";
            // 
            // txtClave
            // 
            this.txtClave.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtClave.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtClave.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtClave.MaxLength = 50;
            this.txtClave.UseSystemPasswordChar = true;
            this.txtClave.Location = new System.Drawing.Point(370, 244);
            this.txtClave.Name = "txtClave";
            this.txtClave.Size = new System.Drawing.Size(340, 32);
            this.txtClave.TabIndex = 10;
            // 
            // btnIngresar
            // 
            this.btnIngresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIngresar.FlatAppearance.BorderSize = 0;
            this.btnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIngresar.BackColor = System.Drawing.Color.FromArgb(((41)), ((182)), ((182)));
            this.btnIngresar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnIngresar.ForeColor = System.Drawing.Color.White;
            this.btnIngresar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((34)), ((154)), ((154)));
            this.btnIngresar.Location = new System.Drawing.Point(370, 305);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(340, 46);
            this.btnIngresar.TabIndex = 11;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = false;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.BackColor = System.Drawing.Color.White;
            this.btnSalir.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnSalir.ForeColor = System.Drawing.Color.FromArgb(((120)), ((128)), ((140)));
            this.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((245)), ((247)), ((250)));
            this.btnSalir.Location = new System.Drawing.Point(370, 360);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(340, 36);
            this.btnSalir.TabIndex = 12;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((255)), ((255)), ((255)));
            this.ClientSize = new System.Drawing.Size(760, 440);
            this.Controls.Add(this.pnlLateral);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblSubtitulo);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.lblClave);
            this.Controls.Add(this.txtClave);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.btnSalir);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ForeColor = System.Drawing.Color.FromArgb(((52)), ((58)), ((70)));
            this.AcceptButton = this.btnIngresar;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Name = "frmLogin";
            this.Text = "Iniciar sesión - Clínica Médica";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.pnlLineaLogin.ResumeLayout(false);
            this.pnlLateral.ResumeLayout(false);
            this.pnlLateral.PerformLayout();
            this.pnlLineaLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlLateral;
        private System.Windows.Forms.Label lblIcono;
        private System.Windows.Forms.Label lblNombreSistema;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Panel pnlLineaLogin;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lblClave;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
