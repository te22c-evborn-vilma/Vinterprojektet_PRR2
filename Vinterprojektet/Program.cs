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

        // "finished" för att testa nu - annars ska det stå att spelaren behöver nå en viss position för att gå vidare
        if (Raylib.IsKeyPressed(KeyboardKey.Space))
        {
            scene = "finished";
        }
    }
    else if (scene == "finished" || scene == "gameOver")
    {
        if (Raylib.IsKeyPressed(KeyboardKey.Enter))
        {
            scene = "room1";
            // efter här är tanken att rum1 ska reset och player ska börja på samma startpunkt
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