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
        /// <summary>
        ///     Setup runs once before the game loop begins.
        /// </summary>
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

            float soulX;
            float soulY;

            float inputX = 0;
            float inputY = 0;

           // Draw.SetFillColor(Color.Red);
           // Draw.Circle(200, 200, 25);
            // Using module 1.4 as a baseline, testing if movement works
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














        }
    }

}
