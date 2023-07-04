using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Risc_BCV.Models
{
    internal class DatePersonale
    {

        private int _idPacient;
        private string _nume;
        private string _prenume;
        private bool _gen;
        private int _varsta;
        private DateTime _dateNasterii;
        private string _email;

        public DatePersonale(int idPacient, string nume, string prenume, bool gen, int varsta, DateTime dateNasterii, string email)
        {
            _idPacient = idPacient;
            _nume = nume;
            _prenume = prenume;
            _gen = gen;
            _varsta = varsta;
            _dateNasterii = dateNasterii;
            _email = email;
        }

        public DatePersonale(string text)
        {
            string[] prop = text.Split('|');

            this._idPacient = int.Parse(prop[0]);
            this._nume = prop[1];
            this._prenume = prop[2];
            this._gen = bool.Parse(prop[3]);
            this._varsta = int.Parse(prop[4]);
            this._dateNasterii = DateTime.Parse(prop[5]);
            this._email = prop[6];

        }

        public int IdPacient
        {
            get { return _idPacient; }
            set { _idPacient = value; }

        }

        public string Nume
        {
            get { return _nume; }
            set { _nume = value; }
        }

        public string Prenume
        {
            get { return _prenume; }
            set { _prenume = value; }
        }

        public bool Gen
        {
            get { return _gen; }
            set { _gen = value; }
        }

        public int Varsta
        {
            get { return _varsta; }
            set { _varsta = value; }
        }

        public DateTime DateNasterii
        {
            get { return _dateNasterii; }
            set { _dateNasterii = value; }
        }

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }
    
    }
}
