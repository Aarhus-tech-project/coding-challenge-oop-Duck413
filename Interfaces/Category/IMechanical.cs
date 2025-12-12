namespace GameCharacter;

public interface IMechanical : ICategoryPick {}

public class Mechanical : IMechanical
{
    public override string ToString()
    {
        return "Mechanical";
    }
}