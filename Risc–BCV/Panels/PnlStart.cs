using Risc_BCV.Controllers;
using Risc_BCV.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Risc_BCV.Panels
{
    internal class PnlStart:Panel
    {

        Form1 form;

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTitlu;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtParola;
        private System.Windows.Forms.Label lblParola;
        private System.Windows.Forms.Button btnLogin;

        ControllerDatePersonale controllerDatePersonale;

        public PnlStart(Form1 form1)
        {

            this.form = form1;
            this.controllerDatePersonale = new ControllerDatePersonale();
            this.form.Size = new System.Drawing.Size(799, 594);
            this.form.MinimumSize = new System.Drawing.Size(799, 594);
            this.form.MaximumSize = new System.Drawing.Size(799, 594);
            this.BackColor = System.Drawing.ColorTranslator.FromHtml("#2E3239");


            // MockupStart
            this.Size = new System.Drawing.Size(799, 594);
            this.Name = "PnlStart";

            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblTitlu = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtParola = new System.Windows.Forms.TextBox();
            this.lblParola = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();

            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtParola);
            this.Controls.Add(this.lblParola);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblTitlu);
            this.Controls.Add(this.pictureBox1);

            // pictureBox1
            this.pictureBox1.Location = new System.Drawing.Point(-6, -4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(804, 144); 
            this.pictureBox1.BackColor = System.Drawing.ColorTranslator.FromHtml("#5F7ADB");

            // lblTitlu
            this.lblTitlu.AutoSize = true;
            this.lblTitlu.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 30.8F);
            this.lblTitlu.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTitlu.Location = new System.Drawing.Point(288, 35);
            this.lblTitlu.Name = "lblTitlu";
            this.lblTitlu.Size = new System.Drawing.Size(160, 67);
            this.lblTitlu.BackColor = System.Drawing.ColorTranslator.FromHtml("#5F7ADB");
            this.lblTitlu.Text = "Login";
            
            // lblEmail
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 15.8F);
            this.lblEmail.Location = new System.Drawing.Point(202, 185);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(80, 35);  
            this.lblEmail.ForeColor = System.Drawing.SystemColors.Control;
            this.lblEmail.Text = "Email";
             
            // txtEmail
            this.txtEmail.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 13.8F, System.Drawing.FontStyle.Regular);
            this.txtEmail.Location = new System.Drawing.Point(208, 223);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(325, 38);
             
            // txtParola
            this.txtParola.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 13.8F, System.Drawing.FontStyle.Regular);
            this.txtParola.Location = new System.Drawing.Point(208, 371);
            this.txtParola.Name = "txtParola";
            this.txtParola.Size = new System.Drawing.Size(325, 38);
             
            // lblParola
            this.lblParola.AutoSize = true;
            this.lblParola.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 15.8F);
            this.lblParola.Location = new System.Drawing.Point(202, 333);
            this.lblParola.Name = "lblParola";
            this.lblParola.Size = new System.Drawing.Size(91, 35);
            this.lblParola.ForeColor = System.Drawing.SystemColors.Control;
            this.lblParola.Text = "Parola";
             
            // btnLogin
            this.btnLogin.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 20.8F, System.Drawing.FontStyle.Regular);
            this.btnLogin.ForeColor = System.Drawing.SystemColors.Control;
            this.btnLogin.Location = new System.Drawing.Point(260, 455);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(240, 62);
            this.btnLogin.Text = "Login";
            this.btnLogin.Click += new EventHandler(btnLogin_Click);
            this.btnLogin.BackColor = System.Drawing.ColorTranslator.FromHtml("#5F7ADB");





        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!txtEmail.Text.Equals("") || !txtParola.Text.Equals(""))
            {
                if (txtEmail.Text.Equals("medic") && txtParola.Text.Equals("oti2014"))
                {
                    this.form.removePnl("PnlStart");

                }
                else
                {
                    MessageBox.Show("Nu ai introdus bine emailul/parola!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtEmail.Text = "";
                    txtParola.Text = "";
                }
            }else MessageBox.Show("Nu ai introdus emailul/parola!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }







    }
}
