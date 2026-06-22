using EntityContextExample.DAL;
using EntityContextExample.Models;

namespace EntityContextExample
{
    internal class Program
    {
        static void Main(string[] args)
        {

            AppDbContext context = new AppDbContext();

            Student? existed = context.Students.FirstOrDefault(s => s.Id == 4);
            Student? existed2 = context.Students.Find(4);

            existed.Name = "Leyla";



            //context.Students.Update(existed);

            //context.Students.Remove(existed);
            context.SaveChanges();












            //Student? student = context.Students.FirstOrDefault(s => s.Id == 2);
            ////Student? student2 = context.Students.Find(5);



            ////Student? student = context.Students.SingleOrDefault(s => s.Id == 2);
            //if (student is null)
            //{
            //    Console.WriteLine("Not found 404");
            //}
            //else
            //{
            //    Console.WriteLine(student.Name);

            //}





            //List<Student> students = context.Students.Where(s => s.Age<=25).OrderByDescending(s=>s.Age).ToList();


            //students.ForEach(s => Console.WriteLine($"{s.Name} {s.Surname} {s.Age}"));
















            //List<Student> students = new List<Student> {
            //    new Student
            //    {
            //    Name = "Shirin",
            //    Surname = "Aliyev",
            //    Age = 25
            //    },
            //     new Student
            //    {
            //    Name = "Nigar",
            //    Surname = "Agaliyeva",
            //    Age = 18
            //    },

            //      new Student
            //    {
            //    Name = "Malik",
            //    Surname = "Malikov",
            //    Age = 34
            //    }
            //};



            //context.Students.AddRange(students);
            //context.SaveChanges();

            //ADD/ insert
            //Student student = new Student
            //{
            //    Name = "Tunar",
            //    Surname = "Baxtiyarov",
            //    Age = 28
            //};


            //context.Students.Add(student);
            //context.SaveChanges();

        }
    }
}
