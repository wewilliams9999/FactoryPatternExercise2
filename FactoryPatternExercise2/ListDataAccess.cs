using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternExercise2
{
    class ListDataAccess : IDataAccess
    {
        List<Product> IDataAccess.LoadData()
        {
            Console.WriteLine($"I am reading data from a list");
            var productList = new List<Product>();
            return productList;
        }

        void IDataAccess.SaveData()
        {
            Console.WriteLine($"I am saving data to a list.");
        }
    }
}

