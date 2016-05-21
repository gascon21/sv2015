using System;
using System.Threading;

namespace FourInARow2016
{
    class CreditsScreen : Screen
    {
        private string[] names;
        private DateTime start;
        private int time;
        private bool quit;
        private int[] startY;
        private string[] jam;
        private int jamSize;
        private int[] spaces;

        public CreditsScreen()
        {
            jam = new string[] {
                "                 +",
                "              :,; ",
                "            :.;   ",
                "         ::,:;    ",
                "      ,,...:;     ",
                "    ..:,.,,;      ",
                "  .:;;.:;;;       ",
                " ;:;.;,;,:        ",
                "':#:;;';,:        ",
                "++';,.:,`         ",
                " ';+;:,;          ",
                "  +''++           ",
                "----------"
            };
            jamSize = 0;

            names = new string[5];
            //names[0] = "Programmed by";
            //names[1] = "Chen Chao";
            //names[2] = "Rubén Blanco Couce";
            //names[3] = "Pedro Antonio Pérez Paterna";
            //names[4] = "Sacha Laurent Van de Sijpe Bueno";

            // Set y for each line
            startY = new int[6];
            for (int i = 0; i < 6; i++)
                startY[i] = 35;

            spaces = new int[5];
            for (int i = 0; i < 5; i++)
                spaces[i] = 4;

            // start timer
            start = DateTime.Now;
            
            quit = false;
        }

