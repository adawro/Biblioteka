using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteka
{
    class Czasopismo:Pozycja
    {
        private int numer;
        public Czasopismo() { }
        public Czasopismo (string tytul, int id, string wydawnictwo, int rokWydania,int numer)
            :base(tytul,id,wydawnictwo,rokWydania)
        {
            this.numer = numer;
        }
        public override void WypiszInfo()
        {
            Console.WriteLine("Numer: {0}\nID {1}\nTytul: {2}\nWydawnictwo {3}\nRok Wydania {4}", numer, id, tytul, wydawnictwo, rokWydania);
        }

    }
}
