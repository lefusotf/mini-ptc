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
            this.lblBienvenido = new System.Windows.Forms.Label();
            this.pnlContenedor.SuspendLayout();
            this.pnlMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlContenedor
            // 
            this.pnlContenedor.Controls.Add(this.lblInicio);
            this.pnlContenedor.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenedor.Name = "pnlContenedor";
            this.pnlContenedor.Size = new System.Drawing.Size(1100, 700);
            this.pnlContenedor.TabIndex = 0;
            // 
            // lblInicio
            // 
            this.lblInicio.AutoSize = true;
            this.lblInicio.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.lblInicio.ForeColor = System.Drawing.Color.FromArgb(((62)), ((68)), ((82)));
            this.lblInicio.Location = new System.Drawing.Point(300, 300);
            this.lblInicio.Name = "lblInicio";
            this.lblInicio.TabIndex = 1;
            this.lblInicio.Text = "Seleccione una opción del menú";
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
            this.pnlMenu.Controls.Add(this.lblBienvenido);
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((43)), ((48)), ((59)));
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(230, 700);
            this.pnlMenu.TabIndex = 2;
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrarSesion.FlatAppearance.BorderSize = 0;
            this.btnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarSesion.ForeColor = System.Drawing.Color.White;
            this.btnCerrarSesion.BackColor = System.Drawing.Color.FromArgb(((220)), ((53)), ((69)));
            this.btnCerrarSesion.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnCerrarSesion.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(230, 50);
            this.btnCerrarSesion.TabIndex = 3;
            this.btnCerrarSesion.Text = "Cerrar sesión";
            this.btnCerrarSesion.UseVisualStyleBackColor = false;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // btnBitacora
            // 
            this.btnBitacora.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBitacora.FlatAppearance.BorderSize = 0;
            this.btnBitacora.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBitacora.ForeColor = System.Drawing.Color.White;
            this.btnBitacora.BackColor = System.Drawing.Color.FromArgb(((43)), ((48)), ((59)));
            this.btnBitacora.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBitacora.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnBitacora.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnBitacora.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBitacora.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((41)), ((182)), ((182)));
            this.btnBitacora.Name = "btnBitacora";
            this.btnBitacora.Size = new System.Drawing.Size(230, 55);
            this.btnBitacora.TabIndex = 4;
            this.btnBitacora.Text = "Bitácora";
            this.btnBitacora.UseVisualStyleBackColor = false;
            this.btnBitacora.Click += new System.EventHandler(this.btnBitacora_Click);
            // 
            // btnPermisos
            // 
            this.btnPermisos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPermisos.FlatAppearance.BorderSize = 0;
            this.btnPermisos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPermisos.ForeColor = System.Drawing.Color.White;
            this.btnPermisos.BackColor = System.Drawing.Color.FromArgb(((43)), ((48)), ((59)));
            this.btnPermisos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPermisos.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnPermisos.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnPermisos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPermisos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((41)), ((182)), ((182)));
            this.btnPermisos.Name = "btnPermisos";
            this.btnPermisos.Size = new System.Drawing.Size(230, 55);
            this.btnPermisos.TabIndex = 5;
            this.btnPermisos.Text = "Roles y permisos";
            this.btnPermisos.UseVisualStyleBackColor = false;
            this.btnPermisos.Click += new System.EventHandler(this.btnPermisos_Click);
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUsuarios.FlatAppearance.BorderSize = 0;
            this.btnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuarios.ForeColor = System.Drawing.Color.White;
            this.btnUsuarios.BackColor = System.Drawing.Color.FromArgb(((43)), ((48)), ((59)));
            this.btnUsuarios.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUsuarios.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnUsuarios.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnUsuarios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsuarios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((41)), ((182)), ((182)));
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(230, 55);
            this.btnUsuarios.TabIndex = 6;
            this.btnUsuarios.Text = "Usuarios";
            this.btnUsuarios.UseVisualStyleBackColor = false;
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // btnHistorial
            // 
            this.btnHistorial.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHistorial.FlatAppearance.BorderSize = 0;
            this.btnHistorial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHistorial.ForeColor = System.Drawing.Color.White;
            this.btnHistorial.BackColor = System.Drawing.Color.FromArgb(((43)), ((48)), ((59)));
            this.btnHistorial.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHistorial.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnHistorial.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnHistorial.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHistorial.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((41)), ((182)), ((182)));
            this.btnHistorial.Name = "btnHistorial";
            this.btnHistorial.Size = new System.Drawing.Size(230, 55);
            this.btnHistorial.TabIndex = 7;
            this.btnHistorial.Text = "Historial clínico";
            this.btnHistorial.UseVisualStyleBackColor = false;
            this.btnHistorial.Click += new System.EventHandler(this.btnHistorial_Click);
            // 
            // btnCitas
            // 
            this.btnCitas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCitas.FlatAppearance.BorderSize = 0;
            this.btnCitas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCitas.ForeColor = System.Drawing.Color.White;
            this.btnCitas.BackColor = System.Drawing.Color.FromArgb(((43)), ((48)), ((59)));
            this.btnCitas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCitas.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnCitas.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnCitas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCitas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((41)), ((182)), ((182)));
            this.btnCitas.Name = "btnCitas";
            this.btnCitas.Size = new System.Drawing.Size(230, 55);
            this.btnCitas.TabIndex = 8;
            this.btnCitas.Text = "Citas";
            this.btnCitas.UseVisualStyleBackColor = false;
            this.btnCitas.Click += new System.EventHandler(this.btnCitas_Click);
            // 
            // btnEspecialidades
            // 
            this.btnEspecialidades.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEspecialidades.FlatAppearance.BorderSize = 0;
            this.btnEspecialidades.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEspecialidades.ForeColor = System.Drawing.Color.White;
            this.btnEspecialidades.BackColor = System.Drawing.Color.FromArgb(((43)), ((48)), ((59)));
            this.btnEspecialidades.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEspecialidades.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnEspecialidades.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnEspecialidades.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEspecialidades.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((41)), ((182)), ((182)));
            this.btnEspecialidades.Name = "btnEspecialidades";
            this.btnEspecialidades.Size = new System.Drawing.Size(230, 55);
            this.btnEspecialidades.TabIndex = 9;
            this.btnEspecialidades.Text = "Especialidades";
            this.btnEspecialidades.UseVisualStyleBackColor = false;
            this.btnEspecialidades.Click += new System.EventHandler(this.btnEspecialidades_Click);
            // 
            // btnMedicos
            // 
            this.btnMedicos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMedicos.FlatAppearance.BorderSize = 0;
            this.btnMedicos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMedicos.ForeColor = System.Drawing.Color.White;
            this.btnMedicos.BackColor = System.Drawing.Color.FromArgb(((43)), ((48)), ((59)));
            this.btnMedicos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMedicos.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnMedicos.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnMedicos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMedicos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((41)), ((182)), ((182)));
            this.btnMedicos.Name = "btnMedicos";
            this.btnMedicos.Size = new System.Drawing.Size(230, 55);
            this.btnMedicos.TabIndex = 10;
            this.btnMedicos.Text = "Médicos";
            this.btnMedicos.UseVisualStyleBackColor = false;
            this.btnMedicos.Click += new System.EventHandler(this.btnMedicos_Click);
            // 
            // btnPacientes
            // 
            this.btnPacientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPacientes.FlatAppearance.BorderSize = 0;
            this.btnPacientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPacientes.ForeColor = System.Drawing.Color.White;
            this.btnPacientes.BackColor = System.Drawing.Color.FromArgb(((43)), ((48)), ((59)));
            this.btnPacientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPacientes.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnPacientes.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnPacientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPacientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((41)), ((182)), ((182)));
            this.btnPacientes.Name = "btnPacientes";
            this.btnPacientes.Size = new System.Drawing.Size(230, 55);
            this.btnPacientes.TabIndex = 11;
            this.btnPacientes.Text = "Pacientes";
            this.btnPacientes.UseVisualStyleBackColor = false;
            this.btnPacientes.Click += new System.EventHandler(this.btnPacientes_Click);
            // 
            // lblBienvenido
            // 
            this.lblBienvenido.AutoSize = true;
            this.lblBienvenido.AutoSize = false;
            this.lblBienvenido.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblBienvenido.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblBienvenido.ForeColor = System.Drawing.Color.White;
            this.lblBienvenido.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblBienvenido.Name = "lblBienvenido";
            this.lblBienvenido.Size = new System.Drawing.Size(230, 110);
            this.lblBienvenido.TabIndex = 12;
            this.lblBienvenido.Text = "Bienvenido";
            // 
            // frmDashboardPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1330, 700);
            this.Controls.Add(this.pnlContenedor);
            this.Controls.Add(this.pnlMenu);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.MinimumSize = new System.Drawing.Size(1200, 700);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Name = "frmDashboardPrincipal";
            this.Text = "Clínica Médica";
            this.Load += new System.EventHandler(this.frmDashboardPrincipal_Load);
            this.pnlMenu.ResumeLayout(false);
            this.pnlContenedor.ResumeLayout(false);
            this.pnlContenedor.PerformLayout();
            this.pnlMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlContenedor;
        private System.Windows.Forms.Label lblInicio;
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
        private System.Windows.Forms.Label lblBienvenido;
    }
}
