namespace DiceRollGame;

public class GuessingGame
{
    private readonly Dice _dice;
    private const int InitialTries = 3;

    public GuessingGame(Dice dice)
    {
        _dice = dice;
    }

    public GameResult Play()
    {
        int diceRollResult = _dice.Roll();
        Console.WriteLine($"Dice rolled, you have {InitialTries} tries left.");

        int triesLeft = InitialTries;
        while (triesLeft > 0)
        {
            int guess = ConsoleReader.ReadInteger("Enter a number");
            if (guess == diceRollResult)
            {
                Console.WriteLine("You win!");
                return GameResult.Victory;
            }
            Console.WriteLine("Wrong Number");
            --triesLeft;
        }

        return GameResult.Loss;
    }

    public void PrintGameResult(GameResult gameResult)
    {
        string message = gameResult == GameResult.Victory ? "You Win!" : "You Lose.";
    }
    
    
}