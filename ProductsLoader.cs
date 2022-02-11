using System.IO;

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

public class CsvProductsLoader : IProductsLoader
{
    public ProductsList LoadProducts()
    {
        var list = new List<Product>();

        using (var reader = new StreamReader(@"./products.csv"))
        {
            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                var values = line.Split(',');
                list.Add(new Product { ID = int.Parse(values[0]), Name = values[1], Price = float.Parse(values[2]), Type = values[3] });
            }
        }

        return new ProductsList { Products = list };
    }
}