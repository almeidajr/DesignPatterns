using Humanizer;
using Spectre.Console;

namespace DesignPatterns.Creational.AbstractFactory;

public sealed class WeekendWorkout : IWorkout
{
    public void GetTrainingSheet()
    {
        AnsiConsole.WriteLine($"{nameof(WeekendWorkout).Humanize()}");
    }
}