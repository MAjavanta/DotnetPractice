using System;

namespace CookiesCookbook;

public class CookiesCookbookApp
{
    public void Run()
    {
        Console.WriteLine("Printing available ingredients.");
        var ingredientList = new List<Ingredient>
        {
            new("Wheat flour", "Sieve."),
            new("Coconut flour", "Sieve."),
            new("Butter", "Melt on low head."),
            new("Chocolate", "Melt in a water bath."),
            new("Sugar", ""),
            new("Cardamom", "Take half a teaspoon."),
            new("Cinammon", "Take half a teaspoon."),
            new("Cocoa powder", "")
        };
        foreach (var ingredient in ingredientList)
        {
            Console.WriteLine($"{ingredient.Id}) {ingredient.Name}");
        }
        Console.WriteLine("Add an ingredient by its ID or type anything else if finished.");
    }
}
