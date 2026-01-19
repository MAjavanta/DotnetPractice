using CookiesCookbook.Recipes;
using CookiesCookbook.UserInteraction;

namespace CookiesCookbook;

public class CookiesCookbookApp(IUserInteraction userInteraction, IRecipeRepository recipeRepository)
{
    private readonly IUserInteraction _userInteraction = userInteraction;
    private readonly IRecipeRepository _recipeRepository = recipeRepository;
    public void Run(string filePath)
    {
        var recipesFromFile = _recipeRepository.Read(filePath);
        _userInteraction.ShowRecipes(recipesFromFile);
        _userInteraction.PromptForIngredients();
        var ingredientList = _userInteraction.GetUserIngredients();
        if (ingredientList.Count > 0)
        {
            var recipe = new Recipe(ingredientList);
            // _recipeRepository.AddRecipe(recipe);
            Console.WriteLine(recipe);
        }
        else
        {
            _userInteraction.DisplayNoIngredientSaved();
        }
        // _userInteraction.Exit();
    }
}
