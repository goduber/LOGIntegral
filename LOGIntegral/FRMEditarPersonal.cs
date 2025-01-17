using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using AForge.Video;
using AForge.Video.DirectShow;
using System.IO;
using Microsoft.VisualBasic;

namespace LOGIntegral
{
    public partial class FRMEditarPersonal : Form
    {
        private LOGIMetodos metodos = new LOGIMetodos();
        private string sqlPersonal;
        private Boolean mirror = true;
        private Int16 opciones = 0;
        private string[,] longuitud = new string[20, 2];
        private Int16 error = 0;
        private Int32 añoActual = DateTime.Today.Year;
        private Int32 mesActual = DateTime.Today.Month;
        private Int32 diaActual = DateTime.Today.Day;
        private string[,] registro = new string[25, 2];

        public FRMEditarPersonal()
        {
            InitializeComponent();
        }

        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice videoCaptureDevice;

        private void DTPFechaNacimiento_ValueChanged(object sender, EventArgs e)
        {
            Int32 edad;
            Int32 añoNacimiento = DTPFechaNacimiento.Value.Year;
            Int32 mesNacimiento = DTPFechaNacimiento.Value.Month;
            Int32 diaNacimiento = DTPFechaNacimiento.Value.Day;
            if (añoNacimiento < añoActual)
            {
                edad = añoActual - añoNacimiento;
                if (mesNacimiento > mesActual && añoNacimiento < añoActual) edad -= 1;
                if (diaNacimiento > diaActual && mesNacimiento == mesActual && añoNacimiento < añoActual) edad -= 1;
                LEdad.Text = "Edad: " + edad.ToString();
            }
            string de = DTPFechaNacimiento.Value.Year < 2000 ? "de" : "del";
            DTPFechaNacimiento.CustomFormat = $"dd 'de' MMMM '{de}' yyyy";
            registro[6, 0] = "fec_nacimiento";
            registro[6, 1] = DTPFechaNacimiento.Value.ToString("yyyy-MM-dd");
        }

        private Bitmap MyImagenes;
        private void BCamara_Click(object sender, EventArgs e)
        {
            if (BCamara.ImageIndex == 12)
            {
                if (CBCamaras.SelectedIndex < 0)
                    CBCamaras.SelectedIndex = 0;
                CBCamaras.Enabled = false;
                videoCaptureDevice = new VideoCaptureDevice(filterInfoCollection[CBCamaras.SelectedIndex].MonikerString);
                videoCaptureDevice.NewFrame += FinalFrame_NewFrame;
                CBResolucion.Items.Clear();
                for (Int32 i = 0; i < videoCaptureDevice.VideoCapabilities.Length; i++)
                {
                    CBResolucion.Items.Add($"{videoCaptureDevice.VideoCapabilities[i].BitCount}bit {videoCaptureDevice.VideoCapabilities[i].MaximumFrameRate}fps {videoCaptureDevice.VideoCapabilities[i].FrameSize.Width} X {videoCaptureDevice.VideoCapabilities[i].FrameSize.Height}");
                }
                CBResolucion.Enabled = true;
                videoCaptureDevice.VideoResolution = videoCaptureDevice.VideoCapabilities[0];
                CBResolucion.SelectedIndex = 0;
                PBFoto.SizeMode = PictureBoxSizeMode.Zoom;
                videoCaptureDevice.Start();
                BCamara.ImageIndex = 13;
            }
            else if (BCamara.ImageIndex == 13)
            {
                if (MyImagenes != null) { MyImagenes.Dispose(); }
                MyImagenes = new Bitmap(PBFoto.Image);
                videoCaptureDevice.Stop();
                PBFoto.Image = (Image)MyImagenes;
                BCamara.ImageIndex = 12;
                CBCamaras.Enabled = true;
                CBResolucion.Items.Clear();
                CBResolucion.Enabled = false;
                registro[23, 0] = "foto";
                registro[23, 1] = "@imagen";
            }
        }

        private void FinalFrame_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Image imagen = (Bitmap)eventArgs.Frame.Clone();
            if (mirror == true)
                imagen.RotateFlip(RotateFlipType.Rotate180FlipY);
            PBFoto.Image = imagen;
        }

