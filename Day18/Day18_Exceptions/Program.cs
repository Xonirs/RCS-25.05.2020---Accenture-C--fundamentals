using System;

namespace Day18_Exceptions
{
    class Program
    {
        //Exception - that is an error/problem which can occure during the execution of a program.
        //Example - when we attempt to divide something by zero.
        //Main goal is to write code to 
        //  1>either avoid exceptions
        //  2>or handle them
        static void Main(string[] args)
        {
            ExceptionTest4();
        }

        public static void ExceptionTest1()
        {
            try
            {
                //Block where we are going to try to execute some code
                int n1 = 100;
                int n2 = 5;
                int result = n1 / n2;
                Console.WriteLine(result);
            }
            catch (Exception)
            {
                //Block where we are going to handle exceptions/errors/problems/etc.
                Console.WriteLine("Something went wrong");
                //Console.WriteLine($"Values:{n1}, {n2}"); // we can't do this
            }
        }
        public static void ExceptionTest2()
        {
            int n1 = 100;
            int n2 = 0;

            try
            {
                //Block where we are going to try to execute some code                
                int result = n1 / n2;
                Console.WriteLine(result);
            }
            catch (Exception)
            {
                //Block where we are going to handle exceptions/errors/problems/etc.
                Console.WriteLine("Something went wrong");
                Console.WriteLine($"Values:{n1}, {n2}"); 
            }
        }
        public static void ExceptionTest3()
        {
            int n1 = 100;
            int n2 = 0;

            try
            {
                //Block where we are going to try to execute some code                
                int result = n1 / n2;
                Console.WriteLine(result);
            }
            catch (Exception e)
            {
                //Block where we are going to handle exceptions/errors/problems/etc.
                //e - exception variable name
                Console.WriteLine("Something went wrong");
                Console.WriteLine($"Values:{n1}, {n2}");
                Console.WriteLine($"Exception message: {e.Message}");
            }
        }

        public static void ExceptionTest4()
        {
            int n1 = 100;
            int n2 = 0;

            try
            {
                //Block where we are going to try to execute some code                
                int result = n1 / n2;
                Console.WriteLine(result);
            }
            catch (Exception e)
            {
                //Block where we are going to handle exceptions/errors/problems/etc.
                //e - exception variable name
                Console.WriteLine("Something went wrong");
                Console.WriteLine($"Values:{n1}, {n2}");
                Console.WriteLine($"Exception message: {e.Message}");
            }
        }
    }
}
