using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectPAW25Forms
{
    public class Clienti: ICloneable
    {
        private string nume;
        private int varsta;
        private string adresa;
        

        public Clienti()
        {
            nume = "Andrei";
            varsta = 25;
            adresa = "Drumul Fermei 10";
            
        }
        public Clienti(string n, int v, string a)
        {
            nume = n;
            varsta = v;
            adresa = a;
        }

        public string Nume { get => nume; set => nume = value; }
        public int Varsta { get => varsta; set => varsta = value; }
        public string Adresa { get => adresa; set => adresa = value; }
        

        public object Clone()
        {
            Clienti clona =(Clienti)MemberwiseClone();
            return clona;

        }
        
        public override string ToString()
        {
            string rezultat = "Clientul " + nume + " cu varsta " + varsta + " si adresa " + adresa;        
            return rezultat;

        }

    }
}
