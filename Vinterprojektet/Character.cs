using Raylib_cs;
using System.Numerics;
using System.Runtime;

public class Character
{
    protected Rectangle _charRect;

    public Character(Rectangle rect)
    {
        _charRect = rect;
    }
    
    protected Vector2 _movement = new Vector2(0, 0);
    protected float _speed = 5; 

    public void DrawCharacter()
    {
        Raylib.DrawRectangleRec(_charRect, Color.Black);
    }

    // protected int _hp;
    // private bool isAlive = true;
    // public void Hurt(int amount)
    // {
    // }
    // public int TakeDamage()
    // {
    //     _hp -= 5;
    //     return _hp;
    // }
}
