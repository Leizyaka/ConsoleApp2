Console.WriteLine("Hello, World!");
//Tablica 6 wartosci losowych
//funkcja zwraca tablice a przekazujemy do niej liczbe elementow
int[] wylosujTablice(int liczbaElementow)
{
    int[] tablicaWylosowana = new int[liczbaElementow];
    Random random = new Random();
    for (int i = 0; i < tablicaWylosowana.Length; i++)
    {
        tablicaWylosowana[i] = random.Next(1, 100); 
    }

    return tablicaWylosowana;
}

void wypiszTablice(int[] tablicaDoWypisania)
{
    Console.WriteLine("Wylosowana tablica: ");
    for (int i = 0; i < tablicaDoWypisania.Length; i++) {
        Console.WriteLine(tablicaDoWypisania[i] + ", ");
}
}
int[] tablicaTestowa = wylosujTablice(10);
wypiszTablice(tablicaTestowa);

int[] wczytajLiczbyDoTablicy(int ileLiczb)
{
    int[] tablicaZKlawiatury = new int[ileLiczb];
    for (int i = 0; i < ileLiczb; i++)
    {
        Console.WriteLine("podaj liczbe " + i);
        tablicaZKlawiatury[i] = int.Parse(Console.ReadLine());

    }
    return tablicaZKlawiatury;
}
int[] tablicaWczytana = wczytajLiczbyDoTablicy(6);
wypiszTablice(tablicaWczytana);

List<int> WylosowanieLiczbBezPowtorzen(int ileLiczb)

{
    List<int> listaLiczbLosowych = new List<int>();

    Random random = new Random();
    for (int i = 0; i < ileLiczb; i++) {
        int liczba = random.Next(1, 10);
        while (listaLiczbLosowych.Contains(liczba))
        {
            listaLiczbLosowych.Add(liczba);
        }
    }
    return listaLiczbLosowych;
}
void wypiszListe(List<int> listaLiczb)
{

    Console.WriteLine();
    Console.WriteLine("Lista: ");


    for (int i = 0; i < listaLiczb.Count ; i++)
    {
        Console.WriteLine(listaLiczb[i] + ", ");
    }
}
List<int> wylosowane = WylosowanieLiczbBezPowtorzen(7);
wypiszListe(wylosowane);

HashSet<int> wylosujLiczbeBezPowtorzen(int ileLiczb)
{
    HashSet<int> zbiorlosowych = new HashSet<int>();
    Random random = new Random();
    while(zbiorlosowych.Count<ileLiczb)
    {
        zbiorlosowych.Add(random.Next(1, 10));
    }
    return zbiorlosowych;
}

void wypiszZbior(HashSet<int> zbiorLiczb)
{
    Console.WriteLine();
    Console.WriteLine("Zbior: ");

   
    foreach (int element in zbiorLiczb)
    {
        Console.WriteLine(element);
    }

}
HashSet<int> wylosowanyZbior = wylosujLiczbeBezPowtorzen(7);
wypiszZbior(wylosowanyZbior)