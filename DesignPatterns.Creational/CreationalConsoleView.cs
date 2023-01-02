using DesignPatterns.Core;
using DesignPatterns.Creational.AbstractFactory;
using DesignPatterns.Creational.FactoryMethod;
using DesignPatterns.Creational.Singleton;
using Spectre.Console;

namespace DesignPatterns.Creational;

public sealed class CreationalConsoleView : IConsoleView
{
    public string Label => nameof(Creational);

    public void Render()
    {
        var view = AnsiConsole.Prompt(
            new SelectionPrompt<IConsoleView>()
                .Title($"Select the {Label} Pattern:")
                .AddChoices(
                    new FactoryMethodConsoleView(),
                    new AbstractFactoryConsoleView(),
                    new SingletonConsoleView())
                .UseConverter(view => view.Label));
        view.Render();
    }
}