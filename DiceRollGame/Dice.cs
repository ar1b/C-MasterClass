namespace DiceRollGame;

public class Dice
{
    private readonly Random _random;
    private const int _sides = 6;

    public Dice(Random random)
    {
        _random = random;
    }

    public int Roll()
    {
        return _random.Next(1, _sides+1);
    }
}