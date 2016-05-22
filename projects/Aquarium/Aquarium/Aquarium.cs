// Aquarium - SDL
// 0.01  20-05-2016  David Gascón, Jorge Montalvo, Indra López: First version
// 0.02  22-05-2016  Nacho: Movement; ESC to exit

using System;

namespace Aquarium
{
    class Aquarium
    {
        private static MobileElement[] moveds;
        //private StaticElement[] fixeds;
        Image fish1 = new Image("fish1.png");
        Image fish2 = new Image("fish2.png");
        Image fish3 = new Image("fish3.png");
        Image fish4 = new Image("fish4.png");
        Image fish5 = new Image("fish5.png");
        Image bubble = new Image("bubble.png");
        Random r = new Random(5);
        bool finished = false;

        public Aquarium()
        {
            moveds = new MobileElement[10];
            moveds[0] = new MobileElement(r.Next(0, 1366), r.Next(0, 768), fish1, 2, 0);
            moveds[1] = new MobileElement(r.Next(0, 1366), r.Next(0, 768), fish2, 3, 0);
            moveds[2] = new MobileElement(r.Next(0, 1366), r.Next(0, 768), fish3, 7, 0);
            moveds[3] = new MobileElement(r.Next(0, 1366), r.Next(0, 768), fish3, 1, 0);
            moveds[4] = new MobileElement(r.Next(0, 1366), r.Next(0, 768), fish4, 3, 0);
            moveds[5] = new MobileElement(r.Next(0, 1366), r.Next(0, 768), fish5, 4, 0);
            moveds[6] = new MobileElement(r.Next(0, 1366), r.Next(0, 768), bubble, 0, -2);
            moveds[7] = new MobileElement(r.Next(0, 1366), r.Next(0, 768), bubble, 0, -4);
            moveds[8] = new MobileElement(r.Next(0, 1366), r.Next(0, 768), bubble, 0, -3);
            moveds[9] = new MobileElement(r.Next(0, 1366), r.Next(0, 768), bubble, 0, -2);
        }

        public void Run()
        {
            do { 
                // Draw
                Hardware.ClearScreen();
                for(int i = 0; i < moveds.Length ; i ++)
                    moveds[i].Draw();
                Hardware.ShowHiddenScreen();
                // Move
                for (int i = 0; i < moveds.Length; i++)
                    moveds[i].Move();
                // Check if we must exit
                if (Hardware.KeyPressed(Hardware.KEY_ESC))
                    finished = true;
                // And delay before the next frame
                Hardware.Pause(25);
            }
            while (!finished);
        }

        static void Main(string[] args)
        {
            bool fullScreen = false;
            Hardware.Init(1366, 768, 24, fullScreen);

            Aquarium a = new Aquarium();
            a.Run();
        }
    }
}
