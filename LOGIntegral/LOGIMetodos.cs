using System;
using System.Windows.Forms;
using System.Data;
using System.IO;
using System.Drawing;
using System.Drawing.Imaging;
using MySql.Data.MySqlClient;
using LOGIntegral.Properties;
using System.Speech.Synthesis;
using System.Speech.AudioFormat;
using SpreadsheetLight;
using System.Threading;
using System.Threading.Tasks;

namespace LOGIntegral
{
    class LOGIMetodos
    {
        /* Declaración de propiedades del programa */
        private MySqlConnection _conexion = new MySqlConnection();
        private MySqlCommand _comandos = new MySqlCommand();
        private MySqlDataReader _lectura;
        //private MySqlDataAdapter _adaptador;
        //private DataTable _tabla = new DataTable();
        private static string _documento = "";
        private static long _contarRegistros;
        private static double _valorSoles = 0;
        private static double _valorDolares = 0;
        private static int _cantidad = 0;
        private static int _transito = 0;
        private static double _PUbicacion = 0;

        public MySqlConnection MyConexion
        {
            get
            {
                return _conexion;
            }
            set
            {
                _conexion = value;
            }
        }
        public MySqlCommand MyComandos
        {
            get
            {
                return _comandos;
            }
            set
            {
                _comandos = value;
            }
        }
        public MySqlDataReader MyLectura
        {
            get
            {
                return _lectura;
            }
            set
            {
                _lectura = value;
            }
        }
        public static int Cantidad_Item
        { 
            get => _cantidad;
            set => _cantidad = value;
        }
        public static double ValorSoles
        {
            get => _valorSoles;
            set => _valorSoles = value;
        }
        public static double ValorDolares
        {
            get => _valorDolares;
            set => _valorDolares = value;
        }
        public static double PUbicacion
        {
            get => _PUbicacion;
            set => _PUbicacion = value;
        }
        public static int Transito
        {
            get => _transito;
            set => _transito = value;
        }

        //public MySqlDataAdapter MyAdaptador
        //{
        //    get
        //    {
        //        return _adaptador;
        //    }
        //    set
        //    {
        //        _adaptador = value;
        //    }
        //}
        //public DataTable MyTabla
        //{
        //    get
        //    {
        //        return _tabla;
        //    }
        //    set
        //    {
        //        _tabla = value;
        //    }
        //}
        public string DocumentoPersonal
        {
            get =>  _documento;
            set =>  _documento = value;
            
        }
        public long MyConteoRegistros
        {
            get => _contarRegistros;
            set => _contarRegistros = value;
        }

        /* Declaración de Variables Locales */

        //private MySqlDataAdapter dataAdapter;

        /* Metodo para definiel color de la cinta de seguridad del mes */
        public static Int32 ColorMes(Int32 mes)
        {
            if (mes == 1 || mes == 2 || mes == 3)
            {
                return 1;
            }
            else if (mes == 4 || mes == 5 || mes == 6)
            {
                return 2;
            }
            else if (mes == 7 || mes == 8 || mes == 9)
            {
                return 3;
            }
            else if (mes == 10 || mes == 11 || mes == 12)
            {
                return 4;
            }
            else
            {
                return 5;
            }
        }
        /*Metodo para cargar información de las tablas a un DataGrid */
        public void CargarDataGrid(DataGridView gridView, string query)
        {
            Cursor.Current = Cursors.WaitCursor;
            ConextarBaseDatos();
            MySqlCommand comando = new MySqlCommand(query, MyConexion);
            MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);
            DataTable dataTable = new DataTable();
            adaptador.Fill(dataTable);
            if (dataTable.Rows.Count > 0)
            {
                gridView.AutoGenerateColumns = false;
                gridView.DataSource = dataTable;
            }
            MyConexion.Close();
            Cursor.Current = Cursors.Default;
        }

