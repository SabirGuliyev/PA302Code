
using UpcastingExamples.Models;

namespace UpcastingExamples.Utility.Extensions
{
    internal static class Helper
    {
        //name.Capitalize()
        public static string Capitalize(this string name)
        {
            if (string.IsNullOrEmpty(name)) return name;
            return name.Substring(0, 1).ToUpper() + name.Substring(1).ToLower();
        }
        //public static string Capitalize(string name)
        //{
        //    return name.Substring(0, 1).ToUpper() + name.Substring(1).ToLower();
        //}

        public static void Test(this Person person)
        {
            Console.WriteLine(person);
        }


        public static int Power(this int num, int power=2)
        {

            //num 5   power 4  5*5*5*5
            int value = num;

            for (int i = 1; i < power; i++)
            {
                num *= value;
            }

            return num;
        }

        //public static int Power(this int num)
        //{
        //    return num * num;
        //}
    }
}
