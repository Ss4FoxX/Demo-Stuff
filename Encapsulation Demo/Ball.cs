using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Game10003
{
    public class Ball
    {
        private float radius;
        private Color color;
        private float friction = 0.9f;

        private Vector2 gravity;
        private Vector2 velocity;
        private Vector2 position;

        //Constructor
        public Ball()
        {
            radius = Random.Float(20, 40);
            color = Random.Color();

            float innerLeftEdge = 0 + radius;
            float innerRightEdge = Window.Width - radius;


            position.X = Random.Float(innerLeftEdge, innerRightEdge);
            position.Y = Random.Float(50,350);

            gravity = new Vector2(0, 20);


        }
        public void Update()
        {
            CollisionDetection();
            SimulatePhysics();

            DrawBall();
        }

        private void SimulatePhysics()
        {
            velocity += gravity * Time.DeltaTime;
            position += velocity;
        }

        private void CollisionDetection()
        {
            float leftEdge = position.X - radius;
            float rightEdge = position.X + radius;
            float topEdge = position.Y - radius;
            float bottomEdge = position.Y + radius;

            if (bottomEdge >= Window.Height && velocity.Y > 0)
            {
                velocity.Y *= -1 * friction;
                position.Y = Window.Height - radius;

            }
        }

        public void DrawBall()
        {
            Draw.FillColor = color;
            Draw.Circle(position, radius);

        }

    }
}
