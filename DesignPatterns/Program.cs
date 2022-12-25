using DesignPatterns.Creational.FactoryMethod;
using Humanizer;
using Spectre.Console;

AnsiConsole.MarkupLine($"[bold]{nameof(DesignPatterns).Humanize(LetterCasing.Title)}[/]");

AnsiConsole.MarkupLine($"[underline]{nameof(DesignPatterns.Creational.FactoryMethod).Humanize(LetterCasing.Title)}[/]");

var hotelServiceType = AnsiConsole.Prompt(
    new SelectionPrompt<HotelServiceType>()
        .Title("Select the type of hotel service")
        .AddChoices(HotelServiceType.Conventional, HotelServiceType.Premium, HotelServiceType.Master));

var hotelService = new SelectHotelService().CreateHotelService(hotelServiceType);
hotelService.Charge();