using DesignPattern.Common;

namespace DesignPattern.HappyBirthday;

public class Cake(string? name, Size? dimensions)
{
    public string? Name { get; set; } = name;
    public Size? Dimensions { get; set; } = dimensions;

    public override string ToString() => $"{Name} - {Dimensions}";
}