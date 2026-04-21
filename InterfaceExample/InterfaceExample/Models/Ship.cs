using InterfaceExample.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample.Models
{
    internal class Ship : ISwim
    {
        public int SwimSpeed { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Swim()
        {
            throw new NotImplementedException();
        }
    }
}
