using ConsoleApp4;

internal class Program
{
    private static void Main(string[] args)
    {
        Uczen jan = new Uczen("Jan","Kowal",3);
        jan.InfoUCzen();
        List<int> oceny = new List<int>();
        oceny.Add(3);
        oceny.Add(5);
        oceny.Add(6);
        Przedmiot matma = new Przedmiot(1, "Matematyka", oceny);
        matma.ShowGrades();
        List<Przedmiot> przedmioty = new List<Przedmiot>();
        przedmioty.Add(matma);
        Dziennik Sp2 = new Dziennik(jan,przedmioty);
        Sp2.addgrade(1);
        Sp2.avggrade(1);
    }
}