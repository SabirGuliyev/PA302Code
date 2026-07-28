using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfigurationExample.Services.Interfaces
{
    internal interface IProductService
    {
        void GetAllProducts();
        void CreateProduct();
    }
}
