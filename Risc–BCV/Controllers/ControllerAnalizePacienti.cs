using Risc_BCV.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Risc_BCV.Controllers
{
    internal class ControllerAnalizePacienti
    {

        private List<AnalizePacient> analizePacienti;

        public ControllerAnalizePacienti()
        {

            analizePacienti = new List<AnalizePacient>();

            load();

        }

        public void load()
        {

            string path = Application.StartupPath + @"/data/analize.txt";
            StreamReader streamReader = new StreamReader(path);

            string t;

            while((t = streamReader.ReadLine()) != null)
            {
                AnalizePacient analize = new AnalizePacient(t);
                analizePacienti.Add(analize);
            }

            streamReader.Close();
        }




    }
}
