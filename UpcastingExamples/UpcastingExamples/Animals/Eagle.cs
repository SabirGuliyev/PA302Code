using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpcastingExamples.Animals
{
    internal class Eagle : Animal
    {
        public int ClawPower { get; set; }
        public override void MakeSound()
        {
            Console.WriteLine("sound like eagle");
        }
    }
}
