using System;
using System.Windows.Forms;
using LOGIntegral.Properties;
using System.IO;
using SpreadsheetLight;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;


namespace LOGIntegral
{
    public partial class FRMPrincipal : Form
    {
        LOGIMetodos metodos = new LOGIMetodos();
        public FRMPrincipal()
        {
            InitializeComponent();
        }
        private void TSMISalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FRMPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Seguro desea Salir del Programa...", "LOGIntegral", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (metodos.MyConexion.State.ToString() == "Open")
                {
                    metodos.MyConexion.Close();
                }
                this.Dispose();
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void TSMIConfiguracion_Click(object sender, EventArgs e)
        {
            FRMConfiguracion configuracion = new FRMConfiguracion { MdiParent = this };
            configuracion.Show();
        }

        private void FRMPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void TSBPersonal_Click(object sender, EventArgs e)
        {
            FRMPersonal personal = new FRMPersonal { MdiParent = this };
            personal.Show();
        }

        private async void TSSLInventario_Click(object sender, EventArgs e)
        {
            Task<bool> task = new Task<bool>(LOGIMetodos.Cargar_Inventario);
            task.Start();
            bool resultado = await task;
            if (resultado) { Cargar_inventario(); }
            else
            {
                TSSLInventario.Text = Convert.ToString(0);
                TPrincipal.Start();
            }

        }

        private void FRMPrincipal_Load(object sender, EventArgs e)
        {
            TSSLMensaje.Text = String.Empty;
            if (LOGIMetodos.ValorSoles > 0)
            {
                Cargar_inventario();
            }
            else
            {
                TPrincipal.Start();
            }
            //FRMDashboard dashboard = new FRMDashboard { MdiParent = this };
            //dashboard.Show();

        }

        private void Cargar_inventario()
        {
            try
            {
                TSSLInventario.Text = String.Format("S/.  {0,12:N2}", LOGIMetodos.ValorSoles);
                TSSLItem.Text = LOGIMetodos.Cantidad_Item.ToString();
                TSSLUbicacion.Text = String.Format("{0,3:N2}%", LOGIMetodos.PUbicacion);
                TSPBCargar_Datos.Value = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error Capturado: -- {ex.Message}", "LOGIntegral", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TPrincipal_Tick(object sender, EventArgs e)
        {
            Cargar_inventario();
            TPrincipal.Stop();
        }

        private void TSBInventario_Click(object sender, EventArgs e)
        {
            FRMInventario inventario = new FRMInventario { MdiParent = this };
            inventario.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            FRMDashboard dashboard = new FRMDashboard {MdiParent = this };
            dashboard.Show();
        }
    }
}