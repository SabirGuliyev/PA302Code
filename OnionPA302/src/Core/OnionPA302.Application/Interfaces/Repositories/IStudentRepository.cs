using OnionPA302.Domain.Entities;


namespace OnionPA302.Application.Interfaces.Repositories
{
    public interface IStudentRepository:IRepository<Student>
    {
        bool IsEmailExists(string email);
    }
}