        private void FRMEditarPersonal_Load(object sender, EventArgs e)
        {
            DTPFechaNacimiento.Value = DateTime.Today;
            if (DTPFechaNacimiento.Value.Year < 2000) { DTPFechaNacimiento.CustomFormat = "dd 'de' MMMM 'de' yyyy"; }
            else { DTPFechaNacimiento.CustomFormat = "dd 'de' MMMM 'del' yyyy"; }
            metodos.DesabilitarControlesForm(this);
            metodos.DesabilitarGroupBox(GBTallas);
            metodos.DesabilitarGroupBox(GBTrabajo);
            BCamara.Enabled = false;
            HabilitarBotones();

            // Carga de Datos del Personal seleccionado
            if (metodos.DocumentoPersonal.Length > 0)
            {
                sqlPersonal = "Select * FROM personal WHERE documento = " + metodos.DocumentoPersonal.ToString();
                if (metodos.ContarRegistro(sqlPersonal) == 1)
                    CargarPersonal(sqlPersonal);
                else
                    MessageBox.Show("Personal no registrado...", "LOGIntegral", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                TSBEditar.Enabled = false;
                TSBEliminar.Enabled = false;
            }
            // Cargar lista de Tipos de Documentos
            if (metodos.ContarRegistro("Select * FROM tipodocumento") > 0)
            {
                Int16 i = 0;
                CBTipoDocumento.Items.Clear();
                metodos.LeerDatosBaseDatos("Select * FROM tipodocumento");
                while (metodos.MyLectura.Read())
                {
                    CBTipoDocumento.Items.Add(metodos.MyLectura["tipo"].ToString());
                    CBTipoDocumento.AutoCompleteCustomSource.Add(metodos.MyLectura["tipo"].ToString());
                    longuitud[i, 0] = metodos.MyLectura["tipo"].ToString();
                    longuitud[i, 1] = metodos.MyLectura["longitud"].ToString();
                    i++;
                }
                metodos.MyConexion.Close();
            }
            else
            {
                MessageBox.Show("Ir a Configuración y agregar los Tipos de Documentos necesarios", "LOGIntegral", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //this.Close();
            }


            // Cargar Lista de Camarar conectadas
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo Device in filterInfoCollection)
                CBCamaras.Items.Add(Device.Name);
            CBCamaras.SelectedIndex = 0;
            videoCaptureDevice = new VideoCaptureDevice();
            BCamara.ImageIndex = 12;
        }

        private void FRMEditarPersonal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (videoCaptureDevice.IsRunning == true)
                videoCaptureDevice.Stop();
        }

        private void BorrarContenido()
        {
            metodos.BorrarControlesForm(this);
            metodos.BorrarGroupBox(GBTallas);
            metodos.BorrarGroupBox(GBTrabajo);
            ChBActivo.Checked = false;
            ChBCelular.Checked = false;
            ChBHerramientas.Checked = false;
            ChBLaptop.Checked = false;
            ChBRadio.Checked = false;
            RBFemenino.Checked = false;
            RBMasculino.Checked = false;
            PBFoto.Image = (Bitmap)LOGIntegral.Properties.Resources.fondo;
            PBFoto.SizeMode = PictureBoxSizeMode.StretchImage;
            CBCamaras.SelectedIndex = 0;
        }

        private void TSBNuevo_Click(object sender, EventArgs e)
        {
            opciones = 1;
            BorrarContenido();
            metodos.HabilitarControlesForm(this);
            metodos.HabilitarGroupBox(GBTallas);
            metodos.HabilitarGroupBox(GBTrabajo);
            DesabilitarBotones();
            CBResolucion.Enabled = false;
            BCamara.Enabled = true;
            CBTipoDocumento.Select();
        }

