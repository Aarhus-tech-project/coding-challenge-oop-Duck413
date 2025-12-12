namespace GameCharacter;

public interface IWarlock : IOccupationPick {}

public class Warlock : IWarlock
{
    public override string ToString()
    {
        return "Warlock";
    }
}