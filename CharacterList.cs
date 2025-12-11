namespace GameCharacter;

public class CharacterList
{
    public List<CharacterModel> AllCharacters = new();

    public void ShowCharacters()
    {
        foreach (CharacterModel c in AllCharacters)
        {
            c.SayName();
        }
    }
}