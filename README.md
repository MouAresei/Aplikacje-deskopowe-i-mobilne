# Aplikacje-deskopowe-i-mobilne

int ileKostekRzucic = 0;
int iloscPunktow = 0;
string czyRzucicPonownie = "";


while (ileKostekRzucic < 3 || ileKostekRzucic > 10)
{
    Console.WriteLine("Ile kostek chcesz rzucić?(3-10)");
    ileKostekRzucic = Convert.ToInt32(Console.ReadLine());
}

do
{
    int[] tabOczek = new int[Convert.ToInt32(ileKostekRzucic + 1)];
    for (int i = 1; i <= Convert.ToInt32(ileKostekRzucic); i++)
    {
        int iloscOczek = wygenerujLosowyInt();
        tabOczek[i] = iloscOczek;
        Console.WriteLine($"Kostka " + i + ": " + iloscOczek);
    }

    Console.WriteLine($"Suma punktów: " + sumujPunkty(tabOczek));
    Console.WriteLine("Jeszcze raz? (t/n)");
    czyRzucicPonownie = Console.ReadLine();
}
while (czyRzucicPonownie != "n");


int wygenerujLosowyInt()
{
    int iloscOczek = 0;
    Random rand = new Random();
    iloscOczek = rand.Next(1, 7);

    return iloscOczek;
}

/*
Nazwa: wygenerujLosowyInt
Opis: Generuje pseudolosowy int z przedzialu 1 do 6

Zwracany typ i opis: Zwraca wygenerowana liczbe w postaci intigera
Autor: Ernest Kłak
 */

int sumujPunkty(int []tab)
{
    Array.Sort(tab);
    int suma = 0;
    for(int i = 0; i <= tab.Length; i++)
    {
        int licznik = 0;
        for (int indexKostki = 0; indexKostki < tab.Length; indexKostki++)
        {
            if (tab[indexKostki] == i)
                licznik++;
        }
        if (licznik > 1)
            suma += i * licznik;
    }

    return suma;
}

/*
 Nazwa: sumujPunkty
 Opis: Sumuje powtarzajace sie cyfry i dodaje je do sumy;
 Parametry: parametr int []tab przyjmuje tablice intigerow
 Zwracany typ i opis: Zwraca sume ogolna w postaci intigera
 Autor: Ernest Kłak
 */


