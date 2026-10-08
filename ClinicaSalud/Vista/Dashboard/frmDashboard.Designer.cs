namespace Vista.Dashboard
{
    partial class frmDashboard
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
            this.pnlSuperior = new System.Windows.Forms.Panel();
            this.pnlLineaSuperior = new System.Windows.Forms.Panel();
            this.lblTituloModulo = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
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
            this.btnInicio = new System.Windows.Forms.Button();
            this.lblMenu = new System.Windows.Forms.Label();
            this.pnlUsuario = new System.Windows.Forms.Panel();
            this.lblNombreUsuario = new System.Windows.Forms.Label();
            this.lblRolUsuario = new System.Windows.Forms.Label();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.lblLogoIcono = new System.Windows.Forms.Label();
            this.lblLogo = new System.Windows.Forms.Label();
            this.pnlContenedor.SuspendLayout();
            this.pnlSuperior.SuspendLayout();
            this.pnlLineaSuperior.SuspendLayout();
            this.pnlMenu.SuspendLayout();
            this.pnlUsuario.SuspendLayout();
            this.pnlLogo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlContenedor
            // 
            this.pnlContenedor.BackColor = System.Drawing.Color.FromArgb(((241)), ((245)), ((249)));
            this.pnlContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenedor.Name = "pnlContenedor";
            this.pnlContenedor.Size = new System.Drawing.Size(1110, 648);
            this.pnlContenedor.TabIndex = 0;
            // 
            // pnlSuperior
            // 
            this.pnlSuperior.Controls.Add(this.pnlLineaSuperior);
            this.pnlSuperior.Controls.Add(this.lblTituloModulo);
            this.pnlSuperior.Controls.Add(this.lblFecha);
            this.pnlSuperior.BackColor = System.Drawing.Color.White;
            this.pnlSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSuperior.Name = "pnlSuperior";
            this.pnlSuperior.Size = new System.Drawing.Size(1110, 72);
            this.pnlSuperior.TabIndex = 1;
            // 
            // pnlLineaSuperior
            // 
            this.pnlLineaSuperior.BackColor = System.Drawing.Color.FromArgb(((226)), ((232)), ((240)));
            this.pnlLineaSuperior.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlLineaSuperior.Name = "pnlLineaSuperior";
            this.pnlLineaSuperior.Size = new System.Drawing.Size(1110, 1);
            this.pnlLineaSuperior.TabIndex = 2;
            // 
            // lblTituloModulo
            // 
            this.lblTituloModulo.AutoSize = true;
            this.lblTituloModulo.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTituloModulo.ForeColor = System.Drawing.Color.FromArgb(((15)), ((23)), ((42)));
            this.lblTituloModulo.Location = new System.Drawing.Point(28, 10);
            this.lblTituloModulo.Name = "lblTituloModulo";
            this.lblTituloModulo.TabIndex = 3;
            this.lblTituloModulo.Text = "Inicio";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblFecha.ForeColor = System.Drawing.Color.FromArgb(((100)), ((116)), ((139)));
            this.lblFecha.Location = new System.Drawing.Point(30, 42);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.TabIndex = 4;
            this.lblFecha.Text = "Fecha";
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
            this.pnlMenu.Controls.Add(this.btnInicio);
            this.pnlMenu.Controls.Add(this.lblMenu);
            this.pnlMenu.Controls.Add(this.pnlUsuario);
            this.pnlMenu.Controls.Add(this.pnlLogo);
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((15)), ((23)), ((42)));
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(240, 720);
            this.pnlMenu.TabIndex = 5;
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrarSesion.FlatAppearance.BorderSize = 0;
            this.btnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarSesion.BackColor = System.Drawing.Color.FromArgb(((15)), ((23)), ((42)));
            this.btnCerrarSesion.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnCerrarSesion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((239)), ((68)), ((68)));
            this.btnCerrarSesion.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.btnCerrarSesion.ForeColor = System.Drawing.Color.FromArgb(((248)), ((113)), ((113)));
            this.btnCerrarSesion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(240, 50);
            this.btnCerrarSesion.TabIndex = 6;
            this.btnCerrarSesion.Text = "      Cerrar sesión";
            this.btnCerrarSesion.UseVisualStyleBackColor = false;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // btnBitacora
            // 
            this.btnBitacora.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBitacora.FlatAppearance.BorderSize = 0;
            this.btnBitacora.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBitacora.BackColor = System.Drawing.Color.FromArgb(((15)), ((23)), ((42)));
            this.btnBitacora.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBitacora.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((30)), ((41)), ((59)));
            this.btnBitacora.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.btnBitacora.ForeColor = System.Drawing.Color.FromArgb(((203)), ((213)), ((225)));
            this.btnBitacora.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBitacora.Name = "btnBitacora";
            this.btnBitacora.Size = new System.Drawing.Size(240, 46);
            this.btnBitacora.TabIndex = 7;
            this.btnBitacora.Text = "      Bitácora";
            this.btnBitacora.UseVisualStyleBackColor = false;
            this.btnBitacora.Click += new System.EventHandler(this.btnBitacora_Click);
            // 
            // btnPermisos
            // 
            this.btnPermisos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPermisos.FlatAppearance.BorderSize = 0;
            this.btnPermisos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPermisos.BackColor = System.Drawing.Color.FromArgb(((15)), ((23)), ((42)));
            this.btnPermisos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPermisos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((30)), ((41)), ((59)));
            this.btnPermisos.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.btnPermisos.ForeColor = System.Drawing.Color.FromArgb(((203)), ((213)), ((225)));
            this.btnPermisos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPermisos.Name = "btnPermisos";
            this.btnPermisos.Size = new System.Drawing.Size(240, 46);
            this.btnPermisos.TabIndex = 8;
            this.btnPermisos.Text = "      Roles y permisos";
            this.btnPermisos.UseVisualStyleBackColor = false;
            this.btnPermisos.Click += new System.EventHandler(this.btnPermisos_Click);
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUsuarios.FlatAppearance.BorderSize = 0;
            this.btnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuarios.BackColor = System.Drawing.Color.FromArgb(((15)), ((23)), ((42)));
            this.btnUsuarios.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUsuarios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((30)), ((41)), ((59)));
            this.btnUsuarios.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.btnUsuarios.ForeColor = System.Drawing.Color.FromArgb(((203)), ((213)), ((225)));
            this.btnUsuarios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(240, 46);
            this.btnUsuarios.TabIndex = 9;
            this.btnUsuarios.Text = "      Usuarios";
            this.btnUsuarios.UseVisualStyleBackColor = false;
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // btnHistorial
            // 
            this.btnHistorial.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHistorial.FlatAppearance.BorderSize = 0;
            this.btnHistorial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHistorial.BackColor = System.Drawing.Color.FromArgb(((15)), ((23)), ((42)));
            this.btnHistorial.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHistorial.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((30)), ((41)), ((59)));
            this.btnHistorial.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.btnHistorial.ForeColor = System.Drawing.Color.FromArgb(((203)), ((213)), ((225)));
            this.btnHistorial.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHistorial.Name = "btnHistorial";
            this.btnHistorial.Size = new System.Drawing.Size(240, 46);
            this.btnHistorial.TabIndex = 10;
            this.btnHistorial.Text = "      Historial clínico";
            this.btnHistorial.UseVisualStyleBackColor = false;
            this.btnHistorial.Click += new System.EventHandler(this.btnHistorial_Click);
            // 
            // btnCitas
            // 
            this.btnCitas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCitas.FlatAppearance.BorderSize = 0;
            this.btnCitas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCitas.BackColor = System.Drawing.Color.FromArgb(((15)), ((23)), ((42)));
            this.btnCitas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCitas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((30)), ((41)), ((59)));
            this.btnCitas.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.btnCitas.ForeColor = System.Drawing.Color.FromArgb(((203)), ((213)), ((225)));
            this.btnCitas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCitas.Name = "btnCitas";
            this.btnCitas.Size = new System.Drawing.Size(240, 46);
            this.btnCitas.TabIndex = 11;
            this.btnCitas.Text = "      Citas";
            this.btnCitas.UseVisualStyleBackColor = false;
            this.btnCitas.Click += new System.EventHandler(this.btnCitas_Click);
            // 
            // btnEspecialidades
            // 
            this.btnEspecialidades.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEspecialidades.FlatAppearance.BorderSize = 0;
            this.btnEspecialidades.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEspecialidades.BackColor = System.Drawing.Color.FromArgb(((15)), ((23)), ((42)));
            this.btnEspecialidades.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEspecialidades.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((30)), ((41)), ((59)));
            this.btnEspecialidades.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.btnEspecialidades.ForeColor = System.Drawing.Color.FromArgb(((203)), ((213)), ((225)));
            this.btnEspecialidades.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEspecialidades.Name = "btnEspecialidades";
            this.btnEspecialidades.Size = new System.Drawing.Size(240, 46);
            this.btnEspecialidades.TabIndex = 12;
            this.btnEspecialidades.Text = "      Especialidades";
            this.btnEspecialidades.UseVisualStyleBackColor = false;
            this.btnEspecialidades.Click += new System.EventHandler(this.btnEspecialidades_Click);
            // 
            // btnMedicos
            // 
            this.btnMedicos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMedicos.FlatAppearance.BorderSize = 0;
            this.btnMedicos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMedicos.BackColor = System.Drawing.Color.FromArgb(((15)), ((23)), ((42)));
            this.btnMedicos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMedicos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((30)), ((41)), ((59)));
            this.btnMedicos.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.btnMedicos.ForeColor = System.Drawing.Color.FromArgb(((203)), ((213)), ((225)));
            this.btnMedicos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMedicos.Name = "btnMedicos";
            this.btnMedicos.Size = new System.Drawing.Size(240, 46);
            this.btnMedicos.TabIndex = 13;
            this.btnMedicos.Text = "      Médicos";
            this.btnMedicos.UseVisualStyleBackColor = false;
            this.btnMedicos.Click += new System.EventHandler(this.btnMedicos_Click);
            // 
            // btnPacientes
            // 
            this.btnPacientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPacientes.FlatAppearance.BorderSize = 0;
            this.btnPacientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPacientes.BackColor = System.Drawing.Color.FromArgb(((15)), ((23)), ((42)));
            this.btnPacientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPacientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((30)), ((41)), ((59)));
            this.btnPacientes.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.btnPacientes.ForeColor = System.Drawing.Color.FromArgb(((203)), ((213)), ((225)));
            this.btnPacientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPacientes.Name = "btnPacientes";
            this.btnPacientes.Size = new System.Drawing.Size(240, 46);
            this.btnPacientes.TabIndex = 14;
            this.btnPacientes.Text = "      Pacientes";
            this.btnPacientes.UseVisualStyleBackColor = false;
            this.btnPacientes.Click += new System.EventHandler(this.btnPacientes_Click);
            // 
            // btnInicio
            // 
            this.btnInicio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInicio.FlatAppearance.BorderSize = 0;
            this.btnInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInicio.BackColor = System.Drawing.Color.FromArgb(((15)), ((23)), ((42)));
            this.btnInicio.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInicio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((30)), ((41)), ((59)));
            this.btnInicio.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.btnInicio.ForeColor = System.Drawing.Color.FromArgb(((203)), ((213)), ((225)));
            this.btnInicio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(240, 46);
            this.btnInicio.TabIndex = 15;
            this.btnInicio.Text = "      Inicio";
            this.btnInicio.UseVisualStyleBackColor = false;
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            // 
            // lblMenu
            // 
            this.lblMenu.AutoSize = false;
            this.lblMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblMenu.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblMenu.ForeColor = System.Drawing.Color.FromArgb(((100)), ((116)), ((139)));
            this.lblMenu.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(240, 40);
            this.lblMenu.TabIndex = 16;
            this.lblMenu.Text = "      MENÚ";
            // 
            // pnlUsuario
            // 
            this.pnlUsuario.Controls.Add(this.lblNombreUsuario);
            this.pnlUsuario.Controls.Add(this.lblRolUsuario);
            this.pnlUsuario.BackColor = System.Drawing.Color.FromArgb(((30)), ((41)), ((59)));
            this.pnlUsuario.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUsuario.Name = "pnlUsuario";
            this.pnlUsuario.Size = new System.Drawing.Size(240, 80);
            this.pnlUsuario.TabIndex = 17;
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.AutoSize = true;
            this.lblNombreUsuario.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblNombreUsuario.ForeColor = System.Drawing.Color.White;
            this.lblNombreUsuario.Location = new System.Drawing.Point(22, 18);
            this.lblNombreUsuario.Name = "lblNombreUsuario";
            this.lblNombreUsuario.TabIndex = 18;
            this.lblNombreUsuario.Text = "Usuario";
            // 
            // lblRolUsuario
            // 
            this.lblRolUsuario.AutoSize = true;
            this.lblRolUsuario.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblRolUsuario.ForeColor = System.Drawing.Color.FromArgb(((148)), ((163)), ((184)));
            this.lblRolUsuario.Location = new System.Drawing.Point(23, 44);
            this.lblRolUsuario.Name = "lblRolUsuario";
            this.lblRolUsuario.TabIndex = 19;
            this.lblRolUsuario.Text = "Rol";
            // 
            // pnlLogo
            // 
            this.pnlLogo.Controls.Add(this.lblLogoIcono);
            this.pnlLogo.Controls.Add(this.lblLogo);
            this.pnlLogo.BackColor = System.Drawing.Color.FromArgb(((15)), ((23)), ((42)));
            this.pnlLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(240, 72);
            this.pnlLogo.TabIndex = 20;
            // 
            // lblLogoIcono
            // 
            this.lblLogoIcono.AutoSize = true;
            this.lblLogoIcono.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblLogoIcono.ForeColor = System.Drawing.Color.FromArgb(((96)), ((165)), ((250)));
            this.lblLogoIcono.Location = new System.Drawing.Point(22, 18);
            this.lblLogoIcono.Name = "lblLogoIcono";
            this.lblLogoIcono.TabIndex = 21;
            this.lblLogoIcono.Text = "✚";
            // 
            // lblLogo
            // 
            this.lblLogo.AutoSize = true;
            this.lblLogo.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lblLogo.ForeColor = System.Drawing.Color.White;
            this.lblLogo.Location = new System.Drawing.Point(55, 22);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.TabIndex = 22;
            this.lblLogo.Text = "Clínica Salud";
            // 
            // frmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((241)), ((245)), ((249)));
            this.ClientSize = new System.Drawing.Size(1350, 720);
            this.Controls.Add(this.pnlContenedor);
            this.Controls.Add(this.pnlSuperior);
            this.Controls.Add(this.pnlMenu);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ForeColor = System.Drawing.Color.FromArgb(((30)), ((41)), ((59)));
            this.MinimumSize = new System.Drawing.Size(1150, 700);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Name = "frmDashboard";
            this.Text = "Clínica Salud";
            this.Load += new System.EventHandler(this.frmDashboard_Load);
            this.pnlLogo.ResumeLayout(false);
            this.pnlUsuario.ResumeLayout(false);
            this.pnlMenu.ResumeLayout(false);
            this.pnlLineaSuperior.ResumeLayout(false);
            this.pnlSuperior.ResumeLayout(false);
            this.pnlContenedor.ResumeLayout(false);
            this.pnlContenedor.PerformLayout();
            this.pnlSuperior.PerformLayout();
            this.pnlLineaSuperior.PerformLayout();
            this.pnlMenu.PerformLayout();
            this.pnlUsuario.PerformLayout();
            this.pnlLogo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlContenedor;
        private System.Windows.Forms.Panel pnlSuperior;
        private System.Windows.Forms.Panel pnlLineaSuperior;
        private System.Windows.Forms.Label lblTituloModulo;
        private System.Windows.Forms.Label lblFecha;
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
        private System.Windows.Forms.Button btnInicio;
        private System.Windows.Forms.Label lblMenu;
        private System.Windows.Forms.Panel pnlUsuario;
        private System.Windows.Forms.Label lblNombreUsuario;
        private System.Windows.Forms.Label lblRolUsuario;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.Label lblLogoIcono;
        private System.Windows.Forms.Label lblLogo;
    }
}
