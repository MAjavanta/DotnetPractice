namespace DiceRollGame;

public class GameController(Dice dice)
{
    private int _numberOfAttempts = 3;
    private readonly Dice _dice = dice;

    public GameResult PlayGame()
    {
        _dice.RollDice();
        int sideCount = _dice.GetSideCount();
        Console.WriteLine($"The {sideCount}-sided die has been rolled. You have {_numberOfAttempts} guesses.");
        while (_numberOfAttempts > 0)
        {
            int userGuess = UserGuess.PromptGuess(sideCount);
            if (userGuess == _dice.RandomRoll)
            {
                return GameResult.Victory;
            }
            else
            {
                Console.WriteLine("Incorrect.");
                _numberOfAttempts--;
            }
        }
        return GameResult.Loss;
    }

    public static void PrintResult(GameResult result)
    {
        string message = result == GameResult.Victory
            ? "You win!"
            : "You lose :(";

        Console.WriteLine(message);
    }
}
