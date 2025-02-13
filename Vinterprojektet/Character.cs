using Raylib_cs;
using System.Numerics;
using System.Runtime;

public class Character
{
    // använder protected så att man fortfarande kan hämta från klasser som ärver, t.ex. Player.cs
    protected Rectangle _charRect;

    public Character(Rectangle rect)
    {
        _charRect = rect;
    }
    protected int _hp;
    
    protected Vector2 _movement = new Vector2(0, 0);
    protected float _speed = 5; 

    public void DrawCharacter()
    {
        Raylib.DrawRectangleRec(_charRect, Color.Black);
    }


    public virtual void Movement() {}
}
