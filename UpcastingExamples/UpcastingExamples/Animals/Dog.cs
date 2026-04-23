using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpcastingExamples.Animals
{
    internal class Dog : Animal
    {
        public string Breed { get; set; }
        public override void MakeSound()
        {
            Console.WriteLine("Bark");
        }

        public override void Eat()
        {
            Console.WriteLine("Meat");
        }
    }
}
