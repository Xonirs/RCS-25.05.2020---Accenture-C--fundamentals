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
            ExceptionTest7();
            //try
            //{
            //    ExceptionTest6();
            //}
            //catch (Exception)
            //{
            //    Console.WriteLine("Something went wrong in one of the ExceptionTest methods!");
            //}
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
            finally
            {
                //Block lets you execute code after try..catch, regardless of the result. 
                //It will execute always, either there was an exception or there were no exceptions
                Console.WriteLine("Finished with our try..catch!");
            }
        }
        public static void ExceptionTest5()
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
                //throw allows us to re-create the SAME exception
                //as if a "new" exception happened once more
                throw; 
            }
            finally
            {
                //Block lets you execute code after try..catch, regardless of the result. 
                //It will execute always, either there was an exception or there were no exceptions
                Console.WriteLine("Finished with our try..catch!");
            }

            if (true)
            {
                //...
            }

            Console.WriteLine("Method ended!");
        }

        public static void ExceptionTest6()
        {
            int[] numbers = { 1, 2, 3, 10 };
            int position = 10;

            try
            {
                Console.WriteLine(numbers[position]);

            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine($"Please use an index inside the range of 0..{numbers.Length - 1}");
                //Console.WriteLine($"There was an exception: {e.Message}");
            }
        }

        public static void ExceptionTest7()
        {
            int[] numbers = { 1, 2, 3, 10 };
            int position = 3, number = 3;

            try
            {
                Console.WriteLine(numbers[position]);
                var result = numbers[position] / number;
                Console.WriteLine(result);
                TestClass test = null;
                test.Name = "Test name value";
                Console.WriteLine(test.Name);
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine($"Please use an index inside the range of 0..{numbers.Length - 1}");
                //Console.WriteLine($"There was an exception: {e.Message}");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine($"Oops, somehow we tried to divide by zero, sorry!");
                //Console.WriteLine($"There was an exception: {e.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Something wrong unexpected happened!");
                Console.WriteLine($"Here is the message: {ex.Message}");
            }
        }
    }
}
