using Newtonsoft.Json;
using SerializationExample.Models;

namespace SerializationExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region HomeTaskSolution
            //Person person = new Person { Name="Mehemmedeli", Surname="Babayev", Age=19};
            //Person person2 = new Person { Name="Test", Surname="Testzade", Age=21};
            //Person person3 = new Person { Name="Jamal", Surname="Aliyov", Age=30};



            // List<Person> people = new List<Person> {person, person2, person3 };


            //foreach (Person prs in people.FindAll(p => p.Name == "Test"))
            //{
            //    Console.WriteLine(prs.Name+" "+prs.Surname);
            //}

            //people
            //    .FindAll(p => p.Surname.EndsWith("yev") || p.Surname.EndsWith("yov"))
            //    .ForEach(p => Console.WriteLine(p.Name+" "+p.Surname));

            //people
            //    .FindAll(p => p.Age >= 20)
            //    .ForEach(p => Console.WriteLine(p.Name + " " + p.Surname)); 
            #endregion

            #region Json convert intro

            // Person person = new Person { Name = "Mehemmedeli", Surname = "Babayev", Age = 19 };
            // Person person2 = new Person { Name = "Test", Surname = "Testzade", Age = 21 };
            // Person person3 = new Person { Name = "Jamal", Surname = "Aliyov", Age = 30 };



            // List<Person> people = new List<Person> { person, person2, person3 };

            //string json= JsonConvert.SerializeObject(people);


            //Console.WriteLine(json);



            //List<Person> list=JsonConvert.DeserializeObject<List<Person>>(json);


            // list.RemoveAll(p => p.Name == person.Name);

            // list.ForEach(p => Console.WriteLine(p.Name));

            #endregion


            //Category category = new Category {Id=1,Name="Smartphone" };
            //Category category2 = new Category {Id=2,Name="TV" };
            //Category category3 = new Category {Id=3,Name="Notebook" };

            //Product product = new Product { Id = 1, Name = "Samsung a22", Price = 500, Category = category };
            //Product product2 = new Product { Id = 2, Name = "Iphone 16", Price = 3000, Category = category };
            //Product product3 = new Product { Id = 3, Name = "Toshiba TV", Price = 700, Category = category2 };
            //Product product4 = new Product { Id = 4, Name = "LG oled", Price = 2500, Category = category2 };
            //Product product5 = new Product { Id = 5, Name = "MSI", Price = 1500, Category = category3 };
            //Product product6 = new Product { Id = 6, Name = "Mac Book", Price = 5000, Category = category3 };


















            //List<Product> products=new List<Product> { product,product2,product3,product4,product5,product6 };

            //string json=JsonConvert.SerializeObject(products);


            //string path = @"C:\Users\sabir\Desktop\SerializationExample\SerializationExample\Files\Products.json";
            //StreamWriter sw = new StreamWriter(path);

            //sw.Write(json);

            //sw.Close();





            //string path = @"C:\Users\sabir\Desktop\SerializationExample\SerializationExample\Files\Products.json";


            // StreamReader sr = new StreamReader(path);

            // string json= sr.ReadToEnd();

            // sr.Close();



            // List<Product> products=JsonConvert.DeserializeObject<List<Product>>(json);



            // products.Remove(products.Find(p => p.Id == 6));

            // products.ForEach(p => p.PrintInfo());



            //string newJson= JsonConvert.SerializeObject(products);


            // StreamWriter sw = new StreamWriter(path);
            // sw.Write(newJson);
            // sw.Close();

            string path = @"C:\Users\sabir\Desktop\SerializationExample\SerializationExample\Files\Products.json";


            Product product = new Product { Id=20, Name="Test", Price=500,Category=new Category {Id=80,Name="testcategory" } };



            //Add(product, path);





            Remove(3, path);




        }


        public static void Add(Product product, string path) {

            StreamReader sr = new StreamReader(path);

            string json=sr.ReadToEnd();

            sr.Close();

            var products = JsonConvert.DeserializeObject<List<Product>>(json);

            products.Add(product);

            string newJson=JsonConvert.SerializeObject(products);

            StreamWriter sw = new StreamWriter(path);
            sw.Write(newJson);

            sw.Close();

        }
        public static void Remove(int id, string path)
        {

            StreamReader sr = new StreamReader(path);

            string json = sr.ReadToEnd();

            sr.Close();

            var products = JsonConvert.DeserializeObject<List<Product>>(json);

            products.Remove(products.Find(p => p.Id == id));

            string newJson = JsonConvert.SerializeObject(products);

            StreamWriter sw = new StreamWriter(path);
            sw.Write(newJson);

            sw.Close();




        }


    }
}
