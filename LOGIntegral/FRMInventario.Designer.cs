namespace LOGIntegral
{
    partial class FRMInventario
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
            this.BInventario = new System.Windows.Forms.Button();
            this.LVInventario = new System.Windows.Forms.ListView();
            this.CHMaterial = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CHDescripcion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CHUMedida = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CHStock = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TBBuscar = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BInventario
            // 
            this.BInventario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BInventario.ForeColor = System.Drawing.SystemColors.WindowText;
            this.BInventario.Location = new System.Drawing.Point(12, 400);
            this.BInventario.Name = "BInventario";
            this.BInventario.Size = new System.Drawing.Size(1042, 58);
            this.BInventario.TabIndex = 1;
            this.BInventario.Text = "Cargar Inventario";
            this.BInventario.UseVisualStyleBackColor = true;
            this.BInventario.Click += new System.EventHandler(this.BInventario_Click);
            // 
            // LVInventario
            // 
            this.LVInventario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LVInventario.BackColor = System.Drawing.Color.LightGray;
            this.LVInventario.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.CHMaterial,
            this.CHDescripcion,
            this.CHUMedida,
            this.CHStock});
            this.LVInventario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LVInventario.GridLines = true;
            this.LVInventario.HideSelection = false;
            this.LVInventario.Location = new System.Drawing.Point(12, 48);
            this.LVInventario.Name = "LVInventario";
            this.LVInventario.Size = new System.Drawing.Size(1042, 346);
            this.LVInventario.TabIndex = 2;
            this.LVInventario.UseCompatibleStateImageBehavior = false;
            this.LVInventario.View = System.Windows.Forms.View.Details;
            // 
            // CHMaterial
            // 
            this.CHMaterial.Text = "Material";
            this.CHMaterial.Width = 180;
            // 
            // CHDescripcion
            // 
            this.CHDescripcion.Text = "Descripción";
            this.CHDescripcion.Width = 400;
            // 
            // CHUMedida
            // 
            this.CHUMedida.Text = "U. Medida";
            this.CHUMedida.Width = 130;
            // 
            // CHStock
            // 
            this.CHStock.Text = "Stock";
            this.CHStock.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.CHStock.Width = 120;
            // 
            // TBBuscar
            // 
            this.TBBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TBBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBBuscar.Location = new System.Drawing.Point(12, 12);
            this.TBBuscar.Name = "TBBuscar";
            this.TBBuscar.Size = new System.Drawing.Size(1042, 30);
            this.TBBuscar.TabIndex = 3;
            // 
            // FRMInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 467);
            this.Controls.Add(this.TBBuscar);
            this.Controls.Add(this.LVInventario);
            this.Controls.Add(this.BInventario);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FRMInventario";
            this.Text = "LOGIntegral - Inventario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BInventario;
        private System.Windows.Forms.ListView LVInventario;
        private System.Windows.Forms.ColumnHeader CHMaterial;
        private System.Windows.Forms.ColumnHeader CHDescripcion;
        private System.Windows.Forms.ColumnHeader CHUMedida;
        private System.Windows.Forms.ColumnHeader CHStock;
        private System.Windows.Forms.TextBox TBBuscar;
    }
}