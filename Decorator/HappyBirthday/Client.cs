using DesignPattern.Common;

namespace DesignPattern.HappyBirthday;

public class Client
{
    public void Handle(Cake cake)
    {
        Console.WriteLine($"Buying Cake: {cake.Name} of size: {cake.Dimensions}");
    }
}