using InterfaceExample.Interfaces;
using InterfaceExample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample.Zoo
{
    internal class Eagle:Bird,IFly
    {
        public int ClawPower { get; set; }
        public int FlySpeed { get; set; }

        public void Fly()
        {
            Console.WriteLine("Flied away:"+FlySpeed);
        }

        public override void MakeSound()
        {
            Console.WriteLine("sounds like Eagle");
        }
    }
}
