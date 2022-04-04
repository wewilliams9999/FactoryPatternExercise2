using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternExercise2
{
    class MongoDataAccess : IDataAccess
    {
        public static List<Product> Products = new List<Product>()
        {
            new Product() {Name = "Xbox", Price = 350},
            new Product() {Name = "Guitar", Price = 1000},
            new Product() {Name = "Blender", Price = 50},
            new Product() {Name = "Kite", Price = 25}
        };
        List<Product> IDataAccess.LoadData()
        {
            Console.WriteLine($"I am reading data from a Mongo database");
            return Products;
        }

        void IDataAccess.SaveData()
        {
            Console.WriteLine($"I am saving data to a Mongo database.");
        }
    }
}
