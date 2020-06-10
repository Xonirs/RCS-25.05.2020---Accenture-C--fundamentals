using System;

namespace Day7_recap
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] salary = { 430.00, 540.00, 330.00, 640.00, 730.00, 840.00, 787.23 };
            Console.WriteLine($"First element - {salary[0]}");
            Console.WriteLine($"Array length - {salary.Length}");
            Console.WriteLine($"Third element - {salary[2]}");
            salary[2] = 999.00;
            Console.WriteLine($"Third element (after the change) - {salary[2]}");

            Console.WriteLine("Loop begins");
            for (int i = 0; i < salary.Length; i++)
            {
                Console.WriteLine(salary[i]);
            }
            Console.WriteLine("Break and continue loop");
            for (int i = 0; i < 10; i++)
            {
                if (i == 4 || i == 5)
                {
                    continue;
                }

                if (i == 7)
                {
                    break;
                }

                Console.WriteLine(i);
            }

            //Console.WriteLine($"{salary[0]}");
            //Console.WriteLine($"{salary[1]}");
            //Console.WriteLine($"{salary[2]}");
            //Console.WriteLine($"{salary[3]}");
            //Console.WriteLine($"{salary[4]}");
            //Console.WriteLine($"{salary[5]}");
            //Console.WriteLine($"{salary[6]}");


            //string name = "John";
            //Console.WriteLine(name[2]);
            //char firstLetter = name[0];
            //Console.WriteLine(firstLetter);

            //int doCounter = 0;
            //string input = "STOP";
            //do
            //{
            //    Console.WriteLine(doCounter);
            //    doCounter++;

            //} while (input != Console.ReadLine() && doCounter < 10);

            //for (int i = 0; i < 100; i = i + 5)
            //{
            //    Console.WriteLine(i);
            //}


        }
    }
}

//for loop
