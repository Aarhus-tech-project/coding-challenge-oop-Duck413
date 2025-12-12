namespace GameCharacter;

public interface IBlacksmith : IOccupationPick {}

public class Blacksmith : IBlacksmith
{
    public override string ToString()
    {
        return "Blacksmith";
    }
}