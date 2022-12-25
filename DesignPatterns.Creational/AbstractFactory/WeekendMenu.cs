using Humanizer;
using Spectre.Console;

namespace DesignPatterns.Creational.AbstractFactory;

public sealed class WeekendMenu : IMenu
{
    public void GetFoodSheet()
    {
        AnsiConsole.WriteLine($"{nameof(WeekendMenu).Humanize()}");
    }
}