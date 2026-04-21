using InterfaceExample.Interfaces;
using InterfaceExample.Models;
using InterfaceExample.Zoo;

namespace InterfaceExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Car car = new Car {
            //    FactoryName="Test",
            //    Model="Test123",
            //    Color="black",
            //    DoorCount=4,
            //    DrivePath=3000,
            //    DriveTime=200,
            //    IsElectricCar=true
            //};

            //Car car2 = new Car
            //{
            //    FactoryName = "Mercedes",
            //    Model = "B200",
            //    Color = "White",
            //    DoorCount = 4,
            //    DrivePath = 4000,
            //    DriveTime = 210,
            //    IsElectricCar = false
            //};

            //Bicycle bicycle = new Bicycle
            //{
            //    FactoryName = "banan",
            //    Model = "forward",
            //    Color = "brown",
            //    Type = "manual",
            //    DrivePath = 1000,
            //    DriveTime = 50
            //};



            //car.GetInfo();
            //car.DefineNatureHarmness();
            //car.AverageSpeed();

            //Console.WriteLine("----------------");

            //car2.GetInfo();
            //car2.DefineNatureHarmness();
            //car2.AverageSpeed();

            //Console.WriteLine("--------------------");
            //bicycle.GetInfo();
            //bicycle.DefineNatureHarmness();
            //bicycle.AverageSpeed();


            Eagle eagle = new Eagle { 
                Name="test",
                AvgLifeTime=30,
                ClawPower=10,
                Gender="female",
                FlySpeed=100,
                HasEgg=true
            };


            //eagle.Fly();



            Plane plane = new Plane();
            plane.FlySpeed = 500;



            Penguin penguin = new Penguin
            {
                Name = "test",
                AvgLifeTime = 30,
                Gender = "female",
                HasEgg = true,
                SwimSpeed=80
            };
            //plane.Fly();
            //eagle.Fly();

            Duck duck = new Duck();

            IFly[] flies = { eagle, plane, duck };

            for (int i = 0; i < flies.Length; i++)
            {
                flies[i].Fly();
            }

            Ship ship = new Ship();

            ISwim[] swimables = { penguin, duck, ship };
            //penguin.Swim();





        }
    }
}
