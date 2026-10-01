using ClinicaMedica.Modelo.DAO;
using ClinicaMedica.Modelo.Entidades;
using ClinicaMedica.Modelo.Utilidades;

namespace ClinicaMedica.Vista
{
    /// <summary>
    /// Menú principal. Los botones se muestran u ocultan según los PERMISOS del rol del usuario.
    /// </summary>
    public class FrmPrincipal : Form
    {
        private readonly FlowLayoutPanel menu;
        private readonly DataGridView gridHoy;
        private readonly Label lblResumen;
        private bool cerrandoSesion;

        public FrmPrincipal()
        {
            Text = "Clínica Médica - Menú principal";
            Size = new Size(1150, 680);
            MinimumSize = new Size(900, 560);
            StartPosition = FormStartPosition.CenterScreen;
            BackColor = Estilos.Fondo;
            Font = Estilos.Texto;

            // ----- Contenido central: citas del día -----
            var centro = new Panel { Dock = DockStyle.Fill, Padding = new Padding(20) };
            gridHoy = new DataGridView { Dock = DockStyle.Fill };
            Estilos.AplicarEstiloGrid(gridHoy);
            lblResumen = new Label { Dock = DockStyle.Top, Height = 40, Font = Estilos.Negrita, ForeColor = Estilos.PrimarioOscuro };
            var lblHoy = new Label
            {
                Dock = DockStyle.Top, Height = 40, Font = new Font("Segoe UI", 14F, FontStyle.Bold),
                Text = "Agenda de hoy - " + DateTime.Today.ToString("dddd dd 'de' MMMM yyyy")
            };
            centro.Controls.Add(gridHoy);
            centro.Controls.Add(lblResumen);
            centro.Controls.Add(lblHoy);

            // ----- Menú lateral -----
            menu = new FlowLayoutPanel
            {
                Dock = DockStyle.Left, Width = 240, BackColor = Estilos.PrimarioOscuro,
                FlowDirection = FlowDirection.TopDown, WrapContents = false, Padding = new Padding(10, 15, 10, 10)
            };

            // ----- Encabezado -----
            var encabezado = new Panel { Dock = DockStyle.Top, Height = 70, BackColor = Estilos.Primario };
            encabezado.Controls.Add(new Label
            {
                Text = "✚ Clínica Médica", ForeColor = Color.White, Font = Estilos.Titulo, AutoSize = true, Location = new Point(18, 18)
            });
            var lblUsuario = new Label
            {
                Text = $"{Sesion.Usuario.NombreCompleto}\nRol: {Sesion.Usuario.NombreRol}",
                ForeColor = Color.White, AutoSize = false, TextAlign = ContentAlignment.MiddleRight,
                Dock = DockStyle.Right, Width = 400, Padding = new Padding(0, 0, 20, 0)
            };
            encabezado.Controls.Add(lblUsuario);

            Controls.Add(centro);
            Controls.Add(menu);
            Controls.Add(encabezado);

            CrearMenu();
            Load += (s, e) => CargarAgendaDelDia();
            FormClosing += AlCerrar;
        }

        /// <summary>Cada opción se agrega solo si el usuario tiene el permiso correspondiente.</summary>
        private void CrearMenu()
        {
            Opcion("Citas", () => new FrmCitas(), P.CitasAgendar, P.CitasVerTodas, P.CitasVerPropias);
            Opcion("Pacientes", () => new FrmPacientes(), P.PacientesVer, P.PacientesGestionar);
            Opcion("Historial clínico", () => new FrmHistorial(), P.HistorialVer);
            Opcion("Médicos", () => new FrmMedicos(), P.MedicosGestionar);
            Opcion("Especialidades", () => new FrmEspecialidades(), P.EspecialidadesGestionar);
            Opcion("Usuarios", () => new FrmUsuarios(), P.UsuariosGestionar);
            Opcion("Roles y permisos", () => new FrmRolesPermisos(), P.RolesGestionar);
            Opcion("Bitácora", () => new FrmBitacora(), P.BitacoraVer);

            menu.Controls.Add(new Label { Height = 20, Width = 210 }); // separador
            menu.Controls.Add(BotonMenu("Cambiar contraseña", (s, e) =>
            {
                using (var f = new FrmCambiarClave()) f.ShowDialog(this);
            }));
            menu.Controls.Add(BotonMenu("Cerrar sesión", (s, e) =>
            {
                if (!Mensaje.Confirmar("¿Desea cerrar sesión?")) return;
                cerrandoSesion = true;
                DialogResult = DialogResult.Retry;
            }));
        }

        private void Opcion(string texto, Func<Form> crear, params string[] permisos)
        {
            if (!permisos.Any(Sesion.TienePermiso)) return;   // sin permiso: la opción ni siquiera aparece
            menu.Controls.Add(BotonMenu(texto, (s, e) => Abrir(crear)));
        }

        private static Button BotonMenu(string texto, EventHandler click)
        {
            var b = Estilos.CrearBoton(texto, Estilos.PrimarioOscuro, click, 215);
            b.TextAlign = ContentAlignment.MiddleLeft;
            b.Height = 44;
            b.FlatAppearance.MouseOverBackColor = Estilos.Primario;
            return b;
        }

        private void Abrir(Func<Form> crear)
        {
            try
            {
                using (var frm = crear())
                    frm.ShowDialog(this);
                CargarAgendaDelDia();
            }
            catch (Exception ex)
            {
                Logger.Error(ex, "Abrir formulario");
                Mensaje.Error("No se pudo abrir la pantalla: " + ex.Message);
            }
        }

        private void CargarAgendaDelDia()
        {
            try
            {
                bool puedeVerTodas = Sesion.TienePermiso(P.CitasVerTodas);
                bool puedeVerPropias = Sesion.TienePermiso(P.CitasVerPropias);
                if (!puedeVerTodas && !(puedeVerPropias && Sesion.IdMedico != null))
                {
                    lblResumen.Text = "Seleccione una opción del menú.";
                    return;
                }
                int? idMedico = puedeVerTodas ? null : Sesion.IdMedico;
                List<Cita> citas = new CitaDAO().Listar("", DateTime.Today, idMedico).OrderBy(c => c.Hora).ToList();
                gridHoy.DataSource = citas;
                if (gridHoy.Columns.Contains("Fecha")) gridHoy.Columns["Fecha"].Visible = false;
                if (gridHoy.Columns.Contains("Hora")) gridHoy.Columns["Hora"].DefaultCellStyle.Format = @"hh\:mm";
                lblResumen.Text = $"Total: {citas.Count}   |   Pendientes: {citas.Count(c => c.Estado == "Pendiente" || c.Estado == "Confirmada")}" +
                                  $"   |   Atendidas: {citas.Count(c => c.Estado == "Atendida")}   |   Canceladas: {citas.Count(c => c.Estado == "Cancelada")}";
            }
            catch (ExcepcionDatos ex) { lblResumen.Text = ex.Message; }
            catch (Exception ex)
            {
                Logger.Error(ex, "Agenda del día");
                lblResumen.Text = "No se pudo cargar la agenda del día.";
            }
        }

        private void AlCerrar(object sender, FormClosingEventArgs e)
        {
            if (!cerrandoSesion && !Mensaje.Confirmar("¿Desea salir del sistema?"))
            {
                e.Cancel = true;
                return;
            }
            Logger.Actividad("LOGOUT", "Login", $"Cierre de sesión de {Sesion.Usuario?.NombreUsuario}");
        }
    }
}
