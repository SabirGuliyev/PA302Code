using InterfaceExample.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample.Zoo
{
    internal class Penguin : Bird, ISwim
    {
        public int SwimSpeed { get; set; }

        public override void MakeSound()
        {
            Console.WriteLine("sounds like penguin");
        }

        public void Swim()
        {
            Console.WriteLine("Swam away:"+SwimSpeed);
        }
    }
}
