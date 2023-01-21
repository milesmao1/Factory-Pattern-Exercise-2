using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise2
{
    public class ListDataAccess: IDataAccess
    {
        public ListDataAccess() 
        {
        }

        public List<Product> LoadData()
        {
            Console.WriteLine(" I am reading data from your list\n");
            return Product.products;
        }

        public void SaveData()
        {
            Console.WriteLine("Saving data to the list");
        }
    }
}
