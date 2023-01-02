namespace DesignPatterns.Creational.Builder;

public interface IProductBuilder
{
    IProductBuilder AddPartA();
    IProductBuilder AddPartB();
    IProductBuilder AddPartC();
    Product Build();
}