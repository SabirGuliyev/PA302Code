using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismExample.Zoo
{
    internal abstract class Animal
    {

        public string Name { get; set; }
        public double AvgLifeTime { get; set; }
        public string Gender { get; set; }
        protected Animal()
        {
            Console.WriteLine("Animal created");
        }
        public virtual void Eat()
        {
            Console.WriteLine("Grass");
        }

        public abstract void MakeSound();
    }
}
