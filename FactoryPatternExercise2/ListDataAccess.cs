using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternExercise2
{
    class ListDataAccess : IDataAccess
    {
        public static List<Product> Products = new List<Product>()
        {
            new Product() {Name = "Cereal", Price = 2},
            new Product() {Name = "Milk", Price = 3},
            new Product() {Name = "Bread", Price = 4},
            new Product() {Name = "Carrots", Price = 2}
        };
        List<Product> IDataAccess.LoadData()
        {
            Console.WriteLine($"I am reading data from a list");
            var productList = new List<Product>();
            return Products;
        }

        void IDataAccess.SaveData()
        {
            Console.WriteLine($"I am saving data to a list.");
        }
    }
}

