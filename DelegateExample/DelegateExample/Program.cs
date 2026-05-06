using DelegateExample.Enums;
using DelegateExample.Models;
using System.Threading.Channels;

namespace DelegateExample
{
    //internal delegate bool CheckNum(int num);

    internal delegate void Print(string str);


    internal class Program
    {
        static void Main(string[] args)
        {
            #region Home task(enum)
            //Student student = new Student("Hamid", "Aliyev", Gender.Male);

            //Student student2 = new Student("Nigar", "Aligayeva", Gender.Female);

            //Student student3 = new Student("Tunar", "Bextiyarov", Gender.Male);

            //Group group = new Group("PA302", GroupType.Mixed);
            //group.Add(student);
            //group.Add(student2);
            //group.Add(student3);


            //group.Delete(2);

            //group.ShowStudents();
            //Console.WriteLine("-------------------");
            //group.Search("yEV");

            #endregion

            //Func<int,int,char,string,int> func = (a,b,c,d) => a+b;
           


       

            //Print print = s => Console.WriteLine(s[0]+" " + s[s.Length-1]);

            //print("salam");
            //Print print = PrintUpper;
            //print += PrintLower;
            //print += PrintCapitalize;


            //print -= PrintLower;


            //print("salAM");


            int[] nums = { 1, 2, 3, 4, 5, 6, 35,70 };


            SumOfArray(nums, IsEven);
            SumOfArray(nums, IsOdd);
            SumOfArray(nums, n => n % 2 == 0);
            SumOfArray(nums, x => x > 7 && x % 5 == 0);



            //CheckNum check = delegate () {

            //    return 60 > 7 && 70 % 5 == 0;
            //};

            //CheckNum check2 =()=>2 == 0;







        }

        public static void PrintUpper(string word) {

            Console.WriteLine(word.ToUpper());
        }
        public static void PrintLower(string text)
        {

            Console.WriteLine(text.ToLower());
        }
        public static void PrintCapitalize(string name)
        {

            Console.WriteLine(name.Substring(0,1).ToUpper()+name.Substring(1).ToLower());
        }








        public static void SumOfArray(int[] arr, Func<int,bool> method)
        {
            int sum = 0;
            foreach (int num in arr)
            {
                if (method(num))
                {
                    sum += num;
                }
            }

            Console.WriteLine(sum);
        }


        //public static void SumOfArray(int[] arr, CheckNum method)
        //{
        //    int sum = 0;
        //    foreach(int num in arr)
        //    {
        //        if (method(num))
        //        {
        //            sum += num;
        //        }
        //    }

        //    Console.WriteLine(sum);
        //}

        public static bool IsEven(int num)
        {
            return num % 2 == 0;
        }
        public static bool IsOdd(int num)
        {
            return num % 2 != 0;
        }
        public static bool IsDividedByThreeOrFIve(int num)
        {
            return num % 3== 0 && num%5==0;
        }

        public static bool IsGreaterThatSeven(int num)
        {
            return num >7;
        }

    }
}
