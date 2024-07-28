using DiceRollGame;

Random random = new Random();
Dice dice = new Dice(random);
GuessingGame guessingGame = new GuessingGame(dice);
GameResult gameResult = guessingGame.Play();

guessingGame.PrintGameResult(gameResult);

Console.ReadKey();