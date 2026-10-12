
int[] tablicaFibonacci = new int[40];
tablicaFibonacci[0] = 0;
tablicaFibonacci[1] = 1;
for (int i = 2; i < tablicaFibonacci.Length; i++)
{
    tablicaFibonacci[i] = tablicaFibonacci[i - 1] + tablicaFibonacci[i - 2];
}


for (int i = 0; i < tablicaFibonacci.Length; i++)
{
    Console.WriteLine(tablicaFibonacci[i] + " ");
}

for (int i = 0; i < tablicaFibonacci.Length; i++)
{
    Console.WriteLine("tablica["+i+"]= " + tablicaFibonacci[i]);
}

Console.WriteLine("podaj liczbę");
int liczbaWpisana = int.Parse(Console.ReadLine());
int gornaLiczba = 0, dolnaLiczba = 0;
for(int i = 0; i < tablicaFibonacci.Length; i++)
{
    if(liczbaWpisana > tablicaFibonacci[i])
    {
        continue;
    }
    else
    {
        gornaLiczba = tablicaFibonacci[i];
        dolnaLiczba = tablicaFibonacci[i - 1];
        break;
    }
}
Console.WriteLine("Dolna liczba"+dolnaLiczba);
Console.WriteLine("Twoja liczba to" + liczbaWpisana);
Console.WriteLine("Gorna liczba"+gornaLiczba);

if(liczbaWpisana - dolnaLiczba > gornaLiczba - liczbaWpisana)
{
    Console.WriteLine("blizej "+ gornaLiczba );
}
else
{
    Console.WriteLine("Dolna liczba" + dolnaLiczba);
}


