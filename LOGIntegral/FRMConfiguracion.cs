using System;
using System.Drawing;
using System.Configuration;
using System.Collections.Specialized;
using System.Data;
using System.Windows.Forms;
using LOGIntegral.Properties;
using MySql.Data.MySqlClient;
using System.Speech.Synthesis;
using System.Speech.AudioFormat;
using Microsoft.VisualBasic;
using System.Windows.Media;


namespace LOGIntegral
{
    public partial class FRMConfiguracion : Form
    {
        private LOGIMetodos prop_met = new LOGIMetodos();
        private string[,] tema = new string[20, 2];
        private Int16 opcion = 0;
        private Boolean modificado = false;
        private string comandoSQL;
        private string[] Voces = new string[20];

        public FRMConfiguracion()
        {
            InitializeComponent();

            TBServidor.Text = Settings.Default.servidor;
            TBPuerto.Text = Settings.Default.puerto;

            //Cargar las Voces instaladas en Windows que son reconocidas
            SpeechSynthesizer voces = new SpeechSynthesizer();
            Int32 i = 0;
            foreach (InstalledVoice voice in voces.GetInstalledVoices())
            {
                CBVoz.Items.Add(voice.VoiceInfo.Description.ToString());
                i++;
            }
            i = 0;
            foreach (InstalledVoice voice in voces.GetInstalledVoices())
            {
                Voces[i] = voice.VoiceInfo.Name.ToString();
                i++;
            }
            CBVoz.Text = Settings.Default.descVoz;

            if (Settings.Default.reproducir == 1)
                ChBVoz.Checked = true;
            else
                ChBVoz.Checked = false;
            mesActual();
        }

        private void TPGeneral_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            Pen pen = new Pen(Color.FromArgb( 181, 181, 181),2);
            e.Graphics.DrawLine(pen, 0, 35, 800, 35);
            e.Graphics.DrawLine(pen, 0, 96, 800, 96);
            e.Graphics.DrawLine(pen, 0, 158, 800, 158);
            e.Graphics.DrawLine(pen, 0, 275, 800, 275);
        }