        private void CargarPersonal(string query)
        {
            metodos.LeerDatosBaseDatos(query);
            while (metodos.MyLectura.Read())
            {
                CBTipoDocumento.Text = metodos.MyLectura["tipo_documento"].ToString();
                TBDocumento.Text = metodos.MyLectura["documento"].ToString();
                TBPrimerNombre.Text = metodos.MyLectura["prim_nombre"].ToString();
                TBSegundoNombre.Text = metodos.MyLectura["segu_nombre"].ToString();
                TBPrimerApellido.Text = metodos.MyLectura["prim_apellido"].ToString();
                TBSegundoApellido.Text = metodos.MyLectura["segu_apellido"].ToString();
                DTPFechaNacimiento.Value = (DateTime)metodos.MyLectura["fec_nacimiento"];
                if (metodos.MyLectura["sexo"].ToString() == "F")
                {
                    RBFemenino.Checked = true;
                    RBMasculino.Checked = false;
                }
                else
                {
                    RBFemenino.Checked = false;
                    RBMasculino.Checked = true;
                }
                TBDireccion.Text = metodos.MyLectura["direccion"].ToString();
                MTBTelefono.Text = metodos.MyLectura["telefono"].ToString();
                MTBCelular.Text = metodos.MyLectura["celular"].ToString();
                CBCamisa.Text = metodos.MyLectura["t_camisa"].ToString();
                CBCasaca.Text = metodos.MyLectura["t_casaca"].ToString();
                CBPantalon.Text = metodos.MyLectura["t_pantalon"].ToString();
                CBCalzado.Text = metodos.MyLectura["t_calzado"].ToString();
                if (metodos.MyLectura["laptop"].ToString() == "True")
                    ChBLaptop.Checked = true;
                else
                    ChBLaptop.Checked = false;
                if (metodos.MyLectura["celular_t"].ToString() == "True")
                    ChBCelular.Checked = true;
                else
                    ChBCelular.Checked = false;
                if (metodos.MyLectura["radio"].ToString() == "True")
                    ChBRadio.Checked = true;
                else
                    ChBRadio.Checked = false;
                if (metodos.MyLectura["herramientas"].ToString() == "True")
                    ChBHerramientas.Checked = true;
                else
                    ChBHerramientas.Checked = false;
                if (metodos.MyLectura["activo"].ToString() == "True")
                    ChBActivo.Checked = true;
                else
                    ChBActivo.Checked = false;
                CBArea.Text = metodos.MyLectura["area_trabajo"].ToString();
                CBCargo.Text = metodos.MyLectura["cargo"].ToString();
                CBCategoria.Text = metodos.MyLectura["categoria"].ToString();
                TBNota.Text = metodos.MyLectura["nota"].ToString();
                if (metodos.MyLectura["foto"] is DBNull)
                {
                    PBFoto.Image = (Bitmap)LOGIntegral.Properties.Resources.fondo;
                    PBFoto.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                else
                    PBFoto.Image = LOGIMetodos.ByteArrayToImage((byte[])metodos.MyLectura["foto"]);
            }
            metodos.MyConexion.Close();
        }

        private void CBResolucion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBResolucion.SelectedIndex >= 0)
            {
                videoCaptureDevice.VideoResolution = videoCaptureDevice.VideoCapabilities[CBResolucion.SelectedIndex];
                videoCaptureDevice.Stop();
                videoCaptureDevice.Start();
            }
        }

        private void PBFoto_DoubleClick(object sender, EventArgs e)
        {
            if (mirror == true)
                mirror = false;
            else
                mirror = true;
        }

        private void TSBSalir_Click(object sender, EventArgs e)
        {
            BorrarContenido();
            this.Close();
        }

        private void HabilitarBotones()
        {
            TSBNuevo.Enabled = true;
            TSBEditar.Enabled = true;
            TSBEliminar.Enabled = true;
            TSBGuardar.Enabled = false;
            TSBSalir.Enabled = true;
        }

        private void DesabilitarBotones()
        {
            TSBNuevo.Enabled = false;
            TSBEditar.Enabled = false;
            TSBEliminar.Enabled = false;
            TSBGuardar.Enabled = true;
            TSBSalir.Enabled = true;
        }

        private void TSBGuardar_Click(object sender, EventArgs e)
        {
            string campos = "";
            string fotos = "";
            string datos = "";
            if (error == 0)
            {
                if (MessageBox.Show("Confirmar guardado de los datos", "LOGIntegral", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    switch (opciones)
                    {
                        case 1:
                            for (int i = 0; i < 25; i++)
                            {
                                if (registro[i, 0] != null && registro[i, 1] != null)
                                {
                                    if (registro[i, 0].Length >= 1 && registro[i, 1].Length >= 1)
                                    {
                                        campos += registro[i, 0] + ",";
                                        fotos = registro[i, 1].Contains("imagen") ? $"{registro[i, 1]}," : $"'{registro[i, 1]}',";
                                        datos += fotos;
                                    }
                                }
                            }
                            if (campos.Length > 0 && datos.Length > 0)
                            {
                                campos = campos.TrimEnd(',');
                                datos = datos.TrimEnd(',');
                            }
                            else
                                break;
                            if (registro[0, 1] != null && registro[1, 1] != null && registro[2, 1] != null && registro[4, 1] != null && registro[6, 1] != null)
                            {
                                sqlPersonal = $"Select * FROM personal WHERE documento = '{TBDocumento.Text}'";
                                int numeroFilas = metodos.ContarRegistro(sqlPersonal);
                                if (numeroFilas == 1)
                                {
                                    MessageBox.Show("Número de Documento Reistrado", "LOGIntegral", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                                    break;
                                }
                                else if (numeroFilas == 0)
                                {
                                    sqlPersonal = $"Insert into personal({campos}) Values({datos})";
                                    if (sqlPersonal.Contains("imagen"))
                                        metodos.EjecutarComandoSQL(sqlPersonal, PBFoto.Image);
                                    else
                                        metodos.EjecutarComandoSQL(sqlPersonal);
                                    registro = null;
                                    metodos.DesabilitarControlesForm(this);
                                    metodos.DesabilitarGroupBox(GBTallas);
                                    metodos.DesabilitarGroupBox(GBTrabajo);
                                    BCamara.Enabled = false;
                                    HabilitarBotones();
                                }
                                else
                                    MessageBox.Show(numeroFilas.ToString());
                            }
                            else
                            {
                                StringBuilder mensage = new StringBuilder();
                                mensage.AppendFormat("Completar los datos de los siguienes Campos:");
                                mensage.AppendLine();
                                mensage.AppendFormat("1.- Tipo de Documento");
                                mensage.AppendLine();
                                mensage.AppendFormat("2.- Documento");
                                mensage.AppendLine();
                                mensage.AppendFormat("3.- Primer Nombre");
                                mensage.AppendLine();
                                mensage.AppendFormat("4.- Primer Apellido");
                                mensage.AppendLine();
                                mensage.AppendFormat("5.- Fecha de Nacimiento");
                                mensage.AppendLine();
                                mensage.AppendFormat(registro[0, 1] + " " + registro[1, 1] + " " + registro[2, 1] + " " + registro[4, 1] + " " + registro[6, 1] + " ");
                                MessageBox.Show(mensage.ToString(), "LOGIntegral", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }

                            break;

                        case 2:
                            campos = "";
                            for (int i = 0; i < 25; i++)
                            {
                                if (registro[i, 0] != null && registro[i, 1] != null)
                                {
                                    if (registro[i, 0].Length >= 1 && registro[i, 1].Length >= 1)
                                    {
                                        campos += registro[i, 0];
                                        fotos = registro[i, 1].Contains("imagen") ? $"{registro[i, 1]}" : $"'{registro[i, 1]}'";
                                        campos += $" = {fotos},";
                                    }
                                }
                            }
                            if (campos.Length > 0)
                            {
                                campos = campos.TrimEnd(',');
                            }
                            else
                                break;
                            sqlPersonal = $"UPDATE personal SET {campos} WHERE (documento = '{TBDocumento.Text}')";
                            //MessageBox.Show(sqlPersonal);
                            if (sqlPersonal.Contains("imagen"))
                                metodos.EjecutarComandoSQL(sqlPersonal, PBFoto.Image);
                            else
                                metodos.EjecutarComandoSQL(sqlPersonal);
                            registro = null;
                            metodos.DesabilitarControlesForm(this);
                            metodos.DesabilitarGroupBox(GBTallas);
                            metodos.DesabilitarGroupBox(GBTrabajo);
                            BCamara.Enabled = false;
                            HabilitarBotones();
                            break;
                    }
                }
            }
            else
            {
                MessageBox.Show("Completar datos obligatorios", "LOGIntegral", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void TBDocumento_Leave(object sender, EventArgs e)
        {
            CompletarDocumento();
            if (metodos.ValidarContenido(TBDocumento, ErrPEditarPersonal) > 0)
                error++;
            else
                if (error > 0) error--;
            if (TBDocumento.Text.Length > 0)
            {
                sqlPersonal = "Select * FROM personal WHERE documento = " + TBDocumento.Text;
                if (metodos.ContarRegistro(sqlPersonal) == 1)
                {
                    MessageBox.Show("Personal ya registrado...", "LOGIntegral", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TBDocumento.SelectionStart = 0;
                    TBDocumento.SelectionLength = TBDocumento.Text.Length;
                    TBDocumento.Select();
                }
                else
                {
                    if (CBTipoDocumento.Text == "DNI" && TBPrimerNombre.Text.Length == 0 && TBPrimerApellido.Text.Length == 0)
                    {
                        LOGIRucDni rucDni = new LOGIRucDni();
                        rucDni.DNIJson(TBDocumento.Text.Trim());
                        String[] nombre = LOGIRucDni.nombres.Split();
                        if (nombre[0] != null)
                        {
                            TBPrimerNombre.Text = nombre[0];
                            TBPrimerApellido.Text = LOGIRucDni.apellidoPaterno;
                            TBSegundoApellido.Text = LOGIRucDni.apellidoMaterno;
                        }
                        if (nombre.Length > 0)
                        {
                            for (int i = 1; i < nombre.Length; i++)
                            {
                                TBSegundoNombre.Text += nombre[i] + " ";
                            }
                            TBSegundoNombre.Text = TBSegundoNombre.Text.Trim();
                        }
                    }
                }
            }
        }

        private void CBTipoDocumento_Leave(object sender, EventArgs e)
        {
            if (metodos.ValidarContenido(CBTipoDocumento, ErrPEditarPersonal) > 0)
                error++;
            else
                if (error > 0) error--;
        }

        private void TBPrimerNombre_Leave(object sender, EventArgs e)
        {
            if (metodos.ValidarContenido(TBPrimerNombre, ErrPEditarPersonal) > 0)
                error++;
            else
                if (error > 0) error--;
            if (TBPrimerNombre.Text.Length > 0)
            {
                registro[2, 0] = "prim_nombre";
                registro[2, 1] = TBPrimerNombre.Text.ToUpper();
            }
        }

        private void TBPrimerApellido_Leave(object sender, EventArgs e)
        {
            if (metodos.ValidarContenido(TBPrimerApellido, ErrPEditarPersonal) > 0)
                error++;
            else
                if (error > 0) error--;
        }

        private void CompletarDocumento()
        {
            if (!string.IsNullOrEmpty(TBDocumento.Text) && TBDocumento.Enabled == true)
            {
                for (Int16 i = 0; i < 20; i++)
                {
                    if (longuitud[i, 0] == CBTipoDocumento.Text)
                    {
                        if (TBDocumento.Text.Length < Convert.ToInt32(longuitud[i, 1]))
                        {
                            TBDocumento.Text = TBDocumento.Text.PadLeft(Convert.ToInt32(longuitud[i, 1]), '0');
                            break;
                        }
                    }
                }
            }
        }

        private void CBTipoDocumento_SelectedIndexChanged(object sender, EventArgs e)
        {
            CompletarDocumento();
        }

        private void CBTipoDocumento_TextChanged(object sender, EventArgs e)
        {
            registro[0, 0] = "tipo_documento";
            registro[0, 1] = CBTipoDocumento.Text.ToUpper();
        }

        private void TBDocumento_TextChanged(object sender, EventArgs e)
        {
            registro[1, 0] = "documento";
            registro[1, 1] = TBDocumento.Text.ToUpper();
        }

        private void TBPrimerNombre_TextChanged(object sender, EventArgs e)
        {
            registro[2, 0] = "prim_nombre";
            registro[2, 1] = TBPrimerNombre.Text.ToUpper();
        }

        private void TBSegundoNombre_TextChanged(object sender, EventArgs e)
        {
            registro[3, 0] = "segu_nombre";
            registro[3, 1] = TBSegundoNombre.Text.ToUpper();
        }

        private void TBPrimerApellido_TextChanged(object sender, EventArgs e)
        {
            registro[4, 0] = "prim_apellido";
            registro[4, 1] = TBPrimerApellido.Text.ToUpper();
        }

        private void TBSegundoApellido_TextChanged(object sender, EventArgs e)
        {
            registro[5, 0] = "segu_apellido";
            registro[5, 1] = TBSegundoApellido.Text.ToUpper();
        }

        private void RBFemenino_CheckedChanged(object sender, EventArgs e)
        {
            registro[7, 0] = "sexo";
            registro[7, 1] = "F";
        }

        private void RBMasculino_CheckedChanged(object sender, EventArgs e)
        {
            registro[7, 0] = "sexo";
            registro[7, 1] = "M";
        }

        private void TBDireccion_TextChanged(object sender, EventArgs e)
        {
            registro[8, 0] = "direccion";
            registro[8, 1] = TBDireccion.Text.ToUpper();
        }

        private void MTBTelefono_TextChanged(object sender, EventArgs e)
        {
            Int16 n = 0;
            for (int i = 0; i < MTBTelefono.Text.Length; i++)
            {
                if (Information.IsNumeric(MTBTelefono.Text.Substring(i, 1)))
                    n++;
            }
            if (n >= 8)
            {
                registro[9, 0] = "telefono";
                registro[9, 1] = MTBTelefono.Text;
            }
        }

        private void MTBCelular_TextChanged(object sender, EventArgs e)
        {
            Int16 n = 0;
            for (int i = 0; i < MTBCelular.Text.Length; i++)
            {
                if (Information.IsNumeric(MTBCelular.Text.Substring(i, 1)))
                    n++;
            }
            if (n == 9)
            {
                registro[10, 0] = "celular";
                registro[10, 1] = MTBCelular.Text;
            }
        }

        private void CBCamisa_TextChanged(object sender, EventArgs e)
        {
            registro[11, 0] = "t_camisa";
            registro[11, 1] = CBCamisa.Text.ToUpper();
        }

        private void CBCasaca_TextChanged(object sender, EventArgs e)
        {
            registro[12, 0] = "t_casaca";
            registro[12, 1] = CBCasaca.Text.ToUpper();
        }

        private void CBPantalon_TextChanged(object sender, EventArgs e)
        {
            registro[13, 0] = "t_pantalon";
            registro[13, 1] = CBPantalon.Text.ToUpper();
        }

        private void CBCalzado_TextChanged(object sender, EventArgs e)
        {
            registro[14, 0] = "t_calzado";
            registro[14, 1] = CBCalzado.Text.ToUpper();
        }

        private void ChBActivo_CheckedChanged(object sender, EventArgs e)
        {
            registro[15, 0] = "activo";
            registro[15, 1] = ChBActivo.Checked ? "1" : "0";
        }

        private void CBArea_TextChanged(object sender, EventArgs e)
        {
            registro[16, 0] = "area_trabajo";
            registro[16, 1] = CBArea.Text.ToUpper();
        }

        private void CBCargo_TextChanged(object sender, EventArgs e)
        {
            registro[17, 0] = "cargo";
            registro[17, 1] = CBCargo.Text.ToUpper();
        }

        private void CBCategoria_TextChanged(object sender, EventArgs e)
        {
            registro[18, 0] = "categoria";
            registro[18, 1] = CBCategoria.Text.ToUpper();
        }

        private void ChBLaptop_CheckedChanged(object sender, EventArgs e)
        {
            registro[19, 0] = "laptop";
            registro[19, 1] = ChBLaptop.Checked ? "1" : "0";
        }

        private void ChBCelular_CheckedChanged(object sender, EventArgs e)
        {
            registro[20, 0] = "celular_t";
            registro[20, 1] = ChBCelular.Checked ? "1" : "0";
        }

        private void ChBRadio_CheckedChanged(object sender, EventArgs e)
        {
            registro[21, 0] = "radio";
            registro[21, 1] = ChBRadio.Checked ? "1" : "0";
        }

        private void ChBHerramientas_CheckedChanged(object sender, EventArgs e)
        {
            registro[22, 0] = "herramientas";
            registro[22, 1] = ChBHerramientas.Checked ? "1" : "0";
        }

        private void TBNota_TextChanged(object sender, EventArgs e)
        {
            registro[24, 0] = "nota";
            registro[24, 1] = TBNota.Text.ToUpper();
        }

        private void TSBEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirmar eliminación de los datos", "LOGIntegral", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string sql = $"DELETE FROM personal WHERE (documento = '{TBDocumento.Text.ToString().ToUpper()}')";
                metodos.EjecutarComandoSQL(sql);
                BorrarContenido();
                metodos.DesabilitarControlesForm(this);
                metodos.DesabilitarGroupBox(GBTallas);
                metodos.DesabilitarGroupBox(GBTrabajo);
                BCamara.Enabled = false;
                HabilitarBotones();
            }
        }

        private void TSBEditar_Click(object sender, EventArgs e)
        {
            if (TBDocumento.Text.Length > 0)
            {
                opciones = 2;
                metodos.HabilitarControlesForm(this);
                metodos.HabilitarGroupBox(GBTallas);
                metodos.HabilitarGroupBox(GBTrabajo);
                DesabilitarBotones();
                BCamara.Enabled = true;
                CBResolucion.Enabled = false;
                CBTipoDocumento.Enabled = false;
                TBDocumento.Enabled = false;
                TBPrimerNombre.Select();
            }
            else
                MessageBox.Show("Seleccionar previamente datos un personal", "LOGIntegral", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
