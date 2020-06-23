using System;

namespace BankingApp {
    class Program {

        static void Main(string[] args) {

            var chk1 = new Checking();
            chk1.Deposit(100);
            chk1.WriteCheck("Cash", 10, 101);
            chk1.WriteCheck("Apple", 2);

            var sav1 = new Savings();
            sav1.InterestRate(0.12);
            sav1.Deposit(100);
            sav1.CalculateAndDepositInterest(9);
            Console.WriteLine($"Balance is {sav1.GetBalance()}");

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
