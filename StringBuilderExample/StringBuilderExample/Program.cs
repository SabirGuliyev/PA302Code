using System.Text;

namespace StringBuilderExample
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //int[] nums = { 1, 2, 3 };
            // 3 {1,2,3}  4{1,2,3,0}
            //Array.Resize(ref nums, nums.Length + 1);
            //nums[nums.Length - 1] = 4;


            //CustomResize(ref nums, 60);
            //CustomResize(ref nums, 80);
            //CustomResize(ref nums, 100);

            //for (int i = 0; i < nums.Length; i++)
            //{
            //    Console.WriteLine(nums[i]);
            //}


            ///////  new { 0, 0, 0, 0}


            //arr  num    {1,2,3,num}
            //newArr {1,2,3,num} 


            string name = "Salam necesiz gencler hello";

            //string[] arr = name.Split("e");

            //for(int i = 0; i < arr.Length; i++)
            //{
            //    Console.WriteLine(arr[i]);
            //}


            //string[] words = { "salam", "necesiz", "gencler" };

            //Console.WriteLine(string.Join(" ", words));





            //name=name.ToLower();
            //name=name.ToUpper();
            //name = name.Trim();
            //name.Contains("666");
            //name.StartsWith("050");
            //name.EndsWith("44");

            //name.Replace("050-666-", "+994-50-666");


            //Console.WriteLine(name.IndexOf('5'));
            //Console.WriteLine(name.LastIndexOf('5'));
            //Console.WriteLine(name.Substring(name.LastIndexOf(".")));

            //Console.WriteLine(string.Concat("Salam", " ", "Necesiz"));

            //int a = default;




            //Console.WriteLine(name);


            //string str = "a";



            //for (int i = 0; i < 100; i++) {
            //    str += "a";
            //    Console.WriteLine(str);
            //}




            //Console.WriteLine("Zehmet olmasa adinizi daxil edin:");

            //string answer = Console.ReadLine().Trim();

            //Console.WriteLine(Capitalize(answer));

            //Char.IsUpper();
            //Char.IsLower();
            //Char.IsDigit();
            //Char.IsSymbol();
            //Char.IsLetter();

            //Array.Sort();
            //Array.Reverse();







        }
        //SaBiR
        public static string Capitalize(string name)
        {
            //ctrl+. ve ya ALT+ENTER

            StringBuilder str=new StringBuilder();//"Sabir"
            str.Append(Char.ToUpper(name[0]));

            for(int i = 1; i < name.Length; i++)
            {
                str.Append(Char.ToLower(name[i]));
            }

            return str.ToString();
            
            

        }









        //public static void CustomResize(ref int[] arr,int num)
        //{
        //    int[] newArr = new int[arr.Length + 1];
        //    //{1,2,3,4,0}
        //    for(int i = 0; i < arr.Length; i++)
        //    {
        //        newArr[i]= arr[i];
        //    }

        //    newArr[newArr.Length - 1] = num;

        //    arr= newArr;

        //}
        //public static void CustomResize(ref int[] arr, params int[] numbers)
        //{

        //}
    }
}
