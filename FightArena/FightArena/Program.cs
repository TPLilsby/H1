
using FightArena;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello World!");

        //Makews new arena
        FightingArena arena = new FightingArena();

        //Calls method Start Game
        arena.StartGame();
    }
}