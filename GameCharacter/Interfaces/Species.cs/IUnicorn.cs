namespace GameCharacter;

public interface IUnicorn : ISpeciesPick {}

public class Unicorn : IUnicorn
{
    public override string ToString()
    {
        return "Unicorn";
    }
}