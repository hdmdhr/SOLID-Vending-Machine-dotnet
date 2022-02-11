
public class ProductsLoader
{
    public ProductsList LoadProducts()
    {
        return JsonFileReader.Read<ProductsList>(@"./products.json");
    }
}