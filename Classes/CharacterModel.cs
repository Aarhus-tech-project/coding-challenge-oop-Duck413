namespace GameCharacter;

public class CharacterModel : CharacterBase
{
    public ICategoryPick Category {get; set;}
    public ISpeciesPick Species {get; set;}
    public IOccupationPick Occupation {get; set;}

    public int Health {get; set;} = 100;
    public bool IsAlive {get; private set;} = true;

    public CharacterModel(string name, ICategoryPick category, ISpeciesPick species, IOccupationPick occupation) : base(name)
    {
        Category = category;
        Species = species;
        Occupation = occupation;
    }

    public override void SayName()
    {
        Console.WriteLine($"{Name} is a {Category} {Species} {Occupation}");
    }

    public void CharacterDeath()
    {
        if (Health <= 0)
        {
            IsAlive = false;
            Category = new Undead();
            Console.WriteLine($"{Name} has died and has become an {Category} {Species} {Occupation}");
        }
    }
}