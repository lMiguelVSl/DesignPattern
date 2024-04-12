namespace DesignPattern.Common;

public abstract class AbstractParty
{
    protected abstract int EventNumber { get; }
    protected abstract void PartyImplementation();

    public void Run()
    {
        Console.WriteLine($"EventNumber: {EventNumber}");
        PartyImplementation();

        Console.WriteLine(new string('-', 20));
        Console.WriteLine();
    }
}