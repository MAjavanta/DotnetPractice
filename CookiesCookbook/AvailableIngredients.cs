namespace CookiesCookbook;

public static class AvailableIngredients
{

    public static List<Ingredient> Ingredients { get; } =
        [
            new("Wheat flour", "Sieve."),
            new("Coconut flour", "Sieve."),
            new("Butter", "Melt on low head."),
            new("Chocolate", "Melt in a water bath."),
            new("Sugar", ""),
            new("Cardamom", "Take half a teaspoon."),
            new("Cinammon", "Take half a teaspoon."),
            new("Cocoa powder", "")
        ];

    public static Ingredient? FindIngredientById(int id)
    {
        var ingredient = Ingredients.Find(i => i.Id == id);
        if (ingredient is not null)
        {
            return ingredient;
        }
        else
        {
            return null;
        }
    }

    public static void PrintIngredients()
    {
        foreach (var ingredient in AvailableIngredients.Ingredients)
        {
            Console.WriteLine($"{ingredient.Id}. {ingredient.Name}");
        }
    }
}
