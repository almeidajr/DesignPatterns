namespace DesignPatterns.Core;

public interface IConsoleView
{
    string Label { get; }
    void Render();
}