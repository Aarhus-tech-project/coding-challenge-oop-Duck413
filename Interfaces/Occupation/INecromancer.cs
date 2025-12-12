namespace GameCharacter;

public interface INecromancer : IOccupationPick {}

public class Necromancer : INecromancer
{
    public override string ToString()
    {
        return "Necromancer";
    }
}