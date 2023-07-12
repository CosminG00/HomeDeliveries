using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectPAW25Forms
{
    public class Comenzi: Clienti, ICloneable, IComparable
    {
        private int idComanda;
        private string timpLivrare;
        private Facturi factura;
        private int cantitate;
        private float pretUnitate;
        private float total;

        public Comenzi() : base()
        {
            idComanda = 0;
            timpLivrare = "1 zi";
            factura = new Facturi();
            cantitate = 0;
            pretUnitate = 0;
            total = 0;
            
        }

        public Comenzi(string n, int v, string a, int id, int c, float p) : base(n,v,a)
        {
            idComanda = id;
            if (c < 5)
                timpLivrare = "2 zile";
            else
                timpLivrare = "3 zile";
            cantitate = c;
            pretUnitate = p;
            total = CalculTotal();
            factura = new Facturi();
        }

        public int IdComanda { get => idComanda; set => idComanda = value; }
        public string TimpLivrare { get => timpLivrare; set => timpLivrare = value; }
        public int Cantitate { get => cantitate; set => cantitate = value; }
        public float PretUnitate { get => pretUnitate; set => pretUnitate = value; }
        public float Total { get => total; set => total = value; }

        public float CalculTotal()
        {
            float rezultat = 0.0f;
            rezultat = this.cantitate * this.pretUnitate;
            return rezultat;
        }

        public object Clone()
        {
            Comenzi c = (Comenzi)MemberwiseClone();
            return c;
        }

        public int CompareTo(object obj)
        {
            Comenzi c = (Comenzi)obj;
            if (this.idComanda < c.idComanda)
                return -1;
            else
                if (this.idComanda > c.idComanda)
                return 1;
            else
                return 0;
         
        }

        public override string ToString()
        {
            return base.ToString() + " a facut comanda " + idComanda + " cu timpul de livrare de " + timpLivrare +
                ". Aceasta comanda cuprinde " + cantitate + " unitati de produs, produsul avand pretul per unitate de " +
                pretUnitate + ". Astfel totalul comenzii este de " + total + " .Factura atasata: " + factura;
        }

      
    }
}
