using GenericExample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Generic Product
            //Product<int> product = new Product<int>(80);



            //Console.WriteLine(product.Quality);




            //Product<char> product2 = new Product<char>('A');


            //Product<string> product3 = new Product<string>("High");

            //product3.Quality.ToUpper();





            // Product local = new Product { 
            //     Quality=80
            // };

            //local.Quality= (int)local.Quality + 5;


            // Product europe=new Product { 
            //     Quality= 'A'
            // };


            // Product america = new Product
            // {
            //     Quality = "High"
            // }; 
            #endregion

            #region Generic Zoo
            //Lion lion = new Lion
            //{
            //    AvgLifeTime = 20,
            //    Name = "Simba"
            //};
            //Lion lion2 = new Lion
            //{
            //    AvgLifeTime = 20,
            //    Name = "GS"
            //};



            //Student student = new Student { Name = "Tunar" };


            //ZooCage<Lion, Meat> zooCage = new ZooCage<Lion, Meat>();

            //zooCage.Add(lion);
            //zooCage.Add(lion2);

            //Meat meat = new Meat { Type = "Beef" };
            //zooCage.Food = meat;

            //zooCage.ShowAnimals();



            //Console.WriteLine("-----------------------");



            //Elephant elephant = new Elephant
            //{
            //    AvgLifeTime = 70,
            //    Name = "Dumbo"
            //};

            //Elephant elephant2 = new Elephant
            //{
            //    AvgLifeTime = 70,
            //    Name = "Timon"
            //};


            //ZooCage<Elephant, Grass> zooCage2 = new ZooCage<Elephant, Grass>();

            //zooCage2.Add(elephant);
            //zooCage2.Add(elephant2);

            //Grass grass = new Grass { IsLegal = false };
            //zooCage2.Food = grass;

            //zooCage2.ShowAnimals();



            //Console.WriteLine("--------------------");

            //ZooCage<Student> zooCage3 = new ZooCage<Student>();
            //ZooCage<int> zooCage4 = new ZooCage<int>();


            ;


            //zooCage3.Add(student);
            //zooCage3.ShowAnimals();

            #endregion


            List<int> numbers = new List<int>();

            numbers.Add(1);
            numbers.Add(2);
            numbers.Add(3);
            numbers.Add(4);
            numbers.Add(5);
            //numbers.Remove(1);


            //{1,2,3} {1,2,3,4}
            //{} {1,2,3,4} {1,2,3,4 5,0,0,0,0,0,0,0}
            //Capacity=4*2
            for (int i = 0; i < numbers.Count; i++)
            {
                Console.WriteLine(numbers[i]);
            }



        }
    }
}
