using System;
using System.Collections.Generic;

namespace Day10_recap_list
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> namesList = new List<string>();
            Console.WriteLine($"List has {namesList.Count} elements");
            
            namesList.Add("John");
            namesList.Add("Marry");
            namesList.Add("Bob");
            namesList.Add("Tom");
            namesList.Add("Chris");
            namesList.Add("Ann");

            string userInput = "";
            namesList.Add(userInput); // namesList.Add("");


            Console.WriteLine($"First element is {namesList[0]} and the last element {namesList[namesList.Count - 1]}");

            for (int i = 0; i < namesList.Count; i++)
            {
                Console.WriteLine(namesList[i]);
            }

            foreach (string name in namesList)
            {
                Console.WriteLine(name);
            }

            //2ways to remove an element
            //1st way to remove
            namesList.Remove("Tom");

            //2nd way to remove
            bool annRemoval = namesList.Remove("Ann");//annRemoval specifies whether removal was successful

        }
    }
}
