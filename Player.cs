using ConsoleRPG.Dicts;
using ConsoleRPG.Spells;

namespace ConsoleRPG;

public class Player : Character
{
    private int maxHealth;
    public int health;
    private int maxMana;
    public int mana;
    public int experience;
    private int level;
    public Dictionary<string, Spell> spells;

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
        spells = new Dictionary<string, Spell>() {{"Fire Bolt", new FireBolt()}};
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
        Console.WriteLine($"\nYou deal {damage} damage!");
        return damage;
    }

    public void Cast(Spell spell, Character target)
    {
        spell.CastSpell(this, target);
    }

    public override void TakeDamage(int damage)
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
        Console.WriteLine($"You leveled up! \n You are now level {this.level}.");
        Console.WriteLine($"You have been healed to {this.health} health and {this.mana} Mana..");
    }

    public void LearnSpell(Spell spell)
    {
        this.spells.Add(spell.Name, spell);
    }
}