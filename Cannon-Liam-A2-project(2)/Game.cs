// Include the namespaces (code libraries) you need below.
using System;
using System.Numerics;

// The namespace your code is in.
namespace MohawkGame2D
{
    /// <summary>
    ///     Your game code goes inside this class!
    /// </summary>
    public class Game
    {
        float soulX;
        float soulY;
        public void Setup()
        {
            Window.ClearBackground(Color.Black);
            Window.SetSize(400, 400);
            Window.SetTitle("Undertale Soul Box");

        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {
            //Declare variables for position of the circle
            Window.ClearBackground(Color.Black);


            float inputX = 0;
            float inputY = 0;

            Draw.SetFillColor(Color.Red);
            Draw.Circle(soulX, soulY, 25);
            //Using module 1.4 as a baseline, testing if movement works
            if (Input.IsKeyboardKeyDown(KeyboardKey.W))
            {
                inputY -= 1;
            }
            if (Input.IsKeyboardKeyDown(KeyboardKey.S))
            {
                inputY += 1;
            }
            if (Input.IsKeyboardKeyDown(KeyboardKey.A))
            {
                inputX -= 1;
            }
            if (Input.IsKeyboardKeyDown(KeyboardKey.D))
            {
                inputX += 1;
            }

            soulX += inputX * 100 * Time.DeltaTime;
            soulY += inputY * 100 * Time.DeltaTime;

            if (Input.IsKeyboardKeyPressed(KeyboardKey.One)) //reorder this and do it a different way.
            {
                {
                    Draw.SetFillColor(Color.Blue);
                    Draw.Circle(soulX, soulY, 25);

                }














            }
        }

    }
}