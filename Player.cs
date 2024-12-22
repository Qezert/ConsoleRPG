using ConsoleRPG.Dicts;

namespace ConsoleRPG;

public class Player : Character
{
    private int maxHealth;
    public int health;
    private int maxMana;
    public int mana;
    public int experience;
    private int level;

    private static Player instance;

    private Player(int health, int mana) : base(health)
    {
        maxHealth = health;
        this.health = health;
        maxMana = mana;
        this.mana = mana;
        experience = 0;
        level = 1;
        instance = this;
    }

    public static Player getInstance(int _health, int _mana)
    {
        if (instance == null) instance = new Player(_health, _mana);
        return instance;
    }

    public override int Attack()
    {
        Random rnd = new Random();
        int damage = rnd.Next(this.level, this.level + 3);
        Console.WriteLine($"You deal {damage} damage!");
        return damage;
    }

    public void TakeDamage(int damage)
    {
        health -= damage;
        Console.WriteLine($"You now have {health} health");
    }

    public void ReceiveExperience(int exp)
    {
        this.experience += exp;
        Console.WriteLine($"You received {exp} experience.");
        Console.WriteLine($"You now have {this.experience} experience.");
        Console.WriteLine($"You need {LevelDicts.LevelExp[level] - this.experience} more experience to level up.");
        if (this.experience >= LevelDicts.LevelExp[level]) LevelUp();
    }

    private void LevelUp()
    {
        this.level++;
        this.maxHealth += 5;
        this.health = this.maxHealth;
        this.maxMana += 5;
        this.mana = this.maxMana;
    }
}