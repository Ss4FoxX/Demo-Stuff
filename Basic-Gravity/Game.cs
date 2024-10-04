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

        Vector2 CirclePosition = new(300, 400);
        Vector2 Gravity = new(0, 10);
        Vector2 Speed = new()
        /// <summary>
        ///     Setup runs once before the game loop begins.
        /// </summary>
        public void Setup()
        {
            Window.SetSize(800, 800);
            Window.SetTitle("Gravity");
        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {
            Window.ClearBackground(Color.OffWhite);

            Draw.LineSize = 1;
            Draw.LineColor = Color.Black;
            Draw.FillColor = Color.Cyan;
            Draw.Circle(200, 200, 50);

            Vector2 PlatformPosition = new(0, 200);
            Vector2 PlatformSize = new(200, 0);


        }
    }
}
