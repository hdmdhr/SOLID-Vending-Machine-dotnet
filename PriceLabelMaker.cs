public class PriceLabelMaker
{
    public static string MakePriceLabel(Product product)
    {
        return $"${product.Price}";
    }
}