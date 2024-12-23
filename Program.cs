using ConsoleRPG;

bool RunFight(Monster m, Player p)
{
    // Executing combat
    while (m.Health > 0 && p.health > 0)
    {
        Console.WriteLine("> Press enter to attack!");
        Console.ReadLine();
        m.TakeDamage(p.Attack());
        p.TakeDamage(m.Attack());
    }

    // Player survived combat
    if (p.health > 0)
    {
        int exp = m.Die(p.health);
        p.ReceiveExperience(exp);
        return true;
    }

    // Player died
    Console.WriteLine("You were slain... try again!");
    return false;
}

Zone z1 = new Zone(1, null, null, null);
Player pc = Player.getInstance(25, 20);

Console.WriteLine($"You have {pc.health} Health, {pc.mana} Mana, and {pc.experience} Experience.");

Console.WriteLine("Press any key to fight your first monster!");
Console.ReadKey();

Monster m1 = z1.SpawnMonster();

if (!RunFight(m1, pc)) return; 

Console.WriteLine("Press enter to end the game");
Console.ReadLine();