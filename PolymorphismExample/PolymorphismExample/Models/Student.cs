using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismExample.Models
{
    internal class Student:Person
    {
        public string Group { get; set; }
        public string UniName { get; set; }


        public Student()
        {

        }
        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"{Group} {UniName}");
        }


    }
}
