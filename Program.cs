using Cukraszdanyilvantartas;

List<Sutemeny> Sutik=new List<Sutemeny>();

for (int i=0; i<4; i++)
{
    Sutemeny aktualis = new Sutemeny();
    Console.WriteLine($"{i+1}. sütemény adatai:");
    Console.Write($"\tNév:");
    aktualis.Nev = Console.ReadLine();
    Console.Write($"\tEgységár(Ft):");
    aktualis.Egysegar = int.Parse(Console.ReadLine());
    Console.Write($"\tRaktáron(db):");
    aktualis.RaktaronDb = int.Parse(Console.ReadLine());
    Console.WriteLine();

    Sutik.Add( aktualis );
}

Console.WriteLine("Pultban lévő sütemények:");
int teljes = 0;
for (int i=0; i<Sutik.Count;i++)
{
    int osszeg = 0;
    string statusz = "";
    osszeg = Sutik[i].Egysegar * Sutik[i].RaktaronDb;
    Console.WriteLine($"-{Sutik[i].Nev}: {Sutik[i].Egysegar} Ft/db ({Sutik[i].RaktaronDb}) -> Összérték: {osszeg}");
    teljes += osszeg;
}
