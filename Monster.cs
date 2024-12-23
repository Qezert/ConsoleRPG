using System.Runtime.InteropServices.ComTypes;

namespace ConsoleRPG;
using ConsoleRPG.Dicts;

public class Monster(string type) : Character(MonsterDicts.monsterStats[type].health)
{
    private readonly (int health, int min, int max, int exp) _stats = MonsterDicts.monsterStats[type];
    public int Health = MonsterDicts.monsterStats[type].health;


    public override int Attack()
    {
        Random random = new Random();
        int damage = random.Next(_stats.min, _stats.max);
        Console.WriteLine($"The {type} deals {damage} damage!");
        return damage;

    }

    public override void TakeDamage(int damage)
    {
        Health -= damage;
    }

    public int Die(int health)
    {
        Console.WriteLine($"You defeated the {type} with {health} health left!");
        return _stats.exp;
    }
}