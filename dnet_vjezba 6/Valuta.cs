using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dnet_vjezba_6 
{
    class Valuta : IIspis, IComparable<Valuta>
    {
        public string Naziv;
        public double Tecaj;

public int CompareTo(Valuta other)
        {
            return this.Tecaj.CompareTo(other.Tecaj);
        }

        public string Ispis()
        {
            return $"Naziv valute: {this.Naziv.ToUpper()}, tečaj prema USD je {this.Tecaj}!";
        }
    }
}
