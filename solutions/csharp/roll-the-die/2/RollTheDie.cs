public class Player
{
    public static int RollDie() => new Random().Next(1, 19);

    public static double GenerateSpellStrength() => new Random().NextDouble() * 100;
}
