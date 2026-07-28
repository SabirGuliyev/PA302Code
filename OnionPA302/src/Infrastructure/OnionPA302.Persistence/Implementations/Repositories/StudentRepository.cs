using OnionPA302.Application.Interfaces.Repositories;
using OnionPA302.Application.Interfaces.Services;
using OnionPA302.Domain.Entities;
using OnionPA302.Persistence.DAL;


namespace OnionPA302.Persistence.Implementations.Repositories
{
    public class StudentRepository:Repository<Student>, IStudentRepository
    {
        public StudentRepository(AppDbContext context) : base(context)
        {

        }

        public bool IsEmailExists(string email)
        {
            return _table.Any(s => s.Email == email);
        }   
    }
}
