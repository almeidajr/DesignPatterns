namespace DesignPatterns.Creational.Builder;

public sealed class ProductBuilder : IProductBuilder
{
    private readonly Product _product = new();

    public IProductBuilder AddPartA()
    {
        _product.Add("Part A");
        return this;
    }

    public IProductBuilder AddPartB()
    {
        _product.Add("Part B");
        return this;
    }

    public IProductBuilder AddPartC()
    {
        _product.Add("Part C");
        return this;
    }

    public Product Build()
    {
        return _product;
    }
}