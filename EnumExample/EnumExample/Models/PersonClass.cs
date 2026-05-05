using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumExample.Models
{

    //internal class PersonClass(string Name, string Surname);
    //{
    //    public string Name { get; set; } = Name;
    //    public string Surname { get; set; } = Surname;
    //}
    internal class PersonClass
    {
        public const string WiFiPass="Salam123";

        public string Name { get; set; }
        public string Surname { get; set; }

        public string FinCode { get; init; }

        static PersonClass()
        {
        }
        

        //public Money Salary { get; set; }
    }
}
