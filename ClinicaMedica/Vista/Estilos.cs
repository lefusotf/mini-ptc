namespace ClinicaMedica.Vista
{
    /// <summary>Colores, fuentes y estilos comunes para que todas las pantallas se vean igual.</summary>
    public static class Estilos
    {
        public static readonly Color Primario = Color.FromArgb(0, 105, 120);     // verde azulado
        public static readonly Color PrimarioOscuro = Color.FromArgb(0, 77, 89);
        public static readonly Color Fondo = Color.FromArgb(244, 247, 248);
        public static readonly Color Exito = Color.FromArgb(46, 139, 87);
        public static readonly Color Peligro = Color.FromArgb(192, 57, 43);
        public static readonly Color Neutro = Color.FromArgb(108, 117, 125);
        public static readonly Color Info = Color.FromArgb(41, 128, 185);

        public static readonly Font Texto = new Font("Segoe UI", 10F);
        public static readonly Font Negrita = new Font("Segoe UI", 10F, FontStyle.Bold);
        public static readonly Font Titulo = new Font("Segoe UI", 16F, FontStyle.Bold);

        public static Button CrearBoton(string texto, Color color, EventHandler click = null, int ancho = 100)
        {
            var b = new Button
            {
                Text = texto,
                BackColor = color,
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Font = Negrita,
                Size = new Size(ancho, 36),
                Cursor = Cursors.Hand,
                Margin = new Padding(3)
            };
            b.FlatAppearance.BorderSize = 0;
            if (click != null) b.Click += click;
            return b;
        }

        public static void AplicarEstiloGrid(DataGridView g)
        {
            g.ReadOnly = true;
            g.AllowUserToAddRows = false;
            g.AllowUserToDeleteRows = false;
            g.AllowUserToResizeRows = false;
            g.MultiSelect = false;
            g.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            g.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            g.RowHeadersVisible = false;
            g.BackgroundColor = Color.White;
            g.BorderStyle = BorderStyle.None;
            g.EnableHeadersVisualStyles = false;
            g.ColumnHeadersDefaultCellStyle.BackColor = PrimarioOscuro;
            g.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            g.ColumnHeadersDefaultCellStyle.Font = Negrita;
            g.ColumnHeadersHeight = 34;
            g.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            g.DefaultCellStyle.Font = Texto;
            g.DefaultCellStyle.SelectionBackColor = Primario;
            g.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(235, 244, 245);
            g.RowTemplate.Height = 28;
        }
    }

    /// <summary>MessageBox con formato uniforme en todo el sistema.</summary>
    public static class Mensaje
    {
        public static void Info(string texto) =>
            MessageBox.Show(texto, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

        public static void Advertencia(string texto) =>
            MessageBox.Show(texto, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        public static void Error(string texto) =>
            MessageBox.Show(texto, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        public static bool Confirmar(string texto) =>
            MessageBox.Show(texto, "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
    }
}
