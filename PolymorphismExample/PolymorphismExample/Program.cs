using PolymorphismExample.Models;
using PolymorphismExample.Zoo;

namespace PolymorphismExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Student student = new Student(){ 
            //    Name="Hamid",
            //    Surname="Testov",
            //    Age=25,
            //    Group="PA302",
            //    UniName="ADA"
            //};

            ////student.PrintInfo();


            ////Console.WriteLine("-----------------");
            //Police police = new Models.Police();
            

            //Person person = new Person()
            //{
            //    Name = "Mammadali",
            //    Surname = "Testov2",
            //    Age = 30
            //};
            //Person person2 = new Person()
            //{
            //    Name = "Tunar",
            //    Surname = "Testov2",
            //    Age = 30
            //};


            //Console.WriteLine(person);
            //Console.WriteLine(person2);
            //Console.WriteLine(student);


            //person.PrintInfo();

            //Person[] people = { person, student };

            //for (int i = 0; i < people.Length; i++)
            //{
            //    Console.WriteLine("----------------------");
            //    people[i].PrintInfo();
            //}






            Dog dog = new Dog { 
                AvgLifeTime=10,
                Gender="male",
                Name="Maximus Prime"
            };

            Cow cow = new Cow
            {
                AvgLifeTime = 15,
                Gender = "female",
                Name = "Xalli"
            };


            dog.MakeSound();
            cow.MakeSound();

            Animal[] animals = {dog,cow};

            for (int i = 0; i < animals.Length; i++)
            {

                Console.WriteLine(animals[i].Name);
                animals[i].Eat();

                animals[i].MakeSound();
                Console.WriteLine("-----------------");

            }
          


          








        }


       
    }
}
