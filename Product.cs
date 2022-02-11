
public class ProductsList
{
    public Product[] Products { get; set; }
}

public enum ProductType
{
    Drink,
    Fruit,
    Other
}

public class Product
{
    public int ID { get; set; }
    public string Name { get; set; }
    public float Price { get; set; }
    public ProductType Type { get; set; }

    public override string ToString()
    {
        return $"ID: {ID}, {Name} - ${Price} \n";
    }
}
