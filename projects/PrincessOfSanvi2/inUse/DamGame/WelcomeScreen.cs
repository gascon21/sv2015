/// <summary>
///  Hardware: to hide SDL details and allow an easier access
///  @author David Gascón and Sergio Martinez
/// </summary>

/* --------------------------------------------------         
   Versions history
   
   Num.   Date        By / Changes
   ---------------------------------------------------
   0.07  15-Apr-2016  David Gascón and Sergio Martinez:
                      Testing CreateImageFromText
   0.01  03-Jan-2016  Nacho: First welcome screen, with
                      options to Play, Quit and see the Credits
 ---------------------------------------------------- */

namespace DamGame
{
    class WelcomeScreen
    {
        public enum options { Play, Credits, Quit };
        private options optionChosen;

        public void Run()
        {
            Font font18 = new Font("data/Joystix.ttf", 18);
            Image player = new Image("data/player.png");
            Image welcomeText = Hardware.CreateImageFromText("SPACE or P to Play, Q to Quit, C for Credits",
                    0xCC, 0xCC, 0xCC,
                    font18);


            bool validOptionChosen = false;

            do
            {
                Hardware.ClearScreen();
                Hardware.DrawHiddenImage(welcomeText, 40, 10);

                Hardware.DrawHiddenImage(player, 400, 300);
                Hardware.ShowHiddenScreen();
            
                if (Hardware.KeyPressed(Hardware.KEY_SPC) || 
                    Hardware.KeyPressed(Hardware.KEY_P))
                {
                    validOptionChosen = true;
                    optionChosen = options.Play;
                }
                if (Hardware.KeyPressed(Hardware.KEY_Q))
                {
                    validOptionChosen = true;
                    optionChosen = options.Quit;
                }
                if (Hardware.KeyPressed(Hardware.KEY_C))
                {
                    validOptionChosen = true;
                    optionChosen = options.Credits;
                }
                Hardware.Pause(50);
            }
            while (!validOptionChosen);
        }

        public options GetOptionChosen()
        {
            return optionChosen;
        }


    }
}
