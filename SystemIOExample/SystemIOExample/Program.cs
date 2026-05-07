namespace SystemIOExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string path = @"C:\Users\sabir\Desktop\Test\test2\test3\test4";
            string path = @"C:\Users\sabir\Desktop\Test";



            Directory.CreateDirectory(path);
            //if (Directory.Exists(path))
            //{
            //    Directory.Delete(path, true);
            //}


            if (!File.Exists(@"C:\Users\sabir\Desktop\Test\text.txt"))
            {
                File.Create(@"C:\Users\sabir\Desktop\Test\text.txt").Close();
            }

            //File.Delete(@"C:\Users\sabir\Desktop\Test\text.txt");

            //FileInfo file = new FileInfo(path);

            //file.Create();
            //file.Delete();
            //file.Exists;


            StreamReader sr = new StreamReader(@"C:\Users\sabir\Desktop\Test\text.txt");

            //Console.WriteLine(sr.ReadLine());

            string text = sr.ReadToEnd();
            sr.Close();

            Console.WriteLine(text);




            StreamWriter sw = new StreamWriter(@"C:\Users\sabir\Desktop\Test\text.txt",true);

            //sw.WriteLine("TUnar");
            //sw.WriteLine("Malik");
            sw.WriteLine("Shirin");

            sw.Close();

           








        }
    }
}
