using ClinicaMedica.Modelo.Utilidades;

namespace ClinicaMedica.Vista
{
    /// <summary>
    /// Formulario base para todas las pantallas CRUD.
    /// Distribución:  [ Encabezado                                   ]
    ///                [ Campos + Botones ] [ Buscar + Tabla de datos ]
    /// Cada pantalla hija solo agrega sus campos y escribe Cargar / Guardar / Eliminar.
    /// </summary>
    public class FrmBaseCrud : Form
    {
        protected readonly FlowLayoutPanel PanelCampos;
        protected readonly FlowLayoutPanel PanelBotones;
        protected readonly DataGridView Grid;
        protected readonly TextBox TxtBuscar;
        protected readonly ErrorProvider Errores;
        protected readonly Label LblTitulo;

        protected Button BtnNuevo, BtnGuardar, BtnEliminar, BtnLimpiar;

        /// <summary>Id del registro seleccionado; 0 = registro nuevo.</summary>
        protected int IdSeleccionado;

        public FrmBaseCrud() : this("Formulario") { }

        public FrmBaseCrud(string titulo)
        {
            Text = titulo + " - Clínica Médica";
            Size = new Size(1180, 700);
            MinimumSize = new Size(950, 600);
            StartPosition = FormStartPosition.CenterParent;
            BackColor = Estilos.Fondo;
            Font = Estilos.Texto;
            Errores = new ErrorProvider { BlinkStyle = ErrorBlinkStyle.NeverBlink };

            // ---------- Zona derecha: buscador + tabla ----------
            var panelDatos = new Panel { Dock = DockStyle.Fill, Padding = new Padding(10) };
            Grid = new DataGridView { Dock = DockStyle.Fill };
            Estilos.AplicarEstiloGrid(Grid);
            Grid.SelectionChanged += (s, e) => { if (Grid.Focused) SeleccionarFila(); };
            Grid.CellClick += (s, e) => { if (e.RowIndex >= 0) SeleccionarFila(); };

            var panelBuscar = new Panel { Dock = DockStyle.Top, Height = 42 };
            var lblBuscar = new Label { Text = "Buscar:", AutoSize = true, Location = new Point(0, 10), Font = Estilos.Negrita };
            TxtBuscar = new TextBox { Location = new Point(70, 7), Width = 400 };
            TxtBuscar.TextChanged += (s, e) => Cargar();
            panelBuscar.Controls.AddRange(new Control[] { lblBuscar, TxtBuscar });

            panelDatos.Controls.Add(Grid);
            panelDatos.Controls.Add(panelBuscar);

            // ---------- Zona izquierda: campos + botones ----------
            var panelIzq = new Panel
            {
                Dock = DockStyle.Left,
                Width = 370,
                BackColor = Color.White,
                Padding = new Padding(15, 10, 10, 10),
                AutoScroll = true
            };
            PanelBotones = new FlowLayoutPanel
            {
                Dock = DockStyle.Top,
                AutoSize = true,
                Padding = new Padding(0, 10, 0, 0)
            };
            PanelCampos = new FlowLayoutPanel
            {
                Dock = DockStyle.Top,
                AutoSize = true,
                FlowDirection = FlowDirection.TopDown,
                WrapContents = false
            };
            panelIzq.Controls.Add(PanelBotones);
            panelIzq.Controls.Add(PanelCampos);

            // ---------- Encabezado ----------
            var encabezado = new Panel { Dock = DockStyle.Top, Height = 60, BackColor = Estilos.Primario };
            LblTitulo = new Label
            {
                Text = titulo,
                ForeColor = Color.White,
                Font = Estilos.Titulo,
                AutoSize = true,
                Location = new Point(18, 14)
            };
            encabezado.Controls.Add(LblTitulo);

            // El orden importa: el último en agregarse se acomoda primero
            Controls.Add(panelDatos);
            Controls.Add(panelIzq);
            Controls.Add(encabezado);

            CrearBotonesBase();
            Load += (s, e) => { CargarListas(); Cargar(); Limpiar(); };
        }

