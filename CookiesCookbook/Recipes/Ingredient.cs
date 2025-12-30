namespace CookiesCookbook.Recipes;

public abstract class Ingredient
{
    private static List<int> _usedIds = [];
    private const string _baseInstruction = "Add to other ingredients.";
    protected Ingredient(string name, int newId, string prepInstructions = "")
    {
        Name = name;
        bool usedId = false;
        foreach (var id in _usedIds)
        {
            if (id == newId) usedId = true;
        }
        if (!usedId)
        {
            Id = newId;
        }
        else
        {
            throw new Exception("Id already used");
        }
        if (prepInstructions == "")
        {
            PrepInstructions = _baseInstruction;
        }
        else
        {
            PrepInstructions = $"{_baseInstruction} {prepInstructions}";
        }
    }
    public int Id { get; internal set; }
    public string Name { get; init; }
    public virtual string PrepInstructions { get; init; }
    public override string ToString()
    {
        return $"{Name}. {PrepInstructions}";
    }
}
