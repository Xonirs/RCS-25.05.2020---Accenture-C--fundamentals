using System;
using System.Collections.Generic;

namespace Day11_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintMe();
            PrintMyValue("John went to school");
            string inputParam = "HAKUNA MATATA";
            PrintMyValue(inputParam);
            inputParam = "GO TIGERS!";
            PrintMyValue(inputParam);
            PrintMyBirthday(31, "June");
            inputParam = "HAKUNA MATATA";
            PrintMyValue(inputParam);
            PrintMySong(1);
        }

        static void PrintMe()
        {
            Console.WriteLine("PrintMe + NEWEWEWEWEWE");
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("THIS IS WEIRD ERROR BLOCK");
            Console.ResetColor();
        }

        static void PrintMyValue(string value)
        {
            Console.WriteLine($"Here you go, this is your value: '{value}'");
        }

        static void PrintMyBirthday(int day, string month)
        {
            string numberEnding;

            if (day == 1 || day == 21 || day == 31)
            {
                numberEnding = "st";
            }
            else if (day == 2 || day == 22)
            {
                numberEnding = "nd";
            }
            else if (day == 3 || day == 23)
            {
                numberEnding = "rd";
            }
            else
            {
                numberEnding = "th";
            }
                
            Console.WriteLine($"Your birthday is on {day}{numberEnding} of {month}");
        }

        static void PrintMySong(int songNr)
        {
            List<string> songs = new List<string>() { "Let it be", "Hakuna matata", "Yesterday", "Yellow submarine" };
            string numberEnding;

            //.ToString() - converts any value or any variable value to string
            string songNrTxt = songNr.ToString();
            //Example - string sss = 12312321.ToString();

            var lastSymbol = songNrTxt[songNrTxt.Length - 1].ToString();
            int lastNumber = int.Parse(lastSymbol); //OR lastNumber = songNr % 10;

            if (lastNumber == 1 && lastNumber != 11)
            {
                numberEnding = "st";
            }
            else if (lastNumber == 2 && lastNumber != 12)
            {
                numberEnding = "nd";
            }
            else if (lastNumber == 3 && lastNumber != 13)
            {
                numberEnding = "rd";
            }
            else
            {
                numberEnding = "th";
            }

            Console.WriteLine($"Your {songNr}{numberEnding} song on your playlist is {songs[songNr - 1]}");
        }
    }
}
