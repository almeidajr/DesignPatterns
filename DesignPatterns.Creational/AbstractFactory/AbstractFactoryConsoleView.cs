using DesignPatterns.Core;
using Humanizer;
using Spectre.Console;

namespace DesignPatterns.Creational.AbstractFactory;

internal sealed class AbstractFactoryConsoleView : IConsoleView
{
    public string Label { get; } = nameof(AbstractFactory).Humanize(LetterCasing.Title);

    public void Render()
    {
        var routineFactory = AnsiConsole.Prompt(new SelectionPrompt<IRoutineFactory>()
            .Title("Select the routine type:")
            .AddChoices(new WeekdayRoutineFactory(), new WeekendRoutineFactory())
            .UseConverter(factory => factory switch
            {
                WeekdayRoutineFactory => "Weekday",
                WeekendRoutineFactory => "Weekend",
                _ => throw new ArgumentOutOfRangeException(nameof(factory), factory, $"{factory} not supported")
            }));
        var menu = routineFactory.CreateDailyMenu();
        menu.GetFoodSheet();
        var workout = routineFactory.CreateDailyWorkout();
        workout.GetTrainingSheet();
    }
}