using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample.Models
{
    internal class Bicycle : Vehicle
    {
        public string Type { get; set; }
        public override void DefineNatureHarmness()
        {
            Console.WriteLine("None");
        }

        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine(Type);
        }
    }
}
