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

         public AnalizePacient getAnalizeById(int id)
        {

            for (int i = 0; i < analizePacienti.Count; i++)
            {
                if (analizePacienti[i].IdAnaliza == id)
                {
                    return analizePacienti[i];
                }
            }

            return null;
        }

        public int generareId()
        {
            Random random = new Random();

            int id = random.Next();
            while (this.getAnalizeById(id) != null)
            {

                id = random.Next();

            }


            return id;

        }



    }
}
