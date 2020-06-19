using System;

namespace BankingApp {
    class Program {

        static int i;
        
        static void Main(string[] args) {

            i = 1;

            Console.WriteLine($"Routing number is {Account.GetRoutingNumber()}");

            var acct1 = new Account();
            acct1.Deposit(100000);
            acct1.Withdraw(60000);
            acct1.Withdraw(50000);
            acct1.Deposit(-20000);
            acct1.Withdraw(-10000);

            var acct2 = new Account();

            acct1.Transfer(acct2, 1000);
            acct1.Transfer(acct2, 40000);
            acct1.Transfer(acct2, 5000);

            Account.AddAccount(acct1);
            Account.AddAccount(acct2);
            Account.ListAccounts();
        }


    }
}
