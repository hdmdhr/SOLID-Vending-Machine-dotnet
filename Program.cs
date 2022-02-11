

namespace VendingMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            var machine = new MyVendingMachine(new JsonProductsLoader());

            machine.Start();
        }
    }


}