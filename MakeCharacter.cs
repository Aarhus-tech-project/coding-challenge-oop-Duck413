namespace GameCharacter;

public class MakeCharacter
{
    private CharacterList _list;

    public MakeCharacter(CharacterList list)
    {
        _list = list;
    }
    
    public void CreatePredefinedCharacters()
    {
        CharacterModel character = new("Wizard", new Magical(), new Human(), new Necromancer());
        _list.AllCharacters.Add(character);

        CharacterModel character2 = new("Thief", new Living(), new Goblin(), new Blacksmith());
        _list.AllCharacters.Add(character2);

        CharacterModel character3 = new("Vampire", new Undead(), new Unicorn(), new Warlock());
        _list.AllCharacters.Add(character3);

        CharacterModel character4 = new("Clockwork Paladin", new Mechanical(), new Dwarf(), new Engineer());
        _list.AllCharacters.Add(character4);

        _list.ShowCharacters();
    }

    public void CreateCustomCharacter()
    {
        Console.WriteLine("\nDo you wish to create your own character?\n" +
            "Press Y to create a character, or any other key to only use the predefined characters:");
        ConsoleKey key = Console.ReadKey(true).Key;
        if (key != ConsoleKey.Y)
        {
            return;
        }
        else
        {
            Console.WriteLine("\nName your character:");
            string name = Console.ReadLine();

            Console.WriteLine("\nPick a category for your character:" +
                "Magical (press 1), Living (press 2), Undead (press 3), Mechanical (press 4)");
            ICategoryPick category = null;
            while (category == null)
            {
                string input = Console.ReadLine();
                if (int.TryParse(input, out int choice))
                {
                    category = choice switch
                    {
                        1 => new Magical(),
                        2 => new Living(),
                        3 => new Undead(),
                        4 => new Mechanical(),
                        _ => null
                    };
                }
                if (category == null)
                {
                   Console.WriteLine("\nInvalid selection. Please pick a valid category (1-4):"); 
                }
            };

            Console.WriteLine("\nPick a species for your character:" +
                "Human (press 1), Goblin (press 2), Unicorn (press 3), Dwarf (press 4)");
            ISpeciesPick species = null;
            while (species == null)
            {
                    string input = Console.ReadLine();
                    if (int.TryParse(input, out int choice))
                    {
                        species = choice switch
                        {
                            1 => new Human(),
                            2 => new Goblin(),
                            3 => new Unicorn(),
                            4 => new Dwarf(),
                            _ => null
                        };
                    }
                    if (species == null)
                    {
                    Console.WriteLine("\nInvalid selection. Please pick a valid category (1-4):"); 
                    }
            };
           

            Console.WriteLine("\nPick an occupation for your character:" +
                "Necromancer (press 1), Blacksmith (press 2), Warlock (press 3), Engineer (press 4)");
            IOccupationPick occupation = null;
            while (occupation == null)
            {
                string input = Console.ReadLine();
                if (int.TryParse(input, out int choice))
                {
                    occupation = choice switch
                    {
                        1 => new Necromancer(),
                        2 => new Blacksmith(),
                        3 => new Warlock(),
                        4 => new Engineer(),
                        _ => null
                    };
                }
                if (occupation == null)
                {
                   Console.WriteLine("\nInvalid selection. Please pick a valid occupation (1-4):"); 
                }
            };            
            CharacterModel character = new(name, category, species, occupation);
            _list.AllCharacters.Add(character);
            Console.WriteLine($"\nYour character {name} has been created, and is a {category} {species} {occupation}");
        }
    }
}