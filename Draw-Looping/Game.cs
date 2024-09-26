// Include code libraries you need below (use the namespace).
using System;
using System.Numerics;
using System.Runtime.CompilerServices;

// The namespace your code is in.
namespace Game10003
{
    /// <summary>
    ///     Your game code goes inside this class!
    /// </summary>
    public class Game
    {
        // Place your variables here:
        int rowCount = 6;
        int columnCount = 6;

        float[] Radiuses;

        float circletime;

        public void Setup()
        {
            Window.SetSize(800, 600);

            Radiuses = new float[rowCount * columnCount];
            for (int i = 0; i < rowCount * columnCount; i++)
            {
                Radiuses[i] = Random.Float(-15, 15);
            }


        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {
            Window.ClearBackground(Color.White);

            Draw.FillColor = Color.OffWhite;
            Draw.LineColor = Color.DarkGray;
            Draw.LineSize = 2;



            /*
            // array drawing exersice
            float[] yCoords = new float[100];
            float[] xCoords = new float[100];

            xCoords[0] = 100;
            yCoords[0] = 100;

            xCoords[1] = 10;
            yCoords[1] = 42;

            xCoords[2] = 56;
            yCoords[2] = 72;

            for (int i = 0; i < 3; i++)
            {
                float x = xCoords[i];
                float y = yCoords[i];

                Draw.Circle(100 + x,100 + y, 30);
            }
            */

            /* That's no good
            float x1 = 100;
            float y1 = 100;

            float x2 = 10;
            float y2 = 42;

            float x3 = 56;
            float y3 = 79;

            float radius = 2;

            Draw.Circle(x1, y1, radius);
            Draw.Circle(x2, y2, radius);
            Draw.Circle(x3, y3, radius);
            */


            /*
            circletime += Time.DeltaTime;
            for (int i = 0; i < rowCount * columnCount; i++)
            {

                //calculate row and column from i
                int row = i / columnCount;
                int col = i % columnCount;
                
                int x = col * 80;
                int y = row * 80 - (int)(25 * circletime);

                Draw.Circle(50 + x, 50 + y, 30 + Radiuses[i]);
            }
            */

            for (int x = 0; x < columnCount; x++)
            {
                for (int y = 0; y < rowCount; y++)
                {
                    int xPos = x * 80;
                    int yPos = y * 80;
                    Draw.Circle(150 + xPos, 150 + yPos, 30);
                }
            }

        }
    }
}
