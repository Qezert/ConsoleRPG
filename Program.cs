using ConsoleRPG;

bool RunFight(Monster m, Player p)
{
    
    // Executing combat
    while (p.health > 0)
    {
        // Print input prompt for player
        Console.WriteLine("\n> 1: Attack \n> 2: Use Fire Bolt");
    
        // Get int from player
        int playerAction = PlayerController.GetPlayerAction(p);
        
        if (playerAction == 1)
        {
            m.TakeDamage(p.Attack());
        } else if (playerAction == 2)
        {
            p.Cast(p.spells["Fire Bolt"], m);
            Console.WriteLine($"\nYou now have {p.mana} mana");
        }

        if (m.Health > 0)
        {
            p.TakeDamage(m.Attack());
        }
        else break;
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

Console.WriteLine("> Press any key to fight your first monster!");
Console.ReadKey();

Monster m1 = z1.SpawnMonster();

if (!RunFight(m1, pc)) return; 

Console.WriteLine("\n> Press enter to end the game");
Console.ReadLine();