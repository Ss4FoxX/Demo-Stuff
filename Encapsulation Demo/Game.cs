// Include code libraries you need below (use the namespace).
using System;
using System.Numerics;

// The namespace your code is in.
namespace Game10003
{
    
    ///     Your game code goes inside this class!
    
    public class Game
    {
        // Place your variables here:

        Ball[] pitBalls = new Ball[100];

        
        ///     Setup runs once before the game loop begins.
        public void Setup()
        {
            Window.SetSize(800, 600);
            Window.SetTitle("Into The Pit");


            for (int i = 0; i < pitBalls.Length; i++)
            {
                pitBalls[i] = new Ball();
            }



        }

        
        ///     Update runs every frame.
        public void Update()
        {
            Window.ClearBackground(Color.OffWhite);

            foreach (Ball pitBall in pitBalls)
            {
                pitBall.Update();
            }


        }
    }
}
