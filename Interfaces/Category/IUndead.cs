namespace GameCharacter;

public interface IUndead : ICategoryPick {}

public class Undead : IUndead
{
    public override string ToString()
    {
        return "Undead";
    }
}