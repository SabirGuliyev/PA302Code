using InterfaceExample.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample.Zoo
{
    internal class Duck : Bird, IFlySwim
    {
        //public int SwimSpeed { get ; set ; }
        //public int FlySpeed { get ; set ; }

        //public void Fly()
        //{
        //    Console.WriteLine("Duck flied");
        //}

        public override void MakeSound()
        {
            Console.WriteLine("Gagk");
        }

        //public void Swim()
        //{
        //    Console.WriteLine("Duck swam");
        //}
        public int FlySpeed { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int SwimSpeed { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Fly()
        {
            throw new NotImplementedException();
        }

        public void Swim()
        {
            throw new NotImplementedException();
        }
    }
}
