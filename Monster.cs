namespace ConsoleRPG;

public class Monster(int health, int minDamage, int maxDamage, int experience) : Character(health)
{
    public int Health = health;


    public override int Attack()
    {
        Random random = new Random();
        int damage = random.Next(minDamage, maxDamage);
        Console.WriteLine($"The monster deals {damage} damage!");
        return damage;

    }

    public void TakeDamage(int damage)
    {
        Health -= damage;
    }

    public int Die()
    {
        return experience;
    }
}