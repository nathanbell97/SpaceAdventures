using System;
using SplashKitSDK;

class Player : GamePiece
{
    // Properties
    private double speed;
    private Bitmap playerbitmap;
    private double x;
    private double y;
    private double _lives;




    // Constructor
    public Player(Window window)
    {
        playerbitmap = new Bitmap("Player Spaceship", "spaceship.png");
        x = (window.Width / 2) - (playerbitmap.Width / 2);
        y = window.Height - playerbitmap.Height;
        //TO DO
    }



    // Methods
    public Boolean CollidesWith(GamePiece gamePiece)
    {
        return true;//TO DO
    }
    public void Draw()
    {
        playerbitmap.Draw(x, y);
    }
    public void Move()
    {
        //TO DO
    }
    public void Shoot()
    {
        //TO DO
    }
}