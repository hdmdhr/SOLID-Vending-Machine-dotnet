

namespace VendingMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Dear Customer! What is your name?");

            // var name = Console.ReadLine();
            var currentDate = DateTime.Now;

            Console.WriteLine($"{Environment.NewLine}Hello dear customer, now is {currentDate:d} at {currentDate:t}! \n");

            ProductsList productsList = JsonFileReader.Read<ProductsList>(@"./products.json");

            foreach (var product in productsList.Products)
            {
                Console.WriteLine(product.ToString());
            }

            Console.Write($"{Environment.NewLine}Press any key to exit...");

            Console.ReadKey(true);
        }
    }


}