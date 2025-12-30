using System;

namespace CookiesCookbook.Recipes;

public class IngredientRepository
{
    private IEnumerable<Ingredient> _availableIngredients = [
        new Flour("Wheat flour", 1),
        new Flour("Coconut flour", 2),
        new BaseIngredient("Butter", 3, "Melt on low heat."),
        new BaseIngredient("Chocolate", 4, "Melt in water bath."),
        new BaseIngredient("Sugar", 5),
        new Spice("Cinnamon", 6),
        new Spice("Cardammom", 7),
        new BaseIngredient("Cocoa Powder", 8)
    ];

    public IEnumerable<Ingredient> GetIngredients => _availableIngredients;

    public Ingredient? GetIngredientById(int id)
    {
        foreach (var ingredient in _availableIngredients)
        {
            if (ingredient.Id == id) return ingredient;
        }
        return null;
    }
}
