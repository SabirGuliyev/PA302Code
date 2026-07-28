using ConfigurationExample.Common;
using ConfigurationExample.Services;
using ConfigurationExample.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfigurationExample
{
    internal class ManagementApplication
    {
        private readonly ServiceInitializer _initializer;

        public ManagementApplication(ServiceInitializer initializer)
        {

            _initializer = initializer;
            _initializer.Initialize();
        }
        public void Run()
        {

            string answer;

            do
            {
                Console.WriteLine("1.Create Product\n\n0.Exit");
                answer = Console.ReadLine()?.Trim();

                switch(answer)
                {
                    case "1":
                        Console.Clear();
                        _initializer.ProductService.CreateProduct();
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Invalid option");
                        break;
                }

            } while (answer!="0");
            Console.WriteLine("Program ended");
        }
    }
}
