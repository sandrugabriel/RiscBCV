using Risc_BCV.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Risc_BCV.Panels
{
    internal class PnlOptiuni:Panel
    {

        Form1 form;


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

        ControllerDatePersonale controllerDatePersonale;

        public PnlOptiuni(Form1 form1)
        {
            this.form = form1;
            this.form.Location = new System.Drawing.Point(1, 1);
            this.form.Size = new System.Drawing.Size(1366, 705);
            this.form.MinimumSize = new System.Drawing.Size(1366, 705);
            this.form.MaximumSize = new System.Drawing.Size(1366, 705);
            this.controllerDatePersonale = new ControllerDatePersonale();

            // MockupOptiuni
            this.Size = new System.Drawing.Size(1366, 705);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 13.8F, System.Drawing.FontStyle.Regular);
            this.Name = "PnlOptiuni";
            this.BackColor = System.Drawing.ColorTranslator.FromHtml("#5F7ADB");

            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabAdd = new System.Windows.Forms.TabPage();
            this.tabGestionare = new System.Windows.Forms.TabPage();
            this.tabGrafic = new System.Windows.Forms.TabPage();
            this.tabIesire = new System.Windows.Forms.TabPage();
            this.lblGenul = new System.Windows.Forms.Label();
            this.radioBarbat = new System.Windows.Forms.RadioButton();
            this.radioFemeie = new System.Windows.Forms.RadioButton();
            this.btnSalvare = new System.Windows.Forms.Button();
            this.dataNasteri = new System.Windows.Forms.MonthCalendar();
            this.lblData = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtPrenume = new System.Windows.Forms.TextBox();
            this.lblPrenume = new System.Windows.Forms.Label();
            this.txtNumele = new System.Windows.Forms.TextBox();
            this.lblNumele = new System.Windows.Forms.Label();

            this.Controls.Add(this.tabControl);

            // tabControl
            this.tabControl.Controls.Add(this.tabAdd);
            this.tabControl.Controls.Add(this.tabGestionare);
            this.tabControl.Controls.Add(this.tabGrafic);
            this.tabControl.Controls.Add(this.tabIesire);
            this.tabControl.Location = new System.Drawing.Point(-1, 26);
            this.tabControl.Name = "tabControl";
            this.tabControl.Size = new System.Drawing.Size(1371, 684);

            // tabAd
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
            this.tabAdd.BackColor = System.Drawing.ColorTranslator.FromHtml("#2E3239");
            this.tabAdd.ForeColor = System.Drawing.SystemColors.Control;
            this.tabAdd.Location = new System.Drawing.Point(4, 39);
            this.tabAdd.Name = "tabAdd";
            this.tabAdd.Padding = new System.Windows.Forms.Padding(3);
            this.tabAdd.Size = new System.Drawing.Size(1363, 641);
            this.tabAdd.Text = "Adaugare Pacient";
             
            // tabGestionare
            this.tabGestionare.ForeColor = System.Drawing.SystemColors.Control;
            this.tabGestionare.Location = new System.Drawing.Point(4, 39);
            this.tabGestionare.Name = "tabGestionare";
            this.tabGestionare.Padding = new System.Windows.Forms.Padding(3);
            this.tabGestionare.Size = new System.Drawing.Size(1345, 636);
            this.tabGestionare.Text = "Gestionare fise pacienti";
             
            // tabGrafic
            this.tabGrafic.ForeColor = System.Drawing.SystemColors.Control;
            this.tabGrafic.Location = new System.Drawing.Point(4, 39);
            this.tabGrafic.Name = "tabGrafic";
            this.tabGrafic.Size = new System.Drawing.Size(1345, 636);
            this.tabGrafic.TabIndex = 2;
            this.tabGrafic.Text = "Grafic interpretare analize pacient";
             
            // tabIesire
            this.tabIesire.ForeColor = System.Drawing.SystemColors.Control;
            this.tabIesire.Location = new System.Drawing.Point(4, 39);
            this.tabIesire.Name = "tabIesire";
            this.tabIesire.Size = new System.Drawing.Size(1345, 636);
            this.tabIesire.Text = "Iesire";
 
            // dataNasteri
            this.dataNasteri.Location = new System.Drawing.Point(91, 305);
            this.dataNasteri.Name = "dataNasteri";
            this.dataNasteri.MaxDate = DateTime.Now.AddMonths(-1);

            // lblData
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(86, 266);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(141, 30);
            this.lblData.Text = "Data Nasteri";
            
            // txtEmail
            this.txtEmail.Location = new System.Drawing.Point(971, 119);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(301, 38);
             
            // lblEmail
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(966, 73);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(67, 30);
            this.lblEmail.Text = "Email";
            
            // txtPrenume
            this.txtPrenume.Location = new System.Drawing.Point(558, 119);
            this.txtPrenume.Name = "txtPrenume";
            this.txtPrenume.Size = new System.Drawing.Size(301, 38);
             
            // lblPrenume
            this.lblPrenume.AutoSize = true;
            this.lblPrenume.Location = new System.Drawing.Point(553, 73);
            this.lblPrenume.Name = "lblPrenume";
            this.lblPrenume.Size = new System.Drawing.Size(125, 30);
            this.lblPrenume.Text = "Prenumele";
            
            // txtNumele
            this.txtNumele.Location = new System.Drawing.Point(91, 119);
            this.txtNumele.Name = "txtNumele";
            this.txtNumele.Size = new System.Drawing.Size(301, 38);
            
            // lblNumele
            this.lblNumele.AutoSize = true;
            this.lblNumele.Location = new System.Drawing.Point(86, 73);
            this.lblNumele.Name = "lblNumele";
            this.lblNumele.Size = new System.Drawing.Size(95, 30);
            this.lblNumele.Text = "Numele";
 
            // lblGenul
            this.lblGenul.AutoSize = true;
            this.lblGenul.Location = new System.Drawing.Point(553, 266);
            this.lblGenul.Name = "lblGenul";
            this.lblGenul.Size = new System.Drawing.Size(74, 30);
            this.lblGenul.Text = "Genul";
             
            // radioBarbat
            this.radioBarbat.AutoSize = true;
            this.radioBarbat.Location = new System.Drawing.Point(558, 334);
            this.radioBarbat.Name = "radioBarbat";
            this.radioBarbat.Size = new System.Drawing.Size(101, 34);
            this.radioBarbat.Text = "Barbat";
             
            // radioFemeie
            this.radioFemeie.AutoSize = true;
            this.radioFemeie.Location = new System.Drawing.Point(558, 385);
            this.radioFemeie.Name = "radioFemeie";
            this.radioFemeie.Size = new System.Drawing.Size(110, 34);
            this.radioFemeie.Text = "Femeie";
             
            // btnSalvare
            this.btnSalvare.Location = new System.Drawing.Point(906, 310);
            this.btnSalvare.Name = "btnSalvare";
            this.btnSalvare.Size = new System.Drawing.Size(240, 90);
            this.btnSalvare.BackColor = System.Drawing.ColorTranslator.FromHtml("#5F7ADB");
            this.btnSalvare.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 15.8F, System.Drawing.FontStyle.Regular);
            this.btnSalvare.Text = "Salveaza Pacient";
            this.btnSalvare.Click += new EventHandler(btnSalvare_Click);


        }

        public void btnSalvare_Click(object sender, EventArgs e)
        {
            int semn = 0;
            RadioButton[] buttons = { radioBarbat, radioFemeie };

            for (int i = 0; i < buttons.Length; i++)
            {
                if (buttons[i].Checked == true)
                {
                    semn = 1;
                }
            }

            if (txtEmail.Text.Equals("") || txtNumele.Text.Equals("") || txtPrenume.Text.Equals("") || semn == 0)
            {
                MessageBox.Show("Ceva nu este completat!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DateTime dataNasterii = dataNasteri.SelectionStart;
                DateTime dataCurenta = DateTime.Now;
                TimeSpan diferenta = dataCurenta - dataNasterii;
                int varsta = (int)(diferenta.TotalDays / 365);
                int id = controllerDatePersonale.generareId();
                string nume = txtNumele.Text;
                string prenume = txtPrenume.Text;
                string email = txtEmail.Text;
                bool barbat = false;

                if (radioBarbat.Checked == true)
                {
                    barbat = true;
                }

                string text = id.ToString() + "|" + nume + "|" + prenume + "|" + barbat.ToString() + "|" + varsta.ToString() + "|" + dataNasterii.ToString() + "|" + email;
                controllerDatePersonale.save(text);
                this.form.removePnl("PnlOptiuni");
                this.form.Controls.Add(new PnlOptiuni(form));
            }

        }

    }
}
