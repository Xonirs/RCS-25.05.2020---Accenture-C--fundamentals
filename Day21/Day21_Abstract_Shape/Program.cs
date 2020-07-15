using System;

namespace Day21_Abstract_Shape
{
    abstract class Shape
    {
        public abstract double Area();
    }

    class Square : Shape
    {
        private int edge = 0;
        public Square(int edgeSize)
        {
            edge = edgeSize;        
        }
        public override double Area()
        {
            return edge * edge;
        }
    }

    class Circle : Shape
    {
        private int radius = 0;
        public Circle(int radiusSize)
        {
            radius = radiusSize;
        }
        public override double Area()
        {
            return radius * radius * Math.PI;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Square square = new Square(25);
            Console.WriteLine($"Square area is: {square.Area()}");
            Circle circle = new Circle(25);
            Console.WriteLine($"Circle area is: {circle.Area()}");
        }
    }
}
