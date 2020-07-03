using System;

namespace Day15_ATM
{
    class Program
    {
        //Create a class ATM. It has 1 method – Withdraw. ATM has the information about available money amount. 
        //ATM also knows the information about all of the Clients accounts and their available money amount in account. 
        //In console application you should be able to specify client id and how much money to withdraw. 
        //In any case if there is not enough money, you should show an error message.
        static void Main(string[] args)
        {
            ATM atm = new ATM()
            {
                Balance = 1000
            };
            Client client1 = new Client()
            {
                AccountBalance = 100,
                Id = "123"
            };
            Client client2 = new Client()
            {
                AccountBalance = 50,
                Id = "234"
            };
            Client client3 = new Client()
            {
                AccountBalance = 9000,
                Id = "345"
            };

            atm.ClientAccounts.Add(client1);
            atm.ClientAccounts.Add(client2);
            atm.ClientAccounts.Add(client3);

            do
            {
                Console.Write("Enter client id: ");
                var clientId = Console.ReadLine();

                Console.Write("Enter amount: ");
                var amount = int.Parse(Console.ReadLine());

                var result = atm.Withdraw(clientId, amount);
                Console.WriteLine(result);

                Console.Write("Do you want to continue (y/n):");
                var doContinue = Console.ReadLine();
                if (doContinue != "y")
                {
                    break;
                }
            } while (true);
        }
    }
}
