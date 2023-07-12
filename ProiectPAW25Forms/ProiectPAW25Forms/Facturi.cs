using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectPAW25Forms
{
    public class Facturi: ICloneable, IComparable
    {
        private int id_factura;
        private string furnizor;

        public Facturi()
        {
            id_factura = 0;
            furnizor = "Anonim";
        }
        public Facturi(int id, string f)
        {
            id_factura = id;
            furnizor = f;
        }

        public int Id_factura
        {
            get { return id_factura; }
            set { if (value > 0) id_factura = value; }
        }
        public string Furnizor
        { 
            get { return furnizor; }
            set { if (value != null) furnizor = value; }
        }

        public object Clone()
        {
           return this.MemberwiseClone();
        }

        public int CompareTo(object obj)
        {
            Facturi f = (Facturi)obj;
            if (this.id_factura < f.id_factura)
                return -1;
            else
                if (this.id_factura > f.id_factura)
                return 1;
            else
                return string.Compare(this.furnizor, f.furnizor);
        }

        public override string ToString()
        {
            string s = "Factura " + id_factura + " provine de la furnizorul " + furnizor;
            return s;
        }

    }

}
