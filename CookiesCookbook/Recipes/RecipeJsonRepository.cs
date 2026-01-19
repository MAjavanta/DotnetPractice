using System.Text.Json;

namespace CookiesCookbook.Recipes;

public class RecipeJsonRepository : IRecipeRepository
{
    public RecipeJsonRepository(IngredientRepository ingredientRepository, string filePath)
    {
        _filePath = filePath;
        _ingredientRepository = ingredientRepository;
        Recipes = Read();

    }
    private readonly IngredientRepository _ingredientRepository;
    private readonly string _filePath;
    public List<Recipe> Recipes { get; set; }

    public void AddRecipe(Recipe recipe)
    {
        List<string> ids = [];
        Recipes.Add(recipe);
        foreach (var savedRecipe in Recipes)
        {
            ids.Add(savedRecipe.GetIds());
        }
        File.WriteAllText(_filePath, JsonSerializer.Serialize(ids));
    }

    public List<Recipe> Read()
    {
        if (!File.Exists(_filePath)) return [];

        var fileText = File.ReadAllText(_filePath);
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
