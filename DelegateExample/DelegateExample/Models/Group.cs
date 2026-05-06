using DelegateExample.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateExample.Models
{
    internal class Group
    {
        static int s_groupCount = 0;

        private Student[] _students=new Student[0];

        public Student[] Students
        {
            get { return _students; }
            set { _students = value; }
        }


        public int GroupId { get; set; }
        public string Name { get; set; }

        public GroupType GroupType { get; set; }


        public Group(string name, GroupType groupType)
        {
            s_groupCount++;
            GroupId=s_groupCount;

            Name=name;
            GroupType=groupType;
        }


        public void Add(Student student)
        {
            Array.Resize(ref _students, Students.Length + 1);
            Students[Students.Length-1]=student;
        }

        public void ShowStudents() {
            foreach (Student student in Students)
            {
                Console.WriteLine(student.Name+" "+student.Surname);
            }
        }

        public void Delete(int id)
        {

            Student[] newArr = new Student[Students.Length-1];
            int j = 0;
 
            for (int i=0; i<Students.Length; i++)
            {
                if (Students[i].Id != id)
                {
                    newArr[j] = Students[i];
                    j++;
                }
            }
            Students= newArr;
        }


        public void Search(string search)
        {

            search = search.ToLower();
            foreach (Student student in Students)
            {
                
                if (student.Name.ToLower().Contains(search) || student.Surname.ToLower().Contains(search))
                {
                    Console.WriteLine(student.Id+" "+student.Name);
                    
                }
            }
        }

    }
}
