using System;
using System.Collections.Generic;
using System.Text;

namespace firstConsoleApp
{
    class BankAccount
    {
        public string accountName = "";
        public int accountID = -1;
        public decimal accountBalance = 0.0m;

        public BankAccount(string name, int id, decimal balance)
        {
            accountName = name;
            accountID = id;
            accountBalance = balance;
        }

        public void ModifyBalance( int deposit)
        {
            accountBalance += deposit;
        }
    }

    
}
