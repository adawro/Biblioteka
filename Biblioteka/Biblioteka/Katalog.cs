using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteka
{
    class Katalog:IZarzadzanieKatalogiem
    {
        private string DzialTematyczny;
        List<Pozycja> listaPozycji = new List<Pozycja>();
        public Katalog() {}
        public Katalog (string DzialTematyczny)
        {
            this.DzialTematyczny = DzialTematyczny;
        }
        public void DodajPozycje(Pozycja pozycja)
        {
            listaPozycji.Add(pozycja);
        }


        public bool WyszukajPoTytule(string tytul)
        {
            foreach (var p in listaPozycji)
            {
                if (p.Tytul == tytul) return true;
            }
            return false;
        }

        public bool WyszukajPoID(int id)
        {
            foreach (var p in listaPozycji)
            {
                if (p.Id == id)
                    return true;
            }
            return false;
        }

        public void WypiszWyszystko()
        {
            foreach (var pozycja in listaPozycji)
            {
                pozycja.WypiszInfo();
            }
        }
    }
}
