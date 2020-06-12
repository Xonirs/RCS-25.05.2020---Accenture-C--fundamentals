using System;

namespace Day8_recap_stringMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            string sentence = "John went to see Marry but there was only Peter.";
            Console.WriteLine(sentence);

            //Checks if the string is empty or null
            bool isTextEmpty = string.IsNullOrEmpty(sentence); Console.WriteLine(isTextEmpty); // false
            string emptyText = "";
            bool isTextEmpty2 = string.IsNullOrEmpty(emptyText); Console.WriteLine(isTextEmpty2); //true
            string userInput = Console.ReadLine();
            if (string.IsNullOrEmpty(userInput))
            {
                Console.WriteLine("User input was empty");
            }
            else
            {
                Console.WriteLine($"User input was NOT empty. He inputted {userInput}");
            }

            //Substring takes a part of string from the 5th position/index and does it for 10 characters
            string partOfString = sentence.Substring(5, 10); Console.WriteLine(partOfString); // 'went to se'
            //Substring takes a part of string from the 5th character and does it till the end
            string partOfString2 = sentence.Substring(5); Console.WriteLine(partOfString2); // 'went to see Marry but there was only Peter.'

            //starts with checks whether the string start with EXACTLY the searchable string
            bool startsWith = sentence.StartsWith("John"); Console.WriteLine(startsWith); // true
            bool startsWith2 = sentence.StartsWith("john"); Console.WriteLine(startsWith2); // false

            //ends with checks whether the string ends with EXACTLY the searchable string
            bool endsWith = sentence.EndsWith("Peter."); Console.WriteLine(endsWith); //true
            bool endsWith2 = sentence.EndsWith("Peter"); Console.WriteLine(endsWith2); //false

            //Contains checks if ANYWHERE the searchable string may be found
            bool contains = sentence.Contains("went to s"); Console.WriteLine(contains); // true
            bool contains2 = sentence.Contains("we@t to s"); Console.WriteLine(contains2); // false

            //ToUpper or ToLower returns a copy of string with changed case, to either UPPER or LOWER
            string upperLetters = sentence.ToUpper(); Console.WriteLine(upperLetters);
            string lowerLetters = sentence.ToLower(); Console.WriteLine(lowerLetters);

            //task : convert the sentence of to upper but only half of it
            int sentenceLength = sentence.Length;
            int halfOfLength = sentenceLength / 2;
            //string firstHalf = sentence.Substring(0, halfOfLength);
            string firstHalf = sentence.Substring(0, sentence.Length / 2);
            string firstHalfUpper = firstHalf.ToUpper();
            string secondHalf = sentence.Substring(halfOfLength);
            string newSentence = firstHalfUpper + secondHalf;
            Console.WriteLine($"New sentence with half to uppder: '{newSentence}'");

            //Length - counts the characters of string
            int length = sentence.Length; Console.WriteLine(length); //48

            //IndexOf - it tries to find a string, if it does it gives the location of the searchable string
            int indexOf = sentence.IndexOf("went to se"); Console.WriteLine(indexOf); //5
            int indexOf2 = sentence.IndexOf("#### %%%o se"); Console.WriteLine(indexOf2); //-1, when we don't find

        }
    }
}
