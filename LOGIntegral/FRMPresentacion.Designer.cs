
namespace LOGIntegral
{
    partial class FRMPresentacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRMPresentacion));
            this.PBarPresentacion = new System.Windows.Forms.ProgressBar();
            this.TInicio = new System.Windows.Forms.Timer(this.components);
            this.TPresentacion = new System.Windows.Forms.Timer(this.components);
            this.PBoxPresentacion = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PBoxPresentacion)).BeginInit();
            this.SuspendLayout();
            // 
            // PBarPresentacion
            // 
            this.PBarPresentacion.Location = new System.Drawing.Point(12, 67);
            this.PBarPresentacion.Name = "PBarPresentacion";
            this.PBarPresentacion.Size = new System.Drawing.Size(434, 10);
            this.PBarPresentacion.TabIndex = 1;
            // 
            // TInicio
            // 
            this.TInicio.Interval = 150;
            this.TInicio.Tick += new System.EventHandler(this.TInicio_Tick);
            // 
            // TPresentacion
            // 
            this.TPresentacion.Interval = 350;
            this.TPresentacion.Tick += new System.EventHandler(this.TPresentacion_Tick);
            // 
            // PBoxPresentacion
            // 
            this.PBoxPresentacion.Image = global::LOGIntegral.Properties.Resources.Lentro_LOGIntegral_Sin_Forndo;
            this.PBoxPresentacion.Location = new System.Drawing.Point(12, 12);
            this.PBoxPresentacion.Name = "PBoxPresentacion";
            this.PBoxPresentacion.Size = new System.Drawing.Size(434, 47);
            this.PBoxPresentacion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PBoxPresentacion.TabIndex = 0;
            this.PBoxPresentacion.TabStop = false;
            // 
            // FRMPresentacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 83);
            this.Controls.Add(this.PBarPresentacion);
            this.Controls.Add(this.PBoxPresentacion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FRMPresentacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Presentacion";
            this.Load += new System.EventHandler(this.FRMPresentacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PBoxPresentacion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PBoxPresentacion;
        private System.Windows.Forms.ProgressBar PBarPresentacion;
        private System.Windows.Forms.Timer TInicio;
        private System.Windows.Forms.Timer TPresentacion;
    }
}