namespace GameCharacter;

public class RunGame
{
    private CharacterList _list;

    public RunGame()
    {
        _list = new CharacterList();
    }
    
    public void StartGame()
    {
        MakeCharacter creator = new(_list);
        creator.CreatePredefinedCharacters();
        creator.CreateCustomCharacter(); 
    }

    public void MakeAllUndead()
    {
        foreach (CharacterModel c in _list.AllCharacters)
        {
            if (c.Category is not Undead)
            {
                c.Health -= 100;
                c.CharacterDeath();
            }
        }
    }

    public void PlayGame()
    {
        Console.WriteLine("\n-----THE GAME STARTS----\n");
        StartGame();
        Console.WriteLine("\n-----THE FOLLOWING CHARACTERS ARE CREATED-----\n");
        foreach (CharacterModel c in _list.AllCharacters)
        {
            Console.WriteLine($"{c.Name} the {c.Category} {c.Species} {c.Occupation} has {c.Health} health.");
        }
        Console.WriteLine("\n-----THE GAME TAKES PLACE-----\n");
        MakeAllUndead();
        Console.WriteLine("\n-----ALL PLAYERS ARE UNDEAD-----\n");
    }
}