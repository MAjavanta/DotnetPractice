using System.Text.Json;

namespace CookiesCookbook.Recipes;

public class RecipeJsonRepository(IngredientRepository ingredientRepository) : IRecipeRepository
{
    private readonly IngredientRepository _ingredientRepository = ingredientRepository;
    public List<Recipe> Recipes { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public void AddRecipe(Recipe recipe)
    {
        throw new NotImplementedException();
    }

    public List<Recipe> Read(string filePath)
    {
        if (!File.Exists(filePath)) return [];

        var fileText = File.ReadAllText(filePath);
        var recipeStrings = JsonSerializer.Deserialize<List<string>>(fileText);
        if (recipeStrings is null) return [];

        List<Recipe> savedRecipes = [];
        foreach (var recipeString in recipeStrings)
        {
            savedRecipes.Add(new Recipe(_ingredientRepository.GetIngredientsFromList(recipeString)));
        }
        return savedRecipes;
    }
}
