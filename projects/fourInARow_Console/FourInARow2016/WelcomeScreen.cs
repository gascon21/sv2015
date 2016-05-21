using System;

namespace FourInARow2016
{
    class WelcomeScreen : Screen
    {
        public void DrawScreen()
        {
            Console.Clear();
            //Title
            Random rnd = new Random();
            int colorNum = rnd.Next(0, 7);
            char color = colorNum == 0 ? 'a' : colorNum == 1 ? 'b' :
                colorNum == 2 ? 'c' : colorNum == 3 ? 'g' :
                colorNum == 4 ? 'r' : colorNum == 5 ? 'm' : 'y';

            WriteText(4, color, "                ##    ##          ####" +
                "####  ##    ##              ");
            WriteText(5, color, "                ##    ##             #" +
                "#     ###   ##              ");
            WriteText(6, color, "                ##    ##             #" +
                "#     ####  ##              ");
            WriteText(7, color, "                ########             #" +
                "#     ## ## ##              ");
            WriteText(8, color, "                      ##             #" +
                "#     ##  ####              ");
            WriteText(9, color, "                      ##             #" +
                "#     ##   ###              ");
            WriteText(10, color, "                      ##          ####" +
                "####  ##    ##              ");

            WriteText(12, color, "       ######               ######   " +
                " #######   ##      ##       ");
            WriteText(13, color, "      ##    ##             ##    ##  " +
                "##     ##  ##  ##  ##       ");
            WriteText(14, color, "      ##    ##             ##    ##  " +
                "##     ##  ##  ##  ##       ");
            WriteText(15, color, "      ##    ##             #######   " +
                "##     ##  ##  ##  ##       ");
            WriteText(16, color, "      ########             ##  ##    " +
                "##     ##  ##  ##  ##       ");
            WriteText(17, color, "      ##    ##             ##   ##   " +
                "##     ##  ##  ##  ##       ");
            WriteText(18, color, "      ##    ##             ##    ##  " +
                " #######    ###  ###        ");

            // Options to choose
            WriteText(32, 'c', "F1 - New game - 2 Players");
            WriteText(34, 'g', "F2 - New game - Player vs Computer");
            WriteText(36, 'y', "F3 - Credits screen");
            WriteText(38, 'r', "ESC - Exit game");

            Console.ResetColor();
        }

        public int Display()
        {
            int option = 0;
            do
            {
                DrawScreen();

                // Play star wars music
                if (!Console.KeyAvailable)
                    Console.Beep(440, 500);
                DrawScreen();
                if (!Console.KeyAvailable)
                    Console.Beep(440, 500);
                DrawScreen();
                if (!Console.KeyAvailable)
                    Console.Beep(440, 500);
                DrawScreen();
                if (!Console.KeyAvailable)
                    Console.Beep(349, 350);
                DrawScreen();
                if (!Console.KeyAvailable)
                    Console.Beep(523, 150);
                DrawScreen();
                if (!Console.KeyAvailable)
                    Console.Beep(440, 500);
                DrawScreen();
                if (!Console.KeyAvailable)
                    Console.Beep(349, 350);
                DrawScreen();
                if (!Console.KeyAvailable)
                    Console.Beep(523, 150);
                DrawScreen();
                if (!Console.KeyAvailable)
                    Console.Beep(440, 1000);
                DrawScreen();
                if (!Console.KeyAvailable)
                    Console.Beep(659, 500);
                DrawScreen();
                if (!Console.KeyAvailable)
                    Console.Beep(659, 500);
                DrawScreen();
                if (!Console.KeyAvailable)
                    Console.Beep(659, 500);
                DrawScreen();
                if (!Console.KeyAvailable)
                    Console.Beep(698, 350);
                DrawScreen();
                if (!Console.KeyAvailable)
                    Console.Beep(523, 150);
                DrawScreen();
                if (!Console.KeyAvailable)
                    Console.Beep(415, 500);
                DrawScreen();
                if (!Console.KeyAvailable)
                    Console.Beep(349, 350);
                DrawScreen();
                if (!Console.KeyAvailable)
                    Console.Beep(523, 150);
                DrawScreen();
                if (!Console.KeyAvailable)
                    Console.Beep(440, 1000);

                ConsoleKeyInfo key;
                if (Console.KeyAvailable)
                {
                    key = Console.ReadKey();

                    if (key.Key == ConsoleKey.F1)
                        option = 1;
                    if (key.Key == ConsoleKey.F2)
                        option = 2;
                    if (key.Key == ConsoleKey.F3)
                        option = 3;
                    if (key.Key == ConsoleKey.Escape)
                        option = 4;
                }

            }
            while (option == 0);

            return option;
        }
    }
}
