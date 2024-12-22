namespace ConsoleRPG.Dicts;

public abstract class LevelDicts
{
    public static readonly Dictionary<int, int> LevelExp = new Dictionary<int, int>()
    {
        {1, 100},
        {2, 250},
        {3, 500},
        {4, 800},
        {5, 1400},
        {6, 2200},
    };
}