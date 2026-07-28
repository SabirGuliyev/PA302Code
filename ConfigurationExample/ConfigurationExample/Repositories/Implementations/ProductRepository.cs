using ConfigurationExample.DAL;
using ConfigurationExample.Entities;
using ConfigurationExample.Repositories.Implementations;
using ConfigurationExample.Repositories.Interfaces;

internal class ProductRepository : Repository<Product>, IProductRepository
{
    public ProductRepository(AppDbContext context) : base(context) { }

    //public void GetProductsWithImage()
    //{
    //    _table.Include(p => p.ImageUrls.Where(pi => pi == "dshbmshdbfhdsb"));
    //}

}