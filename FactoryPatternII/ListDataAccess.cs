using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternII
{
    class ListDataAccess : IDataAccess
    {
        public static List<Product> Products = new List<Product>()
        {
            new Product() { Name = "Shrek 2 DVD", Price = 5.00m },
                new Product() { Name = "Xbox Series S", Price = 200.00m },
                new Product() { Name = "Lamp", Price = 30.00m },
                new Product() { Name = "Acrylic Paint Set", Price = 39.99m },
                new Product() { Name = "Pink Floyd CD", Price = 12.99m },
                new Product() { Name = "Macbook Air", Price = 951.00m },
                new Product() { Name = "ToolBox", Price = 185.00m }
        };

        public void SaveData()
        {
            Console.WriteLine("Saving your static list. . .");
        }

        public List<Product> LoadData()
        {
            Console.WriteLine("Accessing your static list. . .");

            return Products;
        }
    }
}
