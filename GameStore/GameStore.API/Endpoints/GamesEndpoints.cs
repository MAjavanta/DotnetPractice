using GameStore.API.DTOs;

namespace GameStore.API.Endpoints;

public static class GamesEndpoints
{

    const string GET_GAME_ENDPOINT = "GetGame";

    private static readonly List<GameDto> games = [
        new (1, "Street Fighter", "Fighting", 19.99m, new DateOnly(1990,6,2)),
        new (2, "Mario Kart", "Racing", 29.99m, new DateOnly(2008,10,2)),
        new (3, "Legend of Zelda", "RPG", 48.99m, new DateOnly(2016,11,30)),
        new (4, "World's Hardest Game", "Puzzle", 0.99m, new DateOnly(2003,2,1)),
    ];

    public static void MapGamesEndpoints(this WebApplication app)
    {
        var group = app.MapGroup("/games");
        group.MapGet("/", () => games);

        group.MapGet("/{id:int}", (int id) =>
        {
            var game = games.Find(game => game.Id == id);
            return game is null
                ? Results.NotFound()
                : Results.Ok(game);
        })
        .WithName(GET_GAME_ENDPOINT);

        group.MapPost("/", (CreateGameDto newGame) =>
        {
            var maxIndex = games.Max(game => game.Id);
            GameDto game =
                new(
                    maxIndex + 1,
                    newGame.Name,
                    newGame.Genre,
                    newGame.Price,
                    newGame.ReleaseDate
                );
            games.Add(game);
            return Results.CreatedAtRoute(GET_GAME_ENDPOINT, new { id = game.Id }, game);
        });

        group.MapPut("/{id:int}", (int id, UpdateGameDto updatedGame) =>
        {
            var index = games.FindIndex(game => game.Id == id);

            if (index == -1)
                return Results.NotFound();

            games[index] = new(
                id,
                updatedGame.Name,
                updatedGame.Genre,
                updatedGame.Price,
                updatedGame.ReleaseDate
            );
            return Results.NoContent();
        });

        group.MapDelete("/{id:int}", (int id) =>
        {
            games.RemoveAll(game => game.Id == id);
            return Results.NoContent();
        });

    }
}