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

        public List<Transaction> Transactions { get; private set; }

        public Account(int id, string owner)
        {
            Id = id;
            Owner = owner;
            balance = 0;
            Transactions = new List<Transaction>();
        }

        public double Withdraw(double amount)
        {
            if (amount < balance)
            {
                balance -= amount;
                Transaction transaction = new Transaction(-amount);
                Transactions.Add(transaction);
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
            Transaction transaction = new Transaction(amount);
            Transactions.Add(transaction);
        }

        public double Balance { 
            get {
                return balance;
            }
        }

    }
}