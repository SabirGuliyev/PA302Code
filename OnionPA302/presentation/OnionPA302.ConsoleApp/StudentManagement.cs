using OnionPA302.Application.Interfaces.Services;

namespace OnionPA302.ConsoleApp
{
    internal class StudentManagement
    {
        private readonly IStudentService _studentService;

        public StudentManagement(IStudentService studentService)
        {
            _studentService = studentService;
        }

        public void Run()
        {
            while (true)
            {
                Console.WriteLine("\n=== Student Management ===");
                Console.WriteLine("1. Create Student");
                Console.WriteLine("0. Exit");
                Console.Write("Select: ");

                switch (Console.ReadLine()?.Trim())
                {
                    case "1":
                        _studentService.Create();
                        break;
                    case "0":
                        return;
                    default:
                        Console.WriteLine("Invalid option, try again.");
                        break;
                }
            }
        }
    }
}
