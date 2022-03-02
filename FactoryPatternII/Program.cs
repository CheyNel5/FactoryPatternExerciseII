using System;
using System.Collections.Generic;

namespace FactoryPatternII
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What type of database do you want to use???");
            Console.WriteLine("Please enter: Regular or list for a static list.");
            Console.WriteLine("Please enter: Sql for a MySQL DB.");
            Console.WriteLine("Please enter: Mongo for a Mongo DB.");
            string dbType = Console.ReadLine();

            IDataAccess da = DataAccessFactory.GetDataAccess(dbType);

            List<Product> products = da.LoadData();
            da.SaveData();

            Console.WriteLine();

            Console.WriteLine("For loop version");
            Console.WriteLine();

            Console.WriteLine("Here are your products");
            for (int index = 0; index < products.Count; index++)
            {
                Console.WriteLine($"Product Name: {products[index].Name} | " +
                    $"Product Price: {products[index].Price,0:c}");
            }

            Console.WriteLine();
            Console.WriteLine("**********************");
            Console.WriteLine();

            Console.WriteLine("Foreach loop version");
            Console.WriteLine();
            foreach (var product in products)
            {
                Console.WriteLine($"Product Name: {product.Name} | " +
                    $"Product Price: {product.Price,0:c}");
            }
        }
    }
}
