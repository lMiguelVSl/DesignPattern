using DesignPattern.Common;

namespace DesignPattern.HappyBirthday;

public class Employee
{
    public void Hanlde(Cake cake)
    {
        var originalSize = cake.Dimensions!;
        var packagedSize =
            originalSize.Add(new Size(7 * Length.Millimeter, 7 * Length.Millimeter, 7 * Length.Millimeter));
        
        Console.WriteLine($"Selling cake with box {cake.Name} size {packagedSize}");
    }
}