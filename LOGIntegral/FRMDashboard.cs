using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Windows.Forms.DataVisualization.Charting;


namespace LOGIntegral
{
    public partial class FRMDashboard : Form
    {
        LOGIMetodos metodos = new LOGIMetodos();
        public FRMDashboard()
        {
            InitializeComponent();
        }

        private void FRMDashboard_Load(object sender, EventArgs e)
        {
            ArrayList fecha = new ArrayList();
            ArrayList valor = new ArrayList();
            try
            {
                if (LOGIMetodos.ValorSoles > 0)
                {
                    String sql = "SELECT * FROM logi.valorinv";
                    string sql2 = $"select * from logi.valorinv where fecha = '{DateTime.Now.ToString("yyyy-MM-dd")}'";
                    string sql3 = $"INSERT INTO logi.valorinv (fecha, valorSoles, valorDolares, ubicacion, transito) VALUES('{DateTime.Now:yyyy-MM-dd}', '{LOGIMetodos.ValorSoles}', '{LOGIMetodos.ValorDolares}', '{String.Format("{0,3:N2}", LOGIMetodos.PUbicacion)}', '{LOGIMetodos.Transito}')";
                    int cantidadRegistros = metodos.ContarRegistro(sql);
                    if (cantidadRegistros > 0)
                    {
                        if (metodos.ContarRegistro(sql2) == 0)
                            metodos.EjecutarComandoSQL(sql3);
                    }
                    else
                        metodos.EjecutarComandoSQL(sql3);
                    if (cantidadRegistros > 15)
                        sql = $"select fecha, valorSoles from logi.valorinv limit {cantidadRegistros - 14},15";
                    else
                        sql = $"select fecha, valorSoles from logi.valorinv limit 15";
                    metodos.LeerDatosBaseDatos(sql);
                    while (metodos.MyLectura.Read())
                    {
                        fecha.Add(Convert.ToDateTime(metodos.MyLectura["fecha"].ToString()).ToString("dd/MM/yyyy"));
                        valor.Add(metodos.MyLectura["valorSoles"].ToString());
                    }
                    metodos.MyConexion.Close();
                    CHInventario.Series[0].Points.DataBindXY(fecha, valor);
                    CPBUbicacion.Value = (int)LOGIMetodos.PUbicacion;
                    CPBUbicacion.Text = $"{Convert.ToInt32(LOGIMetodos.PUbicacion)}%";
                    LValorSoles.Text = String.Format("{0,12:N2}", LOGIMetodos.ValorSoles);
                    LValorDolares.Text = String.Format("{0,12:N2}", LOGIMetodos.ValorDolares);
                    LTransito.Text = LOGIMetodos.Transito.ToString();

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error Capturado: -- {ex.Message}", "LOGIntegral", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //throw;
            }
        }

        private void FRMDashboard_Activated(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

    }
}
