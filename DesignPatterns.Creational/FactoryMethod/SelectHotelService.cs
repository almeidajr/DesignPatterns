namespace DesignPatterns.Creational.FactoryMethod;

public sealed class SelectHotelService : HotelServiceFactory
{
    public override IHotelService CreateHotelService(HotelServiceType type)
    {
        return type switch
        {
            HotelServiceType.Conventional => new ConventionalHotelService(),
            HotelServiceType.Premium => new PremiumHotelService(),
            HotelServiceType.Master => new MasterHotelService(),
            _ => throw new ArgumentOutOfRangeException(nameof(type), type, $"{type} not supported")
        };
    }
}