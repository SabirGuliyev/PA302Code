using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample.Zoo
{
    internal abstract class Animal
    {
        public int AvgLifeTime { get; set; }
        public string Gender { get; set; }
        public string Name { get; set; }

        public virtual void Eat()
        {
            Console.WriteLine("Grass");
        }

        public abstract void MakeSound();

    }
}
