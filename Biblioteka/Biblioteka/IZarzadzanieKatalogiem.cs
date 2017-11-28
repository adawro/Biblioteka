using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteka
{
    interface IZarzadzanieKatalogiem
    {
        bool WyszukajPoTytule(string tytul);
        bool WyszukajPoID(int id);
        void WypiszWyszystko();
    }
}
