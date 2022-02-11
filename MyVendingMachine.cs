public class MyVendingMachine
{
    IProductsLoader _productsLoader;

    public MyVendingMachine(IProductsLoader productsLoader)
    {
        this._productsLoader = productsLoader;
    }

    public void Start()
    {
        Console.WriteLine("Hello Dear Customer! How are you?");

        // var name = Console.ReadLine();
        var currentDate = DateTime.Now;

        Console.WriteLine($"{Environment.NewLine}Current time is {currentDate:d} at {currentDate:t}! \n");

        foreach (var product in _productsLoader.LoadProducts().Products)
        {
            Console.WriteLine(product.ToString());
        }

        Console.Write($"{Environment.NewLine}Press any key to exit...");

        Console.ReadKey(true);
    }

}