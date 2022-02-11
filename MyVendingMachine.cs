
public interface IFriendlyVendingMachine
{
    void Start();
    void AskUserName();
    void SayHello();
    void TellTime();
}


public class MyVendingMachine : IFriendlyVendingMachine
{
    private IProductsLoader _productsLoader;
    private string? _userName;

    public MyVendingMachine(IProductsLoader productsLoader)
    {
        this._productsLoader = productsLoader;
    }

    public void Start()
    {
        AskUserName();
        SayHello();
        TellTime();

        foreach (var product in _productsLoader.LoadProducts().Products)
        {
            Console.WriteLine(product.ToString());
        }

        Console.Write($"{Environment.NewLine}Press any key to exit...");

        Console.ReadKey(true);
    }

    public void AskUserName()
    {
        Console.WriteLine("Please enter your name");
        _userName = Console.ReadLine();
    }

    public void SayHello()
    {
        Console.WriteLine($"Hello Dear { _userName ?? "Customer" }! How are you?");
    }

    public void TellTime()
    {
        var currentDate = DateTime.Now;

        Console.WriteLine($"{Environment.NewLine}Current time is {currentDate:d} at {currentDate:t}! \n");
    }

}



public class HighEfficencyVendingMachine : IFriendlyVendingMachine
{
    public void Start()
    {
        SayHello();
    }

    public void SayHello()
    {
        Console.WriteLine($"Hello Dear Customer! How are you?");
    }

    public void AskUserName() { }

    public void TellTime() { }
}