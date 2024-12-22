namespace ConsoleRPG.Dicts;

public abstract class ZoneDicts
{
    public static readonly Dictionary<int, List<string>> MonstersInZone = new()
    {
        {1, ["goblin", "zombie", "rat"] }
    };
}