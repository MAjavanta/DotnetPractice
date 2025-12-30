/* Planning app:

CookiesCookbookApp controls main flow:
    Read recipes from file if available
    Print recipes
    Prompt user to select ingredients
    Print all available ingredients
    User inputs ingredient Ids in a loop
    Print created recipe
    Exit
Entities:
- Ingredient
- Recipe
Need to store and collect recipes: RecipeRepository
    Storage and collection details could change
    Create IRecipeRepository
    RecipeJsonRepository, RecipeTxtRepository
Need to print instructions to the user and take their input: UserInteraction
    Method of communicating to the user could change
    Create IUserInteraction
    ConsoleUserInteraction
    Probably need to split out communicating to the user and reading input from the user
Need to store list of available ingredients: IngredientRepository
    Could change storage implementation details, e.g. file or DB could hold them
    IIngredientRepository
Need to print recipe: Recipe should define how to print itself, carried out in ConsoleUserInteraction
*/
using CookiesCookbook;
using CookiesCookbook.Recipes;

var app = new CookiesCookbookApp(
    new ConsoleUserInteraction(),
    new RecipeJsonRepository(
        new IngredientRepository()
    )
);
var filePath = "recipes.json";
app.Run(filePath);
