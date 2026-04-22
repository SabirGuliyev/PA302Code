using StaticExample.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticExample.Models
{
    internal class Person
    {
        public static int s_count=1000;
        public  int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

        public Person()
        {
            s_count++;
            Id = s_count;
        }
        public void PrintInfo()
        {
       
            Console.WriteLine($"{Name} {Surname} Id:{Id}");
            Console.WriteLine(Helper.OffMail);
        }













        //public static byte s_workAge = 18;

        //static   non-instance
        //static Person()
        //{
        //    //Console.WriteLine("Static ctor ishe dushdu");
        //}
        //non-static   instance  instanciated
        //public Person(string name, string surname)
        //{
        //    Console.WriteLine("Adi ctor");

        //    _name = Capitalize(name);
        //    _surname= Capitalize(surname);

        //}

        //non-static

     



    }


  
}
