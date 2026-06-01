namespace MultithreadingExample
{
    internal class Program
    {

        //[ThreadStatic]
        public static int Count=0;
        private static readonly object LockObject=new object();
        private static readonly object LockObject2=new object();
        static void Main(string[] args)
        {


            //Thread thread = new Thread(Print);
            //Thread thread2=new Thread(Print2);

            //thread.Start();
            //thread2.Start();

            

            ////Console.WriteLine("joinden evvelki kodlar ");

            //thread.Join();
            //thread2.Join();

            //Console.WriteLine(Count);

            //Console.WriteLine("Main thread-deki kod ishe dushur djhkdsb kjsdhfdsjhf khsjgdfj");

        }

        //public static void Print()
        //{
        //    for (int i = 0; i < 100000; i++) {

        //        //Console.WriteLine($"1ci- dovr ishe dushur {i}");

        //        lock (LockObject2)
        //        {
        //            lock (LockObject)
        //            {

        //                Count++;

        //            }
        //        }
               
                

        //    }
        //}
        //public static void Print2()
        //{
        //    for (int i = 0; i < 100000; i++)
        //    {

        //        //Console.WriteLine($"2ci- dovr{i}");
        //        lock (LockObject)
        //        {
        //            lock (LockObject2)
        //            {

        //                Count--;

        //            }
        //        }

        //    }
        //}
    }
}
