
public class ProductsList
{
    public Product[] Products { get; set; }
}



public class Product
{
    static Dictionary<string, PriceLabelMaker> labelMakers = new Dictionary<string, PriceLabelMaker> {
        { "Drink", new DrinkTypeProductPriceLabelMaker() },
        { "Fruit", new FruitTypeProductPriceLabelMaker() },
        { "Other", new OtherTypeProductPriceLabelMaker() }
    };
    public int ID { get; set; }
    public string Name { get; set; }
    public float Price { get; set; }
    public string Type { get; set; }

    public override string ToString()
    {
        return $"ID: {ID}, {Name} - {labelMakers[Type].MakePriceLabel(this)} \n";
    }
}
