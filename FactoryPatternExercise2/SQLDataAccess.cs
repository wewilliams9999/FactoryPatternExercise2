using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternExercise2 
{
    class SQLDataAccess : IDataAccess
    {
        List<Product> IDataAccess.LoadData()
        {
            Console.WriteLine($"I am reading data from a SQL database");
            var productList = new List<Product>();
            return productList;
        }

        void IDataAccess.SaveData()
        {
            Console.WriteLine($"I am saving data to a SQL database.");
        }
    }
}

