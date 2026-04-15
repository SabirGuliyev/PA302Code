using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationExample.Models
{
    internal class Person
    {
       public string Name;
       public string Surname;
        int Age;
        //private string FinCode;

        protected string FinCode;

        //Parameterless
        public Person(string name,string finCode)
        {
            Name = name;
            FinCode = finCode;

        }

        public Person()
        {
            
        }
        public void PrintInfo()
        {
            Console.WriteLine($"{Name} {Surname} {Age} {FinCode}");
        }
    }
}
