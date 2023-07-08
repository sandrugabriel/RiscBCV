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

        public void save(string textul)
        {

            string text = textul;
            string path = Application.StartupPath + @"/data/analize.txt";
            File.AppendAllText(path, text + "\n");


        }

        public AnalizePacient getAnaliza(int id, string dateAnalizei)
        {
            for(int i=0;i< analizePacienti.Count; i++)
            {
           // MessageBox.Show(id.ToString() + "  " + dateAnalizei + "  " + analizePacienti[i].IdPacient.ToString() + "  " + analizePacienti[i].DateAnalize.ToString("dd.MM.yyyy"));

                if(id == analizePacienti[i].IdPacient && dateAnalizei == analizePacienti[i].DateAnalize.ToString("dd.MM.yyyy"))
                {
                    return analizePacienti[i];
                }

            }

            return null;
        }

        public string toSaveFisier()
        {

            string t = "";

            for (int i = 0; i < analizePacienti.Count; i++)
            {
                t += analizePacienti[i].toSave() + "\n";
            }

            return t;
        }

        public void update()
        {
            String path = Application.StartupPath + @"/data/analize.txt";
            StreamWriter streamWriter = new StreamWriter(path);

            streamWriter.Write(this.toSaveFisier());

            streamWriter.Close();
        }

        public int getIdAnalize(int id, string dateAnalizei)
        {
            for (int i = 0; i < analizePacienti.Count; i++)
            {

                if (id == analizePacienti[i].IdPacient && dateAnalizei == analizePacienti[i].DateAnalize.ToString("dd.MM.yyyy"))
                {
                    return analizePacienti[i].IdAnaliza;
                }

            }

            return -1;
        }

        public void setAnaliza(int idAanaliza, string dateAnalize, string colesterolTotal, string hDL, string tAs, string pCR, string bCVF, string fumator)
        {

            for (int i = 0; i < analizePacienti.Count; i++)
            {
                if (analizePacienti[i].IdAnaliza == idAanaliza)
                {

                    analizePacienti[i].DateAnalize = DateTime.Parse(dateAnalize);
                    analizePacienti[i].ColesterolTotal = int.Parse(colesterolTotal);
                    analizePacienti[i].HDL = int.Parse(hDL);
                    analizePacienti[i].TAS = int.Parse(tAs);
                    analizePacienti[i].PCR = double.Parse(pCR);
                    analizePacienti[i].BCVF = bool.Parse(bCVF);
                    analizePacienti[i].Fumator = bool.Parse(fumator);
                    return;
                }
            }

        }


    }
}
