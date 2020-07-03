using System;
using System.Collections.Generic;
using System.Text;

namespace Day15_ATM
{
    class ATM
    {
        public int Balance;

        public List<Client> ClientAccounts;

        public string Withdraw(string clientId, int amountToWithdraw)
        {
            //null - is a non-existing value. it's like NOTHING. not zero, not falst - those are values.            
            //null is used only for class objects (there are some extra special cases)

            #region OldWay
            //Old way:
            //We want to go through all of the ATM client accounts and check if we can find with the given clientId
            //Creating account variable to store the found account
            Client account = null;
            //We have to iterate through all the clients
            foreach (Client client in ClientAccounts)
            {
                //We are checking if the current iteration Client is the one we are look for
                //For comparison we are using the client.Id from the list and the value given via parameter
                if (client.Id == clientId)
                {
                    //if the client is found, then we store it, in the {account} variable
                    account = client;
                    break;
                }
            }
            #endregion

            //New way:


            //Check if the client account was found
            if (account == null)
            {
                return $"No such account exist with id '{clientId}'.";
            }

        }
    }
}
