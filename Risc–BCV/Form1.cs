﻿using Risc_BCV.Panels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Risc_BCV
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.Controls.Add(new PnlOptiuni(this));
    

        }

        public void removePnl(string pnl)
        {

            Control control = null;

            foreach (Control c in this.Controls)
            {

                if (c.Name.Equals(pnl))
                {
                    control = c;
                }

            }

            this.Controls.Remove(control);
        }

    }
}
