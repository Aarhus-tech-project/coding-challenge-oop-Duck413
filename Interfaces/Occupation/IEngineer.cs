namespace GameCharacter;

public interface IEngineer : IOccupationPick {}

public class Engineer : IEngineer
{
    public override string ToString()
    {
        return "Engineer";
    }
}