using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Dziennik
    {
        public Uczen uczen;
        public List<Przedmiot> przedmioty= new List<Przedmiot>();
        public Dziennik(Uczen uczen,List<Przedmiot> przedmioty) 
        {
            this.uczen = uczen;
            this.przedmioty = przedmioty;
        }
        public void addgrade(int pid)
        {
            Console.WriteLine("Podaj ocene");
            int ocena=Int32.Parse(Console.ReadLine());
            foreach(Przedmiot pr in przedmioty)
            {
                if(pr.id == pid)
                pr.grades.Add(ocena);
            }
        }
        public void avggrade(int pid) 
        {
            foreach(Przedmiot pr in przedmioty)
            {
                Console.WriteLine(pr.grades.Average());
            }
        }
    }
}