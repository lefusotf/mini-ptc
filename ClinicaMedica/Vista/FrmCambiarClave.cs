using ClinicaMedica.Modelo.DAO;
using ClinicaMedica.Modelo.Utilidades;

namespace ClinicaMedica.Vista
{
    /// <summary>Cualquier usuario puede cambiar su propia contraseña.</summary>
    public class FrmCambiarClave : Form
    {
        private readonly TextBox txtActual, txtNueva, txtConfirmar;

        public FrmCambiarClave()
        {
            Text = "Cambiar contraseña";
            Size = new Size(400, 360);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = MinimizeBox = false;
            StartPosition = FormStartPosition.CenterParent;
            BackColor = Color.White;
            Font = Estilos.Texto;

            txtActual = AgregarCampo("Contraseña actual", 20);
            txtNueva = AgregarCampo("Nueva contraseña", 85);
            txtConfirmar = AgregarCampo("Confirmar nueva contraseña", 150);
            Controls.Add(new Label
            {
                Text = "Mínimo 8 caracteres, con mayúscula, minúscula y número.",
                ForeColor = Estilos.Neutro, AutoSize = false, Bounds = new Rectangle(20, 210, 340, 40)
            });

            var btnGuardar = Estilos.CrearBoton("Guardar", Estilos.Exito, (s, e) => Guardar(), 165);
            btnGuardar.Location = new Point(20, 260);
            var btnCancelar = Estilos.CrearBoton("Cancelar", Estilos.Neutro, (s, e) => Close(), 165);
            btnCancelar.Location = new Point(195, 260);
            Controls.AddRange(new Control[] { btnGuardar, btnCancelar });
            AcceptButton = btnGuardar;
            CancelButton = btnCancelar;
        }

        private TextBox AgregarCampo(string etiqueta, int y)
        {
            Controls.Add(new Label { Text = etiqueta, Font = Estilos.Negrita, AutoSize = true, Location = new Point(20, y) });
            var t = new TextBox { Location = new Point(20, y + 25), Width = 340, UseSystemPasswordChar = true, MaxLength = 50 };
            Controls.Add(t);
            return t;
        }

        private void Guardar()
        {
            try
            {
                var dao = new UsuarioDAO();
                var usuario = dao.BuscarPorNombreUsuario(Sesion.Usuario.NombreUsuario);

                if (!Seguridad.Verificar(txtActual.Text, usuario.ClaveHash))
                {
                    Mensaje.Advertencia("La contraseña actual es incorrecta.");
                    txtActual.Focus();
                    return;
                }
                string error = Seguridad.ValidarFortaleza(txtNueva.Text);
                if (error != null) { Mensaje.Advertencia(error); txtNueva.Focus(); return; }
                if (txtNueva.Text != txtConfirmar.Text) { Mensaje.Advertencia("Las contraseñas no coinciden."); txtConfirmar.Focus(); return; }

                dao.CambiarClave(usuario.IdUsuario, Seguridad.Encriptar(txtNueva.Text));
                Logger.Actividad("CAMBIAR_CLAVE", "Usuarios", $"{usuario.NombreUsuario} cambió su contraseña");
                Mensaje.Info("Contraseña actualizada correctamente.");
                Close();
            }
            catch (ExcepcionDatos ex) { Mensaje.Advertencia(ex.Message); }
            catch (Exception ex)
            {
                Logger.Error(ex, "Cambiar contraseña");
                Mensaje.Error("Error inesperado: " + ex.Message);
            }
        }
    }
}
