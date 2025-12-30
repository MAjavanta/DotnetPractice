using System;

namespace CookiesCookbook.Recipes;

public class Recipe(IEnumerable<Ingredient> ingredients)
{
    public IEnumerable<Ingredient> Ingredients { get; } = ingredients;

    public override string ToString()
    {
        List<string> strings = [];
        foreach (var ingredient in Ingredients)
        {
            strings.Add($"{ingredient.Name}. {ingredient.PrepInstructions}");
        }
        return string.Join(Environment.NewLine, strings);
    }
}
