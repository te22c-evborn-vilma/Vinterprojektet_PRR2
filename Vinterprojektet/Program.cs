using Raylib_cs;

Raylib.InitWindow(700, 700, "A Cube");
Raylib.SetTargetFPS(60);

// VARIABLES AND SUCH
string scene = "start";
Player player = new Player(new Rectangle(4,4,32,32));
// Enemy enemy = new();



while (!Raylib.WindowShouldClose())
{
    //--------------------------------------------------------------------------------
    //              GAME LOGIC
    //--------------------------------------------------------------------------------

    // START SCREEN - the screen will move to the tutorial if the player presses SPACE
    if (scene == "start")
    {
        if (Raylib.IsKeyPressed(KeyboardKey.Space))
        {
            scene = "tutorial";
        }
    }
    // TUTORIAL SCREEN - the screen will move to ROOM 1 (challenge) if the player presses ENTER
    else if (scene == "tutorial")
    {
        if (Raylib.IsKeyPressed(KeyboardKey.Enter))
        {
            scene = "room1";
        }
    }
    // ROOM 1 - the point is that the screen will move to either the FINISHED-screen or the 
    // GAME OVER-screen depending on whether the player won or lost
    else if (scene == "room1")
    {
        player.Movement();
        // enemy.EnemyMovement();

        // "finished" för att testa nu - annars ska det stå att spelaren behöver nå en viss position för att gå vidare
        if (Raylib.IsKeyPressed(KeyboardKey.Space))
        {
            scene = "finished";
        }
    }
    // FINISHED/GAME OVER - the player can press ENTER to play again and the screen moves to ROOM 1
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
        // enemy.DrawEnemy();
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