using ConfigurationExample.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfigurationExample.Repositories.Interfaces
{
    internal interface IRepository<T> where T : BaseEntity, new()
    {
        void Add(T entity);


        List<T> GetAll();


        T? GetById(int id, bool isTracking = false);


        void Update(T entity);

        void Delete(T entity);


        void SaveChanges();
       

    }
}
