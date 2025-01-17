
namespace LOGIntegral
{
    partial class FRMPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRMPrincipal));
            this.MSPrincipal = new System.Windows.Forms.MenuStrip();
            this.STMIArchivo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.TSPrincipal = new System.Windows.Forms.ToolStrip();
            this.SSPrincipal = new System.Windows.Forms.StatusStrip();
            this.TSSLMensaje = new System.Windows.Forms.ToolStripStatusLabel();
            this.TSPBCargar_Datos = new System.Windows.Forms.ToolStripProgressBar();
            this.TSSLItem = new System.Windows.Forms.ToolStripStatusLabel();
            this.TSSLUbicacion = new System.Windows.Forms.ToolStripStatusLabel();
            this.TTPrincipal = new System.Windows.Forms.ToolTip(this.components);
            this.TPrincipal = new System.Windows.Forms.Timer(this.components);
            this.TSSLInventario = new System.Windows.Forms.ToolStripStatusLabel();
            this.TSBPersonal = new System.Windows.Forms.ToolStripButton();
            this.TSBInventario = new System.Windows.Forms.ToolStripButton();
            this.TSMIConfiguracion = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMISalir = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.MSPrincipal.SuspendLayout();
            this.TSPrincipal.SuspendLayout();
            this.SSPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // MSPrincipal
            // 
            this.MSPrincipal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MSPrincipal.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.MSPrincipal.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.MSPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.STMIArchivo});
            this.MSPrincipal.Location = new System.Drawing.Point(0, 0);
            this.MSPrincipal.Name = "MSPrincipal";
            this.MSPrincipal.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.MSPrincipal.Size = new System.Drawing.Size(1423, 36);
            this.MSPrincipal.TabIndex = 1;
            this.MSPrincipal.Text = "menuStrip1";
            // 
            // STMIArchivo
            // 
            this.STMIArchivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.TSMIConfiguracion,
            this.toolStripSeparator2,
            this.TSMISalir});
            this.STMIArchivo.Name = "STMIArchivo";
            this.STMIArchivo.Size = new System.Drawing.Size(94, 29);
            this.STMIArchivo.Text = "&Archivo";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(240, 6);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(240, 6);
            // 
            // TSPrincipal
            // 
            this.TSPrincipal.ImageScalingSize = new System.Drawing.Size(48, 48);
            this.TSPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSBPersonal,
            this.TSBInventario,
            this.toolStripButton1});
            this.TSPrincipal.Location = new System.Drawing.Point(0, 36);
            this.TSPrincipal.Name = "TSPrincipal";
            this.TSPrincipal.Size = new System.Drawing.Size(1423, 57);
            this.TSPrincipal.TabIndex = 2;
            this.TSPrincipal.Text = "Principal";
            // 
            // SSPrincipal
            // 
            this.SSPrincipal.AutoSize = false;
            this.SSPrincipal.BackColor = System.Drawing.SystemColors.Control;
            this.SSPrincipal.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.SSPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSSLMensaje,
            this.TSPBCargar_Datos,
            this.TSSLInventario,
            this.TSSLItem,
            this.TSSLUbicacion});
            this.SSPrincipal.Location = new System.Drawing.Point(0, 704);
            this.SSPrincipal.Name = "SSPrincipal";
            this.SSPrincipal.Padding = new System.Windows.Forms.Padding(2, 0, 19, 0);
            this.SSPrincipal.Size = new System.Drawing.Size(1423, 32);
            this.SSPrincipal.TabIndex = 3;
            // 
            // TSSLMensaje
            // 
            this.TSSLMensaje.AutoSize = false;
            this.TSSLMensaje.BackColor = System.Drawing.SystemColors.Control;
            this.TSSLMensaje.BorderStyle = System.Windows.Forms.Border3DStyle.RaisedOuter;
            this.TSSLMensaje.ForeColor = System.Drawing.SystemColors.WindowText;
            this.TSSLMensaje.Name = "TSSLMensaje";
            this.TSSLMensaje.Size = new System.Drawing.Size(600, 25);
            this.TSSLMensaje.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TSSLMensaje.ToolTipText = "Mensajes del Sistema";
            // 
            // TSPBCargar_Datos
            // 
            this.TSPBCargar_Datos.AutoSize = false;
            this.TSPBCargar_Datos.Name = "TSPBCargar_Datos";
            this.TSPBCargar_Datos.Size = new System.Drawing.Size(100, 24);
            this.TSPBCargar_Datos.ToolTipText = "% de Carga";
            // 
            // TSSLItem
            // 
            this.TSSLItem.AutoSize = false;
            this.TSSLItem.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.TSSLItem.ForeColor = System.Drawing.SystemColors.WindowText;
            this.TSSLItem.Name = "TSSLItem";
            this.TSSLItem.Size = new System.Drawing.Size(100, 25);
            this.TSSLItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.TSSLItem.ToolTipText = "Cantidad de Items Registrados";
            // 
            // TSSLUbicacion
            // 
            this.TSSLUbicacion.AutoSize = false;
            this.TSSLUbicacion.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.TSSLUbicacion.ForeColor = System.Drawing.SystemColors.WindowText;
            this.TSSLUbicacion.Name = "TSSLUbicacion";
            this.TSSLUbicacion.Size = new System.Drawing.Size(100, 25);
            this.TSSLUbicacion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.TSSLUbicacion.ToolTipText = "% de Items con Ubicación";
            // 
            // TTPrincipal
            // 
            this.TTPrincipal.AutoPopDelay = 3000;
            this.TTPrincipal.InitialDelay = 500;
            this.TTPrincipal.ReshowDelay = 100;
            this.TTPrincipal.ShowAlways = true;
            // 
            // TPrincipal
            // 
            this.TPrincipal.Interval = 1500;
            this.TPrincipal.Tick += new System.EventHandler(this.TPrincipal_Tick);
            // 
            // TSSLInventario
            // 
            this.TSSLInventario.AutoSize = false;
            this.TSSLInventario.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.TSSLInventario.ForeColor = System.Drawing.SystemColors.WindowText;
            this.TSSLInventario.Image = ((System.Drawing.Image)(resources.GetObject("TSSLInventario.Image")));
            this.TSSLInventario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TSSLInventario.Name = "TSSLInventario";
            this.TSSLInventario.Size = new System.Drawing.Size(150, 25);
            this.TSSLInventario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.TSSLInventario.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.TSSLInventario.ToolTipText = "Valor del Inventario";
            this.TSSLInventario.Click += new System.EventHandler(this.TSSLInventario_Click);
            // 
            // TSBPersonal
            // 
            this.TSBPersonal.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSBPersonal.Image = ((System.Drawing.Image)(resources.GetObject("TSBPersonal.Image")));
            this.TSBPersonal.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSBPersonal.Name = "TSBPersonal";
            this.TSBPersonal.Size = new System.Drawing.Size(52, 52);
            this.TSBPersonal.Text = "Personal";
            this.TSBPersonal.ToolTipText = "Personal";
            this.TSBPersonal.Click += new System.EventHandler(this.TSBPersonal_Click);
            // 
            // TSBInventario
            // 
            this.TSBInventario.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSBInventario.Image = ((System.Drawing.Image)(resources.GetObject("TSBInventario.Image")));
            this.TSBInventario.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSBInventario.Name = "TSBInventario";
            this.TSBInventario.Size = new System.Drawing.Size(52, 52);
            this.TSBInventario.Text = "Inventario";
            this.TSBInventario.ToolTipText = "Inventario al día";
            this.TSBInventario.Click += new System.EventHandler(this.TSBInventario_Click);
            // 
            // TSMIConfiguracion
            // 
            this.TSMIConfiguracion.Image = ((System.Drawing.Image)(resources.GetObject("TSMIConfiguracion.Image")));
            this.TSMIConfiguracion.Name = "TSMIConfiguracion";
            this.TSMIConfiguracion.Size = new System.Drawing.Size(243, 42);
            this.TSMIConfiguracion.Text = "&Configuración";
            this.TSMIConfiguracion.Click += new System.EventHandler(this.TSMIConfiguracion_Click);
            // 
            // TSMISalir
            // 
            this.TSMISalir.Image = ((System.Drawing.Image)(resources.GetObject("TSMISalir.Image")));
            this.TSMISalir.Name = "TSMISalir";
            this.TSMISalir.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.TSMISalir.Size = new System.Drawing.Size(243, 42);
            this.TSMISalir.Text = "&Salir";
            this.TSMISalir.Click += new System.EventHandler(this.TSMISalir_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::LOGIntegral.Properties.Resources.dashboard;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(52, 52);
            this.toolStripButton1.Text = "Dashboard";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // FRMPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1423, 736);
            this.Controls.Add(this.SSPrincipal);
            this.Controls.Add(this.TSPrincipal);
            this.Controls.Add(this.MSPrincipal);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.MSPrincipal;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FRMPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LOGIntegral - Menú Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FRMPrincipal_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FRMPrincipal_FormClosed);
            this.Load += new System.EventHandler(this.FRMPrincipal_Load);
            this.MSPrincipal.ResumeLayout(false);
            this.MSPrincipal.PerformLayout();
            this.TSPrincipal.ResumeLayout(false);
            this.TSPrincipal.PerformLayout();
            this.SSPrincipal.ResumeLayout(false);
            this.SSPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip MSPrincipal;
        private System.Windows.Forms.ToolStripMenuItem STMIArchivo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem TSMIConfiguracion;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem TSMISalir;
        private System.Windows.Forms.ToolStrip TSPrincipal;
        private System.Windows.Forms.StatusStrip SSPrincipal;
        private System.Windows.Forms.ToolStripButton TSBPersonal;
        private System.Windows.Forms.ToolStripButton TSBInventario;
        private System.Windows.Forms.ToolTip TTPrincipal;
        public System.Windows.Forms.ToolStripStatusLabel TSSLMensaje;
        public System.Windows.Forms.ToolStripProgressBar TSPBCargar_Datos;
        public System.Windows.Forms.ToolStripStatusLabel TSSLInventario;
        public System.Windows.Forms.ToolStripStatusLabel TSSLItem;
        public System.Windows.Forms.ToolStripStatusLabel TSSLUbicacion;
        private System.Windows.Forms.Timer TPrincipal;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}