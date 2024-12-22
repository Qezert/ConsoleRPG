namespace ConsoleRPG.Dicts;

public class MonsterDicts
{
    public static Dictionary<string, (int health, int minDamage, int maxDamage, int experience)> monsterStats =
        new()
        {
            { "goblin", (9, 1, 5, 50) },
            { "zombie", (12, 1, 3, 50) },
            { "rat", (5, 1, 3, 20) }
        };
}