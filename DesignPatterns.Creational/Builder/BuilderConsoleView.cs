using DesignPatterns.Core;
using Humanizer;
using Spectre.Console;

namespace DesignPatterns.Creational.Builder;

public sealed class BuilderConsoleView : IConsoleView
{
    public string Label { get; } = nameof(Builder).Humanize(LetterCasing.Title);

    public void Render()
    {
        var function = AnsiConsole.Prompt(
            new SelectionPrompt<Func<Product>>()
                .Title("Select the type of product:")
                .AddChoices(ProductDirector.MinimalProduct, ProductDirector.FullProduct)
                .UseConverter(function => function.Method.Name.Humanize(LetterCasing.Title)));

        var product = function();
        AnsiConsole.Write(product.ListParts());
    }
}