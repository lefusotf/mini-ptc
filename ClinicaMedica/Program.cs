using ClinicaMedica.Modelo.Utilidades;
using ClinicaMedica.Vista;

namespace ClinicaMedica
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            // Cualquier error no controlado se registra en el log y se muestra con un MessageBox
            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);
            Application.ThreadException += (s, e) =>
            {
                Logger.Error(e.Exception, "Error no controlado");
                MessageBox.Show("Ocurrió un error inesperado:\n" + e.Exception.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            };

            // Ciclo: Login -> Menú principal -> (Cerrar sesión) -> Login ...
            while (true)
            {
                using (var login = new FrmLogin())
                {
                    if (login.ShowDialog() != DialogResult.OK)
                        break;
                }

                DialogResult resultado;
                using (var principal = new FrmPrincipal())
                {
                    resultado = principal.ShowDialog();
                }

                Sesion.Cerrar();
                if (resultado != DialogResult.Retry) // Retry = "Cerrar sesión"
                    break;
            }
        }
    }
}
