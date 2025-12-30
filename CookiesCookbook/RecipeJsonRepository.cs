using System.Text.Json;
using CookiesCookbook.Recipes;

namespace CookiesCookbook;

public class RecipeJsonRepository(IngredientRepository ingredientRepository) : IRecipeRepository
{
    private IngredientRepository _ingredientRepository = ingredientRepository;
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
            List<Ingredient> ingredients = [];
            bool isValidRecipe = true;
            foreach (var ingredientId in recipeString)
            {
                var ingredient = _ingredientRepository.GetIngredientById(ingredientId);
                if (ingredient is null)
                {
                    isValidRecipe = false;
                    break;
                }
                ingredients.Add(ingredient);
            }
            if (isValidRecipe) savedRecipes.Add(new Recipe(ingredients));
        }
        return savedRecipes;
    }
}
