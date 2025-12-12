namespace GameCharacter;

public interface ILiving : ICategoryPick {}

public class Living : ILiving
{
    public override string ToString()
    {
        return "Living";
    }
}