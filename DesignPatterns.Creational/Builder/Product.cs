using System.Text;

namespace DesignPatterns.Creational.Builder;

public sealed class Product
{
    private readonly List<string> _parts = new();

    public void Add(string part)
    {
        _parts.Add(part);
    }

    public string ListParts()
    {
        var builder = new StringBuilder();
        for (var i = 0; i < _parts.Count; i++) builder.AppendLine($"Part ({i + 1:00}) {_parts[i]}");

        return builder.ToString();
    }
}