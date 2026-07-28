using Microsoft.EntityFrameworkCore;
using RelationExample.Contexts;
using RelationExample.Models;

namespace RelationExample
{
    internal class Program
    {
        static void Main(string[] args)
        {

            ManagementDbContext context = new();


            Student? student=context.Students
                .Include(s => s.Group)
                //.ThenInclude(g=>g.Category)
                .Include(s=>s.StudentSubjects)
                .ThenInclude(ss=>ss.Subject)

                .FirstOrDefault(s => s.Id == 1);




            Console.WriteLine(student.Name);
            Console.WriteLine("----");
            foreach (StudentSubject stuSub in student.StudentSubjects)
            {
                Console.WriteLine(stuSub.Subject.Name);
            }


            student.StudentSubjects[0].Subject.Name
            

            //List<Group> groups = context.Groups.Include(g => g.Students).ToList();


            //foreach (Group group in groups)
            //{
            //    Console.WriteLine($"ID:{group.Id}  Name:{group.Name}");
            //    Console.WriteLine("Students:");


            //    foreach (Student student in group.Students)
            //    {
            //        Console.WriteLine($"{student.Id} {student.Name} {student.Surname} {student.Age}");
            //    }


            //    Console.WriteLine("-----------------\n");
            //}


            //Group? group = context.Groups.Include(g => g.Students).FirstOrDefault(g => g.Id == 2);

            //Console.WriteLine(group.Name);

            //foreach (Student student in group.Students)
            //{
            //    Console.WriteLine(student.Name+" "+student.Surname);
            //}




            //Student? student = context.Students.Include(s=>s.Group).FirstOrDefault(s => s.Id == 4);
            ////Student? student = context.Students.Include("Student.Groupppppp").FirstOrDefault(s => s.Id == 4);


            //Console.WriteLine($"{student.Name} {student.Surname} {student.Group.Name}");


            //context.Students.Add(new Student
            //{
            //    Name = "Malik",
            //    Surname = "Malikov",
            //    Age = 30,
            //    GroupId = 1
            //});
            //context.Students.Add(new Student
            //{
            //    Name = "Nigar",
            //    Surname = "Aligaliyeva",
            //    Age = 20,
            //    GroupId = 1
            //});

            //context.Students.Add(new Student
            //{
            //    Name = "Tunar",
            //    Surname = "Bextiyarov",
            //    Age = 18,
            //    GroupId = 2
            //});

            //context.Students.Add(new Student
            //{
            //    Name = "Shirin",
            //    Surname = "Shirinov",
            //    Age = 24,
            //    GroupId = 2
            //});

            //context.Students.Add(new Student
            //{
            //    Name = "Jamal",
            //    Surname = "Aliyev",
            //    Age = 34,
            //    GroupId = 3
            //});
            //context.SaveChanges();


            //context.Groups.Add(new Group { Name = "PA302" });
            //context.Groups.Add(new Group { Name = "SS200" });
            //context.Groups.Add(new Group { Name = "MD500" });
            //context.SaveChanges();


        }
    }
}
