using System;

public class Avatar
{
    //Postion
    //Bild
    //Movement


    private Rectangle rect;
    private Texture2D sprite;

    public Avatar()
    {
        sprite = Raylib.LoadTexture("sceptile.png");
        rect = new Rectangle(0,0, sprite.width, sprite.height);

    }

    public void Draw()
    {
        Raylib.DrawTexture(
            sprite, 
           (int) rect.x,
            (int)rect.y,
            Color.BLUE
        );
    }
    
}
