namespace ConsoleRPG.Spells;

public abstract class Spell(string name, int manaCost)
{
    public string Name { get; set; } = name;
    public int ManaCost { get; set; } = manaCost;

    public abstract void CastSpell(Player caster, Character target);
}