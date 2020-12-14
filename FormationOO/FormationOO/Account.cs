using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FormationOO
{
    public class Account
    {
        private string owner;
        private int id;
        private double balance;

        public double Withdraw(double amount)
        {
            if (amount < balance)
            {
                balance -= amount;
            }
            else
            {
                // TODO
            }
            return amount;
        }

        public void Deposit(double amount)
        {
            balance += amount;
        }

        public double Balance { 
            get {
                return balance;
            }
        }

    }
}