        private void CrearBotonesBase()
        {
            BtnNuevo = Estilos.CrearBoton("Nuevo", Estilos.Info, (s, e) => Limpiar());
            BtnGuardar = Estilos.CrearBoton("Guardar", Estilos.Exito, (s, e) => Guardar());
            BtnEliminar = Estilos.CrearBoton("Eliminar", Estilos.Peligro, (s, e) => Eliminar());
            BtnLimpiar = Estilos.CrearBoton("Cancelar", Estilos.Neutro, (s, e) => Limpiar());
            PanelBotones.Controls.AddRange(new Control[] { BtnNuevo, BtnGuardar, BtnEliminar, BtnLimpiar });
            foreach (Control b in PanelBotones.Controls) b.Width = 160;
        }

        /// <summary>Agrega una etiqueta y su control al panel de campos.</summary>
        protected T Campo<T>(string etiqueta, T control, int alto = 0) where T : Control
        {
            PanelCampos.Controls.Add(new Label
            {
                Text = etiqueta,
                AutoSize = true,
                Font = Estilos.Negrita,
                Margin = new Padding(0, 6, 0, 2)
            });
            control.Width = 325;
            if (alto > 0) control.Height = alto;
            control.Margin = new Padding(0, 0, 0, 2);
            if (control is ComboBox cb) cb.DropDownStyle = ComboBoxStyle.DropDownList;
            PanelCampos.Controls.Add(control);
            return control;
        }

        protected static TextBox TextoMultilinea() =>
            new TextBox { Multiline = true, ScrollBars = ScrollBars.Vertical };

        /// <summary>Marca un control con error (ícono rojo) y devuelve false para cortar la validación.</summary>
        protected bool MarcarError(Control c, string mensaje)
        {
            Errores.SetError(c, mensaje);
            c.Focus();
            Mensaje.Advertencia(mensaje);
            return false;
        }

        protected bool Requerido(TextBox t, string nombreCampo)
        {
            if (string.IsNullOrWhiteSpace(t.Text))
                return MarcarError(t, $"El campo '{nombreCampo}' es obligatorio.");
            return true;
        }

        /// <summary>Oculta los botones de edición si el usuario no tiene el permiso indicado.</summary>
        protected void ModoSoloLectura()
        {
            BtnNuevo.Visible = BtnGuardar.Visible = BtnEliminar.Visible = BtnLimpiar.Visible = false;
            foreach (Control c in PanelCampos.Controls)
                if (!(c is Label)) c.Enabled = false;
        }

        private void SeleccionarFila()
        {
            if (Grid.CurrentRow?.DataBoundItem == null) return;
            try
            {
                Errores.Clear();
                MostrarRegistro(Grid.CurrentRow.DataBoundItem);
            }
            catch (Exception ex)
            {
                Logger.Error(ex, Text + " - seleccionar fila");
                Mensaje.Error("No se pudo mostrar el registro: " + ex.Message);
            }
        }

        /// <summary>Muestra datos en la tabla y opcionalmente oculta columnas.</summary>
        protected void MostrarEnGrid<T>(List<T> datos, params string[] columnasOcultas)
        {
            Grid.DataSource = null;
            Grid.DataSource = datos;
            foreach (string col in columnasOcultas)
                if (Grid.Columns.Contains(col)) Grid.Columns[col].Visible = false;
            Grid.ClearSelection();
        }

        // ---------- Métodos que cada pantalla implementa ----------
        /// <summary>Carga los ComboBox (roles, especialidades, etc.) al abrir la pantalla.</summary>
        protected virtual void CargarListas() { }
        protected virtual void Cargar() { }
        protected virtual void Guardar() { }
        protected virtual void Eliminar() { }
        protected virtual void MostrarRegistro(object registro) { }

        protected virtual void Limpiar()
        {
            IdSeleccionado = 0;
            Errores.Clear();
            foreach (Control c in PanelCampos.Controls)
            {
                if (c is TextBox t) t.Clear();
                else if (c is ComboBox cb && cb.Items.Count > 0) cb.SelectedIndex = 0;
                else if (c is CheckBox ch) ch.Checked = true;
                else if (c is DateTimePicker d) d.Value = DateTime.Today;
            }
            Grid.ClearSelection();
            BtnEliminar.Enabled = false;
            BtnGuardar.Text = "Guardar";
        }

        /// <summary>Llamar al seleccionar un registro existente.</summary>
        protected void ModoEdicion(int id)
        {
            IdSeleccionado = id;
            BtnEliminar.Enabled = true;
            BtnGuardar.Text = "Actualizar";
        }
    }
}
