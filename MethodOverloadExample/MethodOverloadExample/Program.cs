using System;

namespace MethodOverloadExample
{
    internal class Program
    {
        static void Main()
        {
            //int[] nums = { 13, -4, 6, -9, 1, 0, 11, -7, -2 };




            //nums=SortArr(nums);

            //for (int i = 0; i < nums.Length; i++)
            //{
            //    Console.WriteLine(nums[i]);
            //}

            //Console.WriteLine(GetMin(nums));


            //int[] nums2 = {  6, -9, 1, 0, -11, -7, -2 };

            //Console.WriteLine(GetMin(nums));



            //GetFUllname("test");

            //Console.WriteLine(GetPower(5,4));
            //Console.WriteLine(GetPower(3));

            //Console.WriteLine(GetPower(7));

            //Console.WriteLine(GetPower(9));


            //string[] arr = { "salam", "gencler", "necesiz", "veziyyet" };
            //CreateSentence(arr);

            //Console.WriteLine();

            //CreateSentence("Hello", "Guys", "How", "Are", "You", "?");
            //CreateSentence("Hello", "Guys", "How");

            //bool result = false;
            //Console.WriteLine(result);
            //Console.WriteLine(15);



            //Sum(1, 2, 3, 4);



            //Sum(1, 2);
            //Sum(1, 2, 3);
            //Sum(5, 10,5,5);
            //Sum("salam", "salam");
            //Sum("salam", 5);
            //Sum( 5,"Salam");



            //Sum(5);
            //Sum(5);


            Test(5,6,7);



        
        }



        public static void Test(int num)
        {
            Console.WriteLine("1ci");
        }

        public static void Test(int num,int num2 = 0)
        {
            Console.WriteLine("2ci");
        }

        public static void Test(params int[] nums) 
        {
            Console.WriteLine("3");
        }
















        //public static void Sum(int num)
        //{
        //    Console.WriteLine("Int ile olan");
        //}
        //public static int Sum(int num)
        //{
        //    Console.WriteLine("Int ile olan");
        //    return 5;
        //}




        //public static void Sum(double num)
        //{
        //    Console.WriteLine("Double ile olan");
        //}

















        //public static void Sum(int num,int num2)
        //{
        //    Console.WriteLine("1ci method ishe dushdu");
        //}


        //public static void Sum(string num, int num2)
        //{
        //    Console.WriteLine("1ci method ishe dushdu");
        //}

        //public static void Sum(int num2,string word)
        //{
        //    Console.WriteLine("1ci method ishe dushdu");
        //}

        //public static void Sum(string num, string num2)
        //{
        //    Console.WriteLine("string ile olan method ishe dushdu");
        //}
        //public static void Sum(int num,int num2, int num3) {

        //    Console.WriteLine("2ci method ");

        //}

        //public static void Sum(int num, int num2, int num3, int num4)
        //{

        //    Console.WriteLine("3cu");

        //}






        public static void CreateSentence(params string[] words)
        {
            for (int i = 0; i < words.Length; i++)
            {
                Console.Write(words[i] +" ");
            }
            

        }






        //public static int GetPower(int value,int power=2)
        //{
        //    int multi=value;
  
        //    for (int i = 1;i<power; i++)
        //    {
        //        //
        //        value*=multi;

        //    }
        //    return value;
        //}

        //public static void GetFUllname(string name,string surname = "x")
        //{
        //    Console.WriteLine(name + " " + surname);
        //}



        #region HomeworkSolution

        //a)GetMin adli method yaradılır. Daxil olunan arrayın ən kiçik elementini geri qaytarir(return)
        public static int GetMin(int[] arr)
        {
            int min = arr[0];

            for (int i = 1; i < arr.Length; i++)
            {
                if (min > arr[i])
                {
                    min = arr[i];
                }
            }
            return min;

        }
        //b)SortArray adli method yaradılır. Daxil olunan arrayı siralayib geri qaytarir
        public static int[] SortArr(int[] arr)
        {

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - 1 - i; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }

            return arr;

        } 
        #endregion


    }
}

//c)GetPower adli method yaradılır, iki parameter qebul edir. 1-ci parameter eded gonderilir. 2ci parameter-e hemin ededi necenci quvvete yukseltmek istediyimizi reqem olaraq gonderirik. Neticeni ekrana cixaririq. 
//Misal:
//GetPower(5, 3)-- > bu zaman 5-i 3-cu quvvetine yukseltmeliyik(5³) output:125