using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternExercise2 
{
    class SQLDataAccess : IDataAccess
    {
        public static List<Product> Products = new List<Product>()
        {
            new Product() {Name = "Book", Price = 5},
            new Product() {Name = "Couch", Price = 500},
            new Product() {Name = "Table", Price = 100},
            new Product() {Name = "Bench", Price = 75}
        };
        List<Product> IDataAccess.LoadData()
        {
            Console.WriteLine($"I am reading data from a SQL database");
            var productList = new List<Product>();
            return Products;
        }

        void IDataAccess.SaveData()
        {
            Console.WriteLine($"I am saving data to a SQL database.");
        }
    }
}

