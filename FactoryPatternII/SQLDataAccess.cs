using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternII
{
    class MySQLDataAccess : IDataAccess
    {
        public void SaveData()
        {
            Console.WriteLine("Saving data to your MySQL Database. . .");
        }

        public List<Product> LoadData()
        {
            Console.WriteLine("Accessing your SQL Database. . .");

            return new List<Product>()
            {
              new Product() { Name = "Shrek 2 DVD", Price = 5.00m },
                new Product() { Name = "Xbox Series S", Price = 200.00m },
                new Product() { Name = "Lamp", Price = 30.00m },
                new Product() { Name = "Acrylic Paint Set", Price = 39.99m },
                new Product() { Name = "Pink Floyd CD", Price = 12.99m },
                new Product() { Name = "Macbook Air", Price = 951.00m },
                new Product() { Name = "ToolBox", Price = 185.00m }
            };
        }
    }
}
