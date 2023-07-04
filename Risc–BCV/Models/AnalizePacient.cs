using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Risc_BCV.Models
{
    internal class AnalizePacient
    {

        private int _IdAnaliza;
        private int _IdPacient;
        private DateTime _dataAnalize;
        private int _ColesterolTotal;
        private int _HDL;
        private int _TAS;
        private int _PCR;
        private bool _BCVF;
        private bool _Fumator;

        public AnalizePacient(int idAnaliza, int idPacient, DateTime dataAnalize, int colesterolTotal, int hDL, int tAS, int pCR, bool bCVF, bool fumator)
        {
            _IdAnaliza = idAnaliza;
            _IdPacient = idPacient;
            _dataAnalize = dataAnalize;
            _ColesterolTotal = colesterolTotal;
            _HDL = hDL;
            _TAS = tAS;
            _PCR = pCR;
            _BCVF = bCVF;
            _Fumator = fumator;
        }
   
        public AnalizePacient(string text) {
          
            string[] prop = text.Split('|');
        
            this._IdAnaliza = int.Parse(prop[0]);
            this._IdPacient = int.Parse(prop[1]);
            this._dataAnalize = DateTime.Parse(prop[2]);
            this._ColesterolTotal = int.Parse(prop[3]);
            this._HDL = int.Parse(prop[4]);
            this._TAS = int.Parse(prop[5]);
            this._PCR = int.Parse(prop[6]);
            this._BCVF = bool.Parse(prop[7]);
            this._Fumator = bool.Parse(prop[8]);
        
        }
    
        public int IdAnaliza {
        
            get { return _IdAnaliza;}
            set { _IdAnaliza = value;}

        }
    
        public int IdPacient
        {
            get { return _IdPacient;}
            set { _IdPacient = value;}
        }
    
        public DateTime DateAnalize
        {
            get { return _dataAnalize; }
            set { _dataAnalize = value;}
        }

        public int ColesterolTotal
        {
            get { return _ColesterolTotal; }
            set { _ColesterolTotal = value; }
        }

        public int HDL
        {
            get { return _HDL; }
            set { _HDL = value;}
        }

        public int TAS
        {
            get { return _TAS; }
            set { _TAS = value;}
        }

        public int PCR
        {
            get { return _PCR; }
            set { _PCR = value;}
        }

        public bool BCVF
        {
            get { return _BCVF; }
            set { _BCVF = value;}
        }

        public bool Fumator
        {
            get { return _Fumator; }
            set { _Fumator = value;}
        }

    }
}
