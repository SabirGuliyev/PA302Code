using ConfigurationExample.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfigurationExample.Repositories.Interfaces
{
    internal interface IProductRepository:IRepository<Product>
    {
        //void GetProductsWithImages();
    }
}
