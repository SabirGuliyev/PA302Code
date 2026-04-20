using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismExample.Zoo
{
    internal class Cow:Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Moo");
        }

        public void ProduceMilk()
        {
            Console.WriteLine("Milk produced");
        }
       
    }
}
