using System;

namespace CookiesCookbook.Recipes;

public class BaseIngredient(string name, int id, string prepInstructions = "") : Ingredient(name, id, prepInstructions)
{
}
