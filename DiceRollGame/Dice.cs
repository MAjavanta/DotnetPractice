namespace DiceRollGame;

public class Dice(int numberOfSides, Random random)
{

    public int RandomRoll { get; private set; }
    private Random _random = random;
    private readonly int _numberOfSides = numberOfSides;

    public void RollDice()
    {
        RandomRoll = _random.Next(1, _numberOfSides + 1);
    }

    public int GetSideCount() => _numberOfSides;
}
