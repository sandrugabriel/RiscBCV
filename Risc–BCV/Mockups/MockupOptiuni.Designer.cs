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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabAdd = new System.Windows.Forms.TabPage();
            this.tabGestionare = new System.Windows.Forms.TabPage();
            this.tabGrafic = new System.Windows.Forms.TabPage();
            this.tabIesire = new System.Windows.Forms.TabPage();
            this.tabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabAdd);
            this.tabControl.Controls.Add(this.tabGestionare);
            this.tabControl.Controls.Add(this.tabGrafic);
            this.tabControl.Controls.Add(this.tabIesire);
            this.tabControl.Location = new System.Drawing.Point(-1, 26);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1371, 684);
            this.tabControl.TabIndex = 0;
            // 
            // tabAdd
            // 
            this.tabAdd.BackColor = System.Drawing.Color.Transparent;
            this.tabAdd.ForeColor = System.Drawing.SystemColors.Control;
            this.tabAdd.Location = new System.Drawing.Point(4, 39);
            this.tabAdd.Name = "tabAdd";
            this.tabAdd.Padding = new System.Windows.Forms.Padding(3);
            this.tabAdd.Size = new System.Drawing.Size(1363, 641);
            this.tabAdd.TabIndex = 0;
            this.tabAdd.Text = "Adaugare Pacient";
            this.tabAdd.UseVisualStyleBackColor = true;
            // 
            // tabGestionare
            // 
            this.tabGestionare.ForeColor = System.Drawing.SystemColors.Control;
            this.tabGestionare.Location = new System.Drawing.Point(4, 39);
            this.tabGestionare.Name = "tabGestionare";
            this.tabGestionare.Padding = new System.Windows.Forms.Padding(3);
            this.tabGestionare.Size = new System.Drawing.Size(1345, 636);
            this.tabGestionare.TabIndex = 1;
            this.tabGestionare.Text = "Gestionare fise pacienti";
            this.tabGestionare.UseVisualStyleBackColor = true;
            // 
            // tabGrafic
            // 
            this.tabGrafic.ForeColor = System.Drawing.SystemColors.Control;
            this.tabGrafic.Location = new System.Drawing.Point(4, 39);
            this.tabGrafic.Name = "tabGrafic";
            this.tabGrafic.Size = new System.Drawing.Size(1345, 636);
            this.tabGrafic.TabIndex = 2;
            this.tabGrafic.Text = "Grafic interpretare analize pacient";
            this.tabGrafic.UseVisualStyleBackColor = true;
            // 
            // tabIesire
            // 
            this.tabIesire.ForeColor = System.Drawing.SystemColors.Control;
            this.tabIesire.Location = new System.Drawing.Point(4, 39);
            this.tabIesire.Name = "tabIesire";
            this.tabIesire.Size = new System.Drawing.Size(1345, 636);
            this.tabIesire.TabIndex = 3;
            this.tabIesire.Text = "Iesire";
            this.tabIesire.UseVisualStyleBackColor = true;
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabAdd;
        private System.Windows.Forms.TabPage tabGestionare;
        private System.Windows.Forms.TabPage tabGrafic;
        private System.Windows.Forms.TabPage tabIesire;
    }
}