using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FormationOO
{
    public class Account
    {
        public string owner;
        public int id;
        public double balance;

        public double Withdraw(double amount)
        {
            balance -= amount;
            return amount;
        }

        public void Deposit(double amount)
        {
            balance += amount;
        }
    }
}