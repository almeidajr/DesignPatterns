using DesignPatterns.Core;
using Humanizer;
using Spectre.Console;

namespace DesignPatterns.Creational.Singleton;

public class SingletonConsoleView : IConsoleView
{
    public string Label { get; } = nameof(Singleton).Humanize(LetterCasing.Title);

    public void Render()
    {
        var firstCall = DatabaseContext.GetInstance();
        var secondCall = DatabaseContext.GetInstance();

        AnsiConsole.WriteLine($"Checking if objects has the same reference: {ReferenceEquals(firstCall, secondCall)}");
    }
}