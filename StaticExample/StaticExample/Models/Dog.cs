using StaticExample.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticExample.Models
{
    internal class Dog
    {
        public string Name { get; set; }


        public Dog(string dogName)
        {
            Name=Helper.Capitalize(dogName);
            //Name=Person.Capitalize(dogName);
        }
    }
}
