namespace CookiesCookbook.Recipes;

public class RecipeTextRepository : IRecipeRepository
{
    public RecipeTextRepository(IngredientRepository ingredientRepository, string filePath)
    {
        _filePath = filePath;
        _ingredientRepository = ingredientRepository;
        Recipes = Read();

    }
    private readonly string _filePath;
    private readonly IngredientRepository _ingredientRepository;
    public List<Recipe> Recipes { get; set; }

    public void AddRecipe(Recipe recipe)
    {
        List<string> ids = [];
        Recipes.Add(recipe);
        foreach (var savedRecipe in Recipes)
        {
            ids.Add(savedRecipe.GetIds());
        }
        File.WriteAllText(_filePath, string.Join(Environment.NewLine, ids));
    }

    public List<Recipe> Read()
    {
        if (!File.Exists(_filePath)) return [];
        var fileText = File.ReadAllText(_filePath);
        var recipeStrings = ParseRecipeStrings(fileText);

        if (recipeStrings is null) return [];
        List<Recipe> savedRecipes = [];
        foreach (var recipeString in recipeStrings)
        {
            savedRecipes.Add(new Recipe(_ingredientRepository.GetIngredientsFromList(recipeString)));
        }
        return savedRecipes;
    }

    private static List<string>? ParseRecipeStrings(string? fileText)
    {
        if (fileText is null) return [];
        return [.. fileText.Split(Environment.NewLine)];
    }
}
