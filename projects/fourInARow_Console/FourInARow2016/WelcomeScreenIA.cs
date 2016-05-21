using System;

namespace FourInARow2016
{
    class WelcomeScreenIA : Screen
    {
        public void DrawScreen()
        {
            // Difficult level to choose
            WriteText(15, 'c', "PLAYER vs COMPUTER");
            WriteText(16, 'c', "--------------------");
            WriteText(18, 'c', "Choose IA level");
            WriteText(22, 'g', "F1 - Player vs Easy Computer");
            WriteText(24, 'y', "F2 - Player vs Average Computer");
            WriteText(26, 'r', "F2 - Player vs \"The Thinker\"");
            WriteText(32, 'w', "ESC - Back to Welcome Screen");
        }
        public int Display()
        {
            int level = 0;
            Console.Clear();
            do
            {
                DrawScreen();

                ConsoleKeyInfo key;
                if (Console.KeyAvailable)
                {
                    key = Console.ReadKey();

                    if (key.Key == ConsoleKey.F1)
                        level = 1;
                    if (key.Key == ConsoleKey.F2)
                        level = 2;
                    if (key.Key == ConsoleKey.F3)
                        level = 3;
                    if (key.Key == ConsoleKey.Escape)
                        level = 4;
                }
            } while (level == 0);

            return level;
        }
    }
}
