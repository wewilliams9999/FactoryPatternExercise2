using System;
using System.Threading;

namespace FactoryPatternExercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            string dbType;
            bool correctInput;

            do
            {
                Console.Clear();
                correctInput = true;

                Console.WriteLine("What type of database do you want to use? The options are: List, SQL, or Mongo");
                dbType = Console.ReadLine();

                if (dbType != "sql" && dbType != "mongo" && dbType != "list")
                {
                    correctInput = false;
                    Console.WriteLine("Bad input");
                    Thread.Sleep(1000);
                }
            }
            while (!correctInput);

            Console.Clear();

            IDataAccess database = DataAccessFactory.GetDataAccessType(dbType);
            var products = database.LoadData();
            database.SaveData();

            foreach (var product in products)
            {
                Console.WriteLine($"Name: {product.Name}. Price: {product.Price}.");
            }
        }
    }
}
