//Sergio Martínez, Miguel Moya, Vicente Cuenca
class WelcomeScreen
{
    public enum options { Play, Quit };
    private options optionChosen;

    public void Run()
    {
        optionChosen = options.Play;
        Image ws = new Image("data/Welcome.png");
        Image play = new Image("data/Play.png");

        bool validOptionChosen = false;

        Hardware.ClearScreen();
        Hardware.DrawHiddenImage(ws, 0, 0);
        Hardware.DrawHiddenImage(play, 220, 400);
        Hardware.ShowHiddenScreen();
        do
        {
            if (Mouse.ColisionWith(220, 400, 460, 467, true) ||
                Hardware.KeyPressed(Hardware.KEY_P))
            {
                validOptionChosen = true;
                optionChosen = options.Play;
            }
            if (Hardware.KeyPressed(Hardware.KEY_Q))

                Hardware.Pause(20);
        }
        while (!validOptionChosen);
    }
    public options GetOptionChosen()
    {
        return optionChosen;
    }
}
