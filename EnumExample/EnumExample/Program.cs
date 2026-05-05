using EnumExample.Models;
using EnumExample.Utilities.Enums;

namespace EnumExample
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Please chose day of week:");

            foreach (WeekDay day in Enum.GetValues(typeof(WeekDay)))
            {
                Console.WriteLine($"{(int)day}.{day}");
            }

            int choice;
            string str=Console.ReadLine();

            int.TryParse(str, out choice);


            switch (choice)
            {
                case (int)WeekDay.Monday:
                    Console.WriteLine(WeekDay.Monday);
                    break;
                case (int)WeekDay.Tuesday:
                    Console.WriteLine(WeekDay.Tuesday);
                    break;
                case (int)WeekDay.Wednesday:
                    Console.WriteLine(WeekDay.Wednesday);
                    break;
                case (int)WeekDay.Thursday:
                    Console.WriteLine(WeekDay.Thursday);
                    break;
                case (int)WeekDay.Friday:
                    Console.WriteLine(WeekDay.Friday);
                    break;
                case (int)WeekDay.Saturday:
                    Console.WriteLine(WeekDay.Saturday);
                    break;
                case (int)WeekDay.Sunday:
                    Console.WriteLine(WeekDay.Tuesday);
                    break;

                default:
                    Console.WriteLine("Wrong input");
                    break;
            }


      







            //PersonClass.WiFiPass = "Test";
            //Console.WriteLine("Salam123");
            //Console.WriteLine(Math.PI);


            //Console.WriteLine(123);

            //Money money = new Money (500,"AZN");

            //money = money with { Amount= };

            //Console.WriteLine(money);

            //money.Amount = 300000;



            //money = new Money(300, "USD");

            //money = new(500, "USD");











            //PersonClass person=new PersonClass { Name="Test",Surname="Testov", Salary=500, Currency="AZN"};

            //person.Salary = 100000;



            //PersonClass person2=new PersonClass("Salam","bdksbad");

            //person2.Name = "Salam";

            ////Console.WriteLine(person==person2);
            //Console.WriteLine(person);

            //Console.WriteLine("-----------------");

            //PersonRecord record=new PersonRecord("Salam","Testov");

            //PersonRecord record2=new("Test","Testov");

            //record2.Name = "Sabir";

            //Console.WriteLine(record);

            //Console.WriteLine(record==record2);
        }
    }
}
