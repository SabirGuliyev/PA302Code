using ConfigurationExample.DAL;
using ConfigurationExample.Entities;
using ConfigurationExample.Repositories.Implementations;
using ConfigurationExample.Repositories.Interfaces;
using ConfigurationExample.Services;
using ConfigurationExample.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfigurationExample.Common
{
    internal class ServiceInitializer
    {
        public IProductRepository ProductRepository { get; set; }
        public IProductService ProductService { get; set; }

        public AppDbContext Context { get; set; }

        public void Initialize()
        {
           Context=new AppDbContext();
           ProductRepository = new ProductRepository(Context);
           ProductService= new ProductService(ProductRepository);
        }


    }
}
