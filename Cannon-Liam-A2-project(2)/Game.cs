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
        float soulX; //declare the soul positions
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

            //this block of code changes the color of the soul
            if (Input.IsKeyboardKeyDown(KeyboardKey.One))
                Draw.SetFillColor(Color.Red);
            else if (Input.IsKeyboardKeyDown(KeyboardKey.Two))
                Draw.SetFillColor(Color.Cyan);
            else if (Input.IsKeyboardKeyDown(KeyboardKey.Three))
                Draw.SetFillColor(Color.Blue);
            else if (Input.IsKeyboardKeyDown(KeyboardKey.Four))
                Draw.SetFillColor(Color.Green);
            else if (Input.IsKeyboardKeyDown(KeyboardKey.Five))
                Draw.SetFillColor(Color.Yellow);
            else if (Input.IsKeyboardKeyDown(KeyboardKey.Six))
                Draw.SetFillColor(Color.Magenta);
            else if (Input.IsKeyboardKeyDown(KeyboardKey.Seven))
                Draw.SetFillColor("#fca600");
          




        
            //soul needs to be drawn after the color is set
            Draw.Circle(soulX, soulY, 25);
            //movement controls,
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
            if (Input.IsKeyboardKeyDown(KeyboardKey.LeftShift))
            {
                soulX += inputX * 200 * Time.DeltaTime;
                soulY += inputY * 200 * Time.DeltaTime;
            }
        













        }
        }

    }
