using Humanizer;

namespace DesignPatterns.Creational.FactoryMethod;

public sealed class MasterHotelService : IHotelService
{
    public void Charge()
    {
        Console.WriteLine($"The charge for the {nameof(MasterHotelService).Humanize()} has been made");
    }
}