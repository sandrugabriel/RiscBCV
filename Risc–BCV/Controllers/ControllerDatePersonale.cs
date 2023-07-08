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

        public DatePersonale getClientById(int id)
        {

            for (int i = 0; i < datePersonale.Count; i++)
            {
                if (datePersonale[i].IdPacient == id)
                {
                    return datePersonale[i];
                }
            }

            return null;
        }

        public int generareId()
        {
            Random random = new Random();

            int id = random.Next();
            while (this.getClientById(id) != null)
            {

                id = random.Next();

            }


            return id;

        }

        public void save(string textul)
        {

            string text = textul;
            string path = Application.StartupPath + @"/data/pacienti.txt";
            File.AppendAllText(path, text + "\n");


        }

        public List<DatePersonale> getPacienti()
        {
            return datePersonale;
        }

        public void crescator(List<DatePersonale> list)
        {

            int semn = 0;

            do
            {
                semn = 1;

                for (int i = 0; i < list.Count - 1; i++)
                {
                    if (string.Compare(list[i].Nume, list[i + 1].Nume) > 0)
                    {
                        DatePersonale datePersonale = list[i];
                        list[i] = list[i + 1];
                        list[i + 1] = datePersonale;
                        semn = 0;
                    }
                }
            } while (semn == 0);


        }


    }
}
