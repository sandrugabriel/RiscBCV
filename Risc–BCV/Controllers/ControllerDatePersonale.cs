using Risc_BCV.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Risc_BCV.Controllers
{
    internal class ControllerDatePersonale
    {

        private List<DatePersonale> datePersonale;

        public ControllerDatePersonale()
        {

            datePersonale = new List<DatePersonale>();

            load();

        }

        public void load()
        {

            string path = Application.StartupPath + @"/data/pacienti.txt";
            StreamReader streamReader = new StreamReader(path);

            string t;

            while((t = streamReader.ReadLine()) != null)
            {
                DatePersonale date = new DatePersonale(t);
                datePersonale.Add(date);
            }

            streamReader.Close();
        }


    }
}
