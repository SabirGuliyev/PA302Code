using UpcastingExamples.Animals;
using UpcastingExamples.Models;
using UpcastingExamples.Utility.Extensions;

namespace UpcastingExamples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal eagle = new Eagle
            {
                AvgLifeTime = 10,
                ClawPower = 200,
                Gender = "male"
            };

            Animal animal = new Dog
            {
                AvgLifeTime = 10,
                Breed = "german shepard",
                Gender = "male"
            };



            

            Eagle test = (Eagle)eagle;//Explicit operator/ Explicit casting

            Console.WriteLine(test.ClawPower);






            //Animal animal = dog;//implicit casting/ implicit operator/Upcasting
















            

            //PetShop petShop = new PetShop();

            //petShop.Feed(dog);
            //petShop.Feed(eagle);













            //Animal[] animals = { dog, eagle };


            //foreach (Animal animal in animals) {

            //    animal.MakeSound();
            //    animal.Eat();
            //    Console.WriteLine("-------");
            //}











            //int[] arr = { 1, 2, 3, 4 };

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    arr[i]
            //}

            //string test = "salam";


            //foreach (char letter in test)
            //{
            //    Console.WriteLine(letter);
            //}

            //foreach (int num in arr)
            //{

            //    Console.WriteLine(num);
            //}

            //foreach(int num in arr)
            //{

            //}






            //PointClass pointClass = new PointClass { 
            //    X=5,
            //    Y=3
            //};

            //PointClass pointClass2 = null;
            ////Console.WriteLine(pointClass2.ToString());

            ////pointClass2.X = 10;



            ////Console.WriteLine(pointClass.X);


            //PointStruct pointStruct = new PointStruct
            //{
            //    X = 5,
            //    Y = 3
            //};
            //PointStruct pointStruct2 = pointStruct;

            //pointStruct2.X = 10;

            //Console.WriteLine(pointStruct.X);
            //Console.WriteLine(pointStruct2.X);



            //Console.WriteLine(pointClass.X);
            //Console.WriteLine(pointClass.Y);

            //Console.WriteLine("----------------");

            //Console.WriteLine(pointStruct.X);
            //Console.WriteLine(pointStruct.Y);












            //int number = 5;
            //int pow = 4;



            //Console.WriteLine(number.Power(pow));
            //Console.WriteLine(number.Power());





            //Person person = new Person("test", "testov");


            //person.Test();

            //Console.WriteLine("sAlaM".Capitalize());

            //PointClass pointClass = new PointClass
            //{
            //    X = 5,
            //    Y = 3
            //};

            //PointStruct pointStruct = new PointStruct
            //{
            //    X = 5,
            //    Y = 3
            //};


            //Test(pointClass);
            //Test(ref pointStruct);

        }

        //public static void Test(PointClass test)
        //{
        //    Console.WriteLine(test.X);
        //}
        //public static void Test(ref PointStruct test)
        //{
        //    Console.WriteLine(test.X);
        //}


    }
}
