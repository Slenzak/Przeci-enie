using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Przeciążenie
{
    internal class Magazyn
    {
        public string Nazwa { get; set; }
        public List<Produkt> Produkty { get; set; }

        public Magazyn(string nazwa)
        {
            Nazwa = nazwa;
            Produkty = new List<Produkt>();
        }

        public void DodajProdukt(Produkt produkt)
        {
            Produkty.Add(produkt);
        }

        public void WyświetlProdukty()
        {
            foreach (var produkt in Produkty)
            {
                produkt.WyświetlInformacje();
            }
        }

        public void SortujProdukty()
        {
            Produkty.Sort((a, b) => a.Cena.CompareTo(b.Cena));
        }
    }
}

