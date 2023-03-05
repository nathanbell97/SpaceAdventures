using System;
using SplashKitSDK;

class Player
{
    // Properties
    private int speed;
    private Bitmap playerbitmap;
    private int x;
    private int y;




    // Constructor
    public Player(Window window)
    {
        playerbitmap = new Bitmap("Player Spaceship", "spaceship.png");
        x = (window.Width / 2) - (playerbitmap.Width / 2);
        y = window.Height - playerbitmap.Height;
    }



    // Methods
    public void Draw()
    {
        playerbitmap.Draw(x, y);
    }

}