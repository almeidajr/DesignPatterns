using Humanizer;
using Spectre.Console;

namespace DesignPatterns.Creational.FactoryMethod;

public sealed class ConventionalHotelService : IHotelService
{
    public void Charge()
    {
        AnsiConsole.WriteLine(
            $"The charge for the {nameof(ConventionalHotelService).Humanize(LetterCasing.Title)} has been made");
    }
}