using Humanizer;

namespace DesignPatterns.Creational.FactoryMethod;

public sealed class PremiumHotelService : IHotelService
{
    public void Charge()
    {
        Console.WriteLine($"The charge for the {nameof(PremiumHotelService).Humanize()} has been made");
    }
}