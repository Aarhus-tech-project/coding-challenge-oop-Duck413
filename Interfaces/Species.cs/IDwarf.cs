namespace GameCharacter;

public interface IDwarf : ISpeciesPick {}

public class Dwarf : IDwarf
{
    public override string ToString()
    {
        return "Dwarf";
    }
}