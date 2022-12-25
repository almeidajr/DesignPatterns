using Humanizer;
using Spectre.Console;

namespace DesignPatterns.Creational.AbstractFactory;

public sealed class WeekdayWorkout : IWorkout
{
    public void GetTrainingSheet()
    {
        AnsiConsole.WriteLine($"{nameof(WeekdayWorkout).Humanize()}");
    }
}