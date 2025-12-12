namespace GameCharacter;

public abstract class CharacterBase
{
    public string Name {get; set;}

    public CharacterBase(string name)
    {
        Name = name;
    }

    public virtual void SayName()
    {
        Console.WriteLine($"This characters name is {Name}");
    }
}