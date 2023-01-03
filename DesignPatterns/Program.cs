using DesignPatterns.Core;
using DesignPatterns.Creational;
using DesignPatterns.Structural.Adapter;
using Humanizer;
using Spectre.Console;

AnsiConsole.MarkupLine($"[bold underline]{nameof(DesignPatterns).Humanize(LetterCasing.Title)}[/]");

do
{
    var view = AnsiConsole.Prompt(
        new SelectionPrompt<IConsoleView>()
            .Title($"Select the {nameof(DesignPatterns).Humanize().Singularize()}:")
            .AddChoices(
                new CreationalConsoleView(),
                new AdapterConsoleView())
            .UseConverter(view => view.Label));
    view.Render();
} while (AnsiConsole.Confirm("Back to start?"));

AnsiConsole.MarkupLine("[bold underline]Goodbye![/]");