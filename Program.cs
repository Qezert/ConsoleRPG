using ConsoleRPG;

Player pc = Player.getInstance(25, 20);
Monster m1 = new Monster("goblin", 9, 1, 5, 50);

Console.WriteLine($"You have {pc.health} Health, {pc.mana} Mana, and {pc.experience} Experience.");

Console.WriteLine("Press any key to fight your first monster!");
Console.ReadKey();

Console.WriteLine("It's a small goblin!");

while (m1.Health > 0 && pc.health > 0)
{
    m1.TakeDamage(pc.Attack());
    pc.TakeDamage(m1.Attack());
    Console.WriteLine("Press enter to keep fighting!");
    Console.ReadLine();
}

if (pc.health > 0)
{
    int exp = m1.Die(pc.health);
    pc.ReceiveExperience(exp);
}
else
{
    Console.WriteLine("You were slain by the goblin - try again!");
}
Console.WriteLine("Press enter to end the game");
Console.ReadLine();