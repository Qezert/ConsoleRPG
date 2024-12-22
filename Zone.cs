using ConsoleRPG.Dicts;

namespace ConsoleRPG;

public class Zone(int id, Zone previous, Zone next, Monster? boss)
{
    private Zone _previous = previous;
    private Zone _next = next;

    public Monster? Boss = boss;
    
    public Monster SpawnMonster()
    {
        List<string> monsterNames = ZoneDicts.MonstersInZone[id];
        Random random = new Random();
        int monsterIndex = random.Next(monsterNames.Count);
        string monsterName = monsterNames[monsterIndex];
        Monster monster = new Monster(monsterName);
        Console.WriteLine($"You encounter a {monsterName}!");
        return monster;
    }

    
    // Dict over which monsters the zone contains
}