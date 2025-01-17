namespace LOGIntegral
{
    partial class FRMDashboard
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRMDashboard));
            this.CHInventario = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.PUbicacion = new System.Windows.Forms.Panel();
            this.CPBUbicacion = new CircularProgressBar.CircularProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.PInventario = new System.Windows.Forms.Panel();
            this.PValorSoles = new System.Windows.Forms.Panel();
            this.LValorSoles = new System.Windows.Forms.Label();
            this.LTextoSoles = new System.Windows.Forms.Label();
            this.PBSol = new System.Windows.Forms.PictureBox();
            this.PValorDolares = new System.Windows.Forms.Panel();
            this.LValorDolares = new System.Windows.Forms.Label();
            this.LTextoDolares = new System.Windows.Forms.Label();
            this.PBDolares = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LTransito = new System.Windows.Forms.Label();
            this.LTextoTransito = new System.Windows.Forms.Label();
            this.PBTransito = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.CHInventario)).BeginInit();
            this.PUbicacion.SuspendLayout();
            this.PInventario.SuspendLayout();
            this.PValorSoles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBSol)).BeginInit();
            this.PValorDolares.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBDolares)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBTransito)).BeginInit();
            this.SuspendLayout();
            // 
            // CHInventario
            // 
            this.CHInventario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CHInventario.BackColor = System.Drawing.SystemColors.Control;
            this.CHInventario.BorderSkin.BorderWidth = 3;
            chartArea1.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea1.AxisX.IsLabelAutoFit = false;
            chartArea1.AxisX.LabelStyle.Angle = 90;
            chartArea1.AxisX.LabelStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.AxisX.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.AxisY.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea1.BackColor = System.Drawing.SystemColors.Control;
            chartArea1.Name = "ChartArea1";
            this.CHInventario.ChartAreas.Add(chartArea1);
            legend1.Alignment = System.Drawing.StringAlignment.Center;
            legend1.Enabled = false;
            legend1.LegendStyle = System.Windows.Forms.DataVisualization.Charting.LegendStyle.Column;
            legend1.Name = "Legend1";
            this.CHInventario.Legends.Add(legend1);
            this.CHInventario.Location = new System.Drawing.Point(0, 0);
            this.CHInventario.Margin = new System.Windows.Forms.Padding(2);
            this.CHInventario.Name = "CHInventario";
            this.CHInventario.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series1.ChartArea = "ChartArea1";
            series1.CustomProperties = "LabelStyle=Bottom, DrawingStyle=Emboss";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.CHInventario.Series.Add(series1);
            this.CHInventario.Size = new System.Drawing.Size(711, 397);
            this.CHInventario.TabIndex = 1;
            this.CHInventario.Text = "chart1";
            title1.BackColor = System.Drawing.Color.Transparent;
            title1.BorderColor = System.Drawing.Color.Black;
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.Name = "Title1";
            title1.ShadowOffset = 5;
            title1.Text = "Inventario Valorizado";
            this.CHInventario.Titles.Add(title1);
            // 
            // PUbicacion
            // 
            this.PUbicacion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PUbicacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PUbicacion.Controls.Add(this.CPBUbicacion);
            this.PUbicacion.Controls.Add(this.label1);
            this.PUbicacion.Location = new System.Drawing.Point(715, 0);
            this.PUbicacion.Margin = new System.Windows.Forms.Padding(2);
            this.PUbicacion.Name = "PUbicacion";
            this.PUbicacion.Size = new System.Drawing.Size(237, 402);
            this.PUbicacion.TabIndex = 3;
            // 
            // CPBUbicacion
            // 
            this.CPBUbicacion.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.CPBUbicacion.AnimationSpeed = 500;
            this.CPBUbicacion.BackColor = System.Drawing.Color.Transparent;
            this.CPBUbicacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold);
            this.CPBUbicacion.ForeColor = System.Drawing.SystemColors.MenuText;
            this.CPBUbicacion.InnerColor = System.Drawing.SystemColors.Control;
            this.CPBUbicacion.InnerMargin = 2;
            this.CPBUbicacion.InnerWidth = -1;
            this.CPBUbicacion.Location = new System.Drawing.Point(2, 2);
            this.CPBUbicacion.Margin = new System.Windows.Forms.Padding(2);
            this.CPBUbicacion.MarqueeAnimationSpeed = 2000;
            this.CPBUbicacion.Name = "CPBUbicacion";
            this.CPBUbicacion.OuterColor = System.Drawing.SystemColors.Control;
            this.CPBUbicacion.OuterMargin = -25;
            this.CPBUbicacion.OuterWidth = 26;
            this.CPBUbicacion.ProgressColor = System.Drawing.Color.DarkGreen;
            this.CPBUbicacion.ProgressWidth = 16;
            this.CPBUbicacion.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.CPBUbicacion.Size = new System.Drawing.Size(231, 220);
            this.CPBUbicacion.StartAngle = 270;
            this.CPBUbicacion.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.CPBUbicacion.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.CPBUbicacion.SubscriptText = "";
            this.CPBUbicacion.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.CPBUbicacion.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.CPBUbicacion.SuperscriptText = "";
            this.CPBUbicacion.TabIndex = 4;
            this.CPBUbicacion.Text = "XXX%";
            this.CPBUbicacion.TextMargin = new System.Windows.Forms.Padding(5, 8, 0, 0);
            this.CPBUbicacion.Value = 68;
            // 
            // label1
            // 
            this.label1.AutoEllipsis = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label1.Location = new System.Drawing.Point(11, 316);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 43);
            this.label1.TabIndex = 3;
            this.label1.Text = "% de Cumplimiento de Ubicaciones";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PInventario
            // 
            this.PInventario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PInventario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PInventario.Controls.Add(this.CHInventario);
            this.PInventario.Location = new System.Drawing.Point(0, 0);
            this.PInventario.Margin = new System.Windows.Forms.Padding(2);
            this.PInventario.Name = "PInventario";
            this.PInventario.Size = new System.Drawing.Size(712, 402);
            this.PInventario.TabIndex = 4;
            // 
            // PValorSoles
            // 
            this.PValorSoles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PValorSoles.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PValorSoles.Controls.Add(this.LValorSoles);
            this.PValorSoles.Controls.Add(this.LTextoSoles);
            this.PValorSoles.Controls.Add(this.PBSol);
            this.PValorSoles.Location = new System.Drawing.Point(955, 1);
            this.PValorSoles.Margin = new System.Windows.Forms.Padding(2);
            this.PValorSoles.Name = "PValorSoles";
            this.PValorSoles.Size = new System.Drawing.Size(273, 90);
            this.PValorSoles.TabIndex = 5;
            // 
            // LValorSoles
            // 
            this.LValorSoles.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LValorSoles.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LValorSoles.ForeColor = System.Drawing.Color.DarkGreen;
            this.LValorSoles.Location = new System.Drawing.Point(0, 49);
            this.LValorSoles.Name = "LValorSoles";
            this.LValorSoles.Size = new System.Drawing.Size(191, 22);
            this.LValorSoles.TabIndex = 8;
            this.LValorSoles.Text = "99,999,999.99";
            this.LValorSoles.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LTextoSoles
            // 
            this.LTextoSoles.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LTextoSoles.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTextoSoles.ForeColor = System.Drawing.SystemColors.MenuText;
            this.LTextoSoles.Location = new System.Drawing.Point(2, 7);
            this.LTextoSoles.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LTextoSoles.Name = "LTextoSoles";
            this.LTextoSoles.Size = new System.Drawing.Size(187, 28);
            this.LTextoSoles.TabIndex = 7;
            this.LTextoSoles.Text = "Valor del Inventario  en Soles";
            this.LTextoSoles.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PBSol
            // 
            this.PBSol.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PBSol.Image = global::LOGIntegral.Properties.Resources.sol;
            this.PBSol.Location = new System.Drawing.Point(196, 7);
            this.PBSol.Margin = new System.Windows.Forms.Padding(2);
            this.PBSol.Name = "PBSol";
            this.PBSol.Size = new System.Drawing.Size(67, 73);
            this.PBSol.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBSol.TabIndex = 0;
            this.PBSol.TabStop = false;
            // 
            // PValorDolares
            // 
            this.PValorDolares.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PValorDolares.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PValorDolares.Controls.Add(this.LValorDolares);
            this.PValorDolares.Controls.Add(this.LTextoDolares);
            this.PValorDolares.Controls.Add(this.PBDolares);
            this.PValorDolares.Location = new System.Drawing.Point(955, 94);
            this.PValorDolares.Margin = new System.Windows.Forms.Padding(2);
            this.PValorDolares.Name = "PValorDolares";
            this.PValorDolares.Size = new System.Drawing.Size(273, 90);
            this.PValorDolares.TabIndex = 5;
            // 
            // LValorDolares
            // 
            this.LValorDolares.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LValorDolares.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LValorDolares.ForeColor = System.Drawing.Color.DarkGreen;
            this.LValorDolares.Location = new System.Drawing.Point(0, 49);
            this.LValorDolares.Name = "LValorDolares";
            this.LValorDolares.Size = new System.Drawing.Size(191, 22);
            this.LValorDolares.TabIndex = 8;
            this.LValorDolares.Text = "99,999,999.99";
            this.LValorDolares.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LTextoDolares
            // 
            this.LTextoDolares.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LTextoDolares.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTextoDolares.ForeColor = System.Drawing.SystemColors.MenuText;
            this.LTextoDolares.Location = new System.Drawing.Point(2, 7);
            this.LTextoDolares.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LTextoDolares.Name = "LTextoDolares";
            this.LTextoDolares.Size = new System.Drawing.Size(187, 28);
            this.LTextoDolares.TabIndex = 7;
            this.LTextoDolares.Text = "Valor del Inventario  en Soles";
            this.LTextoDolares.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PBDolares
            // 
            this.PBDolares.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PBDolares.Image = global::LOGIntegral.Properties.Resources.dollars;
            this.PBDolares.Location = new System.Drawing.Point(196, 7);
            this.PBDolares.Margin = new System.Windows.Forms.Padding(2);
            this.PBDolares.Name = "PBDolares";
            this.PBDolares.Size = new System.Drawing.Size(67, 73);
            this.PBDolares.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBDolares.TabIndex = 0;
            this.PBDolares.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.LTransito);
            this.panel1.Controls.Add(this.LTextoTransito);
            this.panel1.Controls.Add(this.PBTransito);
            this.panel1.Location = new System.Drawing.Point(955, 188);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(273, 90);
            this.panel1.TabIndex = 5;
            // 
            // LTransito
            // 
            this.LTransito.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LTransito.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTransito.ForeColor = System.Drawing.Color.DarkGreen;
            this.LTransito.Location = new System.Drawing.Point(0, 49);
            this.LTransito.Name = "LTransito";
            this.LTransito.Size = new System.Drawing.Size(191, 22);
            this.LTransito.TabIndex = 8;
            this.LTransito.Text = "99,999,999.99";
            this.LTransito.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LTextoTransito
            // 
            this.LTextoTransito.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LTextoTransito.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTextoTransito.ForeColor = System.Drawing.SystemColors.MenuText;
            this.LTextoTransito.Location = new System.Drawing.Point(2, 7);
            this.LTextoTransito.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LTextoTransito.Name = "LTextoTransito";
            this.LTextoTransito.Size = new System.Drawing.Size(187, 28);
            this.LTextoTransito.TabIndex = 7;
            this.LTextoTransito.Text = "Número de Ítems en Transito";
            this.LTextoTransito.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PBTransito
            // 
            this.PBTransito.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PBTransito.Image = global::LOGIntegral.Properties.Resources.cajas;
            this.PBTransito.Location = new System.Drawing.Point(196, 7);
            this.PBTransito.Margin = new System.Windows.Forms.Padding(2);
            this.PBTransito.Name = "PBTransito";
            this.PBTransito.Size = new System.Drawing.Size(67, 73);
            this.PBTransito.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBTransito.TabIndex = 0;
            this.PBTransito.TabStop = false;
            // 
            // FRMDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1231, 443);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PValorDolares);
            this.Controls.Add(this.PValorSoles);
            this.Controls.Add(this.PInventario);
            this.Controls.Add(this.PUbicacion);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRMDashboard";
            this.ShowIcon = false;
            this.Text = "Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.FRMDashboard_Activated);
            this.Load += new System.EventHandler(this.FRMDashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CHInventario)).EndInit();
            this.PUbicacion.ResumeLayout(false);
            this.PInventario.ResumeLayout(false);
            this.PValorSoles.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PBSol)).EndInit();
            this.PValorDolares.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PBDolares)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PBTransito)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart CHInventario;
        private System.Windows.Forms.Panel PUbicacion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel PInventario;
        private CircularProgressBar.CircularProgressBar CPBUbicacion;
        private System.Windows.Forms.Panel PValorSoles;
        private System.Windows.Forms.PictureBox PBSol;
        private System.Windows.Forms.Label LTextoSoles;
        private System.Windows.Forms.Label LValorSoles;
        private System.Windows.Forms.Panel PValorDolares;
        private System.Windows.Forms.Label LValorDolares;
        private System.Windows.Forms.Label LTextoDolares;
        private System.Windows.Forms.PictureBox PBDolares;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LTransito;
        private System.Windows.Forms.Label LTextoTransito;
        private System.Windows.Forms.PictureBox PBTransito;
    }
}