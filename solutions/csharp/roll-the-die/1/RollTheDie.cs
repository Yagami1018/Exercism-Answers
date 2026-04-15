public class Player
{
    private readonly Random random = new();
    public int RollDie() => random.Next(1, 19);

    public double GenerateSpellStrength() => random.NextDouble() * 100;
}
