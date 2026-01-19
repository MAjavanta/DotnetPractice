using CookiesCookbook.Recipes;

namespace CookiesCookbook.UserInteraction;

public interface IUserInteraction
{
    public void ShowRecipes(List<Recipe> recipes);
    public void DisplayIngredients();
    public void PromptForIngredients();
    public List<Ingredient> GetUserIngredients();
    public void DisplayNoIngredientSaved();
    public void Exit();
}