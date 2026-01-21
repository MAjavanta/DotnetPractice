namespace CookiesCookbook.Recipes;

public class RecipeTextRepository(IngredientRepository ingredientRepository, string filePath) : RecipeRepository(ingredientRepository, filePath)
{
    protected override List<string>? ParseRecipeString(string? fileText)
    {
        if (fileText is null) return [];
        return [.. fileText.Split(Environment.NewLine)];
    }

    protected override void WriteRecipeIds(List<string> ids)
    {
        File.WriteAllText(_filePath, string.Join(Environment.NewLine, ids));
    }
}
