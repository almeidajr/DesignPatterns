using DesignPatterns.Core;
using Humanizer;
using Spectre.Console;

namespace DesignPatterns.Creational.FactoryMethod;

internal sealed class FactoryMethodConsoleView : IConsoleView
{
    public string Label { get; } = nameof(FactoryMethod).Humanize(LetterCasing.Title);

    public void Render()
    {
        var hotelServiceType = AnsiConsole.Prompt(
            new SelectionPrompt<HotelServiceType>()
                .Title("Select the type of hotel service:")
                .AddChoices(HotelServiceType.Conventional, HotelServiceType.Premium, HotelServiceType.Master));

        var hotelService = new SelectHotelService().CreateHotelService(hotelServiceType);
        hotelService.Charge();
    }
}