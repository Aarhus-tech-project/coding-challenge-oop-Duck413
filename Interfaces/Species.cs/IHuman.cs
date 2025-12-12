namespace GameCharacter;

public interface IHuman : ISpeciesPick {}

public class Human : IHuman
{
    public override string ToString()
    {
        return "Human";
    }
}