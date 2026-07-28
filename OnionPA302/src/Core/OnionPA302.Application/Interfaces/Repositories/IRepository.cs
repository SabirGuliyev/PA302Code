using OnionPA302.Domain.Entities;


namespace OnionPA302.Application.Interfaces.Repositories
{
    public interface IRepository<T> where T : BaseEntity, new()
    {
        void Add(T entity);


        List<T> GetAll();


        T? GetById(int id, bool isTracking = false);


        void Update(T entity);

        void Delete(T entity);


        void SaveChanges();


    }
}

