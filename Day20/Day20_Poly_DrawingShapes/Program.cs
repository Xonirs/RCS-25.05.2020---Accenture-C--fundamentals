using System;
using System.Collections.Generic;

namespace Day20_Poly_DrawingShapes
{
    class DrawingShape
    {
        public virtual void Draw()
        {
            Console.WriteLine("I'm just a genering drawing object");
        }
    }

    class Line : DrawingShape
    {
        public override void Draw()
        {
            Console.WriteLine("I'm a line!");
        }
    }

    class Circle : DrawingShape
    {
        public override void Draw()
        {
            Console.WriteLine("I'm a circle!");
        }
    }

    class Square : DrawingShape
    {
        public override void Draw()
        {
            Console.WriteLine("I'm a square!");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            List<DrawingShape> shapes = new List<DrawingShape>();
            shapes.Add(new Square());
            shapes.Add(new Line());
            shapes.Add(new Circle());
            shapes.Add(new DrawingShape());

            foreach (DrawingShape shape in shapes)
            {
                shape.Draw();
            }
        }
    }
}
