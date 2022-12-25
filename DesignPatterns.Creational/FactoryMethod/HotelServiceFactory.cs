namespace DesignPatterns.Creational.FactoryMethod;

public abstract class HotelServiceFactory
{
    public abstract IHotelService CreateHotelService(HotelServiceType type);
}