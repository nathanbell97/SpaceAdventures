using System;
using SplashKitSDK;

public class Program
{
    //variables 
    private static bool Quit = false;


    public static void Main()
    {
        Window window = new Window("Space Adventures", 1400, 850);
        Player player = new Player(window);

        //The loop for the running of the game
        while (!window.CloseRequested && !Quit)
        {
            if (SplashKit.KeyTyped(KeyCode.EscapeKey))
            {
                Quit = true;
            }
            player.Draw();
            SplashKit.ProcessEvents();
            window.Refresh(60);
        }
    }
}