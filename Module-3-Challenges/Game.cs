// Include code libraries you need below (use the namespace).
using System;
using System.Numerics;
using System.Timers;

// The namespace your code is in.
namespace Game10003
{
    /// <summary>
    ///     Your game code goes inside this class!
    /// </summary>
    public class Game
    {
        // Place your variables here:

        int SquareSize = 400;

        Color Squarecolour;    
        public void Setup()
        {
            Window.TargetFPS = 30;
            Window.SetSize(800, 800);
            Window.SetTitle("Toggle Colour Drawing Challenge");

            SquareColour = color1;
            bool IsColourSet;
        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {
            Window.ClearBackground(Color.Gray);

            Draw.LineColor = Color.Black;
            Draw.FillColor = new Color(200, 0, 0); //redish color

            if (Input.IsMouseButtonPressed(MouseInput.Left))
            {
                if (IsColourset)
                Draw.FillColor = new Color(150, 0, 150); //purple like color

                
            }

            Draw.Rectangle(400 - SquareSize /2, 400 - SquareSize /2 , SquareSize, SquareSize);
            
        }
    }
}
