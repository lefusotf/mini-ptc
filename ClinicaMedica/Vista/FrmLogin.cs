using ClinicaMedica.Modelo;
using ClinicaMedica.Modelo.DAO;
using ClinicaMedica.Modelo.Utilidades;

namespace ClinicaMedica.Vista
{
    /// <summary>Pantalla de inicio de sesión. Valida campos y autentica con BCrypt.</summary>
    public class FrmLogin : Form
    {
        private readonly TextBox txtUsuario, txtClave;
        private readonly CheckBox chkMostrar;
        private readonly Button btnIngresar, btnSalir;
        private readonly Label lblEstado;
        private readonly ErrorProvider errores = new ErrorProvider { BlinkStyle = ErrorBlinkStyle.NeverBlink };

        public FrmLogin()
        {
            Text = "Iniciar sesión - Clínica Médica";
            Size = new Size(760, 440);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            StartPosition = FormStartPosition.CenterScreen;
            BackColor = Color.White;
            Font = Estilos.Texto;

            // ----- Panel izquierdo (marca) -----
            var panelMarca = new Panel { Dock = DockStyle.Left, Width = 300, BackColor = Estilos.Primario };
            panelMarca.Controls.Add(new Label
            {
                Text = "✚",
                Font = new Font("Segoe UI", 60F, FontStyle.Bold),
                ForeColor = Color.White,
                AutoSize = false,
                TextAlign = ContentAlignment.MiddleCenter,
                Bounds = new Rectangle(0, 50, 300, 120)
            });
            panelMarca.Controls.Add(new Label
            {
                Text = "Clínica Médica\nSistema de Gestión",
                Font = new Font("Segoe UI", 16F, FontStyle.Bold),
                ForeColor = Color.White,
                AutoSize = false,
                TextAlign = ContentAlignment.MiddleCenter,
                Bounds = new Rectangle(0, 180, 300, 80)
            });
            panelMarca.Controls.Add(new Label
            {
                Text = "Pacientes • Médicos • Citas • Historial",
                ForeColor = Color.FromArgb(200, 235, 238),
                AutoSize = false,
                TextAlign = ContentAlignment.MiddleCenter,
                Bounds = new Rectangle(0, 270, 300, 30)
            });

            // ----- Panel derecho (formulario) -----
            int x = 340;
            var lblTitulo = new Label { Text = "Iniciar sesión", Font = Estilos.Titulo, ForeColor = Estilos.PrimarioOscuro, AutoSize = true, Location = new Point(x, 35) };
            var lblUsuario = new Label { Text = "Usuario", Font = Estilos.Negrita, AutoSize = true, Location = new Point(x, 95) };
            txtUsuario = new TextBox { Location = new Point(x, 120), Width = 360, MaxLength = 50 };
            var lblClave = new Label { Text = "Contraseña", Font = Estilos.Negrita, AutoSize = true, Location = new Point(x, 160) };
            txtClave = new TextBox { Location = new Point(x, 185), Width = 360, UseSystemPasswordChar = true, MaxLength = 50 };
            chkMostrar = new CheckBox { Text = "Mostrar contraseña", AutoSize = true, Location = new Point(x, 220) };
            chkMostrar.CheckedChanged += (s, e) => txtClave.UseSystemPasswordChar = !chkMostrar.Checked;

            btnIngresar = Estilos.CrearBoton("Ingresar", Estilos.Primario, (s, e) => Ingresar(), 175);
            btnIngresar.Location = new Point(x, 260);
            btnSalir = Estilos.CrearBoton("Salir", Estilos.Neutro, (s, e) => Close(), 175);
            btnSalir.Location = new Point(x + 185, 260);

            lblEstado = new Label { AutoSize = false, Location = new Point(x, 315), Size = new Size(380, 60), ForeColor = Estilos.Neutro };

            Controls.AddRange(new Control[] { panelMarca, lblTitulo, lblUsuario, txtUsuario, lblClave, txtClave, chkMostrar, btnIngresar, btnSalir, lblEstado });
            AcceptButton = btnIngresar;   // Enter = Ingresar
            CancelButton = btnSalir;      // Esc = Salir

            Shown += (s, e) => VerificarConexion();
        }

        private void VerificarConexion()
        {
            Cursor = Cursors.WaitCursor;
            lblEstado.Text = "Conectando con la base de datos...";
            Refresh();
            bool ok = Conexion.ProbarConexion(out string mensaje);
            Cursor = Cursors.Default;
            lblEstado.ForeColor = ok ? Estilos.Exito : Estilos.Peligro;
            lblEstado.Text = ok ? "● Conectado a la base de datos" : "● " + mensaje;
            if (!ok)
                Mensaje.Error("No hay conexión con la base de datos:\n\n" + mensaje);
            txtUsuario.Focus();
        }

        private bool Validar()
        {
            errores.Clear();
            if (string.IsNullOrWhiteSpace(txtUsuario.Text))
            {
                errores.SetError(txtUsuario, "Ingrese su usuario");
                Mensaje.Advertencia("Ingrese su nombre de usuario.");
                txtUsuario.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtClave.Text))
            {
                errores.SetError(txtClave, "Ingrese su contraseña");
                Mensaje.Advertencia("Ingrese su contraseña.");
                txtClave.Focus();
                return false;
            }
            return true;
        }

        private void Ingresar()
        {
            if (!Validar()) return;
            try
            {
                Cursor = Cursors.WaitCursor;
                btnIngresar.Enabled = false;
                var usuario = new LoginDAO().Autenticar(txtUsuario.Text, txtClave.Text);
                Mensaje.Info($"¡Bienvenido(a), {usuario.NombreCompleto}!\nRol: {usuario.NombreRol}");
                DialogResult = DialogResult.OK;   // cierra el login y abre el menú principal
            }
            catch (ExcepcionDatos ex)
            {
                Mensaje.Advertencia(ex.Message);
                txtClave.Clear();
                txtClave.Focus();
            }
            catch (Exception ex)
            {
                Logger.Error(ex, "Login");
                Mensaje.Error("Error inesperado al iniciar sesión: " + ex.Message);
            }
            finally
            {
                Cursor = Cursors.Default;
                btnIngresar.Enabled = true;
            }
        }
    }
}
