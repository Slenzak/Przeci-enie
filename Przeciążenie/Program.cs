using Przeciążenie;

internal class Program
{
    static void Main(string[] args)
    {
        Produkt produkt1 = new Produkt("Produkt1", 100.0m, 5);
        Produkt produkt2 = new Produkt("Produkt2", 200.0m, 10);

        produkt1.WyświetlInformacje();
        produkt2.WyświetlInformacje();

        Console.WriteLine($"Czy cena produktu1 jest mniejsza od ceny produktu2? {produkt1 < produkt2}");
        Console.WriteLine($"Czy cena produktu1 jest większa od ceny produktu2? {produkt1 > produkt2}");

        Console.WriteLine($"Zwiększamy ilosc produktu1");
        ++produkt1;
        produkt1.WyświetlInformacje();

        Console.WriteLine($"Zmniejszamy ilosc produktu2");
        --produkt2;
        produkt2.WyświetlInformacje();
        Magazyn magazyn = new Magazyn("Moj Magazyn");

        magazyn.DodajProdukt(new Produkt("Produkt1", 100m, 5));
        magazyn.DodajProdukt(new Produkt("Produkt2", 200m, 10));
        magazyn.DodajProdukt(new Produkt("Produkt3", 50m, 20));

        magazyn.WyświetlProdukty();

        magazyn.SortujProdukty();

        magazyn.WyświetlProdukty();
        Console.WriteLine("Pierwsza Macierz");
        Macierz a = new Macierz(3, 3);
        a.Inicjalizuj(1);
        a.Wyświetl();
        Console.WriteLine("Druga Macierz");
        Macierz b = new Macierz(3, 3);
        b.Inicjalizuj(2);
        b.Wyświetl();
        Console.WriteLine("Dodane Macierze");
        Macierz c = a + b;
        c.Wyświetl();
        Console.WriteLine("Odjete Macierze");
        Macierz d = a - b;
        d.Wyświetl();
        Console.WriteLine("Pomnozone Macierze");
        Macierz e = a * b;
        e.Wyświetl();
        Console.WriteLine("Pierwsza macierz zinkrementowana o 2");
        Macierz f = ++a;
        f.Wyświetl();
        Console.WriteLine("Druga macierz zdekrementowana o 2");
        Macierz g = --b;
        g.Wyświetl();
    }
}