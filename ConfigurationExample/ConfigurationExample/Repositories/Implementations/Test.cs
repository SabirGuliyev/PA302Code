using ConfigurationExample.DAL;
using ConfigurationExample.Entities;
using ConfigurationExample.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfigurationExample.Repositories.Implementations
{
    internal class Test:Repository<Product>, IProductRepository
    {
        public Test(AppDbContext context) : base(context)
        {
            
        }
    }
}
