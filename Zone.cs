namespace ConsoleRPG;

public class Zone(Zone previous, Zone next, Monster? boss)
{
    private Zone _previous = previous;
    private Zone _next = next;

    public Monster? Boss = boss;

    //TODO: Base the spawn on monster dict instead of parameter
    public Monster SpawnMonster(string name, int hp, int min, int max, int exp)
    {
        Monster monster = new Monster(name, hp, min, max, exp);
        Console.WriteLine($"You encounter a {name}!");
        return monster;
    }

    
    // Dict over which monsters the zone contains
}