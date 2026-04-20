using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismExample.Zoo
{
    internal class Dog:Animal
    {
        public void PlayWithHumans()
        {
            Console.WriteLine("Dog played");
        }

        public override void Eat()
        {
            Console.WriteLine("terevez, meyve, etler");
        }

        public override void MakeSound()
        {
            Console.WriteLine("Bark");
        }
    }
}
