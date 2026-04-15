
namespace EncapsulationExample.Models
{
    internal class Student: Person
    {

        public int Point;
        public bool IsGraduated;


        public Student()
        {
            Name = "Test";
            FinCode = "dasdsa";
        }









        //public Student(string name, string surname, int age, int point)
        //{
        //    Name = name;
        //    Surname = surname;
        //    Age = age;
        //    Point = point;

        //    IsGraduated = point >= 65;

        //    //if (Point >= 65)
        //    //{
        //    //    IsGraduated = true;
        //    //}
           
        //}

        //public void PrintInfo()
        //{
        //    Console.WriteLine($"{Name} {Surname} {Age} {Point} {IsGraduated}");
        //}

        //public void CheckGraduation()
        //{
        //    if (IsGraduated)
        //    {
        //        Console.WriteLine("Mezun olub");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Mezun deyil");
        //    }
        //}

        //public void GetDiplomDegree()
        //{
        //    if(Point>=65 && Point < 85)
        //    {
        //        Console.WriteLine("Adi diplom");
        //    }
        //    else if(Point >=85 && Point < 95)
        //    {
        //        Console.WriteLine("Honor diplom");
        //    }
        //    else if(Point >=95 && Point <= 100)
        //    {
        //        Console.WriteLine("High Honor diplom");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Yoxdur");
        //    }
        //}
    }
}
