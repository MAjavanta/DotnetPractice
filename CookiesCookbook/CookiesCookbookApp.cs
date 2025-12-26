namespace CookiesCookbook;

public class CookiesCookbookApp
{
    public void Run()
    {
        Console.WriteLine("Printing available ingredients.");
        AvailableIngredients.PrintIngredients();
        Console.WriteLine("Add an ingredient by its ID, or type anything else if finished.");
        List<int> recipeIngredientIds = UserInput.CollectIngredientsFromList(AvailableIngredients.Ingredients);
        if (recipeIngredientIds.Count == 0)
        {
            Console.WriteLine("No ingredients have been selected. No recipe will be saved.");
        }
        else
        {
            Console.WriteLine("Recipe added.");
            List<Ingredient> recipeIngredients = [];
            foreach (var id in recipeIngredientIds)
            {
                if (AvailableIngredients.FindIngredientById(id) is Ingredient ingredient)
                {
                    recipeIngredients.Add(ingredient);
                }
            }
            var recipe = new Recipe(recipeIngredients);
            recipe.PrintRecipe();
        }
        Console.WriteLine("Press any key to exit.");
        Console.ReadKey();
    }
}