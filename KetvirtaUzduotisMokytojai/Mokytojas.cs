using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KetvirtaUzduotisMokytojai
{
    internal class Mokytojas
    {
        private string vardas;
        private string pavarde;
        private string klase;
        private string pareigos;
        private int stazas;
        private string issivavinimas;

        public Mokytojas(string vardas, string pavarde, string klase, string pareigos, int stazas, string issivavinimas)
        {
            this.vardas = vardas;
            this.pavarde = pavarde;
            this.klase = klase;
            this.pareigos = pareigos;
            this.stazas = stazas;
            this.issivavinimas = issivavinimas;
        }

        public Mokytojas()
        {
        }

        public string Vardas
        {
            get { return vardas; }
            set { vardas = value; }
        }
        public string Pavarde
        {
            get { return pavarde; }
            set { pavarde = value; }
        }
        public string Klase
        {
            get { return klase; }
            set { klase = value; }
        }
        public string Pareigos
        {
            get { return pareigos; }
            set { pareigos = value; }
        }
        public int Stazas
        {
            get { return stazas; }
            set { stazas = value; }
        }
        public string Issilavinimas
        {
            get { return issivavinimas; }
            set { issivavinimas = value; }
        }
    }
}
