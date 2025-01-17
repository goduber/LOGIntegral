
namespace LOGIntegral
{
    partial class FRMConfiguracion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("Amarillo", 0);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("Azul", 1);
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("Blanco", 2);
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("Gris", 3);
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem("Marron", 4);
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem("Morado", 5);
            System.Windows.Forms.ListViewItem listViewItem7 = new System.Windows.Forms.ListViewItem("Naranja", 6);
            System.Windows.Forms.ListViewItem listViewItem8 = new System.Windows.Forms.ListViewItem("Negro", 7);
            System.Windows.Forms.ListViewItem listViewItem9 = new System.Windows.Forms.ListViewItem("Rojo", 8);
            System.Windows.Forms.ListViewItem listViewItem10 = new System.Windows.Forms.ListViewItem("Verde", 9);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRMConfiguracion));
            this.TCConfiguracion = new System.Windows.Forms.TabControl();
            this.TPGeneral = new System.Windows.Forms.TabPage();
            this.PBCinta = new System.Windows.Forms.PictureBox();
            this.CBMes = new System.Windows.Forms.ComboBox();
            this.LColor = new System.Windows.Forms.Label();
            this.LVColor = new System.Windows.Forms.ListView();
            this.ILColor = new System.Windows.Forms.ImageList(this.components);
            this.LMes = new System.Windows.Forms.Label();
            this.ChBVoz = new System.Windows.Forms.CheckBox();
            this.BHablar = new System.Windows.Forms.Button();
            this.ILConfiguracion = new System.Windows.Forms.ImageList(this.components);
            this.CBVoz = new System.Windows.Forms.ComboBox();
            this.LVoz = new System.Windows.Forms.Label();
            this.TBPuerto = new System.Windows.Forms.TextBox();
            this.LPuerto = new System.Windows.Forms.Label();
            this.LConexion = new System.Windows.Forms.Label();
            this.BServidor = new System.Windows.Forms.Button();
            this.TBServidor = new System.Windows.Forms.TextBox();
            this.LServidor = new System.Windows.Forms.Label();
            this.LTema = new System.Windows.Forms.Label();
            this.TPTipoDocumento = new System.Windows.Forms.TabPage();
            this.TBLongitud = new System.Windows.Forms.TextBox();
            this.LLongitud = new System.Windows.Forms.Label();
            this.TSTipoDocumento = new System.Windows.Forms.ToolStrip();
            this.TSBGuardarTDocumento = new System.Windows.Forms.ToolStripButton();
            this.TSBEliminarTDocumento = new System.Windows.Forms.ToolStripButton();
            this.TSBEditarTDocumento = new System.Windows.Forms.ToolStripButton();
            this.TSBNuevoTDocumento = new System.Windows.Forms.ToolStripButton();
            this.TBDescripcion = new System.Windows.Forms.TextBox();
            this.TBTipoDocumento = new System.Windows.Forms.TextBox();
            this.LTipoDocumento = new System.Windows.Forms.Label();
            this.LDescripcion = new System.Windows.Forms.Label();
            this.DGVTipoDocumento = new System.Windows.Forms.DataGridView();
            this.DGVTCTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGVTCDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGVTBLongitud = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TTConfiguracion = new System.Windows.Forms.ToolTip(this.components);
            this.ErrPConfiguracion = new System.Windows.Forms.ErrorProvider(this.components);
            this.CBTema = new System.Windows.Forms.ComboBox();
            this.TCConfiguracion.SuspendLayout();
            this.TPGeneral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBCinta)).BeginInit();
            this.TPTipoDocumento.SuspendLayout();
            this.TSTipoDocumento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVTipoDocumento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrPConfiguracion)).BeginInit();
            this.SuspendLayout();
            // 
            // TCConfiguracion
            // 
            this.TCConfiguracion.Controls.Add(this.TPGeneral);
            this.TCConfiguracion.Controls.Add(this.TPTipoDocumento);
            this.TCConfiguracion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TCConfiguracion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TCConfiguracion.Location = new System.Drawing.Point(0, 0);
            this.TCConfiguracion.Margin = new System.Windows.Forms.Padding(4);
            this.TCConfiguracion.Name = "TCConfiguracion";
            this.TCConfiguracion.SelectedIndex = 0;
            this.TCConfiguracion.Size = new System.Drawing.Size(1200, 693);
            this.TCConfiguracion.TabIndex = 0;
            this.TCConfiguracion.Selected += new System.Windows.Forms.TabControlEventHandler(this.TCConfiguracion_Selected);
            // 
            // TPGeneral
            // 
            this.TPGeneral.BackColor = System.Drawing.SystemColors.Control;
            this.TPGeneral.Controls.Add(this.PBCinta);
            this.TPGeneral.Controls.Add(this.CBMes);
            this.TPGeneral.Controls.Add(this.LColor);
            this.TPGeneral.Controls.Add(this.LVColor);
            this.TPGeneral.Controls.Add(this.LMes);
            this.TPGeneral.Controls.Add(this.ChBVoz);
            this.TPGeneral.Controls.Add(this.BHablar);
            this.TPGeneral.Controls.Add(this.CBVoz);
            this.TPGeneral.Controls.Add(this.LVoz);
            this.TPGeneral.Controls.Add(this.TBPuerto);
            this.TPGeneral.Controls.Add(this.LPuerto);
            this.TPGeneral.Controls.Add(this.LConexion);
            this.TPGeneral.Controls.Add(this.BServidor);
            this.TPGeneral.Controls.Add(this.TBServidor);
            this.TPGeneral.Controls.Add(this.LServidor);
            this.TPGeneral.Controls.Add(this.CBTema);
            this.TPGeneral.Controls.Add(this.LTema);
            this.TPGeneral.Location = new System.Drawing.Point(4, 25);
            this.TPGeneral.Margin = new System.Windows.Forms.Padding(4);
            this.TPGeneral.Name = "TPGeneral";
            this.TPGeneral.Padding = new System.Windows.Forms.Padding(4);
            this.TPGeneral.Size = new System.Drawing.Size(1192, 664);
            this.TPGeneral.TabIndex = 0;
            this.TPGeneral.Text = "General";
            this.TPGeneral.Paint += new System.Windows.Forms.PaintEventHandler(this.TPGeneral_Paint);
            // 
            // PBCinta
            // 
            this.PBCinta.Location = new System.Drawing.Point(874, 269);
            this.PBCinta.Margin = new System.Windows.Forms.Padding(4);
            this.PBCinta.Name = "PBCinta";
            this.PBCinta.Size = new System.Drawing.Size(302, 137);
            this.PBCinta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBCinta.TabIndex = 19;
            this.PBCinta.TabStop = false;
            // 
            // CBMes
            // 
            this.CBMes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBMes.FormattingEnabled = true;
            this.CBMes.Items.AddRange(new object[] {
            "Enero",
            "Febrero",
            "Marzo",
            "Abril",
            "Mayo",
            "Junio",
            "Julio",
            "Agosto",
            "Septiembre",
            "Octubre",
            "Noviembre",
            "Diciembre"});
            this.CBMes.Location = new System.Drawing.Point(76, 269);
            this.CBMes.Margin = new System.Windows.Forms.Padding(4);
            this.CBMes.Name = "CBMes";
            this.CBMes.Size = new System.Drawing.Size(206, 24);
            this.CBMes.TabIndex = 17;
            this.CBMes.SelectedIndexChanged += new System.EventHandler(this.CBMes_SelectedIndexChanged);
            // 
            // LColor
            // 
            this.LColor.AutoSize = true;
            this.LColor.BackColor = System.Drawing.Color.Transparent;
            this.LColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LColor.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LColor.Location = new System.Drawing.Point(294, 274);
            this.LColor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LColor.Name = "LColor";
            this.LColor.Size = new System.Drawing.Size(42, 16);
            this.LColor.TabIndex = 16;
            this.LColor.Text = "Color:";
            // 
            // LVColor
            // 
            this.LVColor.HideSelection = false;
            this.LVColor.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4,
            listViewItem5,
            listViewItem6,
            listViewItem7,
            listViewItem8,
            listViewItem9,
            listViewItem10});
            this.LVColor.Location = new System.Drawing.Point(368, 269);
            this.LVColor.Margin = new System.Windows.Forms.Padding(4);
            this.LVColor.Name = "LVColor";
            this.LVColor.Size = new System.Drawing.Size(482, 137);
            this.LVColor.SmallImageList = this.ILColor;
            this.LVColor.TabIndex = 15;
            this.LVColor.UseCompatibleStateImageBehavior = false;
            this.LVColor.View = System.Windows.Forms.View.List;
            this.LVColor.Click += new System.EventHandler(this.LVColor_Click);
            // 
            // ILColor
            // 
            this.ILColor.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ILColor.ImageStream")));
            this.ILColor.TransparentColor = System.Drawing.Color.Transparent;
            this.ILColor.Images.SetKeyName(0, "amarillo.ico");
            this.ILColor.Images.SetKeyName(1, "azul.ico");
            this.ILColor.Images.SetKeyName(2, "banco.ico");
            this.ILColor.Images.SetKeyName(3, "gris.ico");
            this.ILColor.Images.SetKeyName(4, "marron.ico");
            this.ILColor.Images.SetKeyName(5, "morado.ico");
            this.ILColor.Images.SetKeyName(6, "naranja.ico");
            this.ILColor.Images.SetKeyName(7, "negro.ico");
            this.ILColor.Images.SetKeyName(8, "rojo.ico");
            this.ILColor.Images.SetKeyName(9, "verde.ico");
            // 
            // LMes
            // 
            this.LMes.AutoSize = true;
            this.LMes.BackColor = System.Drawing.Color.Transparent;
            this.LMes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LMes.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LMes.Location = new System.Drawing.Point(12, 274);
            this.LMes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LMes.Name = "LMes";
            this.LMes.Size = new System.Drawing.Size(36, 16);
            this.LMes.TabIndex = 12;
            this.LMes.Text = "Mes:";
            // 
            // ChBVoz
            // 
            this.ChBVoz.AutoSize = true;
            this.ChBVoz.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChBVoz.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ChBVoz.Location = new System.Drawing.Point(814, 184);
            this.ChBVoz.Margin = new System.Windows.Forms.Padding(4);
            this.ChBVoz.Name = "ChBVoz";
            this.ChBVoz.Size = new System.Drawing.Size(131, 20);
            this.ChBVoz.TabIndex = 11;
            this.ChBVoz.Text = "Reproducir Audio";
            this.ChBVoz.UseVisualStyleBackColor = true;
            this.ChBVoz.CheckedChanged += new System.EventHandler(this.ChBVoz_CheckedChanged);
            // 
            // BHablar
            // 
            this.BHablar.BackColor = System.Drawing.SystemColors.Control;
            this.BHablar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BHablar.ImageIndex = 2;
            this.BHablar.ImageList = this.ILConfiguracion;
            this.BHablar.Location = new System.Drawing.Point(738, 161);
            this.BHablar.Margin = new System.Windows.Forms.Padding(4);
            this.BHablar.Name = "BHablar";
            this.BHablar.Size = new System.Drawing.Size(68, 73);
            this.BHablar.TabIndex = 10;
            this.TTConfiguracion.SetToolTip(this.BHablar, "Probar conexion de Base de Datos");
            this.BHablar.UseVisualStyleBackColor = false;
            this.BHablar.Click += new System.EventHandler(this.BHablar_Click);
            // 
            // ILConfiguracion
            // 
            this.ILConfiguracion.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ILConfiguracion.ImageStream")));
            this.ILConfiguracion.TransparentColor = System.Drawing.Color.Transparent;
            this.ILConfiguracion.Images.SetKeyName(0, "servidor Bases de Datos.png");
            this.ILConfiguracion.Images.SetKeyName(1, "nuevo2.png");
            this.ILConfiguracion.Images.SetKeyName(2, "altoparlante.png");
            // 
            // CBVoz
            // 
            this.CBVoz.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBVoz.FormattingEnabled = true;
            this.CBVoz.Location = new System.Drawing.Point(201, 180);
            this.CBVoz.Margin = new System.Windows.Forms.Padding(4);
            this.CBVoz.Name = "CBVoz";
            this.CBVoz.Size = new System.Drawing.Size(526, 24);
            this.CBVoz.TabIndex = 9;
            this.CBVoz.SelectedIndexChanged += new System.EventHandler(this.CBVoz_SelectedIndexChanged);
            // 
            // LVoz
            // 
            this.LVoz.AutoSize = true;
            this.LVoz.BackColor = System.Drawing.Color.Transparent;
            this.LVoz.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LVoz.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LVoz.Location = new System.Drawing.Point(12, 184);
            this.LVoz.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LVoz.Name = "LVoz";
            this.LVoz.Size = new System.Drawing.Size(119, 16);
            this.LVoz.TabIndex = 8;
            this.LVoz.Text = "Voz a Seleccionar:";
            // 
            // TBPuerto
            // 
            this.TBPuerto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBPuerto.Location = new System.Drawing.Point(405, 107);
            this.TBPuerto.Margin = new System.Windows.Forms.Padding(4);
            this.TBPuerto.Name = "TBPuerto";
            this.TBPuerto.Size = new System.Drawing.Size(144, 22);
            this.TBPuerto.TabIndex = 5;
            // 
            // LPuerto
            // 
            this.LPuerto.AutoSize = true;
            this.LPuerto.BackColor = System.Drawing.SystemColors.Control;
            this.LPuerto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LPuerto.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LPuerto.Location = new System.Drawing.Point(12, 113);
            this.LPuerto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LPuerto.Name = "LPuerto";
            this.LPuerto.Size = new System.Drawing.Size(49, 16);
            this.LPuerto.TabIndex = 4;
            this.LPuerto.Text = "Puerto:";
            // 
            // LConexion
            // 
            this.LConexion.AutoSize = true;
            this.LConexion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LConexion.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LConexion.Location = new System.Drawing.Point(861, 86);
            this.LConexion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LConexion.Name = "LConexion";
            this.LConexion.Size = new System.Drawing.Size(63, 16);
            this.LConexion.TabIndex = 7;
            this.LConexion.Text = "Conexión";
            this.LConexion.Visible = false;
            // 
            // BServidor
            // 
            this.BServidor.BackColor = System.Drawing.SystemColors.Control;
            this.BServidor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BServidor.ImageIndex = 0;
            this.BServidor.ImageList = this.ILConfiguracion;
            this.BServidor.Location = new System.Drawing.Point(784, 63);
            this.BServidor.Margin = new System.Windows.Forms.Padding(4);
            this.BServidor.Name = "BServidor";
            this.BServidor.Size = new System.Drawing.Size(68, 73);
            this.BServidor.TabIndex = 6;
            this.TTConfiguracion.SetToolTip(this.BServidor, "Probar conexion de Base de Datos");
            this.BServidor.UseVisualStyleBackColor = false;
            this.BServidor.Click += new System.EventHandler(this.BServidor_Click);
            // 
            // TBServidor
            // 
            this.TBServidor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBServidor.Location = new System.Drawing.Point(405, 64);
            this.TBServidor.Margin = new System.Windows.Forms.Padding(4);
            this.TBServidor.Name = "TBServidor";
            this.TBServidor.Size = new System.Drawing.Size(366, 22);
            this.TBServidor.TabIndex = 3;
            // 
            // LServidor
            // 
            this.LServidor.AutoSize = true;
            this.LServidor.BackColor = System.Drawing.SystemColors.Control;
            this.LServidor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LServidor.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LServidor.Location = new System.Drawing.Point(12, 69);
            this.LServidor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LServidor.Name = "LServidor";
            this.LServidor.Size = new System.Drawing.Size(255, 16);
            this.LServidor.TabIndex = 2;
            this.LServidor.Text = "Dirección del Servidor de Base de Datos:";
            // 
            // LTema
            // 
            this.LTema.AutoSize = true;
            this.LTema.BackColor = System.Drawing.Color.Transparent;
            this.LTema.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTema.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LTema.Location = new System.Drawing.Point(12, 20);
            this.LTema.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LTema.Name = "LTema";
            this.LTema.Size = new System.Drawing.Size(46, 16);
            this.LTema.TabIndex = 0;
            this.LTema.Text = "Tema:";
            // 
            // TPTipoDocumento
            // 
            this.TPTipoDocumento.BackColor = System.Drawing.SystemColors.Control;
            this.TPTipoDocumento.Controls.Add(this.TBLongitud);
            this.TPTipoDocumento.Controls.Add(this.LLongitud);
            this.TPTipoDocumento.Controls.Add(this.TSTipoDocumento);
            this.TPTipoDocumento.Controls.Add(this.TBDescripcion);
            this.TPTipoDocumento.Controls.Add(this.TBTipoDocumento);
            this.TPTipoDocumento.Controls.Add(this.LTipoDocumento);
            this.TPTipoDocumento.Controls.Add(this.LDescripcion);
            this.TPTipoDocumento.Controls.Add(this.DGVTipoDocumento);
            this.TPTipoDocumento.Location = new System.Drawing.Point(4, 25);
            this.TPTipoDocumento.Margin = new System.Windows.Forms.Padding(4);
            this.TPTipoDocumento.Name = "TPTipoDocumento";
            this.TPTipoDocumento.Padding = new System.Windows.Forms.Padding(4);
            this.TPTipoDocumento.Size = new System.Drawing.Size(1192, 664);
            this.TPTipoDocumento.TabIndex = 1;
            this.TPTipoDocumento.Text = "Tipo de Documento";
            // 
            // TBLongitud
            // 
            this.TBLongitud.Enabled = false;
            this.TBLongitud.Location = new System.Drawing.Point(1090, 49);
            this.TBLongitud.Margin = new System.Windows.Forms.Padding(4);
            this.TBLongitud.MaxLength = 2;
            this.TBLongitud.Name = "TBLongitud";
            this.TBLongitud.Size = new System.Drawing.Size(67, 22);
            this.TBLongitud.TabIndex = 5;
            this.TBLongitud.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBLongitud_KeyPress);
            this.TBLongitud.Leave += new System.EventHandler(this.TBLongitud_Leave);
            // 
            // LLongitud
            // 
            this.LLongitud.AutoSize = true;
            this.LLongitud.BackColor = System.Drawing.SystemColors.Control;
            this.LLongitud.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LLongitud.Location = new System.Drawing.Point(988, 54);
            this.LLongitud.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LLongitud.Name = "LLongitud";
            this.LLongitud.Size = new System.Drawing.Size(61, 16);
            this.LLongitud.TabIndex = 4;
            this.LLongitud.Text = "Longitud:";
            // 
            // TSTipoDocumento
            // 
            this.TSTipoDocumento.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TSTipoDocumento.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.TSTipoDocumento.ImageScalingSize = new System.Drawing.Size(38, 38);
            this.TSTipoDocumento.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSBGuardarTDocumento,
            this.TSBEliminarTDocumento,
            this.TSBEditarTDocumento,
            this.TSBNuevoTDocumento});
            this.TSTipoDocumento.Location = new System.Drawing.Point(4, 615);
            this.TSTipoDocumento.Name = "TSTipoDocumento";
            this.TSTipoDocumento.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.TSTipoDocumento.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TSTipoDocumento.Size = new System.Drawing.Size(1184, 45);
            this.TSTipoDocumento.TabIndex = 7;
            this.TSTipoDocumento.Text = "toolStrip1";
            // 
            // TSBGuardarTDocumento
            // 
            this.TSBGuardarTDocumento.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSBGuardarTDocumento.Enabled = false;
            this.TSBGuardarTDocumento.Image = global::LOGIntegral.Properties.Resources.guardar;
            this.TSBGuardarTDocumento.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSBGuardarTDocumento.Name = "TSBGuardarTDocumento";
            this.TSBGuardarTDocumento.Size = new System.Drawing.Size(42, 42);
            this.TSBGuardarTDocumento.Text = "toolStripButton4";
            this.TSBGuardarTDocumento.ToolTipText = "Guardar";
            this.TSBGuardarTDocumento.Click += new System.EventHandler(this.TSBGuardarTDocumento_Click);
            // 
            // TSBEliminarTDocumento
            // 
            this.TSBEliminarTDocumento.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSBEliminarTDocumento.Image = global::LOGIntegral.Properties.Resources.eliminar;
            this.TSBEliminarTDocumento.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSBEliminarTDocumento.Name = "TSBEliminarTDocumento";
            this.TSBEliminarTDocumento.Size = new System.Drawing.Size(42, 42);
            this.TSBEliminarTDocumento.Text = "toolStripButton3";
            this.TSBEliminarTDocumento.ToolTipText = "Eliminar Tipo de Documento";
            this.TSBEliminarTDocumento.Click += new System.EventHandler(this.TSBEliminarTDocumento_Click);
            // 
            // TSBEditarTDocumento
            // 
            this.TSBEditarTDocumento.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSBEditarTDocumento.Image = global::LOGIntegral.Properties.Resources.editar;
            this.TSBEditarTDocumento.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSBEditarTDocumento.Name = "TSBEditarTDocumento";
            this.TSBEditarTDocumento.Size = new System.Drawing.Size(42, 42);
            this.TSBEditarTDocumento.Text = "toolStripButton2";
            this.TSBEditarTDocumento.ToolTipText = "Editar Descripción de Tipo de Documento";
            this.TSBEditarTDocumento.Click += new System.EventHandler(this.TSBEditarTDocumento_Click);
            // 
            // TSBNuevoTDocumento
            // 
            this.TSBNuevoTDocumento.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSBNuevoTDocumento.Image = global::LOGIntegral.Properties.Resources.nuevoDoc;
            this.TSBNuevoTDocumento.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSBNuevoTDocumento.Name = "TSBNuevoTDocumento";
            this.TSBNuevoTDocumento.Size = new System.Drawing.Size(42, 42);
            this.TSBNuevoTDocumento.Text = "toolStripButton1";
            this.TSBNuevoTDocumento.ToolTipText = "Crear Nuevo Tipo de Documento";
            this.TSBNuevoTDocumento.Click += new System.EventHandler(this.TSBNuevoTDocumento_Click);
            // 
            // TBDescripcion
            // 
            this.TBDescripcion.Enabled = false;
            this.TBDescripcion.Location = new System.Drawing.Point(357, 49);
            this.TBDescripcion.Margin = new System.Windows.Forms.Padding(4);
            this.TBDescripcion.Name = "TBDescripcion";
            this.TBDescripcion.Size = new System.Drawing.Size(620, 22);
            this.TBDescripcion.TabIndex = 3;
            this.TBDescripcion.TextChanged += new System.EventHandler(this.TBDescripcion_TextChanged);
            this.TBDescripcion.Leave += new System.EventHandler(this.TBDescripcion_Leave);
            // 
            // TBTipoDocumento
            // 
            this.TBTipoDocumento.Enabled = false;
            this.TBTipoDocumento.Location = new System.Drawing.Point(216, 9);
            this.TBTipoDocumento.Margin = new System.Windows.Forms.Padding(4);
            this.TBTipoDocumento.Name = "TBTipoDocumento";
            this.TBTipoDocumento.Size = new System.Drawing.Size(148, 22);
            this.TBTipoDocumento.TabIndex = 1;
            this.TBTipoDocumento.Leave += new System.EventHandler(this.TBTipoDocumento_Leave);
            // 
            // LTipoDocumento
            // 
            this.LTipoDocumento.AutoSize = true;
            this.LTipoDocumento.BackColor = System.Drawing.SystemColors.Control;
            this.LTipoDocumento.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LTipoDocumento.Location = new System.Drawing.Point(12, 14);
            this.LTipoDocumento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LTipoDocumento.Name = "LTipoDocumento";
            this.LTipoDocumento.Size = new System.Drawing.Size(129, 16);
            this.LTipoDocumento.TabIndex = 0;
            this.LTipoDocumento.Text = "Tipo de Documento:";
            // 
            // LDescripcion
            // 
            this.LDescripcion.AutoSize = true;
            this.LDescripcion.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LDescripcion.Location = new System.Drawing.Point(12, 54);
            this.LDescripcion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LDescripcion.Name = "LDescripcion";
            this.LDescripcion.Size = new System.Drawing.Size(223, 16);
            this.LDescripcion.TabIndex = 2;
            this.LDescripcion.Text = "Descripción de Tipo de Documento:";
            // 
            // DGVTipoDocumento
            // 
            this.DGVTipoDocumento.AllowUserToAddRows = false;
            this.DGVTipoDocumento.AllowUserToDeleteRows = false;
            this.DGVTipoDocumento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVTipoDocumento.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DGVTCTipo,
            this.DGVTCDescripcion,
            this.DGVTBLongitud});
            this.DGVTipoDocumento.Location = new System.Drawing.Point(12, 106);
            this.DGVTipoDocumento.Margin = new System.Windows.Forms.Padding(4);
            this.DGVTipoDocumento.Name = "DGVTipoDocumento";
            this.DGVTipoDocumento.ReadOnly = true;
            this.DGVTipoDocumento.RowHeadersWidth = 25;
            this.DGVTipoDocumento.Size = new System.Drawing.Size(1164, 469);
            this.DGVTipoDocumento.TabIndex = 6;
            this.DGVTipoDocumento.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVTipoDocumento_CellClick);
            // 
            // DGVTCTipo
            // 
            this.DGVTCTipo.Frozen = true;
            this.DGVTCTipo.HeaderText = "Tipo";
            this.DGVTCTipo.MinimumWidth = 8;
            this.DGVTCTipo.Name = "DGVTCTipo";
            this.DGVTCTipo.ReadOnly = true;
            this.DGVTCTipo.Width = 150;
            // 
            // DGVTCDescripcion
            // 
            this.DGVTCDescripcion.Frozen = true;
            this.DGVTCDescripcion.HeaderText = "Descripcion";
            this.DGVTCDescripcion.MinimumWidth = 8;
            this.DGVTCDescripcion.Name = "DGVTCDescripcion";
            this.DGVTCDescripcion.ReadOnly = true;
            this.DGVTCDescripcion.Width = 150;
            // 
            // DGVTBLongitud
            // 
            this.DGVTBLongitud.Frozen = true;
            this.DGVTBLongitud.HeaderText = "Longitud";
            this.DGVTBLongitud.MinimumWidth = 8;
            this.DGVTBLongitud.Name = "DGVTBLongitud";
            this.DGVTBLongitud.ReadOnly = true;
            this.DGVTBLongitud.Width = 150;
            // 
            // TTConfiguracion
            // 
            this.TTConfiguracion.AutomaticDelay = 250;
            // 
            // ErrPConfiguracion
            // 
            this.ErrPConfiguracion.ContainerControl = this;
            // 
            // CBTema
            // 
            this.CBTema.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBTema.FormattingEnabled = true;
            this.CBTema.Location = new System.Drawing.Point(92, 16);
            this.CBTema.Margin = new System.Windows.Forms.Padding(4);
            this.CBTema.Name = "CBTema";
            this.CBTema.Size = new System.Drawing.Size(390, 24);
            this.CBTema.TabIndex = 1;
            // 
            // FRMConfiguracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 693);
            this.Controls.Add(this.TCConfiguracion);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRMConfiguracion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "LOGI - Configuración";
            this.TCConfiguracion.ResumeLayout(false);
            this.TPGeneral.ResumeLayout(false);
            this.TPGeneral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBCinta)).EndInit();
            this.TPTipoDocumento.ResumeLayout(false);
            this.TPTipoDocumento.PerformLayout();
            this.TSTipoDocumento.ResumeLayout(false);
            this.TSTipoDocumento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVTipoDocumento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrPConfiguracion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TCConfiguracion;
        private System.Windows.Forms.TabPage TPGeneral;
        private System.Windows.Forms.TabPage TPTipoDocumento;
        private System.Windows.Forms.Label LTema;
        private System.Windows.Forms.Label LConexion;
        private System.Windows.Forms.Button BServidor;
        private System.Windows.Forms.ImageList ILConfiguracion;
        private System.Windows.Forms.TextBox TBServidor;
        private System.Windows.Forms.Label LServidor;
        private System.Windows.Forms.ToolTip TTConfiguracion;
        private System.Windows.Forms.TextBox TBPuerto;
        private System.Windows.Forms.Label LPuerto;
        private System.Windows.Forms.DataGridView DGVTipoDocumento;
        private System.Windows.Forms.TextBox TBDescripcion;
        private System.Windows.Forms.TextBox TBTipoDocumento;
        private System.Windows.Forms.Label LTipoDocumento;
        private System.Windows.Forms.Label LDescripcion;
        private System.Windows.Forms.ToolStrip TSTipoDocumento;
        private System.Windows.Forms.ToolStripButton TSBNuevoTDocumento;
        private System.Windows.Forms.ToolStripButton TSBEditarTDocumento;
        private System.Windows.Forms.ToolStripButton TSBGuardarTDocumento;
        private System.Windows.Forms.ToolStripButton TSBEliminarTDocumento;
        private System.Windows.Forms.ComboBox CBVoz;
        private System.Windows.Forms.Label LVoz;
        private System.Windows.Forms.Button BHablar;
        private System.Windows.Forms.CheckBox ChBVoz;
        private System.Windows.Forms.TextBox TBLongitud;
        private System.Windows.Forms.Label LLongitud;
        private System.Windows.Forms.ErrorProvider ErrPConfiguracion;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGVTCTipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGVTCDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGVTBLongitud;
        private System.Windows.Forms.Label LMes;
        private System.Windows.Forms.Label LColor;
        private System.Windows.Forms.ListView LVColor;
        private System.Windows.Forms.ComboBox CBMes;
        private System.Windows.Forms.PictureBox PBCinta;
        private System.Windows.Forms.ImageList ILColor;
        private System.Windows.Forms.ComboBox CBTema;
    }
}