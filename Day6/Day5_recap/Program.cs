using System;

namespace Day5_recap
{
    enum MyFavoriteFoodsEnum
    {
        Chicken = 1,
        CocaCola,
        Water,
        Tomato,
        Pasta = 3001,
        Salmon
    }

    class Program
    {
        static void Main(string[] args)
        {
            bool userAnswerIncorrect = true;
            while (userAnswerIncorrect)
            {
                Console.Write("User answer:");
                string userAnswer = Console.ReadLine();
                userAnswerIncorrect = userAnswer != "STOP";
            }
            
            //string userAnswer = "";
            //while (userAnswer != "STOP")
            //{
            //    Console.Write("User answer:");
            //    userAnswer = Console.ReadLine();
            //}

            //string text = "";
            //while (text != "tatatata")
            //{
            //    Console.WriteLine(text);
            //    text = text + "ta";
            //}

            //int n = 0; // it's almost a counter
            //while (n < 10)
            //{
            //    if (n != 3)
            //    {
            //        Console.WriteLine(n);
            //    }
            //    n++; // n = n + 1;
            //}

            //infinite loop
            //int number = 1;
            //int number2 = 1;
            //while (number == number2)
            //{
            //    Console.Write("1 ");
            //}


            //MyFavoriteFoodsEnum myFavoriteFood = MyFavoriteFoodsEnum.Tomato;

            //if (myFavoriteFood == MyFavoriteFoodsEnum.Tomato)
            //{
            //    Console.WriteLine("Great, tomatoes are good!");
            //}

            //Console.WriteLine("Please enter a code of our foods:");
            //string codeInput = Console.ReadLine();
            //int code = int.Parse(codeInput);
            //MyFavoriteFoodsEnum userFood = (MyFavoriteFoodsEnum)code; //from int
            ////int codeFromEnum = (int)userFood; //to int
            //switch (userFood)
            //{
            //    case MyFavoriteFoodsEnum.Chicken:
            //    case MyFavoriteFoodsEnum.Salmon:
            //        Console.WriteLine("This has a lot of protein");
            //        break;
            //    case MyFavoriteFoodsEnum.CocaCola:
            //        Console.WriteLine("NOT Healthy");
            //        break;
            //    case MyFavoriteFoodsEnum.Water:
            //        Console.WriteLine("Drink often");
            //        break;
            //    case MyFavoriteFoodsEnum.Tomato:
            //        Console.WriteLine("Healthy veg");
            //        break;
            //    case MyFavoriteFoodsEnum.Pasta:
            //        Console.WriteLine("Do not eat to much");
            //        break;                
            //    default:
            //        break;
            //}
        }
    }
}
