namespace CookiesCookbook;

public class Ingredient
{
    private static int _maxId = 0;
    public int Id { get; }
    public string Name { get; }
    public string PrepInstructions { get; }

    public Ingredient(string name, string prepInstructions)
    {
        Id = ++_maxId;
        Name = name;
        PrepInstructions = prepInstructions;
    }
}
