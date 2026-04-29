using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericExample.Models
{
    internal abstract class Animal
    {
        public string Name { get; set; }
        public int AvgLifeTime { get; set; }

        public abstract void MakeSound();

    }
}
