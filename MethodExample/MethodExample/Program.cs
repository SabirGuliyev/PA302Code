namespace MethodExample
{
    internal class Program
    {

        static void Main(string[] args)
        {
            //int price = 90;
            //int discount = 20;
            //Console.WriteLine(price*discount/100);
            //bool isSingle = true;//Camel

            //int price2 = 120;
            //int discount2 = 10;
            //Console.WriteLine(price2*discount2/100);


            //num=18<-GetDiscount(90,20);

            //int price = 120;
            //int discountedValue = GetDiscount(price, 10);

            ////Console.WriteLine(price-discountedValue);

            //Console.WriteLine("Zehmet olmasa adinizi daxil edin:");
            //string text=Console.ReadLine();


            //Console.WriteLine("Musterinin adi:"+text);








            Console.WriteLine(IsEven(12));



        }

        public static bool IsEven(int num)
        {
            if (num % 2 == 0)
            {
                return true;
            }

            return false;

        }











        public static int GetDiscount(int price, int percent)
        {
            return price * percent / 100;
        }



    }
}
