namespace GameCharacter;

public class Magical : IMagical
{
    public override string ToString()
    {
        return "Magical";
    }
}
public class Living : ILiving
{
    public override string ToString()
    {
        return "Living";
    }
}
public class Undead : IUndead
{
    public override string ToString()
    {
        return "Undead";
    }
}
public class Mechanical : IMechanical
{
    public override string ToString()
    {
        return "Mechanical";
    }
}