namespace FactoryPatternExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What database would you like to use? List, SQL OR MongoDb");

            var response = Console.ReadLine();

            IDataAccess data = DataAccessFactory.GetDataAccessType(response);

            List<Product> products = data.LoadData();

            data.SaveData();

            Console.WriteLine("Here are your items:");

            foreach (var item in products) 
            {
                Console.WriteLine($"Product Name: {item.Name}");
                Console.WriteLine($"Price: {item.Price}\n");
            }

        }
    }
}
