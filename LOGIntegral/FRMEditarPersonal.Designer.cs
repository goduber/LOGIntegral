
namespace LOGIntegral
{
    partial class FRMEditarPersonal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRMEditarPersonal));
            this.LTipoDocumento = new System.Windows.Forms.Label();
            this.CBTipoDocumento = new System.Windows.Forms.ComboBox();
            this.LDocumento = new System.Windows.Forms.Label();
            this.TBDocumento = new System.Windows.Forms.TextBox();
            this.TSEditarPersonal = new System.Windows.Forms.ToolStrip();
            this.TSBSalir = new System.Windows.Forms.ToolStripButton();
            this.TSBGuardar = new System.Windows.Forms.ToolStripButton();
            this.TSBEliminar = new System.Windows.Forms.ToolStripButton();
            this.TSBEditar = new System.Windows.Forms.ToolStripButton();
            this.TSBNuevo = new System.Windows.Forms.ToolStripButton();
            this.LPrimerNombre = new System.Windows.Forms.Label();
            this.TBPrimerNombre = new System.Windows.Forms.TextBox();
            this.TBSegundoNombre = new System.Windows.Forms.TextBox();
            this.LSegundoNombre = new System.Windows.Forms.Label();
            this.LPrimerApellido = new System.Windows.Forms.Label();
            this.TBSegundoApellido = new System.Windows.Forms.TextBox();
            this.LSegundoApellido = new System.Windows.Forms.Label();
            this.TBPrimerApellido = new System.Windows.Forms.TextBox();
            this.LFechaNacimiento = new System.Windows.Forms.Label();
            this.DTPFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.LEdad = new System.Windows.Forms.Label();
            this.LSexo = new System.Windows.Forms.Label();
            this.RBFemenino = new System.Windows.Forms.RadioButton();
            this.RBMasculino = new System.Windows.Forms.RadioButton();
            this.LDireccion = new System.Windows.Forms.Label();
            this.TBDireccion = new System.Windows.Forms.TextBox();
            this.LTelefono = new System.Windows.Forms.Label();
            this.MTBTelefono = new System.Windows.Forms.MaskedTextBox();
            this.LCelular = new System.Windows.Forms.Label();
            this.MTBCelular = new System.Windows.Forms.MaskedTextBox();
            this.GBTallas = new System.Windows.Forms.GroupBox();
            this.CBCalzado = new System.Windows.Forms.ComboBox();
            this.LCalzado = new System.Windows.Forms.Label();
            this.ILPersonal = new System.Windows.Forms.ImageList(this.components);
            this.CBPantalon = new System.Windows.Forms.ComboBox();
            this.CBCasaca = new System.Windows.Forms.ComboBox();
            this.LPantalon = new System.Windows.Forms.Label();
            this.LCasaca = new System.Windows.Forms.Label();
            this.CBCamisa = new System.Windows.Forms.ComboBox();
            this.LCamisa = new System.Windows.Forms.Label();
            this.GBTrabajo = new System.Windows.Forms.GroupBox();
            this.ChBHerramientas = new System.Windows.Forms.CheckBox();
            this.ChBRadio = new System.Windows.Forms.CheckBox();
            this.ChBCelular = new System.Windows.Forms.CheckBox();
            this.ChBLaptop = new System.Windows.Forms.CheckBox();
            this.CBCategoria = new System.Windows.Forms.ComboBox();
            this.LCategoria = new System.Windows.Forms.Label();
            this.CBCargo = new System.Windows.Forms.ComboBox();
            this.LCargo = new System.Windows.Forms.Label();
            this.CBArea = new System.Windows.Forms.ComboBox();
            this.LArea = new System.Windows.Forms.Label();
            this.ChBActivo = new System.Windows.Forms.CheckBox();
            this.TBNota = new System.Windows.Forms.TextBox();
            this.LNota = new System.Windows.Forms.Label();
            this.CBCamaras = new System.Windows.Forms.ComboBox();
            this.BCamara = new System.Windows.Forms.Button();
            this.PBFoto = new System.Windows.Forms.PictureBox();
            this.CBResolucion = new System.Windows.Forms.ComboBox();
            this.ErrPEditarPersonal = new System.Windows.Forms.ErrorProvider(this.components);
            this.TSEditarPersonal.SuspendLayout();
            this.GBTallas.SuspendLayout();
            this.GBTrabajo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBFoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrPEditarPersonal)).BeginInit();
            this.SuspendLayout();
            // 
            // LTipoDocumento
            // 
            this.LTipoDocumento.AutoSize = true;
            this.LTipoDocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTipoDocumento.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LTipoDocumento.Location = new System.Drawing.Point(12, 15);
            this.LTipoDocumento.Name = "LTipoDocumento";
            this.LTipoDocumento.Size = new System.Drawing.Size(130, 16);
            this.LTipoDocumento.TabIndex = 0;
            this.LTipoDocumento.Text = "Tipo de Documento:";
            // 
            // CBTipoDocumento
            // 
            this.CBTipoDocumento.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CBTipoDocumento.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.CBTipoDocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBTipoDocumento.FormattingEnabled = true;
            this.CBTipoDocumento.Location = new System.Drawing.Point(148, 12);
            this.CBTipoDocumento.MaxLength = 5;
            this.CBTipoDocumento.Name = "CBTipoDocumento";
            this.CBTipoDocumento.Size = new System.Drawing.Size(71, 24);
            this.CBTipoDocumento.Sorted = true;
            this.CBTipoDocumento.TabIndex = 1;
            this.CBTipoDocumento.SelectedIndexChanged += new System.EventHandler(this.CBTipoDocumento_SelectedIndexChanged);
            this.CBTipoDocumento.TextChanged += new System.EventHandler(this.CBTipoDocumento_TextChanged);
            this.CBTipoDocumento.Leave += new System.EventHandler(this.CBTipoDocumento_Leave);
            // 
            // LDocumento
            // 
            this.LDocumento.AutoSize = true;
            this.LDocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LDocumento.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LDocumento.Location = new System.Drawing.Point(225, 15);
            this.LDocumento.Name = "LDocumento";
            this.LDocumento.Size = new System.Drawing.Size(80, 16);
            this.LDocumento.TabIndex = 2;
            this.LDocumento.Text = "Documento:";
            // 
            // TBDocumento
            // 
            this.TBDocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBDocumento.Location = new System.Drawing.Point(311, 12);
            this.TBDocumento.MaxLength = 12;
            this.TBDocumento.Name = "TBDocumento";
            this.TBDocumento.Size = new System.Drawing.Size(95, 22);
            this.TBDocumento.TabIndex = 3;
            this.TBDocumento.TextChanged += new System.EventHandler(this.TBDocumento_TextChanged);
            this.TBDocumento.Leave += new System.EventHandler(this.TBDocumento_Leave);
            // 
            // TSEditarPersonal
            // 
            this.TSEditarPersonal.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TSEditarPersonal.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.TSEditarPersonal.ImageScalingSize = new System.Drawing.Size(38, 38);
            this.TSEditarPersonal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSBSalir,
            this.TSBGuardar,
            this.TSBEliminar,
            this.TSBEditar,
            this.TSBNuevo});
            this.TSEditarPersonal.Location = new System.Drawing.Point(0, 405);
            this.TSEditarPersonal.Name = "TSEditarPersonal";
            this.TSEditarPersonal.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TSEditarPersonal.Size = new System.Drawing.Size(1027, 45);
            this.TSEditarPersonal.TabIndex = 6;
            this.TSEditarPersonal.Text = "toolStrip1";
            // 
            // TSBSalir
            // 
            this.TSBSalir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSBSalir.Image = global::LOGIntegral.Properties.Resources.salir;
            this.TSBSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSBSalir.Name = "TSBSalir";
            this.TSBSalir.Size = new System.Drawing.Size(42, 42);
            this.TSBSalir.Text = "Salir";
            this.TSBSalir.Click += new System.EventHandler(this.TSBSalir_Click);
            // 
            // TSBGuardar
            // 
            this.TSBGuardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSBGuardar.Enabled = false;
            this.TSBGuardar.Image = global::LOGIntegral.Properties.Resources.guardar;
            this.TSBGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSBGuardar.Name = "TSBGuardar";
            this.TSBGuardar.Size = new System.Drawing.Size(42, 42);
            this.TSBGuardar.Text = "toolStripButton4";
            this.TSBGuardar.ToolTipText = "Guardar";
            this.TSBGuardar.Click += new System.EventHandler(this.TSBGuardar_Click);
            // 
            // TSBEliminar
            // 
            this.TSBEliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSBEliminar.Image = global::LOGIntegral.Properties.Resources.eliminar;
            this.TSBEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSBEliminar.Name = "TSBEliminar";
            this.TSBEliminar.Size = new System.Drawing.Size(42, 42);
            this.TSBEliminar.Text = "toolStripButton3";
            this.TSBEliminar.ToolTipText = "Eliminar Tipo de Documento";
            this.TSBEliminar.Click += new System.EventHandler(this.TSBEliminar_Click);
            // 
            // TSBEditar
            // 
            this.TSBEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSBEditar.Image = global::LOGIntegral.Properties.Resources.editar;
            this.TSBEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSBEditar.Name = "TSBEditar";
            this.TSBEditar.Size = new System.Drawing.Size(42, 42);
            this.TSBEditar.Text = "toolStripButton2";
            this.TSBEditar.ToolTipText = "Editar Descripción de Tipo de Documento";
            this.TSBEditar.Click += new System.EventHandler(this.TSBEditar_Click);
            // 
            // TSBNuevo
            // 
            this.TSBNuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSBNuevo.Image = global::LOGIntegral.Properties.Resources.nuevoDoc;
            this.TSBNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSBNuevo.Name = "TSBNuevo";
            this.TSBNuevo.Size = new System.Drawing.Size(42, 42);
            this.TSBNuevo.Text = "toolStripButton1";
            this.TSBNuevo.ToolTipText = "Crear Nuevo Tipo de Documento";
            this.TSBNuevo.Click += new System.EventHandler(this.TSBNuevo_Click);
            // 
            // LPrimerNombre
            // 
            this.LPrimerNombre.AutoSize = true;
            this.LPrimerNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LPrimerNombre.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LPrimerNombre.Location = new System.Drawing.Point(12, 45);
            this.LPrimerNombre.Name = "LPrimerNombre";
            this.LPrimerNombre.Size = new System.Drawing.Size(102, 16);
            this.LPrimerNombre.TabIndex = 7;
            this.LPrimerNombre.Text = "Primer Nombre:";
            // 
            // TBPrimerNombre
            // 
            this.TBPrimerNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBPrimerNombre.Location = new System.Drawing.Point(120, 42);
            this.TBPrimerNombre.MaxLength = 20;
            this.TBPrimerNombre.Name = "TBPrimerNombre";
            this.TBPrimerNombre.Size = new System.Drawing.Size(278, 22);
            this.TBPrimerNombre.TabIndex = 8;
            this.TBPrimerNombre.TextChanged += new System.EventHandler(this.TBPrimerNombre_TextChanged);
            this.TBPrimerNombre.Leave += new System.EventHandler(this.TBPrimerNombre_Leave);
            // 
            // TBSegundoNombre
            // 
            this.TBSegundoNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBSegundoNombre.Location = new System.Drawing.Point(528, 42);
            this.TBSegundoNombre.MaxLength = 20;
            this.TBSegundoNombre.Name = "TBSegundoNombre";
            this.TBSegundoNombre.Size = new System.Drawing.Size(278, 22);
            this.TBSegundoNombre.TabIndex = 10;
            this.TBSegundoNombre.TextChanged += new System.EventHandler(this.TBSegundoNombre_TextChanged);
            // 
            // LSegundoNombre
            // 
            this.LSegundoNombre.AutoSize = true;
            this.LSegundoNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LSegundoNombre.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LSegundoNombre.Location = new System.Drawing.Point(404, 45);
            this.LSegundoNombre.Name = "LSegundoNombre";
            this.LSegundoNombre.Size = new System.Drawing.Size(118, 16);
            this.LSegundoNombre.TabIndex = 9;
            this.LSegundoNombre.Text = "Segundo Nombre:";
            // 
            // LPrimerApellido
            // 
            this.LPrimerApellido.AutoSize = true;
            this.LPrimerApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LPrimerApellido.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LPrimerApellido.Location = new System.Drawing.Point(12, 75);
            this.LPrimerApellido.Name = "LPrimerApellido";
            this.LPrimerApellido.Size = new System.Drawing.Size(103, 16);
            this.LPrimerApellido.TabIndex = 11;
            this.LPrimerApellido.Text = "Primer Apellido:";
            // 
            // TBSegundoApellido
            // 
            this.TBSegundoApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBSegundoApellido.Location = new System.Drawing.Point(525, 72);
            this.TBSegundoApellido.MaxLength = 20;
            this.TBSegundoApellido.Name = "TBSegundoApellido";
            this.TBSegundoApellido.Size = new System.Drawing.Size(278, 22);
            this.TBSegundoApellido.TabIndex = 14;
            this.TBSegundoApellido.TextChanged += new System.EventHandler(this.TBSegundoApellido_TextChanged);
            // 
            // LSegundoApellido
            // 
            this.LSegundoApellido.AutoSize = true;
            this.LSegundoApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LSegundoApellido.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LSegundoApellido.Location = new System.Drawing.Point(400, 75);
            this.LSegundoApellido.Name = "LSegundoApellido";
            this.LSegundoApellido.Size = new System.Drawing.Size(119, 16);
            this.LSegundoApellido.TabIndex = 13;
            this.LSegundoApellido.Text = "Segundo Apellido:";
            // 
            // TBPrimerApellido
            // 
            this.TBPrimerApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBPrimerApellido.Location = new System.Drawing.Point(116, 72);
            this.TBPrimerApellido.MaxLength = 20;
            this.TBPrimerApellido.Name = "TBPrimerApellido";
            this.TBPrimerApellido.Size = new System.Drawing.Size(278, 22);
            this.TBPrimerApellido.TabIndex = 12;
            this.TBPrimerApellido.TextChanged += new System.EventHandler(this.TBPrimerApellido_TextChanged);
            this.TBPrimerApellido.Leave += new System.EventHandler(this.TBPrimerApellido_Leave);
            // 
            // LFechaNacimiento
            // 
            this.LFechaNacimiento.AutoSize = true;
            this.LFechaNacimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LFechaNacimiento.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LFechaNacimiento.Location = new System.Drawing.Point(12, 108);
            this.LFechaNacimiento.Name = "LFechaNacimiento";
            this.LFechaNacimiento.Size = new System.Drawing.Size(139, 16);
            this.LFechaNacimiento.TabIndex = 15;
            this.LFechaNacimiento.Text = "Fecha de Nacimiento:";
            // 
            // DTPFechaNacimiento
            // 
            this.DTPFechaNacimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTPFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DTPFechaNacimiento.Location = new System.Drawing.Point(157, 103);
            this.DTPFechaNacimiento.Name = "DTPFechaNacimiento";
            this.DTPFechaNacimiento.Size = new System.Drawing.Size(195, 22);
            this.DTPFechaNacimiento.TabIndex = 16;
            this.DTPFechaNacimiento.ValueChanged += new System.EventHandler(this.DTPFechaNacimiento_ValueChanged);
            // 
            // LEdad
            // 
            this.LEdad.AutoSize = true;
            this.LEdad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LEdad.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LEdad.Location = new System.Drawing.Point(364, 108);
            this.LEdad.Name = "LEdad";
            this.LEdad.Size = new System.Drawing.Size(47, 16);
            this.LEdad.TabIndex = 17;
            this.LEdad.Text = "Edad: ";
            // 
            // LSexo
            // 
            this.LSexo.AutoSize = true;
            this.LSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LSexo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LSexo.Location = new System.Drawing.Point(472, 108);
            this.LSexo.Name = "LSexo";
            this.LSexo.Size = new System.Drawing.Size(42, 16);
            this.LSexo.TabIndex = 18;
            this.LSexo.Text = "Sexo:";
            // 
            // RBFemenino
            // 
            this.RBFemenino.AutoSize = true;
            this.RBFemenino.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBFemenino.ForeColor = System.Drawing.SystemColors.ControlText;
            this.RBFemenino.Location = new System.Drawing.Point(520, 106);
            this.RBFemenino.Name = "RBFemenino";
            this.RBFemenino.Size = new System.Drawing.Size(86, 20);
            this.RBFemenino.TabIndex = 19;
            this.RBFemenino.Text = "Femenino";
            this.RBFemenino.UseVisualStyleBackColor = true;
            this.RBFemenino.CheckedChanged += new System.EventHandler(this.RBFemenino_CheckedChanged);
            // 
            // RBMasculino
            // 
            this.RBMasculino.AutoSize = true;
            this.RBMasculino.Checked = true;
            this.RBMasculino.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBMasculino.ForeColor = System.Drawing.SystemColors.ControlText;
            this.RBMasculino.Location = new System.Drawing.Point(612, 106);
            this.RBMasculino.Name = "RBMasculino";
            this.RBMasculino.Size = new System.Drawing.Size(87, 20);
            this.RBMasculino.TabIndex = 20;
            this.RBMasculino.TabStop = true;
            this.RBMasculino.Text = "Masculino";
            this.RBMasculino.UseVisualStyleBackColor = true;
            this.RBMasculino.CheckedChanged += new System.EventHandler(this.RBMasculino_CheckedChanged);
            // 
            // LDireccion
            // 
            this.LDireccion.AutoSize = true;
            this.LDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LDireccion.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LDireccion.Location = new System.Drawing.Point(12, 134);
            this.LDireccion.Name = "LDireccion";
            this.LDireccion.Size = new System.Drawing.Size(159, 16);
            this.LDireccion.TabIndex = 21;
            this.LDireccion.Text = "Dirección de Residencia:";
            // 
            // TBDireccion
            // 
            this.TBDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBDireccion.Location = new System.Drawing.Point(177, 131);
            this.TBDireccion.MaxLength = 255;
            this.TBDireccion.Multiline = true;
            this.TBDireccion.Name = "TBDireccion";
            this.TBDireccion.Size = new System.Drawing.Size(629, 53);
            this.TBDireccion.TabIndex = 22;
            this.TBDireccion.TextChanged += new System.EventHandler(this.TBDireccion_TextChanged);
            // 
            // LTelefono
            // 
            this.LTelefono.AutoSize = true;
            this.LTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTelefono.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LTelefono.Location = new System.Drawing.Point(12, 193);
            this.LTelefono.Name = "LTelefono";
            this.LTelefono.Size = new System.Drawing.Size(156, 16);
            this.LTelefono.TabIndex = 23;
            this.LTelefono.Text = "Teléfono de Residencia:";
            // 
            // MTBTelefono
            // 
            this.MTBTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MTBTelefono.Location = new System.Drawing.Point(174, 190);
            this.MTBTelefono.Mask = "(99)000-0000";
            this.MTBTelefono.Name = "MTBTelefono";
            this.MTBTelefono.Size = new System.Drawing.Size(100, 22);
            this.MTBTelefono.TabIndex = 24;
            this.MTBTelefono.TextChanged += new System.EventHandler(this.MTBTelefono_TextChanged);
            // 
            // LCelular
            // 
            this.LCelular.AutoSize = true;
            this.LCelular.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LCelular.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LCelular.Location = new System.Drawing.Point(280, 193);
            this.LCelular.Name = "LCelular";
            this.LCelular.Size = new System.Drawing.Size(123, 16);
            this.LCelular.TabIndex = 25;
            this.LCelular.Text = "Número de Celular:";
            // 
            // MTBCelular
            // 
            this.MTBCelular.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MTBCelular.Location = new System.Drawing.Point(409, 190);
            this.MTBCelular.Mask = "000-000-000";
            this.MTBCelular.Name = "MTBCelular";
            this.MTBCelular.Size = new System.Drawing.Size(81, 22);
            this.MTBCelular.TabIndex = 26;
            this.MTBCelular.TextChanged += new System.EventHandler(this.MTBCelular_TextChanged);
            // 
            // GBTallas
            // 
            this.GBTallas.Controls.Add(this.CBCalzado);
            this.GBTallas.Controls.Add(this.LCalzado);
            this.GBTallas.Controls.Add(this.CBPantalon);
            this.GBTallas.Controls.Add(this.CBCasaca);
            this.GBTallas.Controls.Add(this.LPantalon);
            this.GBTallas.Controls.Add(this.LCasaca);
            this.GBTallas.Controls.Add(this.CBCamisa);
            this.GBTallas.Controls.Add(this.LCamisa);
            this.GBTallas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBTallas.ForeColor = System.Drawing.SystemColors.ControlText;
            this.GBTallas.Location = new System.Drawing.Point(15, 218);
            this.GBTallas.Name = "GBTallas";
            this.GBTallas.Size = new System.Drawing.Size(791, 63);
            this.GBTallas.TabIndex = 27;
            this.GBTallas.TabStop = false;
            this.GBTallas.Text = "Tallas";
            // 
            // CBCalzado
            // 
            this.CBCalzado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBCalzado.FormattingEnabled = true;
            this.CBCalzado.Items.AddRange(new object[] {
            "",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47"});
            this.CBCalzado.Location = new System.Drawing.Point(541, 22);
            this.CBCalzado.MaxLength = 2;
            this.CBCalzado.Name = "CBCalzado";
            this.CBCalzado.Size = new System.Drawing.Size(59, 24);
            this.CBCalzado.TabIndex = 31;
            this.CBCalzado.TextChanged += new System.EventHandler(this.CBCalzado_TextChanged);
            // 
            // LCalzado
            // 
            this.LCalzado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LCalzado.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LCalzado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LCalzado.ImageIndex = 5;
            this.LCalzado.ImageList = this.ILPersonal;
            this.LCalzado.Location = new System.Drawing.Point(454, 17);
            this.LCalzado.Name = "LCalzado";
            this.LCalzado.Size = new System.Drawing.Size(81, 32);
            this.LCalzado.TabIndex = 30;
            this.LCalzado.Text = "Calzado:";
            this.LCalzado.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LCalzado.UseCompatibleTextRendering = true;
            // 
            // ILPersonal
            // 
            this.ILPersonal.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ILPersonal.ImageStream")));
            this.ILPersonal.TransparentColor = System.Drawing.Color.Transparent;
            this.ILPersonal.Images.SetKeyName(0, "hombre.png");
            this.ILPersonal.Images.SetKeyName(1, "mujer.png");
            this.ILPersonal.Images.SetKeyName(2, "camisas.png");
            this.ILPersonal.Images.SetKeyName(3, "chaqueta.png");
            this.ILPersonal.Images.SetKeyName(4, "pantalones.png");
            this.ILPersonal.Images.SetKeyName(5, "botas.png");
            this.ILPersonal.Images.SetKeyName(6, "ordenador-portatil.png");
            this.ILPersonal.Images.SetKeyName(7, "telefono-inteligente.png");
            this.ILPersonal.Images.SetKeyName(8, "walkie-talkie.png");
            this.ILPersonal.Images.SetKeyName(9, "caja-de-herramientas.png");
            this.ILPersonal.Images.SetKeyName(10, "casco.png");
            this.ILPersonal.Images.SetKeyName(11, "kardex.png");
            this.ILPersonal.Images.SetKeyName(12, "camara-de-accion-desactivada.png");
            this.ILPersonal.Images.SetKeyName(13, "camara-de-accion.png");
            // 
            // CBPantalon
            // 
            this.CBPantalon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBPantalon.FormattingEnabled = true;
            this.CBPantalon.Items.AddRange(new object[] {
            "",
            "26",
            "28",
            "30",
            "32",
            "34",
            "36",
            "38",
            "40",
            "42",
            "44"});
            this.CBPantalon.Location = new System.Drawing.Point(389, 22);
            this.CBPantalon.MaxLength = 2;
            this.CBPantalon.Name = "CBPantalon";
            this.CBPantalon.Size = new System.Drawing.Size(59, 24);
            this.CBPantalon.TabIndex = 29;
            this.CBPantalon.TextChanged += new System.EventHandler(this.CBPantalon_TextChanged);
            // 
            // CBCasaca
            // 
            this.CBCasaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBCasaca.FormattingEnabled = true;
            this.CBCasaca.Items.AddRange(new object[] {
            "",
            "XS",
            "S",
            "M",
            "L",
            "XL",
            "2XL",
            "3XL"});
            this.CBCasaca.Location = new System.Drawing.Point(237, 22);
            this.CBCasaca.MaxLength = 3;
            this.CBCasaca.Name = "CBCasaca";
            this.CBCasaca.Size = new System.Drawing.Size(59, 24);
            this.CBCasaca.TabIndex = 27;
            this.CBCasaca.TextChanged += new System.EventHandler(this.CBCasaca_TextChanged);
            // 
            // LPantalon
            // 
            this.LPantalon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LPantalon.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LPantalon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LPantalon.ImageIndex = 4;
            this.LPantalon.ImageList = this.ILPersonal;
            this.LPantalon.Location = new System.Drawing.Point(302, 17);
            this.LPantalon.Name = "LPantalon";
            this.LPantalon.Size = new System.Drawing.Size(81, 32);
            this.LPantalon.TabIndex = 28;
            this.LPantalon.Text = "Pantalon:";
            this.LPantalon.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LPantalon.UseCompatibleTextRendering = true;
            // 
            // LCasaca
            // 
            this.LCasaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LCasaca.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LCasaca.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LCasaca.ImageIndex = 3;
            this.LCasaca.ImageList = this.ILPersonal;
            this.LCasaca.Location = new System.Drawing.Point(154, 17);
            this.LCasaca.Name = "LCasaca";
            this.LCasaca.Size = new System.Drawing.Size(77, 32);
            this.LCasaca.TabIndex = 26;
            this.LCasaca.Text = "Casaca:";
            this.LCasaca.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LCasaca.UseCompatibleTextRendering = true;
            // 
            // CBCamisa
            // 
            this.CBCamisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBCamisa.FormattingEnabled = true;
            this.CBCamisa.Items.AddRange(new object[] {
            "",
            "XS",
            "S",
            "M",
            "L",
            "XL",
            "2XL",
            "3XL"});
            this.CBCamisa.Location = new System.Drawing.Point(89, 22);
            this.CBCamisa.MaxLength = 3;
            this.CBCamisa.Name = "CBCamisa";
            this.CBCamisa.Size = new System.Drawing.Size(59, 24);
            this.CBCamisa.TabIndex = 25;
            this.CBCamisa.TextChanged += new System.EventHandler(this.CBCamisa_TextChanged);
            // 
            // LCamisa
            // 
            this.LCamisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LCamisa.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LCamisa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LCamisa.ImageIndex = 2;
            this.LCamisa.ImageList = this.ILPersonal;
            this.LCamisa.Location = new System.Drawing.Point(6, 17);
            this.LCamisa.Name = "LCamisa";
            this.LCamisa.Size = new System.Drawing.Size(77, 32);
            this.LCamisa.TabIndex = 24;
            this.LCamisa.Text = "Camisa:";
            this.LCamisa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LCamisa.UseCompatibleTextRendering = true;
            // 
            // GBTrabajo
            // 
            this.GBTrabajo.Controls.Add(this.ChBHerramientas);
            this.GBTrabajo.Controls.Add(this.ChBRadio);
            this.GBTrabajo.Controls.Add(this.ChBCelular);
            this.GBTrabajo.Controls.Add(this.ChBLaptop);
            this.GBTrabajo.Controls.Add(this.CBCategoria);
            this.GBTrabajo.Controls.Add(this.LCategoria);
            this.GBTrabajo.Controls.Add(this.CBCargo);
            this.GBTrabajo.Controls.Add(this.LCargo);
            this.GBTrabajo.Controls.Add(this.CBArea);
            this.GBTrabajo.Controls.Add(this.LArea);
            this.GBTrabajo.Controls.Add(this.ChBActivo);
            this.GBTrabajo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBTrabajo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.GBTrabajo.Location = new System.Drawing.Point(15, 287);
            this.GBTrabajo.Name = "GBTrabajo";
            this.GBTrabajo.Size = new System.Drawing.Size(791, 115);
            this.GBTrabajo.TabIndex = 28;
            this.GBTrabajo.TabStop = false;
            this.GBTrabajo.Text = "Datos Laborales";
            // 
            // ChBHerramientas
            // 
            this.ChBHerramientas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ChBHerramientas.ImageIndex = 9;
            this.ChBHerramientas.ImageList = this.ILPersonal;
            this.ChBHerramientas.Location = new System.Drawing.Point(301, 79);
            this.ChBHerramientas.Name = "ChBHerramientas";
            this.ChBHerramientas.Size = new System.Drawing.Size(135, 31);
            this.ChBHerramientas.TabIndex = 11;
            this.ChBHerramientas.Text = "Herramientas";
            this.ChBHerramientas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ChBHerramientas.UseVisualStyleBackColor = true;
            this.ChBHerramientas.CheckedChanged += new System.EventHandler(this.ChBHerramientas_CheckedChanged);
            // 
            // ChBRadio
            // 
            this.ChBRadio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ChBRadio.ImageIndex = 8;
            this.ChBRadio.ImageList = this.ILPersonal;
            this.ChBRadio.Location = new System.Drawing.Point(201, 79);
            this.ChBRadio.Name = "ChBRadio";
            this.ChBRadio.Size = new System.Drawing.Size(94, 31);
            this.ChBRadio.TabIndex = 10;
            this.ChBRadio.Text = "Radio";
            this.ChBRadio.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ChBRadio.UseVisualStyleBackColor = true;
            this.ChBRadio.CheckedChanged += new System.EventHandler(this.ChBRadio_CheckedChanged);
            // 
            // ChBCelular
            // 
            this.ChBCelular.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ChBCelular.ImageIndex = 7;
            this.ChBCelular.ImageList = this.ILPersonal;
            this.ChBCelular.Location = new System.Drawing.Point(101, 79);
            this.ChBCelular.Name = "ChBCelular";
            this.ChBCelular.Size = new System.Drawing.Size(94, 31);
            this.ChBCelular.TabIndex = 9;
            this.ChBCelular.Text = "Celular";
            this.ChBCelular.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ChBCelular.UseVisualStyleBackColor = true;
            this.ChBCelular.CheckedChanged += new System.EventHandler(this.ChBCelular_CheckedChanged);
            // 
            // ChBLaptop
            // 
            this.ChBLaptop.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ChBLaptop.ImageIndex = 6;
            this.ChBLaptop.ImageList = this.ILPersonal;
            this.ChBLaptop.Location = new System.Drawing.Point(6, 79);
            this.ChBLaptop.Name = "ChBLaptop";
            this.ChBLaptop.Size = new System.Drawing.Size(94, 31);
            this.ChBLaptop.TabIndex = 8;
            this.ChBLaptop.Text = "Laptop";
            this.ChBLaptop.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ChBLaptop.UseVisualStyleBackColor = true;
            this.ChBLaptop.CheckedChanged += new System.EventHandler(this.ChBLaptop_CheckedChanged);
            // 
            // CBCategoria
            // 
            this.CBCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBCategoria.FormattingEnabled = true;
            this.CBCategoria.Items.AddRange(new object[] {
            "",
            "RCC",
            "RCO",
            "STAFF"});
            this.CBCategoria.Location = new System.Drawing.Point(472, 49);
            this.CBCategoria.MaxLength = 5;
            this.CBCategoria.Name = "CBCategoria";
            this.CBCategoria.Size = new System.Drawing.Size(70, 24);
            this.CBCategoria.TabIndex = 7;
            this.CBCategoria.TextChanged += new System.EventHandler(this.CBCategoria_TextChanged);
            // 
            // LCategoria
            // 
            this.LCategoria.AutoSize = true;
            this.LCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LCategoria.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LCategoria.Location = new System.Drawing.Point(396, 52);
            this.LCategoria.Name = "LCategoria";
            this.LCategoria.Size = new System.Drawing.Size(70, 16);
            this.LCategoria.TabIndex = 6;
            this.LCategoria.Text = "Categoría:";
            // 
            // CBCargo
            // 
            this.CBCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBCargo.FormattingEnabled = true;
            this.CBCargo.Items.AddRange(new object[] {
            "",
            "ANALISTA DE GESTIÓN HUMANA",
            "ASISTENTE ADMINISTRATIVO",
            "ASISTENTE DE ALMACEN",
            "ASISTENTE DE CALIDAD",
            "ASISTENTE DE CONTROL DOCUMENTARIO",
            "ASISTENTE DE COSTOS",
            "ASISTENTE DE GESTIÓN HUMANA",
            "ASISTENTE DE OFICINA TÉCNICA",
            "ASISTENTE DE OPERACIONES",
            "ASISTENTE DE PLANEAMIENTO",
            "ASISTENTE DE PLANEAMIENTO Y COSTOS",
            "ASISTENTE DE SERVICIOS GENERALES",
            "ASISTENTE DE SSOMA",
            "AUXILIAR DE ALMACEN",
            "AUXILIAR DE COMPRAS",
            "AYUDANTE DE SERVICIOS GENERALES",
            "AYUDANTE DE TOPOGRAFÍA",
            "CADISTA",
            "CAPATAZ CIVIL",
            "CAPATAZ DE MOVIMIENTO DE TIERRAS",
            "CHOFER DE CAMIONETA",
            "CHOFER DE MINIBÚS",
            "COMPRADOR",
            "CONTROLADOR DE OPERACIONES",
            "COORDINADOR DE ADMINISTRACIÓN",
            "COORDINADOR DE GESTIÓN HUMANA",
            "COORDINADOR DE SERVICIOS GENERALES",
            "DESPACHADOR",
            "DIGITADOR",
            "ELECTRICISTA NIVEL 1",
            "ELECTRICISTA NIVEL 2",
            "ENFERMERO OCUPACIONAL",
            "GERENTE DE PROYECTO",
            "INGENIERO DE CALIDAD",
            "INGENIERO DE CAMPO",
            "INGENIERO DE PLANEAMIENTO",
            "INGENIERO DE PLANEAMIENTO Y COSTOS",
            "INGENIERO DE SSOMA",
            "INGENIERO RESIDENTE",
            "INGENIERO SSOMA",
            "INSTRUCTOR DE EQUIPOS",
            "JEFE DE CALIDAD - PROYECTO",
            "JEFE DE CAMPO",
            "JEFE DE EQUIPOS",
            "JEFE DE LABORATORIO",
            "JEFE DE OPERACIONES",
            "JEFE DE PLANEAMIENTO Y COSTOS",
            "JEFE DE SSOMA",
            "LLANTERO NIVEL 1",
            "LUBRICADOR NIVEL 1",
            "MECÁNICO NIVEL 1",
            "MECÁNICO NIVEL 1 _ OP ZARANDA",
            "MECÁNICO NIVEL 2",
            "MECÁNICO NIVEL 2 _ OP ZARANDA",
            "MECÁNICO NIVEL 3",
            "OFICIAL ALBAÑIL",
            "OFICIAL CARPINTERO",
            "OFICIAL DE LABORATORIO",
            "OFICIAL DE MOVIMIENTO DE TIERRAS",
            "OFICIAL DE TUBERÍA",
            "OFICIAL FIERRERO",
            "OPERADOR DE CAMIÓN BARANDA",
            "OPERADOR DE CARGADOR FRONTAL",
            "OPERADOR DE CARMIX",
            "OPERADOR DE CISTERNA DE AGUA",
            "OPERADOR DE EXCAVADORA",
            "OPERADOR DE MINICARGADOR",
            "OPERADOR DE MOTONIVELADORA",
            "OPERADOR DE RETROEXCAVADORA",
            "OPERADOR DE RODILLO",
            "OPERADOR DE TRACTOR",
            "OPERADOR DE VOLQUETE",
            "OPERADOR DE ZARANDA",
            "OPERARIO ALBAÑIL",
            "OPERARIO CARPINTERO",
            "OPERARIO CONCRETERO",
            "OPERARIO DE LABORATORIO",
            "OPERARIO FIERRERO",
            "OPERARIO MANIOBRISTA RIGGER",
            "OPERARIO MECÁNICO TERMOFUSIÓN",
            "OPERARIO MOVIMIENTO DE TIERRAS",
            "PEÓN",
            "PLANER DE EQUIPOS",
            "SOLDADOR NIVEL 1",
            "SUPERINTENDENTE DE OPERACIONES",
            "SUPERVISOR DE ALMACEN",
            "SUPERVISOR DE CALIDAD",
            "SUPERVISOR DE CAMPO",
            "SUPERVISOR DE EQUIPOS",
            "SUPERVISOR DE QC",
            "SUPERVISOR DE TUBERÍAS",
            "SUPERVISOR QC-HDPE",
            "TAREADOR",
            "TÉCNICO DE LABORATORIO",
            "TÉCNICO DE TERMOFUSIÓN",
            "TÉCNICO PROYECTISTA",
            "TÉCNICO QC",
            "TOPÓGRAFO",
            "TRABAJADORA SOCIAL",
            "TRADUCTOR TÉCNICO"});
            this.CBCargo.Location = new System.Drawing.Point(57, 49);
            this.CBCargo.MaxLength = 40;
            this.CBCargo.Name = "CBCargo";
            this.CBCargo.Size = new System.Drawing.Size(333, 24);
            this.CBCargo.TabIndex = 5;
            this.CBCargo.TextChanged += new System.EventHandler(this.CBCargo_TextChanged);
            // 
            // LCargo
            // 
            this.LCargo.AutoSize = true;
            this.LCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LCargo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LCargo.Location = new System.Drawing.Point(3, 52);
            this.LCargo.Name = "LCargo";
            this.LCargo.Size = new System.Drawing.Size(48, 16);
            this.LCargo.TabIndex = 4;
            this.LCargo.Text = "Cargo:";
            // 
            // CBArea
            // 
            this.CBArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBArea.FormattingEnabled = true;
            this.CBArea.Items.AddRange(new object[] {
            "",
            "ADMINISTRACIÓN",
            "ALMACEN",
            "CALIDAD",
            "EQUIPOS - MANTENIMIENTO DE PROYECTOS",
            "GERENCIA",
            "GESTIÓN HUMANA",
            "HDPE",
            "LOGÍSTICA",
            "OFICINA TÉCNICA",
            "OPERACIONES",
            "OPERACIONES - OBRAS CIVILES",
            "SSOMA",
            "TOPOGRAFÍA"});
            this.CBArea.Location = new System.Drawing.Point(192, 19);
            this.CBArea.MaxLength = 40;
            this.CBArea.Name = "CBArea";
            this.CBArea.Size = new System.Drawing.Size(333, 24);
            this.CBArea.TabIndex = 3;
            this.CBArea.TextChanged += new System.EventHandler(this.CBArea_TextChanged);
            // 
            // LArea
            // 
            this.LArea.AutoSize = true;
            this.LArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LArea.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LArea.Location = new System.Drawing.Point(76, 22);
            this.LArea.Name = "LArea";
            this.LArea.Size = new System.Drawing.Size(110, 16);
            this.LArea.TabIndex = 2;
            this.LArea.Text = "Area de Trabajo:";
            // 
            // ChBActivo
            // 
            this.ChBActivo.AutoSize = true;
            this.ChBActivo.Location = new System.Drawing.Point(6, 21);
            this.ChBActivo.Name = "ChBActivo";
            this.ChBActivo.Size = new System.Drawing.Size(64, 20);
            this.ChBActivo.TabIndex = 0;
            this.ChBActivo.Text = "Activo";
            this.ChBActivo.UseVisualStyleBackColor = true;
            this.ChBActivo.CheckedChanged += new System.EventHandler(this.ChBActivo_CheckedChanged);
            // 
            // TBNota
            // 
            this.TBNota.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBNota.Location = new System.Drawing.Point(815, 272);
            this.TBNota.MaxLength = 255;
            this.TBNota.Multiline = true;
            this.TBNota.Name = "TBNota";
            this.TBNota.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TBNota.Size = new System.Drawing.Size(200, 130);
            this.TBNota.TabIndex = 31;
            this.TBNota.TextChanged += new System.EventHandler(this.TBNota_TextChanged);
            // 
            // LNota
            // 
            this.LNota.AutoSize = true;
            this.LNota.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LNota.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LNota.Location = new System.Drawing.Point(812, 253);
            this.LNota.Name = "LNota";
            this.LNota.Size = new System.Drawing.Size(49, 16);
            this.LNota.TabIndex = 30;
            this.LNota.Text = "NOTA:";
            // 
            // CBCamaras
            // 
            this.CBCamaras.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBCamaras.FormattingEnabled = true;
            this.CBCamaras.Location = new System.Drawing.Point(812, 7);
            this.CBCamaras.MaxLength = 5;
            this.CBCamaras.Name = "CBCamaras";
            this.CBCamaras.Size = new System.Drawing.Size(203, 24);
            this.CBCamaras.TabIndex = 33;
            // 
            // BCamara
            // 
            this.BCamara.AutoSize = true;
            this.BCamara.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BCamara.ImageIndex = 12;
            this.BCamara.ImageList = this.ILPersonal;
            this.BCamara.Location = new System.Drawing.Point(812, 220);
            this.BCamara.Name = "BCamara";
            this.BCamara.Size = new System.Drawing.Size(203, 30);
            this.BCamara.TabIndex = 32;
            this.BCamara.UseVisualStyleBackColor = true;
            this.BCamara.Click += new System.EventHandler(this.BCamara_Click);
            // 
            // PBFoto
            // 
            this.PBFoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PBFoto.Image = global::LOGIntegral.Properties.Resources.fondo;
            this.PBFoto.Location = new System.Drawing.Point(812, 37);
            this.PBFoto.Name = "PBFoto";
            this.PBFoto.Size = new System.Drawing.Size(203, 147);
            this.PBFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBFoto.TabIndex = 29;
            this.PBFoto.TabStop = false;
            this.PBFoto.DoubleClick += new System.EventHandler(this.PBFoto_DoubleClick);
            // 
            // CBResolucion
            // 
            this.CBResolucion.Enabled = false;
            this.CBResolucion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBResolucion.FormattingEnabled = true;
            this.CBResolucion.Location = new System.Drawing.Point(812, 190);
            this.CBResolucion.Name = "CBResolucion";
            this.CBResolucion.Size = new System.Drawing.Size(203, 24);
            this.CBResolucion.TabIndex = 34;
            this.CBResolucion.SelectedIndexChanged += new System.EventHandler(this.CBResolucion_SelectedIndexChanged);
            // 
            // ErrPEditarPersonal
            // 
            this.ErrPEditarPersonal.ContainerControl = this;
            // 
            // FRMEditarPersonal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 450);
            this.Controls.Add(this.CBResolucion);
            this.Controls.Add(this.CBCamaras);
            this.Controls.Add(this.BCamara);
            this.Controls.Add(this.TBNota);
            this.Controls.Add(this.LNota);
            this.Controls.Add(this.PBFoto);
            this.Controls.Add(this.GBTrabajo);
            this.Controls.Add(this.GBTallas);
            this.Controls.Add(this.MTBCelular);
            this.Controls.Add(this.LCelular);
            this.Controls.Add(this.MTBTelefono);
            this.Controls.Add(this.LTelefono);
            this.Controls.Add(this.TBDireccion);
            this.Controls.Add(this.LDireccion);
            this.Controls.Add(this.RBMasculino);
            this.Controls.Add(this.RBFemenino);
            this.Controls.Add(this.LSexo);
            this.Controls.Add(this.LEdad);
            this.Controls.Add(this.DTPFechaNacimiento);
            this.Controls.Add(this.LFechaNacimiento);
            this.Controls.Add(this.TBSegundoApellido);
            this.Controls.Add(this.LSegundoApellido);
            this.Controls.Add(this.TBPrimerApellido);
            this.Controls.Add(this.LPrimerApellido);
            this.Controls.Add(this.TBSegundoNombre);
            this.Controls.Add(this.LSegundoNombre);
            this.Controls.Add(this.TBPrimerNombre);
            this.Controls.Add(this.LPrimerNombre);
            this.Controls.Add(this.TSEditarPersonal);
            this.Controls.Add(this.TBDocumento);
            this.Controls.Add(this.LDocumento);
            this.Controls.Add(this.CBTipoDocumento);
            this.Controls.Add(this.LTipoDocumento);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRMEditarPersonal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LOGIntegral - Registro de Personal";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FRMEditarPersonal_FormClosing);
            this.Load += new System.EventHandler(this.FRMEditarPersonal_Load);
            this.TSEditarPersonal.ResumeLayout(false);
            this.TSEditarPersonal.PerformLayout();
            this.GBTallas.ResumeLayout(false);
            this.GBTrabajo.ResumeLayout(false);
            this.GBTrabajo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBFoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrPEditarPersonal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LTipoDocumento;
        private System.Windows.Forms.ComboBox CBTipoDocumento;
        private System.Windows.Forms.Label LDocumento;
        private System.Windows.Forms.TextBox TBDocumento;
        private System.Windows.Forms.ToolStrip TSEditarPersonal;
        private System.Windows.Forms.ToolStripButton TSBSalir;
        private System.Windows.Forms.ToolStripButton TSBGuardar;
        private System.Windows.Forms.ToolStripButton TSBEliminar;
        private System.Windows.Forms.ToolStripButton TSBEditar;
        private System.Windows.Forms.ToolStripButton TSBNuevo;
        private System.Windows.Forms.Label LPrimerNombre;
        private System.Windows.Forms.TextBox TBPrimerNombre;
        private System.Windows.Forms.TextBox TBSegundoNombre;
        private System.Windows.Forms.Label LSegundoNombre;
        private System.Windows.Forms.Label LPrimerApellido;
        private System.Windows.Forms.TextBox TBSegundoApellido;
        private System.Windows.Forms.Label LSegundoApellido;
        private System.Windows.Forms.TextBox TBPrimerApellido;
        private System.Windows.Forms.Label LFechaNacimiento;
        private System.Windows.Forms.DateTimePicker DTPFechaNacimiento;
        private System.Windows.Forms.Label LEdad;
        private System.Windows.Forms.Label LSexo;
        private System.Windows.Forms.RadioButton RBFemenino;
        private System.Windows.Forms.RadioButton RBMasculino;
        private System.Windows.Forms.Label LDireccion;
        private System.Windows.Forms.TextBox TBDireccion;
        private System.Windows.Forms.Label LTelefono;
        private System.Windows.Forms.MaskedTextBox MTBTelefono;
        private System.Windows.Forms.Label LCelular;
        private System.Windows.Forms.MaskedTextBox MTBCelular;
        private System.Windows.Forms.GroupBox GBTallas;
        internal System.Windows.Forms.ImageList ILPersonal;
        private System.Windows.Forms.ComboBox CBCalzado;
        private System.Windows.Forms.Label LCalzado;
        private System.Windows.Forms.ComboBox CBPantalon;
        private System.Windows.Forms.ComboBox CBCasaca;
        private System.Windows.Forms.Label LPantalon;
        private System.Windows.Forms.Label LCasaca;
        private System.Windows.Forms.ComboBox CBCamisa;
        private System.Windows.Forms.Label LCamisa;
        private System.Windows.Forms.GroupBox GBTrabajo;
        private System.Windows.Forms.ComboBox CBArea;
        private System.Windows.Forms.Label LArea;
        private System.Windows.Forms.CheckBox ChBActivo;
        private System.Windows.Forms.ComboBox CBCategoria;
        private System.Windows.Forms.Label LCategoria;
        private System.Windows.Forms.ComboBox CBCargo;
        private System.Windows.Forms.Label LCargo;
        private System.Windows.Forms.CheckBox ChBHerramientas;
        private System.Windows.Forms.CheckBox ChBRadio;
        private System.Windows.Forms.CheckBox ChBCelular;
        private System.Windows.Forms.CheckBox ChBLaptop;
        private System.Windows.Forms.PictureBox PBFoto;
        private System.Windows.Forms.TextBox TBNota;
        private System.Windows.Forms.Label LNota;
        private System.Windows.Forms.Button BCamara;
        private System.Windows.Forms.ComboBox CBCamaras;
        private System.Windows.Forms.ComboBox CBResolucion;
        private System.Windows.Forms.ErrorProvider ErrPEditarPersonal;
    }
}