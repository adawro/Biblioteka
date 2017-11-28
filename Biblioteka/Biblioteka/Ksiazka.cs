using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteka
{
    class Ksiazka:Pozycja
    {
        private int liczbaStron;
        private Autor autor;
        public Ksiazka() { }
        public Ksiazka(string tytul, int id, string wydawnictwo, int rokWydania,int liczbaStron,Autor autor)
            :base(tytul,id,wydawnictwo,rokWydania)
        {
            this.autor = autor;
            this.liczbaStron = liczbaStron;
        }
        public override void WypiszInfo()
        {
            Console.WriteLine("ID: {0}\nTytul: {1}\nWydawnictwo: {2}\nRok wydania: {3}\nLiczba stron: {4}", id, tytul, wydawnictwo, rokWydania, liczbaStron);
            Console.WriteLine("AUTOR");
            autor.WypiszInfo();
        }
    }
}
