using DesignPatterns.Core;
using Humanizer;
using Spectre.Console;

namespace DesignPatterns.Structural.Adapter;

public sealed class AdapterConsoleView : IConsoleView
{
    public string Label { get; } = nameof(Adapter).Humanize(LetterCasing.Title);

    public void Render()
    {
        var thirdPart = new ThirdPartyCode();
        var target = new Adapter(thirdPart);

        AnsiConsole.WriteLine($"Method {nameof(ThirdPartyCode.GetSpecificRequest)} called from {nameof(Adapter)}");
        AnsiConsole.WriteLine(target.GetRequest());
    }
}