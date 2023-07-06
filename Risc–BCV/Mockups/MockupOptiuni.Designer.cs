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
            this.dataNasteri = new System.Windows.Forms.MonthCalendar();
            this.lblData = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtPrenume = new System.Windows.Forms.TextBox();
            this.lblPrenume = new System.Windows.Forms.Label();
            this.txtNumele = new System.Windows.Forms.TextBox();
            this.lblNumele = new System.Windows.Forms.Label();
            this.tabGestionare = new System.Windows.Forms.TabPage();
            this.tabGrafic = new System.Windows.Forms.TabPage();
            this.tabIesire = new System.Windows.Forms.TabPage();
            this.lblGenul = new System.Windows.Forms.Label();
            this.radioBarbat = new System.Windows.Forms.RadioButton();
            this.radioFemeie = new System.Windows.Forms.RadioButton();
            this.btnSalvare = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.tabAdd.SuspendLayout();
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
            this.tabAdd.Controls.Add(this.btnSalvare);
            this.tabAdd.Controls.Add(this.radioFemeie);
            this.tabAdd.Controls.Add(this.radioBarbat);
            this.tabAdd.Controls.Add(this.lblGenul);
            this.tabAdd.Controls.Add(this.dataNasteri);
            this.tabAdd.Controls.Add(this.lblData);
            this.tabAdd.Controls.Add(this.txtEmail);
            this.tabAdd.Controls.Add(this.lblEmail);
            this.tabAdd.Controls.Add(this.txtPrenume);
            this.tabAdd.Controls.Add(this.lblPrenume);
            this.tabAdd.Controls.Add(this.txtNumele);
            this.tabAdd.Controls.Add(this.lblNumele);
            this.tabAdd.ForeColor = System.Drawing.SystemColors.Control;
            this.tabAdd.Location = new System.Drawing.Point(4, 39);
            this.tabAdd.Name = "tabAdd";
            this.tabAdd.Padding = new System.Windows.Forms.Padding(3);
            this.tabAdd.Size = new System.Drawing.Size(1363, 641);
            this.tabAdd.TabIndex = 0;
            this.tabAdd.Text = "Adaugare Pacient";
            this.tabAdd.UseVisualStyleBackColor = true;
            // 
            // dataNasteri
            // 
            this.dataNasteri.Location = new System.Drawing.Point(91, 305);
            this.dataNasteri.Name = "dataNasteri";
            this.dataNasteri.TabIndex = 8;
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(86, 266);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(141, 30);
            this.lblData.TabIndex = 7;
            this.lblData.Text = "Data Nasteri";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(971, 119);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(301, 38);
            this.txtEmail.TabIndex = 6;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(966, 73);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(67, 30);
            this.lblEmail.TabIndex = 5;
            this.lblEmail.Text = "Email";
            // 
            // txtPrenume
            // 
            this.txtPrenume.Location = new System.Drawing.Point(558, 119);
            this.txtPrenume.Name = "txtPrenume";
            this.txtPrenume.Size = new System.Drawing.Size(301, 38);
            this.txtPrenume.TabIndex = 4;
            // 
            // lblPrenume
            // 
            this.lblPrenume.AutoSize = true;
            this.lblPrenume.Location = new System.Drawing.Point(553, 73);
            this.lblPrenume.Name = "lblPrenume";
            this.lblPrenume.Size = new System.Drawing.Size(125, 30);
            this.lblPrenume.TabIndex = 3;
            this.lblPrenume.Text = "Prenumele";
            // 
            // txtNumele
            // 
            this.txtNumele.Location = new System.Drawing.Point(91, 119);
            this.txtNumele.Name = "txtNumele";
            this.txtNumele.Size = new System.Drawing.Size(301, 38);
            this.txtNumele.TabIndex = 2;
            // 
            // lblNumele
            // 
            this.lblNumele.AutoSize = true;
            this.lblNumele.Location = new System.Drawing.Point(86, 73);
            this.lblNumele.Name = "lblNumele";
            this.lblNumele.Size = new System.Drawing.Size(95, 30);
            this.lblNumele.TabIndex = 1;
            this.lblNumele.Text = "Numele";
            // 
            // tabGestionare
            // 
            this.tabGestionare.ForeColor = System.Drawing.SystemColors.Control;
            this.tabGestionare.Location = new System.Drawing.Point(4, 39);
            this.tabGestionare.Name = "tabGestionare";
            this.tabGestionare.Padding = new System.Windows.Forms.Padding(3);
            this.tabGestionare.Size = new System.Drawing.Size(1363, 641);
            this.tabGestionare.TabIndex = 1;
            this.tabGestionare.Text = "Gestionare fise pacienti";
            this.tabGestionare.UseVisualStyleBackColor = true;
            // 
            // tabGrafic
            // 
            this.tabGrafic.ForeColor = System.Drawing.SystemColors.Control;
            this.tabGrafic.Location = new System.Drawing.Point(4, 39);
            this.tabGrafic.Name = "tabGrafic";
            this.tabGrafic.Size = new System.Drawing.Size(1363, 641);
            this.tabGrafic.TabIndex = 2;
            this.tabGrafic.Text = "Grafic interpretare analize pacient";
            this.tabGrafic.UseVisualStyleBackColor = true;
            // 
            // tabIesire
            // 
            this.tabIesire.ForeColor = System.Drawing.SystemColors.Control;
            this.tabIesire.Location = new System.Drawing.Point(4, 39);
            this.tabIesire.Name = "tabIesire";
            this.tabIesire.Size = new System.Drawing.Size(1363, 641);
            this.tabIesire.TabIndex = 3;
            this.tabIesire.Text = "Iesire";
            this.tabIesire.UseVisualStyleBackColor = true;
            // 
            // lblGenul
            // 
            this.lblGenul.AutoSize = true;
            this.lblGenul.Location = new System.Drawing.Point(553, 266);
            this.lblGenul.Name = "lblGenul";
            this.lblGenul.Size = new System.Drawing.Size(74, 30);
            this.lblGenul.TabIndex = 9;
            this.lblGenul.Text = "Genul";
            // 
            // radioBarbat
            // 
            this.radioBarbat.AutoSize = true;
            this.radioBarbat.Location = new System.Drawing.Point(558, 334);
            this.radioBarbat.Name = "radioBarbat";
            this.radioBarbat.Size = new System.Drawing.Size(101, 34);
            this.radioBarbat.TabIndex = 10;
            this.radioBarbat.TabStop = true;
            this.radioBarbat.Text = "Barbat";
            this.radioBarbat.UseVisualStyleBackColor = true;
            // 
            // radioFemeie
            // 
            this.radioFemeie.AutoSize = true;
            this.radioFemeie.Location = new System.Drawing.Point(558, 385);
            this.radioFemeie.Name = "radioFemeie";
            this.radioFemeie.Size = new System.Drawing.Size(110, 34);
            this.radioFemeie.TabIndex = 11;
            this.radioFemeie.TabStop = true;
            this.radioFemeie.Text = "Femeie";
            this.radioFemeie.UseVisualStyleBackColor = true;
            // 
            // btnSalvare
            // 
            this.btnSalvare.Location = new System.Drawing.Point(906, 369);
            this.btnSalvare.Name = "btnSalvare";
            this.btnSalvare.Size = new System.Drawing.Size(267, 119);
            this.btnSalvare.TabIndex = 12;
            this.btnSalvare.Text = "Salveaza Pacient";
            this.btnSalvare.UseVisualStyleBackColor = true;
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
            this.tabAdd.ResumeLayout(false);
            this.tabAdd.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabAdd;
        private System.Windows.Forms.TabPage tabGestionare;
        private System.Windows.Forms.TabPage tabGrafic;
        private System.Windows.Forms.TabPage tabIesire;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtPrenume;
        private System.Windows.Forms.Label lblPrenume;
        private System.Windows.Forms.TextBox txtNumele;
        private System.Windows.Forms.Label lblNumele;
        private System.Windows.Forms.MonthCalendar dataNasteri;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Button btnSalvare;
        private System.Windows.Forms.RadioButton radioFemeie;
        private System.Windows.Forms.RadioButton radioBarbat;
        private System.Windows.Forms.Label lblGenul;
    }
}