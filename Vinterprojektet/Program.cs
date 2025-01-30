using Raylib_cs;

Raylib.InitWindow(700, 700, "A Cube");
Raylib.SetTargetFPS(60);

// VARIABLES AND SUCH
string scene = "start";
Character player = new();

while (!Raylib.WindowShouldClose())
{
//--------------------------------------------------------------------------------
//              GAME LOGIC
//--------------------------------------------------------------------------------

    if (scene == "start")
    {
        if (Raylib.IsKeyPressed(KeyboardKey.Space))
        {
            scene = "tutorial";
        }
    }
    else if (scene == "tutorial")
    {
        if (Raylib.IsKeyPressed(KeyboardKey.Enter))
        {
            scene = "room1";
        }
    }
    else if (scene == "room1")
    {
        player.Movement();   
    }
    else if (scene == "finished" || scene == "gameOver")
    {
        if (Raylib.IsKeyPressed(KeyboardKey.Enter))
        {
            scene = "room1";
        }
    }
    
//--------------------------------------------------------------------------------
//              DRAWING
//--------------------------------------------------------------------------------

    Raylib.BeginDrawing();

    if (scene == "start")
    {
        Raylib.ClearBackground(Color.White);
    }

    else if (scene == "tutorial")
    {
        Raylib.ClearBackground(Color.Black);
    }
    
    else if (scene == "room1")
    {
        Raylib.ClearBackground(Color.White);
        player.DrawCharacter();
    }
    
    else if (scene == "finished")
    {
        Raylib.ClearBackground(Color.Black);
    }
    
    else if (scene == "gameOver")
    {
        Raylib.ClearBackground(Color.White);
    }
    
    
    Raylib.EndDrawing();
}