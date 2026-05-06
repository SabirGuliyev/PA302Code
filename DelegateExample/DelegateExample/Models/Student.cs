using DelegateExample.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateExample.Models
{

    internal class Student
    {
        static int s_count = 0;
        public int Id { get; }
        public string Name { get; set; }
        public string Surname { get; set; }

        public Gender Gender { get; set; } 

        public Student(string name,string surname, Gender gender)
        {
            s_count++;
            Id=s_count;

            Name=name;
            Surname = surname;
            Gender=gender;
        }
    }
}
