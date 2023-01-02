namespace DesignPatterns.Creational.Builder;

public static class ProductDirector
{
    public static Product MinimalProduct()
    {
        var builder = new ProductBuilder();
        builder.AddPartA();
        return builder.Build();
    }

    public static Product FullProduct()
    {
        var builder = new ProductBuilder();
        builder.AddPartA();
        builder.AddPartB();
        builder.AddPartC();
        return builder.Build();
    }
}