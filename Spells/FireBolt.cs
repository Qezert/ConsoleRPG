namespace ConsoleRPG.Spells;

public class FireBolt() : Spell("FireBolt", 8)
{
    public override void CastSpell(Player caster, Character target)
    {
        
        caster.mana -= this.ManaCost;
        Random random = new Random();
        int damage = random.Next(6, 9);
        Console.WriteLine($"\nYou cast {this.Name} dealing {damage} damage!");
        target.TakeDamage(damage);
    }
}