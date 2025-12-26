namespace CookiesCookbook;

public static class UserInput
{

    private static List<int> _recipeIngredientIds = [];
    public static List<int> CollectIngredientsFromList(List<Ingredient> ingredients)
    {
        while (true)
        {
            string input = Console.ReadLine() ?? string.Empty;
            bool isValidInt = int.TryParse(input, out int id);
            if (!isValidInt)
            {
                break;
            }
            var ingredient = ingredients.Find(i => i.Id == id);
            if (ingredient is not null)
            {
                _recipeIngredientIds.Add(ingredient.Id);
            }
            else
            {
                Console.WriteLine("Ingredient not found");
                continue;
            }
        }
        return _recipeIngredientIds;
    }
}
