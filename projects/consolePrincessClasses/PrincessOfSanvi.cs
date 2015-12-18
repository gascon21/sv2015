public class PrincessOfSanvi
{
    public WelcomeScreen  myWelcomeScreen;
    public ConfigScreen  myConfigScreen;
    public CreditsScreen  myCreditsScreen;
    public GameOverScreen  myGameOverScreen;
    public 

    static void Main(string[] args)
    {
        Game myGame = new Game();
        GameOverScreen gameEnd = new GameOverScreen();

        myGame.Run();
        gameEnd.Run();
    }
}
