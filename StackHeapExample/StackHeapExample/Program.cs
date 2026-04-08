namespace StackHeapExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            if (true)
            {
                int b = 10;

                if (true)
                {
                    int c = 20;
                }
            }













            //Area(5);
            //Area(10,20);

            //int a = 5;

            //int b = a;

            //b += 10;

            //Console.WriteLine(b);
            //Console.WriteLine(a);

            //Console.WriteLine(a==b);


            //int[] arr = { 1, 2, 3 };
            //int[] arr2 = arr;

            //arr2[0] = 60;

            //Console.WriteLine(arr[0]);

            //Console.WriteLine(arr==arr2);



            //int a = 5;

            //GetValue(a);
            //Console.WriteLine(a);




            //int[] arr = {1,2,3};
            //ChangeIndex(arr);

            //Console.WriteLine(arr[0]);



            //int a=10;

            //ChangeValue(ref a);
            //Console.WriteLine(a);



            //int answer;

            //string str=Console.ReadLine();

            //Console.WriteLine(int.TryParse(str, out answer));


            //Console.WriteLine(answer);

            //int[] arr = new int[0];//{0,0,0,0,0}


            //int[] nums = { 1, 2, 3, 4, 5 };

            //ResetArr(ref nums);

            //for (int i = 0; i < nums.Length; i++)
            //{
            //    Console.WriteLine(nums[i]);
            //}

          
        }

        //public static void ResetArr(ref int[] arr)
        //{
        //    //a={123}
        //    //b={123}
        //    //arr=0x001
        //    //arr=0x002
        //    arr = new int[arr.Length];
        //}



        //public static void ChangeValue(ref int num)
        //{
        //    num += 10;
        //}



        //public static void ChangeIndex(int[] nums)
        //{
        //    nums[0] += 10;
        //}


        //public static int GetValue(int num)
        //{
        //    num += 10;
        //    return num;
        //}



















        public static void Area(int radius)
        {
            Console.WriteLine(Math.PI * radius*radius);
        }
        public static void Area(int a, int b)
        {
            Console.WriteLine(a*b);
        }
        public static void Area(int a,int b,int c)
        {
            Console.WriteLine(2*((a * b) + (a * c) + (b * c)));
        }
        public static void Area(int a,int b,int c,int r)
        {
            int num = (a + b + c) / 2;

            Console.WriteLine(num*r);
        }


    }
}


//Area deyə Method(lar) yaradılır.
//1. Çevrənin sahəsi - S = p*r² (p=3)
//2. Düzbucaqlının sahəsi - S = a*b
//3. Düzbucaqlı paralelpipedin tam səthinin sahəsi - S=2(a*b+a*c+b*c)
//4. Üçbucaqlının daxilinə çəkilmiş çevrənin sahəsi - S=p*r; p = (a + b + c) / 2