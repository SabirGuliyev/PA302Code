using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample.Models
{
    internal class Car : Vehicle
    {
        public int DoorCount { get; set; }
        public bool IsElectricCar { get; set; }
        public override void DefineNatureHarmness()
        {
            if (IsElectricCar)
            {
                Console.WriteLine("Low");
            }
            else
            {
                Console.WriteLine("High");
            }
        }

        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine($"{DoorCount} {IsElectricCar}");
        }
    }
}
