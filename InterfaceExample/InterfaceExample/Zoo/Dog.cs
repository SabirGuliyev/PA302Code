using InterfaceExample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample.Zoo
{
    internal class Dog:Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Bark");
        }

        public override void Eat()
        {
            Console.WriteLine("Fruits, Vegetables, Meat");
        }
        public void PlayWithHuman()
        {
            Console.WriteLine("Plays with human");
        }
    }
}
