using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FormationOO
{
    public class Account
    {
        public string Owner { get; set; }
        public int Id { get; set; }
        private double balance;

        // Account possède * transactions (DateTime.Now, amount < 0 si débit, > 0 sinon)
        // Un Deposit et Withdraw créé une transaction
        public Account(int id, string owner)
        {
            Id = id;
            Owner = owner;
            balance = 0;
        }

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