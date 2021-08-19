using System;

namespace firstConsoleApp
{
    class Program 
    {

        static void Main(string[] args)
        {
            BankAccount john = new BankAccount("john", 456, 1300.45m);

            Console.WriteLine($"name {john.accountName}, account: {john.accountID} balance: {john.accountBalance}");

            john.ModifyBalance(1000);

            Console.WriteLine($"the new balance is: {john.accountBalance}");

            Console.ReadKey();
        }
    }
}
