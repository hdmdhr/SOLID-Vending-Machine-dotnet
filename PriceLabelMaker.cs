public class PriceLabelMaker
{
    public static string MakePriceLabel(Product product)
    {
        switch (product.Type)
        {
            case "Drink":
                return $"{product.Price * 1.1}";
            case "Fruit":
                return $"{product.Price * 1.05}";
            default:
                return $"${product.Price}";
        }
    }
}