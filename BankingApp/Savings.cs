using System;
using System.Collections.Generic;
using System.Text;

namespace BankingApp {
    
    public class Savings : Account {

        public double _InterestRate { get; private set; } = 0;

        private double CalculateInterestAmount(int NumberOfMonths) {
            return _InterestRate / 12 * NumberOfMonths * GetBalance();
        }

        public bool CalculateAndDepositInterest(int NumberOfMonths) {
            if(NumberOfMonths <= 0) {
                Console.WriteLine("Number of months must be greater than zero");
                return false;
            }
            var InterestToBeDeposited = CalculateInterestAmount(NumberOfMonths);
            return Deposit(InterestToBeDeposited);
        }

        public bool InterestRate(double NewInterestRate) {
            if(NewInterestRate < 0) {
                Console.WriteLine("Interest rate cannot be negative!");
                return false;
            }
            if(NewInterestRate > 10) {
                Console.WriteLine("Interest rate cannot be greater than 10.0!");
                return false;
            }
            _InterestRate = NewInterestRate;
            return true;
        }

        public Savings() : base() {
            Description = "New Savings Account";
        }
    }
}
