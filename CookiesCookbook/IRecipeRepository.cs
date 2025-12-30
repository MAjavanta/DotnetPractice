using CookiesCookbook.Recipes;

namespace CookiesCookbook;

public interface IRecipeRepository
{
    public List<Recipe> Recipes { get; set; }
    public List<Recipe> Read(string filePath);
    public void AddRecipe(Recipe recipe);
}