using System.Text.Json;

namespace CookiesCookbook.Recipes;

public class RecipeJsonRepository(IngredientRepository ingredientRepository, string filePath) : RecipeRepository(ingredientRepository, filePath)
{
    protected override List<string>? ParseRecipeString(string? fileText)
    {
        if (fileText is null) return [];
        return JsonSerializer.Deserialize<List<string>>(fileText);
    }

    protected override void WriteRecipeIds(List<string> ids)
    {
        File.WriteAllText(_filePath, JsonSerializer.Serialize(ids));
    }
}
