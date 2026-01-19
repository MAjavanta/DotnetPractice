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

    public List<Ingredient> GetIngredientsFromList(string ingredients)
    {
        List<Ingredient> ingredientList = [];
        foreach (var character in ingredients)
        {
            if (char.IsNumber(character))
            {
                Ingredient? ingredient = GetIngredientById(int.Parse(character.ToString()));
                if (ingredient is not null)
                {
                    ingredientList.Add(ingredient);
                }
                else
                {
                    return [];
                }
            }
        }
        return ingredientList;
    }

    public string ShowIngredients()
    {
        string ingredientRepo = "";
        foreach (var ingredient in _availableIngredients)
        {
            ingredientRepo += $"{ingredient.Id}. {ingredient.Name}" + Environment.NewLine;
        }
        return ingredientRepo;
    }
}
