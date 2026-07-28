namespace ClaudeExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        static string OddOrEven(int number)
        {
            return number % 2 == 0 ? "Even" : "Odd";
        }
    }
}
