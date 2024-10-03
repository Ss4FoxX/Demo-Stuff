// Include code libraries you need below (use the namespace).
using System;
using System.Numerics;

// The namespace your code is in.
namespace Game10003
{
    /// <summary>
    ///     Your game code goes inside this class!
    /// </summary>
    public class Game
    {
        // Place your variables here:

        float customLength = 50;

        /// <summary>
        ///     Setup runs once before the game loop begins.
        /// </summary>
        public void Setup()
        {
       
            Window.SetSize(800, 800);

        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {
            Window.ClearBackground(Color.OffWhite);



            Vector2 positionA = new(100, 100);
            Vector2 positionC = Input.GetMousePosition();
            Vector2 positionD = new(450, 450);
            
            Vector2 aToc = positionC - positionA;

            if (Input.IsMouseButtonPressed(MouseInput.Left))
            {
                customLength += 10;
            }
            else if (Input.IsMouseButtonPressed(MouseInput.Right))
            {
                customLength -= 10;
            }

            Vector2 positionB = positionA + Vector2.Normalize(aToc) * customLength;

            if (Vector2.Distance(positionC,positionA) < Vector2.Distance(positionC,positionD))
            {
                positionA = positionC;
            }




            Draw.LineColor = Color.Black;
            Draw.LineSize = 5;
            Draw.Line(positionA, positionC);

            Draw.Line(positionB, positionD);

            Draw.LineSize = 1;
            Draw.FillColor = Color.Blue;
            Draw.Circle(positionA, 15);

            Draw.FillColor = Color.Red;
            Draw.Circle(positionC, 15);

            Draw.FillColor = Color.Magenta;
            Draw.Circle(positionB, 15);

            Draw.FillColor = Color.Gray;
            Draw.Circle(positionD, 15);


        }
    }
}
