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

        public PnlOptiuni(Form1 form1)
        {
            this.form = form1;
            this.form.Size = new System.Drawing.Size(1366, 705);
            this.form.MinimumSize = new System.Drawing.Size(1366, 705);
            this.form.MaximumSize = new System.Drawing.Size(1366, 705);


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

            this.Controls.Add(this.tabControl);

            // tabControl
            this.tabControl.Controls.Add(this.tabAdd);
            this.tabControl.Controls.Add(this.tabGestionare);
            this.tabControl.Controls.Add(this.tabGrafic);
            this.tabControl.Controls.Add(this.tabIesire);
            this.tabControl.Location = new System.Drawing.Point(-1, 26);
            this.tabControl.Name = "tabControl";
            this.tabControl.Size = new System.Drawing.Size(1371, 684);
             
            // tabAdd
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



        }




    }
}
