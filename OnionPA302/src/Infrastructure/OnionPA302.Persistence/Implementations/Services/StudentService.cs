using OnionPA302.Application.Interfaces.Repositories;
using OnionPA302.Application.Interfaces.Services;
using OnionPA302.Domain.Entities;
using OnionPA302.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionPA302.Persistence.Implementations.Services
{
    public class StudentService : IStudentService
    {
        private readonly IStudentRepository _repository;

        public StudentService(IStudentRepository repository)
        {
            _repository = repository;
        }
        public void Create()
        {
            Console.WriteLine("Pls enter Student name:");
            string? name=Console.ReadLine();

            Console.WriteLine("Pls enter Student surname:");
            string? surname = Console.ReadLine();

            Console.WriteLine("Pls enter Student Age:");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("Choose gender:");

            

            foreach (Gender gnd in Enum.GetValues(typeof(Gender)))
            {
                Console.WriteLine($"{(int)gnd}. {gnd}");
            }
            
            Gender gender=(Gender)int.Parse(Console.ReadLine());

            Console.WriteLine("Pls enter Student Email:");
            string? email = Console.ReadLine();

            if (_repository.IsEmailExists(email))
            {
                Console.WriteLine("Email already exists");
                return;
            }

            Student student = new Student
            {
                Name = name,
                Surname = surname,
                Age = age,
                Email = email
            };

            _repository.Add(student);
            _repository.SaveChanges();
            
        }
    }
}
