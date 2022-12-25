using Humanizer;
using Spectre.Console;

namespace DesignPatterns.Creational.FactoryMethod;

public sealed class MasterHotelService : IHotelService
{
    public void Charge()
    {
        AnsiConsole.WriteLine(
            $"The charge for the {nameof(MasterHotelService).Humanize(LetterCasing.Title)} has been made");
    }
}