namespace GameCharacter;

public interface IGoblin : ISpeciesPick {}

public class Goblin : IGoblin
{
    public override string ToString()
    {
        return "Goblin";
    }
}