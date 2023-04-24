using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankEncapsulation
{
    internal class BankAccount
    {
        private double balance = 0.0;

        public void Deposit(double amount)
        {
            balance += amount;
        }

        public double GetBalance() 
        { 
            return balance; 
        }

    }
}
