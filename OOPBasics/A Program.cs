using System;

namespace OOPBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount myAccount = new BankAccount();
            myAccount.Balance = 123.34m;
            Console.WriteLine(myAccount.Balance);

        }
    }
}
