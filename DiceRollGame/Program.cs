using DiceRollGame;

Dice dice = new(6, new Random());
GameController controller = new(dice);
GameResult result = controller.PlayGame();
GameController.PrintResult(result);