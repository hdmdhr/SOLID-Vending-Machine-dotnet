

namespace VendingMachine
{
    class Program
    {
        static IProductsLoader _productsLoader = new CsvProductsLoader();

        static void Main(string[] args)
        {
            Console.WriteLine("Hello Dear Customer! How are you?");

            // var name = Console.ReadLine();
            var currentDate = DateTime.Now;

            Console.WriteLine($"{Environment.NewLine}Current time is {currentDate:d} at {currentDate:t}! \n");

            ProductsList productsList = _productsLoader.LoadProducts();

            foreach (var product in productsList.Products)
            {
                Console.WriteLine(product.ToString());
            }

            Console.Write($"{Environment.NewLine}Press any key to exit...");

            Console.ReadKey(true);
        }
    }


}