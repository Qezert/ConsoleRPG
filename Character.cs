namespace ConsoleRPG;

public abstract class Character(int health)
{
    private int _health = health;

    public abstract int Attack();

    private void TakeDamage(int damage)
    {
        this._health -= damage;
    }
}