using DelegateExample.Enums;
using DelegateExample.Models;
using System.Threading.Channels;

namespace DelegateExample
{
    //internal delegate bool CheckNum(int num);

    //internal delegate void Print(string str);


    internal class Program
    {
        static void Main(string[] args)
        {


            //List<string> students= new List<string>() {"Tunar","Nigar", "Mehemmedeli","Hamid","Malik","Artogrul" };


            //students.RemoveAll(s=>s.Length>5);

            //students.ForEach(s => Console.WriteLine(s));



            //foreach (string student in students)
            //{
            //    Console.WriteLine(student);
            //}

















            #region Home task(enum)
            //Student student = new Student("Hamid", "Aliyev", Gender.Male);
            //Student student4 = new Student("Test", "Testov", Gender.Other);


            //Student student2 = new Student("Bigar", "Aligayeva", Gender.Female);

            //Student student3 = new Student("Aunar", "Bextiyarov", Gender.Male);


            //List<Student> students = new List<Student>() { student,student4, student2, student3 };

            //students.RemoveAll(s => s.Gender == Gender.Male);

            //students=students.OrderByDescending(s=>s.Gender).ToList();

            //students.OrderBy(x => x.Name).ToList().ForEach(x => Console.WriteLine(x.Name));

            //students.ForEach(s => Console.WriteLine(s.Name));

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

            //Action<string> print = x => Console.WriteLine(x);
            //Action<string> print2 = ;


            //Predicate<>





            //Print print = s => Console.WriteLine(s[0]+" " + s[s.Length-1]);

            //print("salam");
            //Print print = PrintUpper;
            //print += PrintLower;
            //print += PrintCapitalize;


            //print -= PrintLower;


            //print("salAM");


            //int[] nums = { 1, 2, 3, 4, 5, 6, 35,70 };


            //SumOfArray(nums, IsEven);
            //SumOfArray(nums, IsOdd);
            //SumOfArray(nums, n => n % 3 == 0);
            //SumOfArray(nums, x => x > 7 && x % 5 == 0);



            //CheckNum check = delegate () {

            //    return 60 > 7 && 70 % 5 == 0;
            //};

            //CheckNum check2 =()=>2 == 0;







        }

        //public static void PrintUpper(string word) {

        //    Console.WriteLine(word.ToUpper());
        //}
        //public static void PrintLower(string text)
        //{

        //    Console.WriteLine(text.ToLower());
        //}
        //public static void PrintCapitalize(string name)
        //{

        //    Console.WriteLine(name.Substring(0,1).ToUpper()+name.Substring(1).ToLower());
        //}








        //public static void SumOfArray(int[] arr, Predicate<int> method)
        //{
        //    int sum = 0;
        //    foreach (int num in arr)
        //    {
        //        if (method(num))
        //        {
        //            sum += num;
        //        }
        //    }

        //    Console.WriteLine(sum);
        //}
        //public static void SumOfArray(int[] arr, Func<int, bool> method)
        //{
        //    int sum = 0;
        //    foreach (int num in arr)
        //    {
        //        if (method(num))
        //        {
        //            sum += num;
        //        }
        //    }

        //    Console.WriteLine(sum);
        //}

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
