using Humanizer;

namespace DesignPatterns.Creational.Prototype;

public sealed class Person
{
    public required int Id { get; init; }
    public required string Name { get; init; }
    public required DateTimeOffset BirthDate { get; init; }

    public Person ShallowCopy()
    {
        return (Person)MemberwiseClone();
    }

    public Person DeepCopy()
    {
        return new Person
        {
            Id = Id,
            Name = Name,
            BirthDate = new DateTimeOffset(BirthDate.UtcDateTime)
        };
    }

    public override string ToString()
    {
        return $"""
            {nameof(Id)}: {Id}
            {nameof(Name)}: {Name}
            {nameof(BirthDate).Humanize(LetterCasing.Title)}: {BirthDate}
            """;
    }
}