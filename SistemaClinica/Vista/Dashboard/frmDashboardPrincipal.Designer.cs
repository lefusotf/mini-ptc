namespace Vista.Dashboard
{
    partial class frmDashboardPrincipal
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
            this.pnlContenedor = new System.Windows.Forms.Panel();
            this.lblInicio = new System.Windows.Forms.Label();
            this.pnlSuperior = new System.Windows.Forms.Panel();
            this.pnlLineaSuperior = new System.Windows.Forms.Panel();
            this.lblSistema = new System.Windows.Forms.Label();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.btnBitacora = new System.Windows.Forms.Button();
            this.btnPermisos = new System.Windows.Forms.Button();
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.btnHistorial = new System.Windows.Forms.Button();
            this.btnCitas = new System.Windows.Forms.Button();
            this.btnEspecialidades = new System.Windows.Forms.Button();
            this.btnMedicos = new System.Windows.Forms.Button();
            this.btnPacientes = new System.Windows.Forms.Button();
            this.pnlSeparador = new System.Windows.Forms.Panel();
            this.lblBienvenido = new System.Windows.Forms.Label();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.lblLogo = new System.Windows.Forms.Label();
            this.pnlContenedor.SuspendLayout();
            this.pnlSuperior.SuspendLayout();
            this.pnlLineaSuperior.SuspendLayout();
            this.pnlMenu.SuspendLayout();
            this.pnlSeparador.SuspendLayout();
            this.pnlLogo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlContenedor
            // 
            this.pnlContenedor.Controls.Add(this.lblInicio);
            this.pnlContenedor.BackColor = System.Drawing.Color.FromArgb(((245)), ((247)), ((250)));
            this.pnlContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenedor.Padding = new System.Windows.Forms.Padding(15);
            this.pnlContenedor.Name = "pnlContenedor";
            this.pnlContenedor.Size = new System.Drawing.Size(1100, 656);
            this.pnlContenedor.TabIndex = 0;
            // 
            // lblInicio
            // 
            this.lblInicio.AutoSize = false;
            this.lblInicio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblInicio.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.lblInicio.ForeColor = System.Drawing.Color.FromArgb(((170)), ((178)), ((190)));
            this.lblInicio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblInicio.Name = "lblInicio";
            this.lblInicio.Size = new System.Drawing.Size(1100, 656);
            this.lblInicio.TabIndex = 1;
            this.lblInicio.Text = "✚\r\nSeleccione una opción del menú";
            // 
            // pnlSuperior
            // 
            this.pnlSuperior.Controls.Add(this.pnlLineaSuperior);
            this.pnlSuperior.Controls.Add(this.lblSistema);
            this.pnlSuperior.BackColor = System.Drawing.Color.White;
            this.pnlSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSuperior.Name = "pnlSuperior";
            this.pnlSuperior.Size = new System.Drawing.Size(1100, 64);
            this.pnlSuperior.TabIndex = 2;
            // 
            // pnlLineaSuperior
            // 
            this.pnlLineaSuperior.BackColor = System.Drawing.Color.FromArgb(((41)), ((182)), ((182)));
            this.pnlLineaSuperior.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlLineaSuperior.Name = "pnlLineaSuperior";
            this.pnlLineaSuperior.Size = new System.Drawing.Size(1100, 3);
            this.pnlLineaSuperior.TabIndex = 3;
            // 
            // lblSistema
            // 
            this.lblSistema.AutoSize = true;
            this.lblSistema.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lblSistema.ForeColor = System.Drawing.Color.FromArgb(((43)), ((48)), ((59)));
            this.lblSistema.Location = new System.Drawing.Point(25, 18);
            this.lblSistema.Name = "lblSistema";
            this.lblSistema.TabIndex = 4;
            this.lblSistema.Text = "Sistema de Gestión de Clínica Médica";
            // 
            // pnlMenu
            // 
            this.pnlMenu.Controls.Add(this.btnCerrarSesion);
            this.pnlMenu.Controls.Add(this.btnBitacora);
            this.pnlMenu.Controls.Add(this.btnPermisos);
            this.pnlMenu.Controls.Add(this.btnUsuarios);
            this.pnlMenu.Controls.Add(this.btnHistorial);
            this.pnlMenu.Controls.Add(this.btnCitas);
            this.pnlMenu.Controls.Add(this.btnEspecialidades);
            this.pnlMenu.Controls.Add(this.btnMedicos);
            this.pnlMenu.Controls.Add(this.btnPacientes);
            this.pnlMenu.Controls.Add(this.pnlSeparador);
            this.pnlMenu.Controls.Add(this.lblBienvenido);
            this.pnlMenu.Controls.Add(this.pnlLogo);
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((43)), ((48)), ((59)));
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(250, 720);
            this.pnlMenu.TabIndex = 5;
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrarSesion.FlatAppearance.BorderSize = 0;
            this.btnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarSesion.BackColor = System.Drawing.Color.FromArgb(((35)), ((39)), ((48)));
            this.btnCerrarSesion.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnCerrarSesion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((214)), ((69)), ((65)));
            this.btnCerrarSesion.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnCerrarSesion.ForeColor = System.Drawing.Color.White;
            this.btnCerrarSesion.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnCerrarSesion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(250, 52);
            this.btnCerrarSesion.TabIndex = 6;
            this.btnCerrarSesion.Text = "   Cerrar sesión";
            this.btnCerrarSesion.UseVisualStyleBackColor = false;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // btnBitacora
            // 
            this.btnBitacora.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBitacora.FlatAppearance.BorderSize = 0;
            this.btnBitacora.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBitacora.BackColor = System.Drawing.Color.FromArgb(((43)), ((48)), ((59)));
            this.btnBitacora.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBitacora.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((62)), ((68)), ((82)));
            this.btnBitacora.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnBitacora.ForeColor = System.Drawing.Color.FromArgb(((220)), ((225)), ((232)));
            this.btnBitacora.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnBitacora.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBitacora.Name = "btnBitacora";
            this.btnBitacora.Size = new System.Drawing.Size(250, 50);
            this.btnBitacora.TabIndex = 7;
            this.btnBitacora.Text = "   Bitácora";
            this.btnBitacora.UseVisualStyleBackColor = false;
            this.btnBitacora.Click += new System.EventHandler(this.btnBitacora_Click);
            // 
            // btnPermisos
            // 
            this.btnPermisos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPermisos.FlatAppearance.BorderSize = 0;
            this.btnPermisos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPermisos.BackColor = System.Drawing.Color.FromArgb(((43)), ((48)), ((59)));
            this.btnPermisos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPermisos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((62)), ((68)), ((82)));
            this.btnPermisos.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnPermisos.ForeColor = System.Drawing.Color.FromArgb(((220)), ((225)), ((232)));
            this.btnPermisos.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnPermisos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPermisos.Name = "btnPermisos";
            this.btnPermisos.Size = new System.Drawing.Size(250, 50);
            this.btnPermisos.TabIndex = 8;
            this.btnPermisos.Text = "   Roles y permisos";
            this.btnPermisos.UseVisualStyleBackColor = false;
            this.btnPermisos.Click += new System.EventHandler(this.btnPermisos_Click);
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUsuarios.FlatAppearance.BorderSize = 0;
            this.btnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuarios.BackColor = System.Drawing.Color.FromArgb(((43)), ((48)), ((59)));
            this.btnUsuarios.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUsuarios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((62)), ((68)), ((82)));
            this.btnUsuarios.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnUsuarios.ForeColor = System.Drawing.Color.FromArgb(((220)), ((225)), ((232)));
            this.btnUsuarios.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnUsuarios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(250, 50);
            this.btnUsuarios.TabIndex = 9;
            this.btnUsuarios.Text = "   Usuarios";
            this.btnUsuarios.UseVisualStyleBackColor = false;
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // btnHistorial
            // 
            this.btnHistorial.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHistorial.FlatAppearance.BorderSize = 0;
            this.btnHistorial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHistorial.BackColor = System.Drawing.Color.FromArgb(((43)), ((48)), ((59)));
            this.btnHistorial.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHistorial.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((62)), ((68)), ((82)));
            this.btnHistorial.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnHistorial.ForeColor = System.Drawing.Color.FromArgb(((220)), ((225)), ((232)));
            this.btnHistorial.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnHistorial.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHistorial.Name = "btnHistorial";
            this.btnHistorial.Size = new System.Drawing.Size(250, 50);
            this.btnHistorial.TabIndex = 10;
            this.btnHistorial.Text = "   Historial clínico";
            this.btnHistorial.UseVisualStyleBackColor = false;
            this.btnHistorial.Click += new System.EventHandler(this.btnHistorial_Click);
            // 
            // btnCitas
            // 
            this.btnCitas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCitas.FlatAppearance.BorderSize = 0;
            this.btnCitas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCitas.BackColor = System.Drawing.Color.FromArgb(((43)), ((48)), ((59)));
            this.btnCitas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCitas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((62)), ((68)), ((82)));
            this.btnCitas.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnCitas.ForeColor = System.Drawing.Color.FromArgb(((220)), ((225)), ((232)));
            this.btnCitas.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnCitas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCitas.Name = "btnCitas";
            this.btnCitas.Size = new System.Drawing.Size(250, 50);
            this.btnCitas.TabIndex = 11;
            this.btnCitas.Text = "   Citas";
            this.btnCitas.UseVisualStyleBackColor = false;
            this.btnCitas.Click += new System.EventHandler(this.btnCitas_Click);
            // 
            // btnEspecialidades
            // 
            this.btnEspecialidades.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEspecialidades.FlatAppearance.BorderSize = 0;
            this.btnEspecialidades.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEspecialidades.BackColor = System.Drawing.Color.FromArgb(((43)), ((48)), ((59)));
            this.btnEspecialidades.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEspecialidades.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((62)), ((68)), ((82)));
            this.btnEspecialidades.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnEspecialidades.ForeColor = System.Drawing.Color.FromArgb(((220)), ((225)), ((232)));
            this.btnEspecialidades.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnEspecialidades.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEspecialidades.Name = "btnEspecialidades";
            this.btnEspecialidades.Size = new System.Drawing.Size(250, 50);
            this.btnEspecialidades.TabIndex = 12;
            this.btnEspecialidades.Text = "   Especialidades";
            this.btnEspecialidades.UseVisualStyleBackColor = false;
            this.btnEspecialidades.Click += new System.EventHandler(this.btnEspecialidades_Click);
            // 
            // btnMedicos
            // 
            this.btnMedicos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMedicos.FlatAppearance.BorderSize = 0;
            this.btnMedicos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMedicos.BackColor = System.Drawing.Color.FromArgb(((43)), ((48)), ((59)));
            this.btnMedicos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMedicos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((62)), ((68)), ((82)));
            this.btnMedicos.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnMedicos.ForeColor = System.Drawing.Color.FromArgb(((220)), ((225)), ((232)));
            this.btnMedicos.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnMedicos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMedicos.Name = "btnMedicos";
            this.btnMedicos.Size = new System.Drawing.Size(250, 50);
            this.btnMedicos.TabIndex = 13;
            this.btnMedicos.Text = "   Médicos";
            this.btnMedicos.UseVisualStyleBackColor = false;
            this.btnMedicos.Click += new System.EventHandler(this.btnMedicos_Click);
            // 
            // btnPacientes
            // 
            this.btnPacientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPacientes.FlatAppearance.BorderSize = 0;
            this.btnPacientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPacientes.BackColor = System.Drawing.Color.FromArgb(((43)), ((48)), ((59)));
            this.btnPacientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPacientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((62)), ((68)), ((82)));
            this.btnPacientes.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnPacientes.ForeColor = System.Drawing.Color.FromArgb(((220)), ((225)), ((232)));
            this.btnPacientes.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnPacientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPacientes.Name = "btnPacientes";
            this.btnPacientes.Size = new System.Drawing.Size(250, 50);
            this.btnPacientes.TabIndex = 14;
            this.btnPacientes.Text = "   Pacientes";
            this.btnPacientes.UseVisualStyleBackColor = false;
            this.btnPacientes.Click += new System.EventHandler(this.btnPacientes_Click);
            // 
            // pnlSeparador
            // 
            this.pnlSeparador.BackColor = System.Drawing.Color.FromArgb(((62)), ((68)), ((82)));
            this.pnlSeparador.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSeparador.Name = "pnlSeparador";
            this.pnlSeparador.Size = new System.Drawing.Size(250, 1);
            this.pnlSeparador.TabIndex = 15;
            // 
            // lblBienvenido
            // 
            this.lblBienvenido.AutoSize = false;
            this.lblBienvenido.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblBienvenido.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblBienvenido.ForeColor = System.Drawing.Color.FromArgb(((200)), ((206)), ((215)));
            this.lblBienvenido.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblBienvenido.Name = "lblBienvenido";
            this.lblBienvenido.Size = new System.Drawing.Size(250, 90);
            this.lblBienvenido.TabIndex = 16;
            this.lblBienvenido.Text = "Bienvenido";
            // 
            // pnlLogo
            // 
            this.pnlLogo.Controls.Add(this.lblLogo);
            this.pnlLogo.BackColor = System.Drawing.Color.FromArgb(((35)), ((39)), ((48)));
            this.pnlLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(250, 70);
            this.pnlLogo.TabIndex = 17;
            // 
            // lblLogo
            // 
            this.lblLogo.AutoSize = false;
            this.lblLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblLogo.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lblLogo.ForeColor = System.Drawing.Color.FromArgb(((41)), ((182)), ((182)));
            this.lblLogo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(250, 70);
            this.lblLogo.TabIndex = 18;
            this.lblLogo.Text = "✚  Clínica Médica";
            // 
            // frmDashboardPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((245)), ((247)), ((250)));
            this.ClientSize = new System.Drawing.Size(1350, 720);
            this.Controls.Add(this.pnlContenedor);
            this.Controls.Add(this.pnlSuperior);
            this.Controls.Add(this.pnlMenu);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ForeColor = System.Drawing.Color.FromArgb(((52)), ((58)), ((70)));
            this.MinimumSize = new System.Drawing.Size(1200, 700);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Name = "frmDashboardPrincipal";
            this.Text = "Clínica Médica";
            this.Load += new System.EventHandler(this.frmDashboardPrincipal_Load);
            this.pnlLogo.ResumeLayout(false);
            this.pnlSeparador.ResumeLayout(false);
            this.pnlMenu.ResumeLayout(false);
            this.pnlLineaSuperior.ResumeLayout(false);
            this.pnlSuperior.ResumeLayout(false);
            this.pnlContenedor.ResumeLayout(false);
            this.pnlContenedor.PerformLayout();
            this.pnlSuperior.PerformLayout();
            this.pnlLineaSuperior.PerformLayout();
            this.pnlMenu.PerformLayout();
            this.pnlSeparador.PerformLayout();
            this.pnlLogo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlContenedor;
        private System.Windows.Forms.Label lblInicio;
        private System.Windows.Forms.Panel pnlSuperior;
        private System.Windows.Forms.Panel pnlLineaSuperior;
        private System.Windows.Forms.Label lblSistema;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Button btnCerrarSesion;
        private System.Windows.Forms.Button btnBitacora;
        private System.Windows.Forms.Button btnPermisos;
        private System.Windows.Forms.Button btnUsuarios;
        private System.Windows.Forms.Button btnHistorial;
        private System.Windows.Forms.Button btnCitas;
        private System.Windows.Forms.Button btnEspecialidades;
        private System.Windows.Forms.Button btnMedicos;
        private System.Windows.Forms.Button btnPacientes;
        private System.Windows.Forms.Panel pnlSeparador;
        private System.Windows.Forms.Label lblBienvenido;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.Label lblLogo;
    }
}
