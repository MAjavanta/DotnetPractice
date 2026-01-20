using CookiesCookbook;
using CookiesCookbook.Extensions;
using CookiesCookbook.Recipes;
using CookiesCookbook.UserInteraction;

// Change this to read from/save to different file types
FileType fileType = FileType.Json;

string fileName = "recipes";

var filePath = Path.Combine(
    AppContext.BaseDirectory,
    fileType.GetFileName(fileName)
);
var ingredientRepo = new IngredientRepository();

IRecipeRepository recipeRepository = fileType == FileType.Json
        ? new RecipeJsonRepository(ingredientRepo, filePath)
        : new RecipeTextRepository(ingredientRepo, filePath);

var app = new CookiesCookbookApp(
    new ConsoleUserInteraction(
        ingredientRepo
    ),
    recipeRepository
);

app.Run();
