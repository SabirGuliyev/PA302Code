
using ConfigurationExample.Entities;
using ConfigurationExample.Repositories.Interfaces;
using ConfigurationExample.Services.Interfaces;

namespace ConfigurationExample.Services
{
    internal class ProductService:IProductService
    {
        private readonly IProductRepository _repository;

        public ProductService(IProductRepository repository)
        {
            _repository = repository;
        }
        public void CreateProduct()
        {

            Console.WriteLine("Enter product Name:");
            string? name = Console.ReadLine()?.Trim();

            Console.WriteLine("Enter price:");

            decimal price = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Enter description:");
            string? description = Console.ReadLine()?.Trim();

            Console.WriteLine("Enter category:");
            int? categoryId = int.Parse(Console.ReadLine()?.Trim());

            Product product = new Product
            {
                Name = name,
                Price = price,
                Description = description,
                Category_Id = categoryId.Value
            };


            _repository.Add(product);
            _repository.SaveChanges();
            Console.WriteLine("Products successfully created!");

        }

        public void GetAllProducts()
        {
            List<Product> products = _repository.GetAll();

            products.ForEach(p => Console.WriteLine($"{p.Name} {p.Price}"));
        }
    }
}
