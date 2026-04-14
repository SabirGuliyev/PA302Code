namespace ClassObjectExample
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //string name = "Jamal";
            //string surname = "Agazade";
            //byte age = 20;

            //string name2 = "Nigar";
            //string surname2 = "Aligayeva";
            //byte age2 = 24;


            //Console.WriteLine(name+surname2);

            //var a = "Salam";


            //int b = 30;



            //var person = new
            //{
            //    Name = "Jamal",
            //    Surname = "Agazade",
            //    Age = 20
            //};


            //var person2 = new
            //{
            //    FullName = "Nigar Aligayeva",
            //    Date = "09.09.2000",
            //    FinCode = "bsakdaksd"

            //};

            //Console.WriteLine(person.Name+" "+person.Surname+" "+person.Age);


            //Person person = new Person("Jamal","Agazade",20);
            //Person person2 = new Person("Jamal","Agazade");
            //person.PrintInfo();




            //Person person3 = new Person("Jamal","Agazade");


            //Person person2 = new Person
            //{
            //    Name = "Nigar",
            //    Surname = "Aligayeva",
            //    Age = 24
            //};


            //person2.PrintInfo();



            Person person2=new Person("Jamal");
            person2.PrintInfo();
            Person person3=new Person("Nigar","Agazade");
            person3.PrintInfo();
            Person person4=new Person("Ali", "Agazade",20);
            person4.PrintInfo();

        }



    }

    class Person
    {
        //Field
        public string Name;
        public string Surname;
        public byte Age;

        //Constructor
        public Person()
        {
            Console.WriteLine("Person created");
        }
        public Person(string name):this()
        {
            Name = name;
        }
        public Person(string name,string surname):this(name)
        {
            Surname = surname;
        }
        public Person(string name, string surname, byte age):this(name, surname)
        {
            Age = age;
        }
        //Method
        public void PrintInfo()
        {
            Console.WriteLine($"Name:{Name}  Surname:{Surname}  Age:{Age}");
        }



    }


}
