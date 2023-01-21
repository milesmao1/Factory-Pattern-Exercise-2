using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise2
{
    public class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public static List<Product> products = new List<Product>()
        {
            new Product() { Name = "Pogo stick", Price = 25.00},
            new Product() { Name = "Skateboard", Price = 50.00},
            new Product(){ Name = "Slinky", Price = 3.00}
        };

    }
}
