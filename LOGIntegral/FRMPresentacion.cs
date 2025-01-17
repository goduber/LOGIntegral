using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows;
using System.Speech.Synthesis;
using System.Globalization;
using LOGIntegral.Properties;
using System.Threading;
using System.Threading.Tasks;

namespace LOGIntegral
{
    public partial class FRMPresentacion : Form
    {
        private Int32 valor = 0;
        private LOGIMetodos metodos = new LOGIMetodos();
        public FRMPresentacion()
        {
            InitializeComponent();
            TInicio.Start();
            DateTime fecha = DateTime.Now;
            Int32 mes = fecha.Month;
            string colorHex = "ff2e2e2e";

            switch (mes)
            {
                case 1:
                    colorHex = Settings.Default.Enero;
                    break;
                case 2:
                    colorHex = Settings.Default.Febrero;
                    break;
                case 3:
                    colorHex = Settings.Default.Marzo;
                    break;
                case 4:
                    colorHex = Settings.Default.Abril;
                    break;
                case 5:
                    colorHex = Settings.Default.Mayo;
                    break;
                case 6:
                    colorHex = Settings.Default.Junio;
                    break;
                case 7:
                    colorHex = Settings.Default.Julio;
                    break;
                case 8:
                    colorHex = Settings.Default.Agosto;
                    break;
                case 9:
                    colorHex = Settings.Default.Septiembre;
                    break;
                case 10:
                    colorHex = Settings.Default.Octubre;
                    break;
                case 11:
                    colorHex = Settings.Default.Noviembre;
                    break;
                case 12:
                    colorHex = Settings.Default.Diciembre;
                    break;
            }
            try
            { 
                int argb = Int32.Parse(colorHex, NumberStyles.HexNumber);
                Color colorBarra = Color.FromArgb(argb);
                PBarPresentacion.ForeColor = colorBarra;
                PBarPresentacion.Style = ProgressBarStyle.Continuous;
            }
            catch (FormatException)
            {
                LOGIMetodos.MensajeFRM($"No se puede convertir \"{colorHex}\"");
            }
            catch (OverflowException)
            {
                LOGIMetodos.MensajeFRM($"\"{colorHex}\" está fuera del rango del tipo Númerico");
            }
        }

        private async void TInicio_Tick(object sender, EventArgs e)
        {
            TInicio.Stop();
            PBarPresentacion.Visible = true;
            TPresentacion.Start();
            Task<bool> task = new Task<bool>(LOGIMetodos.Cargar_Inventario);
            task.Start();
            bool resultado = await task;
        }

        private void TPresentacion_Tick(object sender, EventArgs e)
        {
            valor += 10;
            if (valor > 100)
            {
                FRMPrincipal principal = new FRMPrincipal();
                principal.Show();
                TPresentacion.Stop();
                this.Hide();
            }
            else
            {
                PBarPresentacion.Value = valor;
            }
        }

        private void FRMPresentacion_Load(object sender, EventArgs e)
        {
            DateTime madrugada = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 00, 00, 00);
            DateTime mañana = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 06, 00, 00);
            DateTime tarde = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 12, 00, 00);
            DateTime noche = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 18, 00, 00);
            if (Settings.Default.reproducir == 1)
            {
                if ((DateTime.Compare(DateTime.Now, madrugada) == 0 || DateTime.Compare(DateTime.Now, madrugada) == 1) && DateTime.Compare(DateTime.Now, mañana) == -1)
                    metodos.Hablar("Buenas Madrugadas");
                else if((DateTime.Compare(DateTime.Now, mañana) == 0 || DateTime.Compare(DateTime.Now, mañana) == 1) && DateTime.Compare(DateTime.Now, tarde) == -1)
                metodos.Hablar("Buenos Días");
                else if ((DateTime.Compare(DateTime.Now, tarde) == 0 || DateTime.Compare(DateTime.Now, tarde) == 1) && DateTime.Compare(DateTime.Now, noche) == -1)
                    metodos.Hablar("Buenas Tardes");
                else if ((DateTime.Compare(DateTime.Now, noche) == 0 || DateTime.Compare(DateTime.Now, noche) == 1) && DateTime.Compare(DateTime.Now, madrugada) == -1)
                    metodos.Hablar("Buenas Noches");
            }

        }
    }
}
