using DesignPatterns.Core;
using Humanizer;
using Spectre.Console;

namespace DesignPatterns.Creational.Prototype;

public class PrototypeConsoleView : IConsoleView
{
    public string Label { get; } = nameof(Prototype).Humanize(LetterCasing.Title);

    public void Render()
    {
        var person = new Person
        {
            Id = 42,
            Name = "John Doe",
            BirthDate = new DateTimeOffset(1999, 1, 1, 12, 0, 0, TimeSpan.Zero)
        };
        AnsiConsole.MarkupLine("[underline]Original object[/]");
        AnsiConsole.WriteLine(person.ToString());

        var shallowCopy = person.ShallowCopy();
        AnsiConsole.MarkupLine(
            $"[underline]{nameof(Person.ShallowCopy).Humanize()}[/] checking if objects has the same reference: {ReferenceEquals(person, shallowCopy)}");
        AnsiConsole.WriteLine(shallowCopy.ToString());

        var deepCopy = shallowCopy.DeepCopy();
        AnsiConsole.MarkupLine(
            $"[underline]{nameof(Person.DeepCopy).Humanize()}[/] checking if objects has the same reference: {ReferenceEquals(person, deepCopy)}");
        AnsiConsole.WriteLine(deepCopy.ToString());
    }
}