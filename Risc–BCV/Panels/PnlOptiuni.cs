using Risc_BCV.Controllers;
using Risc_BCV.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Risc_BCV.Panels
{
    internal class PnlOptiuni : Panel
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
        ControllerAnalizePacienti controllerAnalizePacienti;

        List<string> errors;
        private System.Windows.Forms.TextBox txtCod;
        private System.Windows.Forms.Label lblCod;
        private System.Windows.Forms.TextBox txtNume;
        private System.Windows.Forms.Label lblNume;
        private System.Windows.Forms.TextBox txtVarsta;
        private System.Windows.Forms.Label lblVarsta;
        private System.Windows.Forms.TextBox txtData;
        private System.Windows.Forms.Label lblData1;
        private System.Windows.Forms.Label lblGen;
        private System.Windows.Forms.TextBox txtPrenume1;
        private System.Windows.Forms.Label lblPrenume1;
        private System.Windows.Forms.TextBox txtEmail1;
        private System.Windows.Forms.Label lblEmail1;
        private System.Windows.Forms.Label lblHDL;
        private System.Windows.Forms.Label lblTAS;
        private System.Windows.Forms.Label lblPCR;
        private System.Windows.Forms.Label lblCosTotal;
        private System.Windows.Forms.MonthCalendar dataAnaliza;
        private System.Windows.Forms.Label lblAnaliza;
        private System.Windows.Forms.RadioButton radioFemeie1;
        private System.Windows.Forms.RadioButton radioBarbat1;
        private System.Windows.Forms.CheckBox chk60Ani;
        private System.Windows.Forms.CheckBox chkFumator;
        private System.Windows.Forms.TextBox txtPCR;
        private System.Windows.Forms.TextBox txtTAS;
        private System.Windows.Forms.TextBox txtHDL;
        private System.Windows.Forms.TextBox txtCostTotal;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSalvare1;
        private System.Windows.Forms.Button btnModificare;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnCancel;

        List<DatePersonale> listPacientii;
        int i;


        private System.Windows.Forms.Label lblTitlu;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.ComboBox comboPacienti;
        ChartArea chartArea;
        Legend legend;
        Series series;
        List<AnalizePacient> listAnalize;

        public PnlOptiuni(Form1 form1)
        {
            this.form = form1;
            errors = new List<string>();
            listAnalize = new List<AnalizePacient>();
            this.form.Location = new System.Drawing.Point(1, 1);
            this.form.Size = new System.Drawing.Size(1366, 705);
            this.form.MinimumSize = new System.Drawing.Size(1366, 705);
            this.form.MaximumSize = new System.Drawing.Size(1366, 705);
            this.controllerDatePersonale = new ControllerDatePersonale();
            this.controllerAnalizePacienti = new ControllerAnalizePacienti();
            i = 0;
            listPacientii = new List<DatePersonale>();
            listPacientii = controllerDatePersonale.getPacienti();
            controllerDatePersonale.crescator(listPacientii);
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
            this.btnCancel = new System.Windows.Forms.Button();

            this.lblCod = new System.Windows.Forms.Label();
            this.txtCod = new System.Windows.Forms.TextBox();
            this.txtVarsta = new System.Windows.Forms.TextBox();
            this.lblVarsta = new System.Windows.Forms.Label();
            this.txtNume = new System.Windows.Forms.TextBox();
            this.lblNume = new System.Windows.Forms.Label();
            this.txtData = new System.Windows.Forms.TextBox();
            this.lblData1 = new System.Windows.Forms.Label();
            this.txtEmail1 = new System.Windows.Forms.TextBox();
            this.lblEmail1 = new System.Windows.Forms.Label();
            this.txtPrenume1 = new System.Windows.Forms.TextBox();
            this.lblPrenume1 = new System.Windows.Forms.Label();
            this.lblGen = new System.Windows.Forms.Label();
            this.radioBarbat1 = new System.Windows.Forms.RadioButton();
            this.radioFemeie1 = new System.Windows.Forms.RadioButton();
            this.lblAnaliza = new System.Windows.Forms.Label();
            this.dataAnaliza = new System.Windows.Forms.MonthCalendar();
            this.lblCosTotal = new System.Windows.Forms.Label();
            this.lblPCR = new System.Windows.Forms.Label();
            this.lblTAS = new System.Windows.Forms.Label();
            this.lblHDL = new System.Windows.Forms.Label();
            this.txtCostTotal = new System.Windows.Forms.TextBox();
            this.txtHDL = new System.Windows.Forms.TextBox();
            this.txtTAS = new System.Windows.Forms.TextBox();
            this.txtPCR = new System.Windows.Forms.TextBox();
            this.chkFumator = new System.Windows.Forms.CheckBox();
            this.chk60Ani = new System.Windows.Forms.CheckBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnModificare = new System.Windows.Forms.Button();
            this.btnSalvare1 = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();

            this.Controls.Add(this.tabControl);

            // tabControl
            this.tabControl.Controls.Add(this.tabAdd);
            this.tabControl.Controls.Add(this.tabGestionare);
            this.tabControl.Controls.Add(this.tabGrafic);
            this.tabControl.Controls.Add(this.tabIesire);
            this.tabControl.Location = new System.Drawing.Point(-1, 26);
            this.tabControl.Name = "tabControl";
            this.tabControl.Size = new System.Drawing.Size(1371, 684);
            this.tabControl.SelectedIndexChanged += new EventHandler(tabControl_SelectedIndexChanged);

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
            this.tabGestionare.Controls.Add(this.btnAdd);
            this.tabGestionare.Controls.Add(this.btnSalvare1);
            this.tabGestionare.Controls.Add(this.btnModificare);
            this.tabGestionare.Controls.Add(this.btnNext);
            this.tabGestionare.Controls.Add(this.btnBack);
            this.tabGestionare.Controls.Add(this.chk60Ani);
            this.tabGestionare.Controls.Add(this.chkFumator);
            this.tabGestionare.Controls.Add(this.txtPCR);
            this.tabGestionare.Controls.Add(this.txtTAS);
            this.tabGestionare.Controls.Add(this.txtHDL);
            this.tabGestionare.Controls.Add(this.txtCostTotal);
            this.tabGestionare.Controls.Add(this.lblHDL);
            this.tabGestionare.Controls.Add(this.lblTAS);
            this.tabGestionare.Controls.Add(this.lblPCR);
            this.tabGestionare.Controls.Add(this.lblCosTotal);
            this.tabGestionare.Controls.Add(this.dataAnaliza);
            this.tabGestionare.Controls.Add(this.lblAnaliza);
            this.tabGestionare.Controls.Add(this.radioFemeie1);
            this.tabGestionare.Controls.Add(this.radioBarbat1);
            this.tabGestionare.Controls.Add(this.lblGen);
            this.tabGestionare.Controls.Add(this.txtPrenume1);
            this.tabGestionare.Controls.Add(this.lblPrenume1);
            this.tabGestionare.Controls.Add(this.txtEmail1);
            this.tabGestionare.Controls.Add(this.lblEmail1);
            this.tabGestionare.Controls.Add(this.txtData);
            this.tabGestionare.Controls.Add(this.lblData1);
            this.tabGestionare.Controls.Add(this.txtNume);
            this.tabGestionare.Controls.Add(this.lblNume);
            this.tabGestionare.Controls.Add(this.txtVarsta);
            this.tabGestionare.Controls.Add(this.lblVarsta);
            this.tabGestionare.Controls.Add(this.txtCod);
            this.tabGestionare.Controls.Add(this.lblCod);
            this.tabGestionare.Controls.Add(this.btnCancel);
            this.tabGestionare.ForeColor = System.Drawing.SystemColors.Control;
            this.tabGestionare.Location = new System.Drawing.Point(4, 39);
            this.tabGestionare.Name = "tabGestionare";
            this.tabGestionare.Padding = new System.Windows.Forms.Padding(3);
            this.tabGestionare.Size = new System.Drawing.Size(1345, 636);
            this.tabGestionare.Text = "Gestionare fise pacienti";
            this.tabGestionare.BackColor = System.Drawing.ColorTranslator.FromHtml("#2E3239");

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

            // lblCod
            this.lblCod.AutoSize = true;
            this.lblCod.ForeColor = System.Drawing.SystemColors.Control;
            this.lblCod.Location = new System.Drawing.Point(38, 31);
            this.lblCod.Name = "lblCod";
            this.lblCod.Size = new System.Drawing.Size(56, 30);
            this.lblCod.TabIndex = 0;
            this.lblCod.Text = "Cod";

            // txtCod
            this.txtCod.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtCod.Location = new System.Drawing.Point(43, 64);
            this.txtCod.Name = "txtCod";
            this.txtCod.ReadOnly = true;
            this.txtCod.Size = new System.Drawing.Size(185, 38);
            this.txtCod.TabIndex = 1;

            // txtVarsta
            this.txtVarsta.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtVarsta.Location = new System.Drawing.Point(43, 173);
            this.txtVarsta.Name = "txtVarsta";
            this.txtVarsta.ReadOnly = true;
            this.txtVarsta.Size = new System.Drawing.Size(185, 38);
            this.txtVarsta.TabIndex = 3;

            // lblVarsta
            this.lblVarsta.AutoSize = true;
            this.lblVarsta.ForeColor = System.Drawing.SystemColors.Control;
            this.lblVarsta.Location = new System.Drawing.Point(38, 140);
            this.lblVarsta.Name = "lblVarsta";
            this.lblVarsta.Size = new System.Drawing.Size(77, 30);
            this.lblVarsta.TabIndex = 2;
            this.lblVarsta.Text = "Varsta";

            // txtNume
            this.txtNume.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtNume.Location = new System.Drawing.Point(335, 64);
            this.txtNume.Name = "txtNume";
            this.txtNume.ReadOnly = true;
            this.txtNume.Size = new System.Drawing.Size(263, 38);
            this.txtNume.TabIndex = 5;

            // lblNume
            this.lblNume.AutoSize = true;
            this.lblNume.ForeColor = System.Drawing.SystemColors.Control;
            this.lblNume.Location = new System.Drawing.Point(330, 31);
            this.lblNume.Name = "lblNume";
            this.lblNume.Size = new System.Drawing.Size(95, 30);
            this.lblNume.TabIndex = 4;
            this.lblNume.Text = "Numele";

            // txtData
            this.txtData.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtData.Location = new System.Drawing.Point(335, 173);
            this.txtData.Name = "txtData";
            this.txtData.ReadOnly = true;
            this.txtData.Size = new System.Drawing.Size(263, 38);
            this.txtData.TabIndex = 7;

            // lblData
            this.lblData1.AutoSize = true;
            this.lblData1.ForeColor = System.Drawing.SystemColors.Control;
            this.lblData1.Location = new System.Drawing.Point(330, 140);
            this.lblData1.Name = "lblData";
            this.lblData1.Size = new System.Drawing.Size(141, 30);
            this.lblData1.TabIndex = 6;
            this.lblData1.Text = "Data Nasteri";

            // txtEmail
            this.txtEmail1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtEmail1.Location = new System.Drawing.Point(719, 173);
            this.txtEmail1.Name = "txtEmail";
            this.txtEmail1.ReadOnly = true;
            this.txtEmail1.Size = new System.Drawing.Size(263, 38);
            this.txtEmail1.TabIndex = 9;

            // lblEmail
            this.lblEmail1.AutoSize = true;
            this.lblEmail1.ForeColor = System.Drawing.SystemColors.Control;
            this.lblEmail1.Location = new System.Drawing.Point(714, 140);
            this.lblEmail1.Name = "lblEmail";
            this.lblEmail1.Size = new System.Drawing.Size(67, 30);
            this.lblEmail1.TabIndex = 8;
            this.lblEmail1.Text = "Email";

            // txtPrenume
            this.txtPrenume1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtPrenume1.Location = new System.Drawing.Point(719, 64);
            this.txtPrenume1.Name = "txtPrenume";
            this.txtPrenume1.ReadOnly = true;
            this.txtPrenume1.Size = new System.Drawing.Size(263, 38);
            this.txtPrenume1.TabIndex = 11;

            // lblPrenume
            this.lblPrenume1.AutoSize = true;
            this.lblPrenume1.ForeColor = System.Drawing.SystemColors.Control;
            this.lblPrenume1.Location = new System.Drawing.Point(714, 31);
            this.lblPrenume1.Name = "lblPrenume";
            this.lblPrenume1.Size = new System.Drawing.Size(125, 30);
            this.lblPrenume1.TabIndex = 10;
            this.lblPrenume1.Text = "Prenumele";

            // lblGen
            this.lblGen.AutoSize = true;
            this.lblGen.ForeColor = System.Drawing.SystemColors.Control;
            this.lblGen.Location = new System.Drawing.Point(1156, 31);
            this.lblGen.Name = "lblGen";
            this.lblGen.Size = new System.Drawing.Size(56, 30);
            this.lblGen.TabIndex = 12;
            this.lblGen.Text = "Gen";

            // radioBarbat
            this.radioBarbat1.AutoSize = true;
            this.radioBarbat1.ForeColor = System.Drawing.SystemColors.Control;
            this.radioBarbat1.Location = new System.Drawing.Point(1113, 94);
            this.radioBarbat1.Name = "radioBarbat";
            this.radioBarbat1.Size = new System.Drawing.Size(101, 34);
            this.radioBarbat1.TabIndex = 13;
            this.radioBarbat1.TabStop = true;
            this.radioBarbat1.Text = "Barbat";
            this.radioBarbat1.UseVisualStyleBackColor = true;

            // radioFemeie
            this.radioFemeie1.AutoSize = true;
            this.radioFemeie1.ForeColor = System.Drawing.SystemColors.Control;
            this.radioFemeie1.Location = new System.Drawing.Point(1113, 151);
            this.radioFemeie1.Name = "radioFemeie";
            this.radioFemeie1.Size = new System.Drawing.Size(110, 34);
            this.radioFemeie1.Text = "Femeie";

            // lblAnaliza
            this.lblAnaliza.AutoSize = true;
            this.lblAnaliza.Location = new System.Drawing.Point(77, 259);
            this.lblAnaliza.Name = "lblAnaliza";
            this.lblAnaliza.Size = new System.Drawing.Size(143, 30);
            this.lblAnaliza.TabIndex = 15;
            this.lblAnaliza.Text = "Data Analiza";

            // dataAnaliza
            this.dataAnaliza.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 10.8F);
            this.dataAnaliza.Location = new System.Drawing.Point(31, 298);
            this.dataAnaliza.Name = "dataAnaliza";
            this.dataAnaliza.DateChanged += new DateRangeEventHandler(dataAnaliza_DateChanged);

            // lblCosTotal
            this.lblCosTotal.AutoSize = true;
            this.lblCosTotal.ForeColor = System.Drawing.SystemColors.Control;
            this.lblCosTotal.Location = new System.Drawing.Point(344, 298);
            this.lblCosTotal.Name = "lblCosTotal";
            this.lblCosTotal.Size = new System.Drawing.Size(254, 30);
            this.lblCosTotal.TabIndex = 17;
            this.lblCosTotal.Text = "Coresterol total(mg/dL)";

            // lblPCR
            this.lblPCR.AutoSize = true;
            this.lblPCR.ForeColor = System.Drawing.SystemColors.Control;
            this.lblPCR.Location = new System.Drawing.Point(344, 475);
            this.lblPCR.Name = "lblPCR";
            this.lblPCR.Size = new System.Drawing.Size(281, 30);
            this.lblPCR.TabIndex = 19;
            this.lblPCR.Text = "Proteina C - reactiva(PCR)";

            // lblTAS
            this.lblTAS.AutoSize = true;
            this.lblTAS.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTAS.Location = new System.Drawing.Point(344, 415);
            this.lblTAS.Name = "lblTAS";
            this.lblTAS.Size = new System.Drawing.Size(348, 30);
            this.lblTAS.TabIndex = 20;
            this.lblTAS.Text = "Tensiunea arteriala sistolica(TAS)";

            // lblHDL
            this.lblHDL.AutoSize = true;
            this.lblHDL.ForeColor = System.Drawing.SystemColors.Control;
            this.lblHDL.Location = new System.Drawing.Point(344, 352);
            this.lblHDL.Name = "lblHDL";
            this.lblHDL.Size = new System.Drawing.Size(254, 30);
            this.lblHDL.TabIndex = 21;
            this.lblHDL.Text = "Coresterol HDL(mg/dL)";

            // txtCostTotal
            this.txtCostTotal.Location = new System.Drawing.Point(604, 298);
            this.txtCostTotal.Name = "txtCostTotal";
            this.txtCostTotal.ReadOnly = true;
            this.txtCostTotal.Size = new System.Drawing.Size(131, 38);
            this.txtCostTotal.TabIndex = 23;

            // txtHDL
            this.txtHDL.Location = new System.Drawing.Point(604, 352);
            this.txtHDL.Name = "txtHDL";
            this.txtHDL.ReadOnly = true;
            this.txtHDL.Size = new System.Drawing.Size(131, 38);
            this.txtHDL.TabIndex = 24;

            // txtTAS
            this.txtTAS.Location = new System.Drawing.Point(698, 407);
            this.txtTAS.Name = "txtTAS";
            this.txtTAS.ReadOnly = true;
            this.txtTAS.Size = new System.Drawing.Size(131, 38);
            this.txtTAS.TabIndex = 25;

            // txtPCR
            this.txtPCR.Location = new System.Drawing.Point(631, 467);
            this.txtPCR.Name = "txtPCR";
            this.txtPCR.ReadOnly = true;
            this.txtPCR.Size = new System.Drawing.Size(131, 38);
            this.txtPCR.TabIndex = 26;

            // chkFumator
            this.chkFumator.AutoSize = true;
            this.chkFumator.ForeColor = System.Drawing.SystemColors.Control;
            this.chkFumator.Location = new System.Drawing.Point(1018, 353);
            this.chkFumator.Name = "chkFumator";
            this.chkFumator.Size = new System.Drawing.Size(121, 34);
            this.chkFumator.TabIndex = 27;
            this.chkFumator.Text = "Fumator";
            this.chkFumator.UseVisualStyleBackColor = true;

            // chk60Ani
            this.chk60Ani.AutoSize = true;
            this.chk60Ani.ForeColor = System.Drawing.SystemColors.Control;
            this.chk60Ani.Location = new System.Drawing.Point(896, 407);
            this.chk60Ani.Name = "chk60Ani";
            this.chk60Ani.Size = new System.Drawing.Size(435, 64);
            this.chk60Ani.TabIndex = 28;
            this.chk60Ani.Text = "Persoane in familie cu accident \r\nvascular cerebral inainte de 60 de ani  ";
            this.chk60Ani.UseVisualStyleBackColor = true;

            // btnBack
            this.btnBack.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 18.8F);
            this.btnBack.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBack.Location = new System.Drawing.Point(82, 530);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(74, 58);
            this.btnBack.Text = "<";
            this.btnBack.BackColor = System.Drawing.ColorTranslator.FromHtml("#5F7ADB");
            this.btnBack.Click += new EventHandler(btnBack_Click);

            // btnNext
            this.btnNext.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 18.8F);
            this.btnNext.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnNext.Location = new System.Drawing.Point(1177, 530);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(74, 58);
            this.btnNext.Text = ">";
            this.btnNext.BackColor = System.Drawing.ColorTranslator.FromHtml("#5F7ADB");
            this.btnNext.Click += new EventHandler(btnNext_Click);

            // btnCancel
            this.btnCancel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCancel.Location = new System.Drawing.Point(100, 530);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(158, 58);
            this.btnCancel.BackColor = System.Drawing.ColorTranslator.FromHtml("#5F7ADB");
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new EventHandler(btnCancel_Click);
            this.btnCancel.Visible = false;

            // btnModificare
            this.btnModificare.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnModificare.Location = new System.Drawing.Point(325, 530);
            this.btnModificare.Name = "btnModificare";
            this.btnModificare.Size = new System.Drawing.Size(158, 58);
            this.btnModificare.BackColor = System.Drawing.ColorTranslator.FromHtml("#5F7ADB");
            this.btnModificare.Text = "Modificare";
            this.btnModificare.Click += new EventHandler(btnModificare_Click);

            // btnSalvare
            this.btnSalvare1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSalvare1.Location = new System.Drawing.Point(589, 530);
            this.btnSalvare1.Name = "btnSalvare";
            this.btnSalvare1.Size = new System.Drawing.Size(158, 58);
            this.btnSalvare1.BackColor = System.Drawing.ColorTranslator.FromHtml("#5F7ADB");
            this.btnSalvare1.Text = "Salvare";
            this.btnSalvare1.Enabled = false;
            this.btnSalvare1.Click += new EventHandler(btnSalvare1_Click);

            // btnAdd
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAdd.Location = new System.Drawing.Point(877, 530);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(158, 58);
            this.btnAdd.BackColor = System.Drawing.ColorTranslator.FromHtml("#5F7ADB");
            this.btnAdd.Text = "Adaugare";
            this.btnAdd.Click += new EventHandler(btnAdd_Click);
            this.tabControl.SelectedIndex = 1;
            load();
            chart = new Chart();
            chartArea = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            legend = new System.Windows.Forms.DataVisualization.Charting.Legend();
            series = new System.Windows.Forms.DataVisualization.Charting.Series();
            lblTitlu = new Label();
            comboPacienti = new System.Windows.Forms.ComboBox();
            this.tabGrafic.Controls.Add(lblTitlu);
            this.tabGrafic.Controls.Add(chart);
            this.tabGrafic.Controls.Add(comboPacienti);

            // lblTitlu
            this.lblTitlu.AutoSize = true;
            this.lblTitlu.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 17.8F);
            this.lblTitlu.Location = new System.Drawing.Point(150, 49);
            this.lblTitlu.Size = new System.Drawing.Size(122, 39);
            this.lblTitlu.Text = "Pacienti";

            // comboPacienti
            this.comboPacienti.FormattingEnabled = true;
            this.comboPacienti.Location = new System.Drawing.Point(94, 112);
            this.comboPacienti.Size = new System.Drawing.Size(223, 38);
            this.comboPacienti.SelectedIndexChanged += new EventHandler(comboBox_SelectedIndexChanged);

            for(int i=0;i<listPacientii.Count;i++)
                comboPacienti.Items.Add(listPacientii[i].Nume);


            this.chart.Size = new System.Drawing.Size(812, 525);
            this.chart.Location = new System.Drawing.Point(446, 70);
            this.chart.Legends.Add(legend);
            this.chart.Name = "chart";
            this.chart.Text = "chart";
            this.chart.Series.Add(series);
            this.chart.ChartAreas.Add(chartArea);
            this.chart.Series.Add(series1);

            this.chartArea.Name = "ChartArea";
            this.legend.Name = "Legend";
            this.series.ChartType = SeriesChartType.Column;
            this.tabGrafic.BackColor = System.Drawing.ColorTranslator.FromHtml("#2E3239");
        }

        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string nume = comboPacienti.SelectedItem.ToString();
            int id = controllerDatePersonale.getIdbyNume(nume);

            styleOne(id);
        }

            Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
        private void styleOne(int id)
        {

            listAnalize = controllerAnalizePacienti.getAnalizePacint(id);
            this.series.Points.Clear();
            this.series1.Points.Clear();
            for (int i = 0; i < listAnalize.Count; i++)
            {
                DataPoint dataPoint = new DataPoint(0, listAnalize[i].ColesterolTotal);
                dataPoint.Label = "ColesterolTotal";
                this.series.Points.Add(dataPoint);


                DataPoint dataPoint1 = new DataPoint(0, listAnalize[i].HDL);
                dataPoint1.Label = "ColesterolTotal";
                this.series1.Points.Add(dataPoint1);

                this.series1.Color = Color.LightGreen;
            }
            this.series.Name = "ColesterolTotal";
            this.series1.Name = "HDL";
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

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl.SelectedIndex == 3)
            {
                this.form.removePnl("PnlOptiuni");
                this.form.Controls.Add(new PnlStart(form));
            }
        }

        public void load()
        {
            radioBarbat1.Visible = true;
            radioFemeie1.Visible = true;
            txtCod.Text = listPacientii[i].IdPacient.ToString();
            txtNume.Text = listPacientii[i].Nume;
            txtPrenume1.Text = listPacientii[i].Prenume;
            txtVarsta.Text = listPacientii[i].Varsta.ToString();
            txtEmail1.Text = listPacientii[i].Email;
            txtData.Text = listPacientii[i].DateNasterii.ToString("dd.MM.yyyy");

            if (listPacientii[i].Gen == true)
            {
                radioFemeie1.Visible = false;
                radioBarbat1.Checked = true;
            }
            else
            {
                radioBarbat1.Visible = false;
                radioFemeie1.Checked = true;
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {

            i++;
            if (listPacientii.Count <= i)
            {
                i = 0;
            }

            dataAnaliza.Refresh();
            chk60Ani.Checked = false;
            chkFumator.Visible = true;
            chkFumator.Checked = false;
            chk60Ani.Visible = true;
            txtCostTotal.ReadOnly = true;
            txtHDL.ReadOnly = true;
            txtTAS.ReadOnly = true;
            txtPCR.ReadOnly = true;
            txtCostTotal.Text = "";
            txtHDL.Text = "";
            txtTAS.Text = "";
            txtPCR.Text = "";

            load();


        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            i--;
            if (-1 == i)
                i = listPacientii.Count - 1;
            dataAnaliza.Refresh();
            chk60Ani.Checked = false;
            chkFumator.Visible = true;
            chkFumator.Checked = false;
            chk60Ani.Visible = true;
            txtCostTotal.ReadOnly = true;
            txtHDL.ReadOnly = true;
            txtTAS.ReadOnly = true;
            txtPCR.ReadOnly = true;
            txtCostTotal.Text = "";
            txtHDL.Text = "";
            txtTAS.Text = "";
            txtPCR.Text = "";

            load();

        }

        int semn = 0;

        private void dataAnaliza_DateChanged(object sender, EventArgs e)
        {

            string dateTime = dataAnaliza.SelectionEnd.ToString("MM.dd.yyyy");
            //MessageBox.Show(dateTime);
            if (controllerAnalizePacienti.getAnaliza(int.Parse(txtCod.Text), dateTime) == null)
            {
                chk60Ani.Checked = false;
                chkFumator.Visible = true;
                chkFumator.Checked = false;
                chk60Ani.Visible = true;
                txtCostTotal.Text = "";
                txtHDL.Text = "";
                txtTAS.Text = "";
                txtPCR.Text = "";
                MessageBox.Show("In acesta data nu este nici o fisa de analaize\nO poti adauga acum!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCostTotal.ReadOnly = false;
                txtHDL.ReadOnly = false;
                txtTAS.ReadOnly = false;
                txtPCR.ReadOnly = false;
                semn = 1;
            }
            else
            {
                chk60Ani.Checked = false;
                chkFumator.Visible = true;
                chkFumator.Checked = false;
                chk60Ani.Visible = true;
                txtCostTotal.ReadOnly = true;
                txtHDL.ReadOnly = true;
                txtTAS.ReadOnly = true;
                txtPCR.ReadOnly = true;
                AnalizePacient analizePacient = controllerAnalizePacienti.getAnaliza(int.Parse(txtCod.Text), dateTime);
                txtCostTotal.Text = analizePacient.ColesterolTotal.ToString();
                txtHDL.Text = analizePacient.HDL.ToString();
                txtTAS.Text = analizePacient.TAS.ToString();
                txtPCR.Text = analizePacient.PCR.ToString("0.###");
                if (analizePacient.Fumator == true)
                {
                    chkFumator.Checked = true;
                    chk60Ani.Visible = false;
                }

                if (analizePacient.BCVF == true)
                {
                    chk60Ani.Checked = true;
                    chkFumator.Visible = false;
                }
            }

        }

        private void verificare()
        {
            errors.Clear();

            if (txtCostTotal.Text.Equals(""))
            {
                errors.Add("Nu ai introdus coresterolul");
            }
            if (txtHDL.Text.Equals(""))
            {
                errors.Add("Nu ai introdus HDL");
            }
            if (txtTAS.Text.Equals(""))
            {
                errors.Add("Nu ai introdus TAS");
            }
            if (txtPCR.Text.Equals(""))
            {
                errors.Add("Nu ai introdus PCR");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            verificare();

            if (semn == 1)
                if (errors.Count == 0)
                {
                    string idPacient = txtCod.Text;
                    string costtoal = txtCostTotal.Text;
                    string hdl = txtHDL.Text;
                    string tas = txtTAS.Text;
                    string pcr = txtPCR.Text;
                    string data = dataAnaliza.SelectionEnd.ToString("dd.MM.yyyy");
                    string id = controllerAnalizePacienti.generareId().ToString();
                    string bcvf = "false";
                    string fum = "false";
                    if (chk60Ani.Checked == true)
                    {
                        bcvf = "true";
                    }
                    if (chkFumator.Checked == true)
                    {
                        fum = "true";
                    }

                    string text = id + "|" + idPacient + "|" + data + "|" + costtoal + "|" + hdl + "|" + tas + "|" + pcr + "|" + bcvf + "|" + fum;
                    controllerAnalizePacienti.save(text);
                    this.form.removePnl("PnlOptiuni");
                    this.form.Controls.Add(new PnlOptiuni(form));
                }
                else
                {
                    for (int i = 0; i < errors.Count; i++)
                    {
                        MessageBox.Show(errors[i], "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

            btnSalvare1.Enabled = false;
            btnNext.Enabled = true;
            btnNext.Visible = true;
            btnBack.Enabled = true;
            btnBack.Visible = true;
            btnAdd.Enabled = true;

            chkFumator.Visible = true;
            chk60Ani.Visible = true;
            txtCostTotal.ReadOnly = true;
            txtHDL.ReadOnly = true;
            txtTAS.ReadOnly = true;
            txtPCR.ReadOnly = true;
            btnCancel.Enabled = false;
            btnCancel.Visible = false;
            load();
        }

        private void btnModificare_Click(object sender, EventArgs e)
        {

            errors.Clear();

            verificare();

            if (errors.Count == 0)
            {

                btnSalvare1.Enabled = true;
                btnNext.Enabled = false;
                btnNext.Visible = false;
                btnBack.Enabled = false;
                btnBack.Visible = false;
                btnAdd.Enabled = false;
                btnCancel.Enabled = true;
                btnCancel.Visible = true;
                chk60Ani.Checked = false;
                chkFumator.Visible = true;
                chkFumator.Checked = false;
                chk60Ani.Visible = true;
                txtCostTotal.ReadOnly = false;
                txtHDL.ReadOnly = false;
                txtTAS.ReadOnly = false;
                txtPCR.ReadOnly = false;



            }
            else
            {
                MessageBox.Show("In data acesta nu a fost inregistrata o fisa de analize", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void btnSalvare1_Click(object sender, EventArgs e)
        {

            verificare();

            if (errors.Count == 0)
            {
                int idAnaliza = controllerAnalizePacienti.getIdAnalize(int.Parse(txtCod.Text), dataAnaliza.SelectionEnd.ToString("dd.MM.yyyy"));
                string data = dataAnaliza.SelectionEnd.ToString("dd.MM.yyyy");
                string co = txtCostTotal.Text;
                string hpl = txtHDL.Text;
                string tas = txtTAS.Text;
                string p = txtPCR.Text;
                string b = "false";
                string fum = "false";

                if (chk60Ani.Checked)
                {
                    b = "true";
                }
                if (chkFumator.Checked)
                {
                    fum = "true";
                }

                controllerAnalizePacienti.setAnaliza(idAnaliza, data, co, hpl, tas, p, b, fum);
                controllerAnalizePacienti.update();


                btnSalvare1.Enabled = false;
                btnNext.Enabled = true;
                btnNext.Visible = true;
                btnBack.Enabled = true;
                btnBack.Visible = true;
                btnAdd.Enabled = true;

                chkFumator.Visible = true;
                chk60Ani.Visible = true;
                txtCostTotal.ReadOnly = true;
                txtHDL.ReadOnly = true;
                txtTAS.ReadOnly = true;
                txtPCR.ReadOnly = true;
                btnCancel.Enabled = false;
                btnCancel.Visible = false;
                load();
            }
            else
            {
                for (int i = 0; i < errors.Count; i++)
                    MessageBox.Show(errors[i], "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }




    }
}
