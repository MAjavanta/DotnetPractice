using CookiesCookbook.Recipes;

namespace CookiesCookbook.UserInteraction;

public class ConsoleUserInteraction(IngredientRepository ingredientRepository) : IUserInteraction
{
    private readonly IngredientRepository _ingredientRepository = ingredientRepository;
    private readonly string NEW_LINE = Environment.NewLine;
    public void DisplayIngredients()
    {
        Console.WriteLine("Available ingredients are:");
        Console.WriteLine(_ingredientRepository.ShowIngredients());
    }

    public void DisplayNoIngredientSaved()
    {
        Console.WriteLine("No ingredients have been selected. Recipe will not be saved");
    }

    public void Exit()
    {
        Console.WriteLine("Press any key to exit");
        Console.ReadKey();
    }

    public List<Ingredient> GetUserIngredients()
    {
        List<Ingredient> userIngredients = [];
        while (true)
        {
            Console.WriteLine("Enter an id to select the ingredient. Enter anything other than a number to finish");
            if (int.TryParse(Console.ReadLine(), out int id))
            {
                var ingredient = _ingredientRepository.GetIngredientById(id);
                if (ingredient is null)
                {
                    Console.WriteLine($"No ingredient found with id: {id}");
                }
                else
                {
                    userIngredients.Add(ingredient);
                }
                continue;
            }
            break;
        }
        return userIngredients;
    }

    public void PromptForIngredients()
    {
        Console.WriteLine("Create a new recipe!");
        DisplayIngredients();
        Console.WriteLine("Add an ingredient by its ID or type anything else if finished.");
    }

    public void ShowRecipes(List<Recipe> recipes)
    {
        for (var i = 0; i < recipes.Count; i++)
        {
            Console.WriteLine($"*******{i + 1}*******");
            Console.WriteLine(recipes[i]);
            Console.WriteLine(NEW_LINE);
        }
    }
}
