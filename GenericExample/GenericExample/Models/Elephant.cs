using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericExample.Models
{
    internal class Elephant:Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Sound like elephant");
        }
    }
}
