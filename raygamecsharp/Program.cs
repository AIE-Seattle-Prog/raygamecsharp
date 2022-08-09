/*******************************************************************************************
*
*   raylib [core] example - Basic window
*
*   Welcome to raylib!
*
*   This example has been created using raylib-cs 4.0 (www.raylib.com)
*   raylib is licensed under an unmodified zlib/libpng license (View raylib.h for details)
*
*   Copyright (c) 2019-2022 Academy of Interactive Entertainment (@aie_usa)
*   Copyright (c) 2013-2016 Ramon Santamaria (@raysan5)
*
********************************************************************************************/

using Raylib_cs;                // core methods (InitWindow, BeginDrawing())
using System.Numerics;          // mathematics types (Vector2, Vector3, etc.)

namespace Examples
{
    public class CoreBasicWindow
    {
        public static int Main()
        {
            // Initialization
            //--------------------------------------------------------------------------------------
            const int screenWidth = 800;
            const int screenHeight = 450;

            Raylib.InitWindow(screenWidth, screenHeight, "raylib [core] example - basic window");

            Raylib.SetTargetFPS(60);
            //--------------------------------------------------------------------------------------

            // Main game loop
            while (!Raylib.WindowShouldClose())    // Detect window close button or ESC key
            {
                // Update
                //----------------------------------------------------------------------------------
                // TODO: Update your variables here
                //----------------------------------------------------------------------------------

                // Draw
                //----------------------------------------------------------------------------------
                Raylib.BeginDrawing();

                Raylib.ClearBackground(Color.RAYWHITE);

                Raylib.DrawText("Congrats! You created your first window!", 190, 200, 20, Color.MAROON);

                Raylib.EndDrawing();
                //----------------------------------------------------------------------------------
            }

            // De-Initialization
            //--------------------------------------------------------------------------------------
            Raylib.CloseWindow();        // Close window and OpenGL context
            //--------------------------------------------------------------------------------------

            return 0;
        }
    }
}