namespace GameCharacter;

public class Blacksmith : IBlacksmith
{
    public override string ToString()
    {
        return "Blacksmith";
    }
}
public class Engineer : IEngineer
{
    public override string ToString()
    {
        return "Engineer";
    }
}
public class Necromancer : INecromancer
{
    public override string ToString()
    {
        return "Necromancer";
    }
}
public class Warlock : IWarlock
{
    public override string ToString()
    {
        return "Warlock";
    }
}