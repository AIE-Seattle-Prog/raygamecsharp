/*******************************************************************************************
*
*   raylib [core] example - Basic window
*
*   Welcome to raylib!
*
*   This example has been created using raylib-cs 3.7.0.1 (www.raylib.com)
*   raylib is licensed under an unmodified zlib/libpng license (View raylib.h for details)
*
*   Copyright (c) 2019-2022 Academy of Interactive Entertainment (@aie_usa)
*   Copyright (C) 2018-2021 ChrisDill
*   Copyright (c) 2013-2016 Ramon Santamaria (@raysan5)
*
********************************************************************************************/

using System;                   // basic classes (Console)
using Raylib_cs;                // core methods (InitWindow, BeginDrawing())
using System.Numerics;          // mathematics types (Vector2, Vector3, etc.)

namespace RaygameCSharp
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

            Texture2D aieLogoTex = Raylib.LoadTexture("res/img/aielogo.png");

            //--------------------------------------------------------------------------------------

            // Main game loop
            while (!Raylib.WindowShouldClose())    // Detect window close button or ESC key
            {
                // Update
                //----------------------------------------------------------------------------------
                // TODO: Update your variables here
                //

                // Draw
                //----------------------------------------------------------------------------------
                // NOTE: origin of the world/positions (0,0) is top-left of window
                //
                Raylib.BeginDrawing();

                Raylib.ClearBackground(Color.RAYWHITE);

                Raylib.DrawTexture(aieLogoTex,                  // texture
                    screenWidth/2 - aieLogoTex.width/2,         // x-position
                    screenHeight/2 - aieLogoTex.height / 2,     // y-position
                    Color.WHITE);                               // tint

                Raylib.DrawText("Congrats! You created your first window!", // text
                    190,                                                    // x-position
                    392,                                                    // y-position
                    20,                                                     // font size
                    Raylib.ColorFromHSV(91, .65f, .51f));                   // tint

                Raylib.EndDrawing();
                //----------------------------------------------------------------------------------
            }

            // De-Initialization
            //--------------------------------------------------------------------------------------
            Raylib.CloseWindow();        // Close window and OpenGL context

            return 0;
        }
    }
}