public abstract class PriceLabelMaker
{
    public abstract string MakePriceLabel(Product product);
}

public class DrinkTypeProductPriceLabelMaker : PriceLabelMaker
{
    public override string MakePriceLabel(Product product)
    {
        return $"${product.Price * 1.1:0.##} (including ${product.Price * 0.1:0.##} deposit fee)";
    }
}

public class FruitTypeProductPriceLabelMaker : PriceLabelMaker
{
    public override string MakePriceLabel(Product product)
    {
        return $"${product.Price * 1.05} (including ${product.Price * 0.05} wrapping fee)";
    }
}

public class OtherTypeProductPriceLabelMaker : PriceLabelMaker
{
    public override string MakePriceLabel(Product product)
    {
        return $"${product.Price}";
    }
}