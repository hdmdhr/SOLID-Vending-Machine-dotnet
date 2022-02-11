public interface IProductsLoader
{
    public ProductsList LoadProducts();
}

public class JsonProductsLoader : IProductsLoader
{
    public ProductsList LoadProducts()
    {
        return JsonFileReader.Read<ProductsList>(@"./products.json");
    }
}