        /*Metodo para cargar información de las tablas a un Chart */
        public void CargarChart(System.Windows.Forms.DataVisualization.Charting.Chart chart, string query)
        {
            Cursor.Current = Cursors.WaitCursor;
            ConextarBaseDatos();
            MySqlCommand comando = new MySqlCommand(query, MyConexion);
            MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);
            DataTable dataTable = new DataTable();
            adaptador.Fill(dataTable);
            if (dataTable.Rows.Count > 0)
            {
                chart.DataSource = dataTable;
            }
            MyConexion.Close();
            Cursor.Current = Cursors.Default;
        }

        public void ConextarBaseDatos()
        {
            try
            {
                if (MyConexion.State.ToString() != "Open")
                {
                    MyConexion.ConnectionString = Settings.Default.conexion;
                    MyConexion.Open();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Conexión Fallida -- {ex.Message}", "LOGIntegral", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (MyConexion.State.ToString() == "Open")
                {
                    MyConexion.Close();
                }
            }
        }

        public void EjecutarComandoEspecificos(string query)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                if (MyConexion.State.ToString() != "Open")
                    ConextarBaseDatos();
                MyComandos.CommandText = query;
                MyComandos.Connection = MyConexion;
                MyComandos.ExecuteNonQuery();
                MyLectura = MyComandos.ExecuteReader();
                MyLectura = MyComandos.ExecuteReader();
                Cursor.Current = Cursors.Default;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "LOGIntegral", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (MyConexion.State.ToString() == "Open")
                {
                    MyConexion.Close();
                }
            }
        }

        public void EjecutarComandoSQL(string query)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                if (MyConexion.State.ToString() != "Open")
                    ConextarBaseDatos();
                MyComandos.CommandText = query;
                MyComandos.Connection = MyConexion;
                MyComandos.ExecuteNonQuery();
                MyConexion.Close();
                Cursor.Current= Cursors.Default;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message , "LOGIntegral", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if(MyConexion.State.ToString() == "Open")
                {
                    MyConexion.Close();
                }
            }
        }

        public void EjecutarComandoSQL(string query,Image imagen)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                if (MyConexion.State.ToString() != "Open")
                    ConextarBaseDatos();
                MyComandos.CommandText = query;
                MyComandos.Connection = MyConexion;
                MyComandos.Parameters.AddWithValue("@imagen", ImageToByteArray(imagen));
                MyComandos.ExecuteNonQuery();
                MyConexion.Close();
                Cursor.Current = Cursors.Default;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "LOGIntegral", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (MyConexion.State.ToString() == "Open")
                {
                    MyConexion.Close();
                }
            }
        }

        public void ContarRegistrosSQL(string query)
        {
            try
            {
                if (MyConexion.State.ToString() != "Open")
                    ConextarBaseDatos();
                MyComandos.CommandText = query;
                MyComandos.Connection = MyConexion;
                MyConteoRegistros = (long)MyComandos.ExecuteScalar();
                MyConexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "LOGIntegral", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (MyConexion.State.ToString() == "Open")
                {
                    MyConexion.Close();
                }
            }
        }


        // Usar LeerDatosBaseDatos despues de AdaptadorBaseDatos
        public void LeerDatosBaseDatos(string query)
        {
            try
            {
                if (MyConexion.State.ToString() != "Open")
                    ConextarBaseDatos();
                MyComandos.CommandText = query;
                MyComandos.Connection = MyConexion;
                MyLectura = MyComandos.ExecuteReader();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Conexión Fallida -- {ex.Message}", "LOGIntegral", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (MyConexion.State.ToString() == "Open")
                {
                    MyConexion.Close();
                }
            }
        }
        
        public int ContarRegistro(string query)
        {
            try
            {
                MySqlDataAdapter adapter;
                DataTable table = new DataTable();
                if (MyConexion.State.ToString() != "Open")
                    ConextarBaseDatos();
                MyComandos.CommandText = query;
                MyComandos.Connection = MyConexion;
                MyComandos.ExecuteNonQuery();
                adapter = new MySqlDataAdapter(MyComandos);
                adapter.Fill(table);
                MyConexion.Close();
                return table.Rows.Count;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Conexión Fallida -- {ex.Message}", "LOGIntegral", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (MyConexion.State.ToString() == "Open")
                {
                    MyConexion.Close();
                }
                return -1;
            }

        }
        
        public void DesabilitarControlesForm(Form formulario)
        {
            foreach (Control form in formulario.Controls)
            {
                if (form is TextBox)
                {
                    form.Enabled = false;
                }
                if (form is ComboBox)
                {
                    form.Enabled = false;
                }
                if (form is MaskedTextBox)
                {
                    form.Enabled = false;
                }
                if (form is CheckBox)
                {
                    form.Enabled = false;
                }
                if (form is RadioButton)
                {
                    form.Enabled = false;
                }
                if (form is DateTimePicker)
                {
                    form.Enabled = false;
                }
            }
        }
        
        public void DesabilitarGroupBox(GroupBox group)
        {
            foreach (Control grupo in group.Controls)
            {
                if (grupo is TextBox)
                {
                    grupo.Enabled = false;
                }
                if (grupo is ComboBox)
                {
                    grupo.Enabled = false;
                }
                if (grupo is MaskedTextBox)
                {
                    grupo.Enabled = false;
                }
                if (grupo is CheckBox)
                {
                    grupo.Enabled = false;
                }
                if (grupo is RadioButton)
                {
                    grupo.Enabled = false;
                }
                if (grupo is DateTimePicker)
                {
                    grupo.Enabled = false;
                }
            }
        }
        
        public void HabilitarControlesForm(Form formulario)
        {
            foreach (Control form in formulario.Controls)
            {
                if (form is TextBox)
                {
                    form.Enabled = true;
                }
                if (form is ComboBox)
                {
                    form.Enabled = true;
                }
                if (form is MaskedTextBox)
                {
                    form.Enabled = true;
                }
                if (form is CheckBox)
                {
                    form.Enabled = true;
                }
                if (form is RadioButton)
                {
                    form.Enabled = true;
                }
                if (form is DateTimePicker)
                {
                    form.Enabled = true;
                }
            }
        }
        
        public void HabilitarGroupBox(GroupBox group)
        {
            foreach (Control grupo in group.Controls)
            {
                if (grupo is TextBox)
                {
                    grupo.Enabled = true;
                }
                if (grupo is ComboBox)
                {
                    grupo.Enabled = true;
                }
                if (grupo is MaskedTextBox)
                {
                    grupo.Enabled = true;
                }
                if (grupo is CheckBox)
                {
                    grupo.Enabled = true;
                }
                if (grupo is RadioButton)
                {
                    grupo.Enabled = true;
                }
                if (grupo is DateTimePicker)
                {
                    grupo.Enabled = true;
                }
            }
        }
        
        public void BorrarControlesForm(Form formulario)
        {
            foreach (Control form in formulario.Controls)
            {
                if (form is TextBox)
                {
                    form.Text = null;
                }
                if (form is ComboBox)
                {
                    form.Text = null;
                }
                if (form is MaskedTextBox)
                {
                    form.Text = null;
                }
                if (form is DateTimePicker)
                {
                    form.Text = null;
                }
            }
        }
        
        public void BorrarGroupBox(GroupBox group)
        {
            foreach (Control grupo in group.Controls)
            {
                if (grupo is TextBox)
                {
                    grupo.Text = null;
                }
                if (grupo is ComboBox)
                {
                    grupo.Text = null;
                }
                if (grupo is MaskedTextBox)
                {
                    grupo.Text = null;
                }
                if (grupo is DateTimePicker)
                {
                    grupo.Text = null;
                }
            }
        }

        public static Image ByteArrayToImage(byte[] byteBLOBData)
        {
            MemoryStream ms = new MemoryStream(byteBLOBData);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }

        public static byte[] ImageToByteArray(Image imageIn)
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, ImageFormat.Jpeg);
            return ms.ToArray();
        }

        public void Hablar(string texto)
        {
            try
            {
                SpeechSynthesizer hablar = new SpeechSynthesizer();
                if (Settings.Default.Voz.Length > 0)
                {
                    hablar.SelectVoice(Settings.Default.Voz);
                    hablar.SpeakAsync(texto);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "LOGIntegral", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }        
        }

        public Int16 ValidarContenido (TextBox text, ErrorProvider error)
        {
            Int16 valor = 0;
            if (string.IsNullOrEmpty(text.Text) && text.Enabled == true)
            {
                error.SetError(text, "Completar Información");
                valor++;
                return valor;
            }
            else
            {
                error.SetError(text, string.Empty);
                valor--;
                return valor;
            }
        }

        public Int16 ValidarContenido(ComboBox text, ErrorProvider error)
        {
            Int16 valor = 0;
            if (string.IsNullOrEmpty(text.Text) && text.Enabled == true)
            {
                error.SetError(text, "Completar Información");
                valor++;
                return valor;
            }
            else
            {
                error.SetError(text, string.Empty);
                valor--;
                return valor;
            }
        }

        public static void MensajeFRM(string mensaje)
        {
            FRMPrincipal principal = new FRMPrincipal();
            principal.TSSLMensaje.Text = mensaje;
        }

        public static bool Cargar_Inventario()
        {
            string strDoc = @"C:\DataLOGI\Inventario.xlsx";
            var archivo = new FileInfo(strDoc);
            //FRMPrincipal fRM = new FRMPrincipal();
            int ubicacion = 0;

            if (archivo.Exists)
            {
                try
                {
                    SLDocument document = new SLDocument(strDoc);

                    int IRows = 2;
                    Cantidad_Item = 0;
                    double invSoles = 0;
                    double invDolares = 0;
                    int itemTransito = 0;
                    int almobra = 0;
                    while (!string.IsNullOrEmpty(document.GetCellValueAsString(IRows, 1)))
                    {
                        invSoles += document.GetCellValueAsDouble(IRows, 12);
                        invDolares += document.GetCellValueAsDouble(IRows, 14);
                        //if (document.GetCellValueAsString(IRows, 5) == "0001" || document.GetCellValueAsString(IRows, 5) == "0002" || document.GetCellValueAsString(IRows, 5) == "0003")
                        //{
                            almobra++;
                        //}
                        if (document.GetCellValueAsString(IRows, 13).Length > 0) //&& (document.GetCellValueAsString(IRows, 5) == "0001" || document.GetCellValueAsString(IRows, 5) == "0002" || document.GetCellValueAsString(IRows, 5) == "0003"))
                        {
                            ubicacion++;
                        }
                        if (document.GetCellValueAsDouble(IRows, 15) > 0)
                        {
                            itemTransito++;
                        }
                        IRows++;
                    }
                    IRows--;
                    Cantidad_Item = almobra;
                    ValorSoles = invSoles;
                    ValorDolares = invDolares;
                    PUbicacion = (Convert.ToDouble(ubicacion) / Convert.ToDouble(almobra)) * 100;
                    Transito = itemTransito;
                    return true;
                }
                catch (IOException)
                {
                    MensajeFRM("Error en el Origen");
                    return false;
                }
            }
            else
            {
                MensajeFRM("Archivo de Referencia no registrado en el directorio de origen");
                return false;
            }
        }
    }
}