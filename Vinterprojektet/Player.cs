using Raylib_cs;
using System.Numerics;

public class Player : Character
{
    public Player(Rectangle rect) : base(rect){}

    public void Movement()
    {
        _movement = Vector2.Zero;

        if (Raylib.IsKeyDown(KeyboardKey.Left) || Raylib.IsKeyDown(KeyboardKey.A))
        {
            _movement.X = -1;
        }
        else if (Raylib.IsKeyDown(KeyboardKey.Right) || Raylib.IsKeyDown(KeyboardKey.D))
        {
            _movement.X = 1;
        }
        if (Raylib.IsKeyDown(KeyboardKey.Up) || Raylib.IsKeyDown(KeyboardKey.W))
        {
            _movement.Y = -1;
        }
        // else if (Raylib.IsKeyDown(KeyboardKey.Down) || Raylib.IsKeyDown(KeyboardKey.S))
        // {
        //     _movement.Y = 1;
        // }

        if (_movement.Length() > 0)
        {
            _movement = Vector2.Normalize(_movement) * _speed;
        }

        _charRect.X += _movement.X;
        _charRect.Y += _movement.Y;
    }

    // private Rectangle _charRect = new Rectangle(400, 500, 30, 30);
    // private Vector2 _movement = new Vector2(0, 0);
    // private float _speed = 5;
    // call for DrawPlayer in program.cs to draw the player
    // public void DrawPlayer()
    // {
    //     Raylib.DrawRectangleRec(_charRect, Color.SkyBlue);
    // }
}
