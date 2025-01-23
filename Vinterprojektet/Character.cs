using Raylib_cs;
using System.Numerics;

public class Character
{
    private Rectangle charRect = new Rectangle(400, 500, 30, 30);
    private Vector2 movement = new Vector2(0, 0);
    private float speed = 5;

    public void DrawCharacter()
    {
        Raylib.DrawRectangleRec(charRect, Color.Black);
    }


    public Vector2 Movement (out Vector2 movement, float speed)
    {
        movement = Vector2.Zero;

        if (Raylib.IsKeyDown(KeyboardKey.Left))
        {
            movement.X = -1;
        }
        else if (Raylib.IsKeyDown(KeyboardKey.Right))
        {
            movement.X = 1;
        }
        if (Raylib.IsKeyDown(KeyboardKey.Up))
        {
            movement.Y = -1;
        }
        else if (Raylib.IsKeyDown(KeyboardKey.Down))
        {
            movement.Y = 1;
        }
        
        if (movement.Length() > 0)
        {
        movement = Vector2.Normalize(movement) * speed;
        }

        charRect.X += movement.X;
        charRect.Y += movement.Y;

        // bool undoCharX = false;     
        // bool undoCharY = false;

        // if (undoCharX == true)
        // {
        //     charRect.X -= movement.X;
        // }
        // if (undoCharY == true)
        // {
        //     charRect.Y -= movement.Y;
        // }

        return movement;
    }
    

}