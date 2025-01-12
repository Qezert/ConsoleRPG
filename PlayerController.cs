namespace ConsoleRPG;

public abstract class PlayerController
{
    public static int GetPlayerAction(Player p)
    {
        var input = Console.ReadKey();
        return int.Parse(input.KeyChar.ToString());
    }
}