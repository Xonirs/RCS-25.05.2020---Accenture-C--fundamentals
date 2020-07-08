using System;
using System.Collections.Generic;
using System.Text;

namespace Day17_OOP_Closet
{
    //Create a class Closet. Create a private field – List<string> Clothes. Create a public method – void PrintClosetContent(), 
    //which will print all of the clothes in closet. Create a public method – string AddClothes(string clothesName). 
    //Method AddClothes will take the input parameter and will add the string value to the private list Clothes. 
    //Any clothes can be added if the length of name is 5 or greater and no such other clothes exist in Closet. 
    //For this create a separate private method – bool DoesClothesExist(string clothesName), 
    //which will tell if such clothes can be already located in closet. Inside method AddClothes - if clothes can’t be added return 
    //an error message with the correct reason, but if the clothes can be added then return message 
    //$“Clothes ‘{clothesName}’ successfully added to closet.” 
    class Closet
    {
        List<string> Clothes = new List<string>();
        public void PrintClosetContent()
        {
            if (Clothes.Count > 0)
            {
                Console.WriteLine("Closet content:");
                foreach (var items in Clothes)
                {
                    Console.WriteLine(items);
                }
            }
        }

        public string AddClothes(string clothesName)
        {
            if (clothesName.Length < 5)
            {
                return $"This item '{clothesName}' has too short name!";
            }

            if (DoesClothesExist(clothesName))
            {
                return $"This item '{clothesName}' already exists in the closet!";
            }

            Clothes.Add(clothesName);
            return $"Clothes ‘{clothesName}’ successfully added to the closet.";
        }

        private bool DoesClothesExist(string clothesName)
        {
            foreach (var item in Clothes)
            {
                if (item == clothesName)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
