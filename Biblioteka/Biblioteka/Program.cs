using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteka
{
    class Program
    {
        static void Main(string[] args)
        {
            Autor autor_1 = new Autor("adam", "Kowalski", "Polak");
            Autor autor_2 = new Autor("Karol", "kaka","Amerykanin");
            Ksiazka ksiazka_1 = new Ksiazka("Dzieci", 0, "Polska", 1999, 200, autor_1);
            Ksiazka ksiazka_2 = new Ksiazka("Mama I tata", 1, "ZIP", 1945, 200, autor_1);
            Ksiazka ksiazka_3 = new Ksiazka("Dzieci z Domu dziecka", 2, "Herkules", 1956, 2540, autor_2);
            Katalog katalog_1 = new Katalog("Lektury");
            Czasopismo czasopismo1 = new Czasopismo("Agora", 0, "HISTORY", 2018, 123456789);
            katalog_1.DodajPozycje(ksiazka_1);
            katalog_1.DodajPozycje(ksiazka_2);
            katalog_1.DodajPozycje(ksiazka_3);
            czasopismo1.WypiszInfo();
            // wypisanie wszystkiego
            katalog_1.WypiszWyszystko();

            //szukanie po id
            if (katalog_1.WyszukajPoID(4))
                Console.WriteLine("jest taka ksiazka z takim id");
            else 
                Console.WriteLine("Nie ma takeigo ID");
                if (katalog_1.WyszukajPoTytule("Dzieci"))
                Console.WriteLine("jest taka ksiazka z takim tytulem");
            else 
            Console.WriteLine("Nie ma takiego tytulu");
            Console.ReadKey();
        }
    }
}
