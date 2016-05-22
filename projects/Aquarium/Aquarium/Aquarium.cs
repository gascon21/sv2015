// David Gascón, Jorge Montalvo, Indra López
// Aquiarium with SDL

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public Aquarium()
        {
            moveds = new MobileElement[10];
            moveds[0] = new MobileElement(r.Next(0, 1366), r.Next(0, 768), fish1, 2, 0);
            moveds[1] = new MobileElement(r.Next(0, 1366), r.Next(0, 768), fish2, 3, 0);
            moveds[2] = new MobileElement(r.Next(0, 1366), r.Next(0, 768), fish3, 7, 0);
            moveds[3] = new MobileElement(r.Next(0, 1366), r.Next(0, 768), fish3, 1, 0);
            moveds[4] = new MobileElement(r.Next(0, 1366), r.Next(0, 768), fish4, 3, 0);
            moveds[5] = new MobileElement(r.Next(0, 1366), r.Next(0, 768), fish5, 4, 0);
            moveds[6] = new MobileElement(r.Next(0, 1366), r.Next(0, 768), bubble, 0, 2);
            moveds[7] = new MobileElement(r.Next(0, 1366), r.Next(0, 768), bubble, 0, 4);
            moveds[8] = new MobileElement(r.Next(0, 1366), r.Next(0, 768), bubble, 0, 3);
            moveds[9] = new MobileElement(r.Next(0, 1366), r.Next(0, 768), bubble, 0, 2);
        }

        public void Run()
        {

            for(int i = 0; i < moveds.Length ; i ++)
                moveds[i].Draw();
            Hardware.ShowHiddenScreen();
            
        }
        static void Main(string[] args)
        {
            bool fullScreen = false;
            Hardware.Init(1366, 768, 24, fullScreen);

            Aquarium a = new Aquarium();

            do
            {
                a.Run();
            } while (true);

        }
    }
}
