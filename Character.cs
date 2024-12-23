namespace ConsoleRPG;

public abstract class Character(int health)
{
    private int _health = health;

    public abstract int Attack();

    public abstract void TakeDamage(int damage);
}