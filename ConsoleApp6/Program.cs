
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
Console.WriteLine();
Random random = new Random();
List<int> wylosowane = new List<int>();
for (int i = 0; i < 30; i++){
    wylosowane.Add(random.Next(50, 101));
}
for(int i = 0; i < 30; i++)
{
    Console.WriteLine( wylosowane[i]+ "**");
}
HashSet<int> uzbiorWylosowanych = new HashSet<int>(wylosowane);
foreach(int wartosc in uzbiorWylosowanych)
{
    Console.Write(wartosc+" == ");
}

HashSet<int> zbior2 = new HashSet<int>();
for(int i = 0; i < 30; i++)
{
    zbior2.Add(wylosowane[i]);
}
Console.WriteLine();
foreach (int wartosc in zbior2)
{
    Console.WriteLine(wartosc + " wystąpiła " + policz(wartosc, wylosowane) + " razy");
}

int policz(int wartosc, List<int> lista)
{
    int ile = 0;
    for(int i = 0; i < lista.Count; i++)
    {
        if (lista[i] == wartosc)
        {
            ile++;
        }
    }
    return ile;
}

