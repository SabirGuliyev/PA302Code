using System.Collections;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {



            //SortedList nonlist = new SortedList();

            //nonlist.Add(1,"salam");
            //nonlist.Add(1,"sagol");
            //nonlist.Add(3, "sagol");

            //nonlist.TryAdd()





            //Get big O(log N)  Add O(N) Index destekleyir
            //SortedList<char, string> list = new();

            //list.Add('c', "Jamal");
            //list.Add('d', "Jamal");

            //list.Add('b', "Tunar");
            //list.Add('s', "Tunar");

            //Console.WriteLine(list.TryAdd('a', "Ali"));


            //Console.WriteLine(list['d']);

            //foreach (var item in list)
            //{
            //    Console.WriteLine(item);
            //}



            //Push() O(1) - Pop O(1) /*index desteklemir LIFO*/
            //Stack<string> names = new();

            //names.Push("Jamal");
            //names.Push("Tunar");
            //names.Push("Nigar");
            //names.Push("Hamid");


            ////Console.WriteLine(names.Peek());
            //string str;
            //Console.WriteLine(names.TryPop(out str));
            //Console.WriteLine(str);
            //Console.WriteLine("-------------------");


            //foreach (string name in names)
            //{
            //    Console.WriteLine(name);
            //}

            //FIFO Enqueue O(1) - Dequeue O(1)*index desteklemir*/ 
            //Queue<string> names = new Queue<string>();
            //names.Enqueue("Jamal");
            //names.Enqueue("Fardi");
            //names.Enqueue("Artogrul");
            //names.Enqueue("Yusif");


            //names.Peek();

            ////Console.WriteLine(names.TryDequeue());
            //Console.WriteLine(names.Dequeue());
            //Console.WriteLine(names.Dequeue());
            //Console.WriteLine(names.Dequeue());
            //Console.WriteLine(names.Dequeue());
            //Console.WriteLine("--------------");
            //foreach (string name in names)
            //{
            //    Console.WriteLine(name);
            //}
            //Get O(1) Add O(1) 
            //Map -> Java equivalent
            Dictionary<string, string> cities = new();

            cities.Add("Russia", "Moscow-St burg-Novqorod");
            cities.Add("Aze", "Baki-Berde-Sumqayit");
            cities.Add("Aze", "Shamaxi");
            cities.Add("France", "Paris-Marcel");

            Console.WriteLine(cities["Aze"]);

            foreach (var city in cities)
            {
                Console.WriteLine(city.Value);
            }



        }
    }
}
