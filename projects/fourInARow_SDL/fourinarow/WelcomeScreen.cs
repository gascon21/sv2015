/* Four in a row, SDL version


0.01  20-May-2016  Sergio Martínez, Miguel Moya, Vicente Cuenca:
                   First release
0.02  21-May-2016  Nacho
                   Game can be quitted. Text about usable keys.
                   Screen adjusted to 800x600
*/
class WelcomeScreen
{
    public enum options { Play, Quit };
    private options optionChosen;

    Image ws;
    Image play;
    Font f;

    public WelcomeScreen()
    {
        ws = new Image("data/Welcome.png");
        play = new Image("data/Play.png");
        f = new Font("FreeSansBold.ttf", 14);
    }

    public void Run()
    {
        optionChosen = options.Play;
        bool validOptionChosen = false;

        Hardware.ClearScreen();
        Hardware.DrawHiddenImage(ws, 0, 0);
        Hardware.DrawHiddenImage(play, 120, 450);
        Hardware.WriteHiddenText("Press P to Play, Q to Quit", 300, 550,
            255, 255, 0, f);
        do
        {
            if (Mouse.ColisionWith(120, 450, 360, 517, true) ||
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

            Hardware.Pause(20);

            // Sometimes, ShowHiddenScreen does not work in the first frame,
            // so let's redraw
            Hardware.ShowHiddenScreen();

        }
        while (!validOptionChosen);
    }

    public options GetOptionChosen()
    {
        return optionChosen;
    }
}
