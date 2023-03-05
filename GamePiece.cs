using SplashKitSDK;
public interface GamePiece
{
    //variables 
    double x {get;} //x position 
    double y {get;} //y position
    double speed {get;} //movement speed 
    Bitmap bitmap {get;} //game piece image 
    bool CollidesWith(GamePiece gamePiece); //checks if collision is true 
    void Draw(); //method to draw image 
    void Move(); //method to move image
}
