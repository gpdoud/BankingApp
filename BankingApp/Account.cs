using System;
using System.Collections.Generic;
using System.Text;

namespace BankingApp {
    public class Account {

        private static int NextAccountNumber = 1;
        public int AccountNumber { get; private set; }
        private double Balance { get; set; } = 0;
        public string Description { get; set; }

        private static Account[] AccountArray = new Account[5];
        private static int NextIndex = 0;

        public static void AddAccount(Account AccountInstance) {
            AccountArray[NextIndex] = AccountInstance;
            NextIndex++;
        }

        public static void ListAccounts() {
            for(var idx = 0; idx < NextIndex; idx++) {
                var account = AccountArray[idx];
                Console.WriteLine($"Id:{account.AccountNumber}; Desc:{account.Description}; Bal:{account.GetBalance()}");
            }
        }

        public bool Transfer(Account ToAccount, double Amount) {
            var success = Withdraw(Amount);
            if(!success) {
                Console.WriteLine("Transfer failed - See log file");
                return false;
            }
            success = ToAccount.Deposit(Amount);
            if(!success) {
                Console.WriteLine("Transfer failed - See log file");
                Deposit(Amount);
                return false;
            }
            return true;
        }

        private bool IsAmountNegative(double Amount) {
            if(Amount <= 0) {
                Console.WriteLine("Amount must be positive");
                return true;
            }
            return false;
        }

        public bool Deposit(double Amount) {
            if(IsAmountNegative(Amount)) {
                return false; ;
            }
            Balance += Amount;
            return true;
        }

        public bool Withdraw(double Amount) {
            if(IsAmountNegative(Amount) 
                || InsufficientFunds(Amount)) {
                return false;
            }
            
            Balance -= Amount;
            return true;
        }

        private bool InsufficientFunds(double Amount) {
            if(Amount > Balance) {
                Console.WriteLine("Insufficient funds");
                return true;
            }
            return false;
        }

        public double GetBalance() {
            return Balance;
        }
        public static string GetRoutingNumber() {
            return "123 456 789";
        }

        public Account() {
            this.AccountNumber = NextAccountNumber++;
            this.Description = "New Account";
        }
    }
}
