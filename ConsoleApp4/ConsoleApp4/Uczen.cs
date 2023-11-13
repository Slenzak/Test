using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Uczen
    {
        public int idx;
        public string imie;
        public string nazwisko;
        public Uczen(string imie, string nazwisko,int idx)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.idx = idx;
        }
        public void InfoUCzen()
        {
            Console.WriteLine(imie+" "+nazwisko+" "+idx);
        }
    }
}