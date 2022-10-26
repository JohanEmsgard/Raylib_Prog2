using System;

public class Avatar
{
    //Postion
    private Rectangle rect;
    private Texture2D sprite;

    public float speed = 5f;

    public Avatar()
    {
        sprite = Raylib.LoadTexture("sceptile.png");
        rect = new Rectangle(0,0, sprite.width, sprite.height);

    }

    //Movement
    public void Update()
    {
        if (Raylib.IsKeyDown(KeyboardKey.KEY_RIGHT))
        {
            rect.x += speed;
        }
        if (Raylib.IsKeyDown(KeyboardKey.KEY_LEFT))
        {
            rect.x -= speed;

        }
        if (Raylib.IsKeyDown(KeyboardKey.KEY_UP))
        {
            rect.y -= speed;
        }
        if (Raylib.IsKeyDown(KeyboardKey.KEY_DOWN))
        {
            rect.y += speed;
        }

        if (Raylib.IsKeyDown(KeyboardKey.KEY_A))
        {
            Raylib.DrawCircle((int)rect.x,(int)rect.y,50,Color.GREEN);
        }

    }

    //Bild
    public void Draw()
    {
        Raylib.DrawTexture(sprite, (int) rect.x,(int)rect.y,Color.WHITE);
    }


    
}
