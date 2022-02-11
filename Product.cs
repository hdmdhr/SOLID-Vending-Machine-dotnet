
public class ProductsList
{
    public Product[] Products { get; set; }
}



public class Product
{
    public int ID { get; set; }
    public string Name { get; set; }
    public float Price { get; set; }
    public string Type { get; set; }

    public override string ToString()
    {
        return $"ID: {ID}, {Name} - {PriceLabelMaker.MakePriceLabel(this)} \n";
    }
}
