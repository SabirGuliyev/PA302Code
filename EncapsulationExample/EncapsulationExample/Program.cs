
using EncapsulationExample.Models;

namespace EncapsulationExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 5;

            a = 10;
            Console.WriteLine(a);
            #region Class Task Solution
            //Student student = new Student("Shirin","Alizade",22,85);

            //student.PrintInfo();
            //student.CheckGraduation();
            //student.GetDiplomDegree(); 
            #endregion

            Person person = new Person("Sabir","ssdjhsavb");

            person.Name = ",nalksd.m";
            Console.WriteLine(person.FinCode);
            person.PrintInfo();











            //person.Name = "sjkahdaks";

            //Teacher teacher = new Teacher("Sabir");

            //Student student = new Student("Shirin");


            //teacher.Name = "Sabir";
            //teacher.Surname = "Guliyev";
            //teacher.Age = 27;
            //teacher.Experience = 4;
            //teacher.Salary = 76543.12m;

            //Console.WriteLine(teacher.Salary+" "+teacher.Name);


            //Student student=new Student();
            //student.Age = 27;
            //student.Name = "Shirin";



        }
    }



}
