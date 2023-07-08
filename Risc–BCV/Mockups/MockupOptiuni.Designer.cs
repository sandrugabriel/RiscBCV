namespace Risc_BCV.Mockups
{
    partial class MockupOptiuni
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabGrafic = new System.Windows.Forms.TabPage();
            this.lblTitlu = new System.Windows.Forms.Label();
            this.comboPacienti = new System.Windows.Forms.ComboBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabControl.SuspendLayout();
            this.tabGrafic.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabGrafic);
            this.tabControl.Location = new System.Drawing.Point(-1, 26);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1371, 684);
            this.tabControl.TabIndex = 0;
            // 
            // tabGrafic
            // 
            this.tabGrafic.Controls.Add(this.chart1);
            this.tabGrafic.Controls.Add(this.comboPacienti);
            this.tabGrafic.Controls.Add(this.lblTitlu);
            this.tabGrafic.ForeColor = System.Drawing.SystemColors.Control;
            this.tabGrafic.Location = new System.Drawing.Point(4, 39);
            this.tabGrafic.Name = "tabGrafic";
            this.tabGrafic.Padding = new System.Windows.Forms.Padding(3);
            this.tabGrafic.Size = new System.Drawing.Size(1363, 641);
            this.tabGrafic.TabIndex = 1;
            this.tabGrafic.Text = "Grafic";
            this.tabGrafic.UseVisualStyleBackColor = true;
            // 
            // lblTitlu
            // 
            this.lblTitlu.AutoSize = true;
            this.lblTitlu.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 17.8F);
            this.lblTitlu.Location = new System.Drawing.Point(150, 49);
            this.lblTitlu.Name = "lblTitlu";
            this.lblTitlu.Size = new System.Drawing.Size(122, 39);
            this.lblTitlu.TabIndex = 0;
            this.lblTitlu.Text = "Pacienti";
            // 
            // comboPacienti
            // 
            this.comboPacienti.FormattingEnabled = true;
            this.comboPacienti.Location = new System.Drawing.Point(94, 112);
            this.comboPacienti.Name = "comboPacienti";
            this.comboPacienti.Size = new System.Drawing.Size(223, 38);
            this.comboPacienti.TabIndex = 1;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(446, 70);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(812, 525);
            this.chart1.TabIndex = 2;
            this.chart1.Text = "chart1";
            // 
            // MockupOptiuni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1366, 705);
            this.Controls.Add(this.tabControl);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "MockupOptiuni";
            this.Text = "MockupStart";
            this.tabControl.ResumeLayout(false);
            this.tabGrafic.ResumeLayout(false);
            this.tabGrafic.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabGrafic;
        private System.Windows.Forms.Label lblTitlu;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.ComboBox comboPacienti;
    }
}