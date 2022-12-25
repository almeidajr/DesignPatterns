using Humanizer;
using Spectre.Console;

namespace DesignPatterns.Creational.AbstractFactory;

public sealed class WeekdayMenu : IMenu
{
    public void GetFoodSheet()
    {
        AnsiConsole.WriteLine($"{nameof(WeekdayMenu).Humanize()}");
    }
}