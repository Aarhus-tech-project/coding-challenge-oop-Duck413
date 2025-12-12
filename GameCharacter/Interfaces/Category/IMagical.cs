namespace GameCharacter;

public interface IMagical : ICategoryPick {}

public class Magical : IMagical
{
    public override string ToString()
    {
        return "Magical";
    }
}