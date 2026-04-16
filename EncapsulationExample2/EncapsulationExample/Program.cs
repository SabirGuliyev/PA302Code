using EncapsulationExample.Models;

namespace EncapsulationExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user = new User("Test","Testov","Salam123");


            user.Password= "password";

            //user.UserName = "Killer71";
            //user.Name = "sa1";
            //string a = user.Name;

            Console.WriteLine(user.UserName);
            Console.WriteLine(user.Password);









            //user.PrintInfo();

        }
    }
}
