// Inga publika variabler - inkapsling - Get / Set
using Raylib_cs;

Raylib.InitWindow(800, 800, "A Cube");
Raylib.SetTargetFPS(60);

// VARIABLES
string scene = "start";
Character player = new();

while (!Raylib.WindowShouldClose())
{
//--------------------------------------------------------------------------------
//              SPELETS LOGIK
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