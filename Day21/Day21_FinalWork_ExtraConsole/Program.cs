using System;
using System.Threading;

namespace Day21_FinalWork_ExtraConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Console.Clear
            //PrintSomeRandomStuff();
            //string name = Console.ReadLine();
            //Console.Clear();
            //Console.WriteLine(name);
            #endregion
            #region Console.ReadKey
            //Console.WriteLine("Please press any key:");
            //var key = Console.ReadKey();
            //Console.WriteLine();
            //Console.WriteLine($"You pressed : Key - {key.Key}, KeyChar - {key.KeyChar}");
            //ConsoleKey keyEnum = Console.ReadKey().Key;
            //if (keyEnum == ConsoleKey.UpArrow)
            //{
            //    Console.WriteLine("You pressed up");
            //}
            //else
            //{
            //    Console.WriteLine("Your printed something else");
            //    Console.WriteLine($"Your typed: {keyEnum}");
            //}
            #endregion
            #region Console.SetCursorPosition
            //Console.WriteLine("This is default place text");
            //Console.SetCursorPosition(10, 10);
            //Console.WriteLine("Again this is something elsewhere");
            //Console.SetCursorPosition(0, 1);
            //Console.WriteLine("Something at beginning");
            //Console.SetCursorPosition(20, 15);
            //Console.WriteLine("Something much further");
            //Console.SetCursorPosition(26, 15);
            //Console.WriteLine("OVERWROTE TEXT");
            #endregion
            #region Console.Beep()
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.Beep();
            //}
            //for (int i = 37; i < 300; i+=20)
            //{
            //    Console.Beep(i, 100);
            //}
            #endregion
            #region Thread.Sleep
            //PrintSomeRandomStuff();
            //Thread.Sleep(500);
            //PrintSomeRandomStuff("b");
            #endregion
            #region Console.KeyAvailable

            //while (true)
            //{
            //    Console.WriteLine("Press z to exit");
            //    int count = 0;
            //    while (!Console.KeyAvailable) //Console.KeyAvailable is true when there is a key input to be read
            //    {
            //        //Loop until input is entered
            //        Thread.Sleep(100);
            //        //Console.WriteLine(count++);
            //    }

            //    var keyPressed = Console.ReadKey().Key;
            //    Console.WriteLine($"You pressed {keyPressed}");
            //    if (keyPressed == ConsoleKey.Z)
            //    {
            //        break;
            //    }
            //}
            
            //PrintSomeRandomStuff();
            //if (Console.KeyAvailable)
            //{
            //    var key = Console.ReadKey().Key;
            //    Console.WriteLine(key);
            //}

            #endregion
        }

        private static void PrintSomeRandomStuff(string letter = "a")
        {
            for (int i = 0; i < 5000; i++)
            {
                Console.Write(letter);
            }
            Console.WriteLine();
        }
    }
}
