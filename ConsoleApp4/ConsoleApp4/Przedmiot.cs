using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Przedmiot
    {
        public int id;
        public string name;
        public List<int> grades=new List<int>();
        public Przedmiot(int id,string name,List<int> grades)
        {
            this.id = id;
            this.name = name;
            this.grades = grades;
        }
        public void ShowGrades()
        {
            foreach(int grade in this.grades)
            {
                Console.WriteLine(grade);
            }
        }
    }

}
