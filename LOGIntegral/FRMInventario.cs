using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;
using SpreadsheetLight;

namespace LOGIntegral 
{
    public partial class FRMInventario : Form
    {
        string strDoc = @"C:\DataLOGI\Inventario.xlsx";
        public FRMInventario()
        {
            InitializeComponent();
        }

        private void BInventario_Click(object sender, EventArgs e)
        {
            var archivo = new FileInfo(strDoc);
            FRMPrincipal fRM = new FRMPrincipal();
            if (archivo.Exists)
            {
                try
                {
                    SLDocument document = new SLDocument(strDoc);
                    int IRows = 2;
                    TBBuscar.Clear();
                    fRM.TSPBCargar_Datos.Value = 50;
                    while (!string.IsNullOrEmpty(document.GetCellValueAsString(IRows, 1)))
                    {
                        fRM.TSPBCargar_Datos.Value = (int) ((IRows-1) / LOGIMetodos.Cantidad_Item) * 100;
                        fRM.Refresh();
                        string material = document.GetCellValueAsString(IRows, 1);
                        string descripcion = document.GetCellValueAsString(IRows, 2);
                        string unidad = document.GetCellValueAsString(IRows, 9);
                        double cantidad = document.GetCellValueAsDouble(IRows, 8);
                        ListViewItem listView = new ListViewItem(material);
                        listView.SubItems.Add(descripcion);
                        listView.SubItems.Add(unidad);
                        listView.SubItems.Add(Convert.ToString(cantidad));
                        LVInventario.Items.AddRange(new ListViewItem[] { listView }); 
                        IRows++;
                    }
                }
                catch (IOException err)
                {
                    MessageBox.Show(err.Message, "LOGIntegral", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //throw;
                }
            }
            else
            {
                MessageBox.Show("Archivo de Referencia no registrado en el directorio de origen","LOGIntegral",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }
    }
}
