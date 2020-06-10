using System;

namespace Day3_IfUsage2
{
    class Program
    {
        static void Main(string[] args)
        {
            //We have 30 euro in our bank account. Ask the user how much money would he like to take. 
            //Depending on the answer, tell the user appropriate answer – print it in Console screen.
            int bankMoney = 30;
            Console.WriteLine("how much money would you like to take?");
            string moneyInput = Console.ReadLine();
            int money = int.Parse(moneyInput);
            if (money > bankMoney)
            {
                Console.WriteLine("There is not enough money in the bank");
            }
            else if (money > 0 && money <= bankMoney)
            {
                Console.WriteLine($"You can take the money, here you go {money}");
            }
            else
            {
                Console.WriteLine("You can't get 0 or negative EUROS");
            }
        }
    }
}
