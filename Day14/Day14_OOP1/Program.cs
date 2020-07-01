using System;

namespace Day14_OOP1
{
    class Rectangle
    {
        #region Fields
        //default access modifier for class memmber is private
        //private - the code can be accessed only within the same class
        //public - the code can be accessed anywhere
        public int width, height;
        private string name;
        #endregion
        #region Constructors
        //constructor - special method which is used when object is created. if not used, it is treated as empty
        public Rectangle(string _name)
        {
            Console.BackgroundColor = ConsoleColor.Cyan; Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(); Console.WriteLine("Rectangle has been created!");
            Console.ResetColor();
            name = _name;
        }
        public Rectangle(string _name, int _width, int _height)
        {
            Console.BackgroundColor = ConsoleColor.Cyan; Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(); Console.WriteLine("Rectangle has been created with values!");
            Console.ResetColor();
            name = _name;
            width = _width;
            height = _height;
        }
        #endregion
        #region Methods
        public void PrintInfo()
        {
            Console.WriteLine($"Rectangle '{name}' info:");
            Console.WriteLine($"The rectangle height - {height}");
            Console.WriteLine($"The rectangle width - {width}");
            Console.WriteLine($"The rectangle permiter - {Perimeter()}");
            Console.WriteLine($"The rectangle area - {Area()}");
            if (IsSquare())
            {
                Console.WriteLine("This rectangle is a square");
            }
            else
            {
                Console.WriteLine("This rectangle is not a square");
            }
            Console.WriteLine();
        }

        public int Perimeter()
        {
            return 2 * (width + height);
        }

        public int Area()
        {
            return width * height;
        }

        public bool IsSquare()
        {
            //if (width == height)
            //{
            //    return true;
            //}
            //else
            //{
            //    return false;
            //}

            //return width == height ? true : false;

            return width == height;
        }
        #endregion
    }

    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle1 = new Rectangle("Garden"); Console.WriteLine(rectangle1);
            //rectangle1.name = "Garden"; // if field 'name' is private, it can't be accessed outside of class Rectangle
            rectangle1.height = 100;
            rectangle1.width = 50;
            rectangle1.PrintInfo();
            Console.WriteLine($"The first rectangle permiter is {rectangle1.Perimeter()}");

            Rectangle rectangle2 = new Rectangle("Sports field", 200, 30);
            rectangle2.PrintInfo();

            Rectangle rectangle3 = new Rectangle("Airfield", 500, 500);
            rectangle3.PrintInfo();
        }
    }
}
