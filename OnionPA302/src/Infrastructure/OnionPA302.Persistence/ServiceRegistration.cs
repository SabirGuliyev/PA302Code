using OnionPA302.Application.Interfaces.Services;
using OnionPA302.Persistence.DAL;
using OnionPA302.Persistence.Implementations.Repositories;
using OnionPA302.Persistence.Implementations.Services;

namespace OnionPA302.Persistence
{
    public static class ServiceRegistration
    {
        public static IStudentService GetStudentService()
        {
            var context = new AppDbContext();
            var studentRepository = new StudentRepository(context);
            return new StudentService(studentRepository);
        }
    }
}
