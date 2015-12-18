using System;

public class GameOverScreen : InfoScreen
{
    public void Run()
    {
        Console.Clear();
        Console.SetCursorPosition(35, 12);
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("Game Over!");

        Console.SetCursorPosition(1, 18);
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.ReadKey();
    }
}
