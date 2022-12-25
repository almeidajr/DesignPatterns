using Humanizer;

namespace DesignPatterns.Creational.FactoryMethod;

public sealed class ConventionalHotelService : IHotelService
{
    public void Charge()
    {
        Console.WriteLine($"The charge for the {nameof(ConventionalHotelService).Humanize()} has been made");
    }
}