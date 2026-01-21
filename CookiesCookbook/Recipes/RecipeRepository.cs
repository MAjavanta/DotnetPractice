namespace CookiesCookbook.Recipes;

public abstract class RecipeRepository : IRecipeRepository
{
    public RecipeRepository(IngredientRepository ingredientRepository, string filePath)
    {
        _filePath = filePath;
        _ingredientRepository = ingredientRepository;
        Recipes = Read();

    }
    protected readonly IngredientRepository _ingredientRepository;
    protected readonly string _filePath;
    public virtual List<Recipe> Recipes { get; set; }

    public virtual void AddRecipe(Recipe recipe)
    {
        List<string> ids = [];
        Recipes.Add(recipe);
        foreach (var savedRecipe in Recipes)
        {
            ids.Add(savedRecipe.GetIds());
        }
        WriteRecipeIds(ids);
    }

    public virtual List<Recipe> Read()
    {
        if (!File.Exists(_filePath)) return [];

        var fileText = File.ReadAllText(_filePath);
        var recipeStrings = ParseRecipeString(fileText);
        if (recipeStrings is null) return [];

        List<Recipe> savedRecipes = [];
        foreach (var recipeString in recipeStrings)
        {
            savedRecipes.Add(new Recipe(_ingredientRepository.GetIngredientsFromList(recipeString)));
        }
        return savedRecipes;
    }

    protected abstract List<string>? ParseRecipeString(string? fileText);

    protected abstract void WriteRecipeIds(List<string> ids);
}
