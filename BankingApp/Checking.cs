using System;
using System.Collections.Generic;
using System.Text;

namespace BankingApp {
    
    public class Checking : Account {

        public int NextElectronicCheckNumber { get; private set; } = 10000;

        public bool WriteCheck(string Payee, double Amount, int? PaperCheckNumber = null) {
            // if null; it is an electronic check
            // which must be assigned
            var checkNumber = (PaperCheckNumber == null) 
                ? NextElectronicCheckNumber++  
                : PaperCheckNumber.Value;
            if(!Withdraw(Amount)) {
                Console.WriteLine("ERROR: WriteCheck failed; see log!");
                return false;
            }
            return true;
        }
        public Checking() : base() {
            Description = "New Checkint Account";
        }
    }
}
