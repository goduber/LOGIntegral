
namespace LOGIntegral
{
    partial class FRMPersonal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRMPersonal));
            this.TVPersonal = new System.Windows.Forms.TreeView();
            this.ILPersonal = new System.Windows.Forms.ImageList(this.components);
            this.LVPersonal = new System.Windows.Forms.ListView();
            this.CHNombreApellido = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CHTipoDocumento = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CHDocumento = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CHArea = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CHCargo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ILIPersonal = new System.Windows.Forms.ImageList(this.components);
            this.TB_buscar = new System.Windows.Forms.TextBox();
            this.LBuscar = new System.Windows.Forms.Label();
            this.TTPersonal = new System.Windows.Forms.ToolTip(this.components);
            this.BActualizar = new System.Windows.Forms.Button();
            this.BSalir = new System.Windows.Forms.Button();
            this.BEditar = new System.Windows.Forms.Button();
            this.BConsumo = new System.Windows.Forms.Button();
            this.PBFoto = new System.Windows.Forms.PictureBox();
            this.CHCategoria = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.PBFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // TVPersonal
            // 
            this.TVPersonal.BackColor = System.Drawing.Color.LightGray;
            this.TVPersonal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TVPersonal.ImageIndex = 0;
            this.TVPersonal.ImageList = this.ILPersonal;
            this.TVPersonal.Location = new System.Drawing.Point(604, 240);
            this.TVPersonal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TVPersonal.Name = "TVPersonal";
            this.TVPersonal.SelectedImageIndex = 0;
            this.TVPersonal.Size = new System.Drawing.Size(556, 256);
            this.TVPersonal.TabIndex = 5;
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
            // 
            // LVPersonal
            // 
            this.LVPersonal.BackColor = System.Drawing.Color.LightGray;
            this.LVPersonal.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.CHNombreApellido,
            this.CHTipoDocumento,
            this.CHDocumento,
            this.CHArea,
            this.CHCargo,
            this.CHCategoria});
            this.LVPersonal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LVPersonal.GridLines = true;
            this.LVPersonal.HideSelection = false;
            this.LVPersonal.Location = new System.Drawing.Point(12, 39);
            this.LVPersonal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.LVPersonal.MultiSelect = false;
            this.LVPersonal.Name = "LVPersonal";
            this.LVPersonal.Size = new System.Drawing.Size(1148, 197);
            this.LVPersonal.SmallImageList = this.ILPersonal;
            this.LVPersonal.TabIndex = 4;
            this.LVPersonal.UseCompatibleStateImageBehavior = false;
            this.LVPersonal.View = System.Windows.Forms.View.Details;
            this.LVPersonal.Click += new System.EventHandler(this.LVPersonal_Click);
            this.LVPersonal.DoubleClick += new System.EventHandler(this.LVPersonal_DoubleClick);
            // 
            // CHNombreApellido
            // 
            this.CHNombreApellido.Text = "Nombre y Apellido";
            this.CHNombreApellido.Width = 400;
            // 
            // CHTipoDocumento
            // 
            this.CHTipoDocumento.Text = "Tipo Documento";
            this.CHTipoDocumento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CHTipoDocumento.Width = 150;
            // 
            // CHDocumento
            // 
            this.CHDocumento.Text = "Documento";
            this.CHDocumento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CHDocumento.Width = 130;
            // 
            // CHArea
            // 
            this.CHArea.Text = "Area";
            this.CHArea.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CHArea.Width = 150;
            // 
            // CHCargo
            // 
            this.CHCargo.Text = "Cargo";
            this.CHCargo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CHCargo.Width = 250;
            // 
            // ILIPersonal
            // 
            this.ILIPersonal.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ILIPersonal.ImageStream")));
            this.ILIPersonal.TransparentColor = System.Drawing.Color.Transparent;
            this.ILIPersonal.Images.SetKeyName(0, "editar.png");
            this.ILIPersonal.Images.SetKeyName(1, "Salir2.png");
            this.ILIPersonal.Images.SetKeyName(2, "actualizar.png");
            // 
            // TB_buscar
            // 
            this.TB_buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_buscar.Location = new System.Drawing.Point(68, 6);
            this.TB_buscar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TB_buscar.Name = "TB_buscar";
            this.TB_buscar.Size = new System.Drawing.Size(518, 22);
            this.TB_buscar.TabIndex = 1;
            this.TB_buscar.Enter += new System.EventHandler(this.TB_buscar_Enter);
            this.TB_buscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_buscar_KeyPress);
            // 
            // LBuscar
            // 
            this.LBuscar.AutoSize = true;
            this.LBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBuscar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LBuscar.Location = new System.Drawing.Point(8, 9);
            this.LBuscar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LBuscar.Name = "LBuscar";
            this.LBuscar.Size = new System.Drawing.Size(52, 16);
            this.LBuscar.TabIndex = 0;
            this.LBuscar.Text = "Buscar:";
            // 
            // TTPersonal
            // 
            this.TTPersonal.AutoPopDelay = 5000;
            this.TTPersonal.InitialDelay = 300;
            this.TTPersonal.ReshowDelay = 100;
            // 
            // BActualizar
            // 
            this.BActualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BActualizar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BActualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BActualizar.ImageIndex = 2;
            this.BActualizar.ImageList = this.ILIPersonal;
            this.BActualizar.Location = new System.Drawing.Point(590, 2);
            this.BActualizar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BActualizar.Name = "BActualizar";
            this.BActualizar.Size = new System.Drawing.Size(97, 27);
            this.BActualizar.TabIndex = 2;
            this.BActualizar.Text = "Actualizar";
            this.BActualizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.TTPersonal.SetToolTip(this.BActualizar, "Agregar y Editar información del Personal");
            this.BActualizar.UseVisualStyleBackColor = false;
            this.BActualizar.Click += new System.EventHandler(this.BActualizar_Click);
            // 
            // BSalir
            // 
            this.BSalir.BackColor = System.Drawing.SystemColors.Control;
            this.BSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BSalir.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BSalir.ImageIndex = 1;
            this.BSalir.ImageList = this.ILIPersonal;
            this.BSalir.Location = new System.Drawing.Point(1036, 500);
            this.BSalir.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BSalir.Name = "BSalir";
            this.BSalir.Size = new System.Drawing.Size(124, 34);
            this.BSalir.TabIndex = 6;
            this.BSalir.Text = "Salir";
            this.TTPersonal.SetToolTip(this.BSalir, "Cerrar Ventana");
            this.BSalir.UseVisualStyleBackColor = false;
            this.BSalir.Click += new System.EventHandler(this.BSalir_Click);
            // 
            // BEditar
            // 
            this.BEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BEditar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BEditar.ImageIndex = 0;
            this.BEditar.ImageList = this.ILIPersonal;
            this.BEditar.Location = new System.Drawing.Point(1074, 2);
            this.BEditar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BEditar.Name = "BEditar";
            this.BEditar.Size = new System.Drawing.Size(86, 32);
            this.BEditar.TabIndex = 3;
            this.BEditar.Text = "Editar...";
            this.BEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.TTPersonal.SetToolTip(this.BEditar, "Agregar y Editar información del Personal");
            this.BEditar.UseVisualStyleBackColor = false;
            this.BEditar.Click += new System.EventHandler(this.BEditar_Click);
            // 
            // BConsumo
            // 
            this.BConsumo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BConsumo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BConsumo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BConsumo.ImageIndex = 10;
            this.BConsumo.ImageList = this.ILPersonal;
            this.BConsumo.Location = new System.Drawing.Point(963, 3);
            this.BConsumo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BConsumo.Name = "BConsumo";
            this.BConsumo.Size = new System.Drawing.Size(107, 32);
            this.BConsumo.TabIndex = 7;
            this.BConsumo.Text = "Consumo";
            this.BConsumo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.TTPersonal.SetToolTip(this.BConsumo, "Agregar y Editar información del Personal");
            this.BConsumo.UseVisualStyleBackColor = false;
            this.BConsumo.Click += new System.EventHandler(this.BConsumo_Click);
            // 
            // PBFoto
            // 
            this.PBFoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PBFoto.Image = global::LOGIntegral.Properties.Resources.fondo;
            this.PBFoto.Location = new System.Drawing.Point(126, 242);
            this.PBFoto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PBFoto.Name = "PBFoto";
            this.PBFoto.Size = new System.Drawing.Size(301, 169);
            this.PBFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBFoto.TabIndex = 6;
            this.PBFoto.TabStop = false;
            // 
            // CHCategoria
            // 
            this.CHCategoria.Text = "Categoria";
            // 
            // FRMPersonal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1171, 539);
            this.Controls.Add(this.BConsumo);
            this.Controls.Add(this.BActualizar);
            this.Controls.Add(this.PBFoto);
            this.Controls.Add(this.BSalir);
            this.Controls.Add(this.TVPersonal);
            this.Controls.Add(this.LVPersonal);
            this.Controls.Add(this.BEditar);
            this.Controls.Add(this.TB_buscar);
            this.Controls.Add(this.LBuscar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRMPersonal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "LOGIntegral - Personal";
            this.Activated += new System.EventHandler(this.FRMPersonal_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FRMPersonal_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.PBFoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.TreeView TVPersonal;
        internal System.Windows.Forms.ListView LVPersonal;
        internal System.Windows.Forms.ColumnHeader CHNombreApellido;
        internal System.Windows.Forms.ColumnHeader CHTipoDocumento;
        internal System.Windows.Forms.ColumnHeader CHDocumento;
        internal System.Windows.Forms.ColumnHeader CHArea;
        internal System.Windows.Forms.ColumnHeader CHCargo;
        internal System.Windows.Forms.Button BEditar;
        internal System.Windows.Forms.TextBox TB_buscar;
        internal System.Windows.Forms.Label LBuscar;
        internal System.Windows.Forms.Button BSalir;
        internal System.Windows.Forms.ImageList ILIPersonal;
        internal System.Windows.Forms.ImageList ILPersonal;
        private System.Windows.Forms.PictureBox PBFoto;
        private System.Windows.Forms.ToolTip TTPersonal;
        internal System.Windows.Forms.Button BActualizar;
        internal System.Windows.Forms.Button BConsumo;
        private System.Windows.Forms.ColumnHeader CHCategoria;
    }
}