using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationExample.Models
{
    internal class Teacher:Person
    {

        public decimal Salary;
        public int Experience;

        public Teacher()
        {
          
            //Person person = new Person();
            //person.FinCode = "slndalkd";
        }

        //public Teacher(string name):base(name)
        //{


        //}
    }
}
