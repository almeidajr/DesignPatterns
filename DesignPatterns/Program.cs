using DesignPatterns.Core;
using DesignPatterns.Creational;
using Humanizer;
using Spectre.Console;

AnsiConsole.MarkupLine($"[bold underline]{nameof(DesignPatterns).Humanize(LetterCasing.Title)}[/]");

var view = AnsiConsole.Prompt(
    new SelectionPrompt<IConsoleView>()
        .Title($"Select the {nameof(DesignPatterns).Humanize().Singularize()}:")
        .AddChoices(new CreationalConsoleView())
        .UseConverter(view => view.Label));
view.Render();