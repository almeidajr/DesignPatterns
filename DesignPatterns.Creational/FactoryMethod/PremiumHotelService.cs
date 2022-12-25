using Humanizer;
using Spectre.Console;

namespace DesignPatterns.Creational.FactoryMethod;

public sealed class PremiumHotelService : IHotelService
{
    public void Charge()
    {
        AnsiConsole.WriteLine(
            $"The charge for the {nameof(PremiumHotelService).Humanize(LetterCasing.Title)} has been made");
    }
}