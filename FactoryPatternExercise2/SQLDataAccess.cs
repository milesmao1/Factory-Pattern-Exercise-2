using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise2
{
    public class SQLDataAccess : IDataAccess
    {
        public SQLDataAccess()
        {

        }

        public List<Product> LoadData()
        {
            Console.WriteLine("I'm reading data from your SQL database\n");
            return Product.products;
        }

        public void SaveData()
        {
            Console.WriteLine("Saving data to the list");
        }
    }
}
