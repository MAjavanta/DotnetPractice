
namespace DiceRollGame;

public static class UserGuess
{

    public static int PromptGuess(int maxValue)
    {
        while (true)
        {
            Console.WriteLine("Enter a number:");
            string? userInput = Console.ReadLine();

            if (int.TryParse(userInput, out int userGuess) && guessIsInRange(userGuess, maxValue))
            {
                return userGuess;
            }

            Console.WriteLine("Invalid Guess.");
        }
    }

    private static bool guessIsInRange(int userGuess, int maxValue)
    {
        return userGuess <= maxValue && userGuess > 0;
    }
}