        public void Display()
        {
            while (!quit)
            {
                // Check current time
                DateTime end = DateTime.Now;
                TimeSpan dif = end - start;
                time = dif.Seconds;

                // Check key
                ConsoleKeyInfo key;
                if (Console.KeyAvailable)
                {
                    key = Console.ReadKey();

                    if (key.Key == ConsoleKey.Escape)
                        quit = true;
                }

                Console.Clear();

                // Credits text
                if (startY[0] > 0)
                    names[0] = "P" + 
                        new string(' ', spaces[0]) + "r" + 
                        new string(' ', spaces[0]) + "o" + 
                        new string(' ', spaces[0]) + "g" + 
                        new string(' ', spaces[0]) + "r" + 
                        new string(' ', spaces[0]) + "a" + 
                        new string(' ', spaces[0]) + "m" + 
                        new string(' ', spaces[0]) + "m" + 
                        new string(' ', spaces[0]) + "e" + 
                        new string(' ', spaces[0]) + "d" + 
                        new string(' ', spaces[0]) + " " + 
                        new string(' ', spaces[0]) + "b" + 
                        new string(' ', spaces[0]) + "y";
                if (startY[1] > 0)
                    names[1] = "C" +
                        new string(' ', spaces[1]) + "h" +
                        new string(' ', spaces[1]) + "e" +
                        new string(' ', spaces[1]) + "n" +
                        new string(' ', spaces[1]) + " " +
                        new string(' ', spaces[1]) + "C" +
                        new string(' ', spaces[1]) + "h" +
                        new string(' ', spaces[1]) + "a" +
                        new string(' ', spaces[1]) + "o";
                if (startY[2] > 0)
                    names[2] = "R" +
                        new string(' ', spaces[2]) + "u" +
                        new string(' ', spaces[2]) + "b" +
                        new string(' ', spaces[2]) + "é" +
                        new string(' ', spaces[2]) + "n" +
                        new string(' ', spaces[2]) + " " +
                        new string(' ', spaces[2]) + "B" +
                        new string(' ', spaces[2]) + "l" +
                        new string(' ', spaces[2]) + "a" +
                        new string(' ', spaces[2]) + "n" +
                        new string(' ', spaces[2]) + "c" +
                        new string(' ', spaces[2]) + "o" +
                        new string(' ', spaces[2]) + " " +
                        new string(' ', spaces[2]) + "C" +
                        new string(' ', spaces[2]) + "o" +
                        new string(' ', spaces[2]) + "u" +
                        new string(' ', spaces[2]) + "c" +
                        new string(' ', spaces[2]) + "e";
                if (startY[3] > 0)
                    names[3] = "P" +
                        new string(' ', spaces[3]) + "e" +
                        new string(' ', spaces[3]) + "d" +
                        new string(' ', spaces[3]) + "r" +
                        new string(' ', spaces[3]) + "o" +
                        new string(' ', spaces[3]) + " " +
                        new string(' ', spaces[3]) + "A" +
                        new string(' ', spaces[3]) + "n" +
                        new string(' ', spaces[3]) + "t" +
                        new string(' ', spaces[3]) + "o" +
                        new string(' ', spaces[3]) + "n" +
                        new string(' ', spaces[3]) + "i" +
                        new string(' ', spaces[3]) + "o" +
                        new string(' ', spaces[3]) + " " +
                        new string(' ', spaces[3]) + "P" +
                        new string(' ', spaces[3]) + "é" +
                        new string(' ', spaces[3]) + "r" +
                        new string(' ', spaces[3]) + "e" +
                        new string(' ', spaces[3]) + "z" +
                        new string(' ', spaces[3]) + " " +
                        new string(' ', spaces[3]) + "P" +
                        new string(' ', spaces[3]) + "a" +
                        new string(' ', spaces[3]) + "t" +
                        new string(' ', spaces[3]) + "e" +
                        new string(' ', spaces[3]) + "r" +
                        new string(' ', spaces[3]) + "n" +
                        new string(' ', spaces[3]) + "a";
                if (startY[4] > 0)
                    names[4] = "S" +
                        new string(' ', spaces[4]) + "a" +
                        new string(' ', spaces[4]) + "c" +
                        new string(' ', spaces[4]) + "h" +
                        new string(' ', spaces[4]) + "a" +
                        new string(' ', spaces[4]) + " " +
                        new string(' ', spaces[4]) + "L" +
                        new string(' ', spaces[4]) + "a" +
                        new string(' ', spaces[4]) + "u" +
                        new string(' ', spaces[4]) + "r" +
                        new string(' ', spaces[4]) + "e" +
                        new string(' ', spaces[4]) + "n" +
                        new string(' ', spaces[4]) + "t" +
                        new string(' ', spaces[4]) + " " +
                        new string(' ', spaces[4]) + "V" +
                        new string(' ', spaces[4]) + "a" +
                        new string(' ', spaces[4]) + "n" +
                        new string(' ', spaces[4]) + " " +
                        new string(' ', spaces[4]) + "d" +
                        new string(' ', spaces[4]) + "e" +
                        new string(' ', spaces[4]) + " " +
                        new string(' ', spaces[4]) + "S" +
                        new string(' ', spaces[4]) + "i" +
                        new string(' ', spaces[4]) + "j" +
                        new string(' ', spaces[4]) + "p" +
                        new string(' ', spaces[4]) + "e" +
                        new string(' ', spaces[4]) + " " +
                        new string(' ', spaces[4]) + "B" +
                        new string(' ', spaces[4]) + "u" +
                        new string(' ', spaces[4]) + "e" +
                        new string(' ', spaces[4]) + "n" +
                        new string(' ', spaces[4]) + "o";

                // Scroll for each name
                WriteText(startY[0], 'y', names[0]);
                if (startY[0] > 0)
                    startY[0]--;
                else
                    names[0] = "";
                
                if (startY[0] % 5 == 0)
                {
                    spaces[0]--;
                    spaces[0] = spaces[0] >= 0 ? spaces[0] : 0;
                }

                if (time > 2)
                {
                    WriteText(startY[1], 'y', names[1]);
                    if (startY[1] > 0)
                        startY[1]--;
                    else
                        names[1] = "";

                    if (startY[1] % 5 == 0)
                    {
                        spaces[1]--;
                        spaces[1] = spaces[1] >= 0 ? spaces[1] : 0;
                    }
                }

                if (time > 5)
                {
                    WriteText(startY[2], 'y', names[2].Length > 80 ? 
                        names[2].Substring(0, 79) : names[2]);
                    if (startY[2] > 0)
                        startY[2]--;
                    else
                        names[2] = "";

                    if (startY[2] % 5 == 0)
                    {
                        spaces[2]--;
                        spaces[2] = spaces[2] >= 0 ? spaces[2] : 0;
                    }
                }

                if (time > 8)
                {
                    WriteText(startY[3], 'y', names[3].Length > 80 ?
                        names[3].Substring(0, 79) : names[3]);
                    if (startY[3] > 0)
                        startY[3]--;
                    else
                        names[3] = "";

                    if (startY[3] % 5 == 0)
                    {
                        spaces[3]--;
                        spaces[3] = spaces[3] >= 0 ? spaces[3] : 0;
                    }
                }

                if (time > 11)
                {
                    WriteText(startY[4], 'y', names[4].Length > 80 ?
                        names[4].Substring(0, 79) : names[4]);
                    if (startY[4] > 0)
                        startY[4]--;
                    else
                        names[4] = "";

                    if (startY[4] % 5 == 0)
                    {
                        spaces[4]--;
                        spaces[4] = spaces[4] >= 0 ? spaces[4] : 0;
                    }
                }

                if (time > 14)
                {
                    jamSize++;
                    jamSize = jamSize > jam.Length ? jam.Length : jamSize;
                    for (int i = 0; i < jamSize; i++)
                        WriteText(startY[5] + i, 'y', jam[i]);

                    if (startY[5] > 0)
                        startY[5]--;
                    else
                        quit = true;
                }
                Thread.Sleep(500);
            }

        }
    }
}
