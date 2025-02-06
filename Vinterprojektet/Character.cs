using Raylib_cs;
using System.Numerics;
using System.Runtime;

public class Character
{
    private int _hp;
    
    // don't know what i will do with this
    private bool isAlive = true;

    public void Hurt(int amount)
    {

    }
    public int Attack()
    {
        _hp -= 5;
        return _hp;
    }
}
