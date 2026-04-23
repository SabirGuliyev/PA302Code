using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpcastingExamples.Animals
{
    internal abstract class Animal
    {
        public int AvgLifeTime { get; set; }

        public string Gender { get; set; }

        public abstract void MakeSound();

        public virtual void Eat()
        {
            Console.WriteLine("grass");
        }
    }
}
