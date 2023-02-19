using System;
using SplashKitSDK;

public class Program
{
    //variables 
    private static bool Quit = false;


    public static void Main()
    {
        Window window = new Window("Space Adventures", 1400, 850);

        //The loop for the running of the game
        while (!window.CloseRequested && !Quit)
        {
            if (SplashKit.KeyTyped(KeyCode.EscapeKey))
            {
                Quit = true;
            }
            SplashKit.ProcessEvents();
            window.Refresh(60);
        }
    }
}