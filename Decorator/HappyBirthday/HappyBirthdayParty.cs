using DesignPattern.Common;

namespace DesignPattern.HappyBirthday;

public class HappyBirthdayParty : AbstractParty
{
    protected override int EventNumber => 1;

    protected override void PartyImplementation()
    {
        var employee = new Employee();
        var client = new Client();
        var cake = new Cake("Miguel Party",
            new Size(188 * Length.Millimeter, 239 * Length.Millimeter, 28 * Length.Millimeter));
        
        client.Handle(cake);
        employee.Hanlde(cake);
    }
}