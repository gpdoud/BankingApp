using System;
using System.Collections.Generic;
using System.Text;

namespace BankingApp.Exceptions {
    
    public class InsufficientFundsException : Exception {

        public int AccountNumber { get; set; }
        public string AccountDescription { get; set; }
        public double  AccountBalance { get; set; }
        public double  WithdrawAmount { get; set; }

        public InsufficientFundsException() 
            : base() { }

        public InsufficientFundsException(string message) 
            : base(message) { }

        public InsufficientFundsException(string message, Exception innerException)
            : base(message, innerException) { }
    }
}
