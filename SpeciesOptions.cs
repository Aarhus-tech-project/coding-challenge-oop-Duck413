namespace GameCharacter;

public class Human : IHuman
{
    public override string ToString()
    {
        return "Human";
    }
}
public class Goblin : IGoblin
{
    public override string ToString()
    {
        return "Goblin";
    }
}
public class Unicorn : IUnicorn
{
    public override string ToString()
    {
        return "Unicorn";
    }
}
public class Dwarf : IDwarf
{
    public override string ToString()
    {
        return "Dwarf";
    }
}