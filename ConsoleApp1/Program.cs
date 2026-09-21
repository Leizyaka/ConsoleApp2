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