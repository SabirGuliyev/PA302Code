

namespace ConfigurationExample.Entities
{
    internal class Product:BaseEntity
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }

        public int Category_Id { get; set; }
        public Category Category { get; set; }

        //public List<string> ImageUrls { get; set; }

    }
}
