namespace CookiesCookbook;

public class Recipe
{
    private List<Ingredient> _ingredients;
    public Recipe(List<Ingredient> ingredients)
    {
        _ingredients = ingredients;
    }

    public void PrintRecipe()
    {
        foreach (var ingredient in _ingredients)
        {
            Console.WriteLine($"{ingredient.Name}. {ingredient.PrepInstructions} Add to other ingredients.");
        }
    }
}
