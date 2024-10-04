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


        ///     Setup runs once before the game loop begins.
        
        public void Setup()
        {
            Window.SetSize(400, 400);
            Window.SetTitle("Starin at you");

            DrawEye(new(150, 100), 50f);
        }
        //     Update runs every frame.
        //     
        

        public void Update()
        {
            Window.ClearBackground(Color.OffWhite);
            float eyeRadius = 50f;
            float irisRadius = 35f;
            float pupilRadius = 25f;

            Vector2 eyePosition = new(150, 100);
            Vector2 mousePosition = Input.GetMousePosition();
            Vector2 offSet = new(0, 0);
            Vector2 EyetoMouse = mousePosition - eyePosition;

            float eyeWhiteSpaceRadius = eyeRadius - irisRadius;
            offSet = Vector2.Normalize(EyetoMouse) * eyeWhiteSpaceRadius;

            if(Vector2.Distance(eyePosition, mousePosition) < eyeWhiteSpaceRadius)
            {
                offSet = -eyePosition + mousePosition;
            }

            Draw.FillColor = Color.White;
            Draw.LineColor = Color.Black;
            Draw.Circle(eyePosition, eyeRadius);


            Draw.FillColor = new Color(255, 155, 0);
            Draw.Circle(eyePosition + offSet, irisRadius);

            Draw.FillColor = Color.Black;
            Draw.Circle(eyePosition + offSet, pupilRadius);






        }
        void Draweye(Vector2 eyePosition, float eyeRadius)
        {
            Window.ClearBackground(Color.OffWhite);
            float eyeRadius = 50f;
            float irisRadius = 35f;
            float pupilRadius = 25f;

            Vector2 eyePosition = new(150, 100);
            Vector2 mousePosition = Input.GetMousePosition();
            Vector2 offSet = new(0, 0);
            Vector2 EyetoMouse = mousePosition - eyePosition;

            float eyeWhiteSpaceRadius = eyeRadius - irisRadius;
            offSet = Vector2.Normalize(EyetoMouse) * eyeWhiteSpaceRadius;

            if (Vector2.Distance(eyePosition, mousePosition) < eyeWhiteSpaceRadius)
            {
                offSet = -eyePosition + mousePosition;
            }

            Draw.FillColor = Color.White;
            Draw.LineColor = Color.Black;
            Draw.Circle(eyePosition, eyeRadius);


            Draw.FillColor = new Color(255, 155, 0);
            Draw.Circle(eyePosition + offSet, irisRadius);

            Draw.FillColor = Color.Black;
            Draw.Circle(eyePosition + offSet, pupilRadius);






        }

    }
}