        private void BServidor_Click(object sender, EventArgs e)
        {
            if(TBServidor.Text.Length > 5 && TBPuerto.Text.Length > 3)
            {
                try
                {
                    string estructuraConexion = $"Server={TBServidor.Text.Trim()};Port={TBPuerto.Text.Trim()}; Database=logi; Uid=root;Pwd=Syst3m0001D@taB@se;";
                    prop_met.MyConexion.ConnectionString = estructuraConexion;
                    prop_met.MyConexion.Open();
                    LConexion.Text = "Conexión Satisfactoria";
                    LConexion.Visible = true;
                    TBServidor.Enabled = false;
                    TBPuerto.Enabled = false;
                    BServidor.Enabled = false;
                    Settings.Default.servidor = TBServidor.Text.Trim();
                    Settings.Default.puerto = TBPuerto.Text.Trim();
                    Settings.Default.conexion = estructuraConexion;
                    Settings.Default.Save();
                    prop_met.MyConexion.Close();
                }
                catch (MySqlException ex)
                {
                    LConexion.Text = $"Conexión Fallida -- {ex.Message}";
                    LConexion.Visible = true;
                    TBServidor.Enabled = true;
                    TBPuerto.Enabled = true;
                    BServidor.Enabled = true;
                    TBServidor.Focus();
                    //throw;
                }

            }
            else
            {
                MessageBox.Show("Dirección del Servidor no Especificado", "LOGIntegral", MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                TBServidor.Focus();
            }
        }

        private void TCConfiguracion_Selected(object sender, TabControlEventArgs e)
        {
            switch (e.TabPageIndex)
            {
                case 1: // Pestaña Tipo de Documento
                    if (Settings.Default.conexion.Length > 0)
                    {
                        if (prop_met.ContarRegistro("SELECT * FROM tipodocumento") > 0)  
                            prop_met.CargarDataGrid(DGVTipoDocumento, "SELECT * FROM tipodocumento");

                        DGVTipoDocumento.Columns[0].DataPropertyName = "tipo";
                        DGVTipoDocumento.Columns[0].Width = 105;
                        DGVTipoDocumento.Columns[0].HeaderText = "Tipo de Documento";
                        DGVTipoDocumento.Columns[1].DataPropertyName = "descripcion";
                        DGVTipoDocumento.Columns[1].Width = 580;
                        DGVTipoDocumento.Columns[1].HeaderText = "Descripción de Tipo de Documento";
                        DGVTipoDocumento.Columns[2].DataPropertyName = "longitud";
                        DGVTipoDocumento.Columns[2].Width = 55;
                        DGVTipoDocumento.Columns[2].HeaderText = "Long.";
                        DGVTipoDocumento.RowsDefaultCellStyle.BackColor = Color.Gray;
                        DGVTipoDocumento.RowsDefaultCellStyle.ForeColor = Color.White;
                        DGVTipoDocumento.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
                        DGVTipoDocumento.AlternatingRowsDefaultCellStyle.ForeColor = Color.Black;
                    }
                    else
                    {
                        MessageBox.Show("Verificar Primero Conexión de Base de Datos", "LOGIntegral", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    break;
            }
        }

        private void TSBEditarTDocumento_Click(object sender, EventArgs e)
        {
            opcion = 2;
            TBDescripcion.Enabled = true;
            TBDescripcion.Focus();
            TBLongitud.Enabled = true;
            DeshabilitarBotones();
        }

        private void DeshabilitarBotones()
        {
            TSBNuevoTDocumento.Enabled = false;
            TSBEditarTDocumento.Enabled = false;
            TSBEliminarTDocumento.Enabled = false;
            TSBGuardarTDocumento.Enabled = true;
        }

        private void HabilitarBotones()
        {
            TBTipoDocumento.Text = null;
            TBTipoDocumento.Enabled = false;
            TBDescripcion.Text = null;
            TBDescripcion.Enabled = false;
            TBLongitud.Text = null;
            TBLongitud.Enabled = false;
            TSBNuevoTDocumento.Enabled = true;
            TSBEditarTDocumento.Enabled = true;
            TSBEliminarTDocumento.Enabled = true;
            TSBGuardarTDocumento.Enabled = false;
        }

        private void TSBGuardarTDocumento_Click(object sender, EventArgs e)
        {
            Boolean noHabilitar = false;
            switch (opcion)
            {
                case 1:
                    if (modificado)
                    {
                        Boolean salir = false;
                        foreach (DataGridViewRow dataGrid in DGVTipoDocumento.Rows)
                        {
                            if (dataGrid.Cells["DGVTCTipo"].Value.ToString().ToUpper() == TBTipoDocumento.Text.ToString().ToUpper())
                            {
                                MessageBox.Show("Tipo de Documento ya registrado", "LOGIntegral", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                salir = true;
                                break;
                            }
                        }
                        if (salir)
                        {
                            noHabilitar = true;
                            break;
                        }
                        comandoSQL = $"Insert into tipodocumento(tipo, descripcion, longitud) Values('{TBTipoDocumento.Text.ToUpper()}', '{TBDescripcion.Text.ToUpper()}', '{TBLongitud.Text.ToUpper()}')";
                        prop_met.EjecutarComandoSQL(comandoSQL);
                        prop_met.CargarDataGrid(DGVTipoDocumento, "SELECT * FROM tipodocumento");
                    }
                    break;
                case 2:
                    if (modificado)
                    {
                        comandoSQL = $"UPDATE tipodocumento SET descripcion = '{TBDescripcion.Text.ToUpper()}', longitud = '{TBLongitud.Text.ToUpper()}' WHERE (tipo = '{TBTipoDocumento.Text.ToUpper()}')";
                        prop_met.EjecutarComandoSQL(comandoSQL);
                        prop_met.CargarDataGrid(DGVTipoDocumento, "SELECT * FROM tipodocumento");
                    }
                    break;
            }
            if (noHabilitar)
            {
                TBTipoDocumento.Focus();
            }
            else
            {
                HabilitarBotones();
            }
        }

        private void TBDescripcion_TextChanged(object sender, EventArgs e)
        { 
            modificado = true;
        }

        private void TSBNuevoTDocumento_Click(object sender, EventArgs e)
        {
            opcion = 1;
            TBTipoDocumento.Enabled = true;
            TBDescripcion.Enabled = true;
            TBLongitud.Enabled = true;
            TBTipoDocumento.Focus();
            DeshabilitarBotones();
        }

        private void TSBEliminarTDocumento_Click(object sender, EventArgs e)
        {
            if (TBTipoDocumento.Text.ToString().ToUpper() != null) 
            {
                if (MessageBox.Show("Confirmar Elininación del Registro...", "LOGIntegral", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    comandoSQL = $"DELETE FROM tipodocumento WHERE (tipo = '{TBTipoDocumento.Text.ToString().ToUpper()}')";
                    prop_met.EjecutarComandoSQL(comandoSQL);
                    prop_met.CargarDataGrid(DGVTipoDocumento, "SELECT * FROM tipodocumento");
                    HabilitarBotones();
                }
            }
            else
            {
                MessageBox.Show("Seleccionar Registro a Eliminar", "LOGIntegral", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void DGVTipoDocumento_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TBTipoDocumento.Text = (string)DGVTipoDocumento.CurrentRow.Cells["DGVTCTipo"].Value;
            TBDescripcion.Text = (string)DGVTipoDocumento.CurrentRow.Cells["DGVTCDescripcion"].Value;
            TBLongitud.Text = DGVTipoDocumento.CurrentRow.Cells["DGVTBLongitud"].Value.ToString();
        }

        private void CBVoz_SelectedIndexChanged(object sender, EventArgs e)
        {
            Settings.Default.Voz = Voces[CBVoz.SelectedIndex].ToString();
            Settings.Default.descVoz = CBVoz.Text.ToString();
            Settings.Default.Save();
        }

        private void BHablar_Click(object sender, EventArgs e)
        {
            prop_met.Hablar("Probando funcionamiento del sintetizador de voz");
        }

        private void ChBVoz_CheckedChanged(object sender, EventArgs e)
        {
            if (ChBVoz.Checked)
                Settings.Default.reproducir = 1;
            else
                Settings.Default.reproducir = 0;
            Settings.Default.Save();
        }

        private void TBLongitud_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsPunctuation(e.KeyChar) || char.IsSymbol(e.KeyChar))
                e.Handled = true;
                
            else
                e.Handled = false;
        }

        private void TBLongitud_Leave(object sender, EventArgs e)
        {
            if (!Information.IsNumeric(TBLongitud.Text) && TBLongitud.Enabled ==  true)
            {
                ErrPConfiguracion.SetError(TBLongitud, "Ingresar Longitud de Dígitos del Tipo de Documento");
                TBLongitud.Select();
            }
            else
                ErrPConfiguracion.SetError(TBLongitud, string.Empty);
        }

        private void TBTipoDocumento_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TBTipoDocumento.Text) && TBTipoDocumento.Enabled == true)
            {
                ErrPConfiguracion.SetError(TBTipoDocumento, "Ingresar Tipo de Documento");
                TBTipoDocumento.Select();
            }
            else
                ErrPConfiguracion.SetError(TBTipoDocumento, string.Empty);
        }

        private void TBDescripcion_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TBDescripcion.Text) && TBDescripcion.Enabled == true)
            {
                ErrPConfiguracion.SetError(TBDescripcion, "Ingresar Descripción del Tipo de Documento");
                TBDescripcion.Select();
            }
            else
                ErrPConfiguracion.SetError(TBDescripcion, string.Empty);
        }

        private void LVColor_Click(object sender, EventArgs e)
        {
            try
            {
                string colorRGB = "";
                int IMGColor = 0;

                if (CBMes.Text.Length > 0)
                {
                    switch (LVColor.SelectedItems[0].Text)
                    {
                        case "Amarillo":
                            colorRGB = Color.FromArgb(255, 255, 0).Name;
                            IMGColor = 0;
                            break;
                        case "Azul":
                            colorRGB = Color.FromArgb(0, 0, 255).Name;
                            IMGColor = 1;
                            break;
                        case "Blanco":
                            colorRGB = Color.FromArgb(255, 255, 255).Name;
                            IMGColor = 2;
                            break;
                        case "Gris":
                            colorRGB = Color.FromArgb(153, 153, 153).Name;
                            IMGColor = 3;
                            break;
                        case "Marron":
                            colorRGB = Color.FromArgb(128, 64, 0).Name;
                            IMGColor = 4;
                            break;
                        case "Morado":
                            colorRGB = Color.FromArgb(124, 50, 143).Name;
                            IMGColor = 5;
                            break;
                        case "Naranja":
                            colorRGB = Color.FromArgb(255, 128, 0).Name;
                            IMGColor = 6;
                            break;
                        case "Negro":
                            colorRGB = Color.FromArgb(0, 0, 0).Name;
                            IMGColor = 7;
                            break;
                        case "Rojo":
                            colorRGB = Color.FromArgb(255, 0, 0).Name;
                            IMGColor = 8;
                            break;
                        case "Verde":
                            colorRGB = Color.FromArgb(0, 143, 57).Name;
                            IMGColor = 9;
                            break;
                    }
                    if (colorRGB.Length > 0)
                    {
                        switch (CBMes.Text)
                        {
                            case "Enero":
                                Settings.Default.Enero = (string)colorRGB;
                                Settings.Default.IMGEnero = IMGColor;
                                break;
                            case "Febrero":
                                Settings.Default.Febrero = (string)colorRGB;
                                Settings.Default.IMGFebrero = IMGColor;
                                break;
                            case "Marzo":
                                Settings.Default.Marzo = (string)colorRGB;
                                Settings.Default.IMGMarzo = IMGColor;
                                break;
                            case "Abril":
                                Settings.Default.Abril = (string)colorRGB;
                                Settings.Default.IMGAbril = IMGColor;
                                break;
                            case "Mayo":
                                Settings.Default.Mayo = (string)colorRGB;
                                Settings.Default.IMGMayo = IMGColor;
                                break;
                            case "Junio":
                                Settings.Default.Junio = (string)colorRGB;
                                Settings.Default.IMGJunio = IMGColor;
                                break;
                            case "Julio":
                                Settings.Default.Julio = (string)colorRGB;
                                Settings.Default.IMGJulio = IMGColor;
                                break;
                            case "Agosto":
                                Settings.Default.Agosto = (string)colorRGB;
                                Settings.Default.IMGAgosto = IMGColor;
                                break;
                            case "Septiembre":
                                Settings.Default.Septiembre = (string)colorRGB;
                                Settings.Default.IMGSeptiembre = IMGColor;
                                break;
                            case "Octubre":
                                Settings.Default.Octubre = (string)colorRGB;
                                Settings.Default.IMGOctubre = IMGColor;
                                break;
                            case "Noviembre":
                                Settings.Default.Noviembre = (string)colorRGB;
                                Settings.Default.IMGNoviembre = IMGColor;
                                break;
                            case "Diciembre":
                                Settings.Default.Diciembre = (string)colorRGB;
                                Settings.Default.IMGDiciembre = IMGColor;
                                break;
                        }
                        ImagenCinta(IMGColor);
                        Settings.Default.Save();
                    }
                }
            }
            catch (Exception ex)
            {
                LOGIMetodos.MensajeFRM(ex.Message);
            }
        }

        private void CBMes_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (CBMes.Text)
            {
                case "Enero":
                    ImagenCinta(Settings.Default.IMGEnero);
                    break;
                case "Febrero":
                    ImagenCinta(Settings.Default.IMGFebrero);
                    break;
                case "Marzo":
                    ImagenCinta(Settings.Default.IMGMarzo); 
                    break;
                case "Abril":
                    ImagenCinta(Settings.Default.IMGAbril);
                    break;
                case "Mayo":
                    ImagenCinta(Settings.Default.IMGMayo);
                    break;
                case "Junio":
                    ImagenCinta(Settings.Default.IMGJunio);
                    break;
                case "Julio":
                    ImagenCinta(Settings.Default.IMGJulio);
                    break;
                case "Agosto":
                    ImagenCinta(Settings.Default.IMGAgosto);
                    break;
                case "Septiembre":
                    ImagenCinta(Settings.Default.IMGSeptiembre);
                    break;
                case "Octubre":
                    ImagenCinta(Settings.Default.IMGOctubre);
                    break;
                case "Noviembre":
                    ImagenCinta(Settings.Default.IMGNoviembre);
                    break;
                case "Diciembre":
                    ImagenCinta(Settings.Default.IMGDiciembre);
                    break;
            }
        }
        private void ImagenCinta(int imagen)
        {
            switch (imagen)
            { 
                case 0:
                    PBCinta.Image = (Bitmap)LOGIntegral.Properties.Resources.Cinta_Amarillo;
                    break;
                case 1:
                    PBCinta.Image = (Bitmap)LOGIntegral.Properties.Resources.Cinta_Azul;
                    break;
                case 2:
                    PBCinta.Image = (Bitmap)LOGIntegral.Properties.Resources.Cinta_Blanco;
                    break;
                case 3:
                    PBCinta.Image = (Bitmap)LOGIntegral.Properties.Resources.Cinta_Gris;
                    break;
                case 4:
                    PBCinta.Image = (Bitmap)LOGIntegral.Properties.Resources.Cinta_Marron;
                    break;
                case 5:
                    PBCinta.Image = (Bitmap)LOGIntegral.Properties.Resources.Cinta_Morado;
                    break;
                case 6:
                    PBCinta.Image = (Bitmap)LOGIntegral.Properties.Resources.Cinta_Naranja;
                    break;
                case 7:
                    PBCinta.Image = (Bitmap)LOGIntegral.Properties.Resources.Cinta_negro;
                    break;
                case 8:
                    PBCinta.Image = (Bitmap)LOGIntegral.Properties.Resources.Cinta_Roja;
                    break;
                case 9:
                    PBCinta.Image = (Bitmap)LOGIntegral.Properties.Resources.Cinta_Verde;
                    break;
                default:
                    PBCinta.Image = (Bitmap)LOGIntegral.Properties.Resources.fondo;
                    break;
            }
        }

        private void mesActual()
        {
            DateTime fecha = DateTime.Now;
            Int32 mes = fecha.Month;

            string[] Meses = new string[] {"Enero","Febrero","Marzo","Abril","Mayo","Junio","Julio","Agosto","Septiembre","Octubre","Noviembre","Diciembre"};
            if (mes <= 12)
            {
                CBMes.Text = Meses[mes-1];
            }
            else
            {
                CBMes.Text = Meses[0];
            }
            //switch (mes)
            //{
            //    case 1:
            //        CBMes.Text = "Enero";
            //        break;
            //    case 2:
            //        CBMes.Text = "Febrero";
            //        break;
            //    case 3:
            //        CBMes.Text = "Marzo";
            //        break;
            //    case 4:
            //        CBMes.Text = "Abril";
            //        break;
            //    case 5:
            //        CBMes.Text = "Mayo";
            //        break;
            //    case 6:
            //        CBMes.Text = "Junio";
            //        break;
            //    case 7:
            //        CBMes.Text = "Julio";
            //        break;
            //    case 8:
            //        CBMes.Text = "Agosto";
            //        break;
            //    case 9:
            //        CBMes.Text = "Septiembre";
            //        break;
            //    case 10:
            //        CBMes.Text = "Octubre";
            //        break;
            //    case 11:
            //        CBMes.Text = "Noviembre";
            //        break;
            //    case 12:
            //        CBMes.Text = "Diciembre";
            //        break;
            //}
        }
    }
}
