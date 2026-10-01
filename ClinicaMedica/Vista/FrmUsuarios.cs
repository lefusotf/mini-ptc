using ClinicaMedica.Modelo.DAO;
using ClinicaMedica.Modelo.Entidades;
using ClinicaMedica.Modelo.Utilidades;

namespace ClinicaMedica.Vista
{
    public class FrmUsuarios : FrmBaseCrud
    {
        private readonly UsuarioDAO dao = new UsuarioDAO();
        private readonly TextBox txtUsuario, txtNombre, txtCorreo, txtClave, txtConfirmar;
        private readonly ComboBox cboRol;
        private readonly CheckBox chkActivo;
        private readonly Label lblNotaClave;

        public FrmUsuarios() : base("Gestión de Usuarios")
        {
            txtUsuario = Campo("Nombre de usuario *", new TextBox { MaxLength = 50 });
            txtNombre = Campo("Nombre completo *", new TextBox { MaxLength = 100 });
            txtCorreo = Campo("Correo", new TextBox { MaxLength = 100 });
            cboRol = Campo("Rol *", new ComboBox());
            txtClave = Campo("Contraseña *", new TextBox { UseSystemPasswordChar = true, MaxLength = 50 });
            txtConfirmar = Campo("Confirmar contraseña *", new TextBox { UseSystemPasswordChar = true, MaxLength = 50 });
            lblNotaClave = new Label
            {
                AutoSize = false, Width = 325, Height = 36, ForeColor = Estilos.Neutro,
                Text = "Mínimo 8 caracteres, con mayúscula, minúscula y número."
            };
            PanelCampos.Controls.Add(lblNotaClave);
            chkActivo = Campo("Estado", new CheckBox { Text = "Activo (desmarcar para bloquear)", Checked = true });
        }

        protected override void CargarListas()
        {
            try
            {
                cboRol.DataSource = new RolDAO().Listar();
                cboRol.DisplayMember = "Nombre";
                cboRol.ValueMember = "IdRol";
            }
            catch (Exception ex)
            {
                Logger.Error(ex, "Cargar roles");
                Mensaje.Error("No se pudieron cargar los roles: " + ex.Message);
            }
        }

        protected override void Cargar()
        {
            try
            {
                MostrarEnGrid(dao.Listar(TxtBuscar.Text.Trim()));
            }
            catch (ExcepcionDatos ex) { Mensaje.Error(ex.Message); }
            catch (Exception ex)
            {
                Logger.Error(ex, "Cargar usuarios");
                Mensaje.Error("Error al cargar usuarios: " + ex.Message);
            }
        }

        protected override void MostrarRegistro(object registro)
        {
            var u = (Usuario)registro;
            txtUsuario.Text = u.NombreUsuario;
            txtNombre.Text = u.NombreCompleto;
            txtCorreo.Text = u.Correo;
            cboRol.SelectedValue = u.IdRol;
            txtClave.Clear();
            txtConfirmar.Clear();
            chkActivo.Checked = u.Activo;
            lblNotaClave.Text = "Deje la contraseña vacía para conservar la actual.";
            ModoEdicion(u.IdUsuario);
        }

        private bool Validar()
        {
            Errores.Clear();
            if (!Validaciones.EsNombreUsuario(txtUsuario.Text))
                return MarcarError(txtUsuario, "El usuario debe tener de 4 a 50 caracteres (letras, números, punto o guion bajo), sin espacios.");
            if (!Requerido(txtNombre, "Nombre completo")) return false;
            if (!Validaciones.EsCorreo(txtCorreo.Text)) return MarcarError(txtCorreo, "El correo no tiene un formato válido.");
            if (cboRol.SelectedValue == null) return MarcarError(cboRol, "Seleccione un rol.");

            bool esNuevo = IdSeleccionado == 0;
            bool cambiaClave = txtClave.Text.Length > 0 || txtConfirmar.Text.Length > 0;
            if (esNuevo || cambiaClave)
            {
                string error = Seguridad.ValidarFortaleza(txtClave.Text);
                if (error != null) return MarcarError(txtClave, error);
                if (txtClave.Text != txtConfirmar.Text) return MarcarError(txtConfirmar, "Las contraseñas no coinciden.");
            }

            // Regla: un usuario no puede bloquearse a sí mismo
            if (!esNuevo && IdSeleccionado == Sesion.Usuario.IdUsuario && !chkActivo.Checked)
                return MarcarError(chkActivo, "No puede desactivar su propio usuario.");
            return true;
        }

        protected override void Guardar()
        {
            if (!Validar()) return;

            var u = new Usuario
            {
                IdUsuario = IdSeleccionado,
                NombreUsuario = txtUsuario.Text.Trim(),
                NombreCompleto = txtNombre.Text.Trim(),
                Correo = txtCorreo.Text.Trim(),
                IdRol = (int)cboRol.SelectedValue,
                Activo = chkActivo.Checked,
                // La contraseña SIEMPRE se guarda encriptada con BCrypt
                ClaveHash = txtClave.Text.Length > 0 ? Seguridad.Encriptar(txtClave.Text) : null
            };
            try
            {
                if (IdSeleccionado == 0)
                {
                    dao.Insertar(u);
                    Logger.Actividad("INSERTAR", "Usuarios", $"Usuario creado: {u.NombreUsuario} (rol {cboRol.Text})");
                    Mensaje.Info("Usuario creado correctamente.");
                }
                else
                {
                    dao.Actualizar(u);
                    Logger.Actividad("ACTUALIZAR", "Usuarios",
                        $"Usuario #{u.IdUsuario} modificado: {u.NombreUsuario}, rol {cboRol.Text}" +
                        (u.ClaveHash != null ? ", contraseña cambiada" : ""));
                    Mensaje.Info("Usuario actualizado correctamente.");
                }
                Cargar();
                Limpiar();
            }
            catch (ExcepcionDatos ex) { Mensaje.Advertencia(ex.Message); }
            catch (Exception ex)
            {
                Logger.Error(ex, "Guardar usuario");
                Mensaje.Error("Error inesperado: " + ex.Message);
            }
        }

        protected override void Eliminar()
        {
            if (IdSeleccionado == 0) return;
            if (IdSeleccionado == Sesion.Usuario.IdUsuario)
            {
                Mensaje.Advertencia("No puede eliminar el usuario con el que inició sesión.");
                return;
            }
            if (!Mensaje.Confirmar($"¿Eliminar el usuario '{txtUsuario.Text}'?")) return;
            try
            {
                dao.Eliminar(IdSeleccionado);
                Logger.Actividad("ELIMINAR", "Usuarios", $"Usuario #{IdSeleccionado} eliminado: {txtUsuario.Text}");
                Mensaje.Info("Usuario eliminado.");
                Cargar();
                Limpiar();
            }
            catch (ExcepcionDatos ex) { Mensaje.Advertencia(ex.Message + "\nSugerencia: desactive el usuario en lugar de eliminarlo."); }
            catch (Exception ex)
            {
                Logger.Error(ex, "Eliminar usuario");
                Mensaje.Error("Error inesperado: " + ex.Message);
            }
        }

        protected override void Limpiar()
        {
            base.Limpiar();
            lblNotaClave.Text = "Mínimo 8 caracteres, con mayúscula, minúscula y número.";
        }
    }
}
