using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormationOO
{
    public class Transaction
    {
        public DateTime Date { get; private set; }
        public double Amount { get; private set; }

        public Transaction(double amount)
        {
            Date = DateTime.Now;
            Amount = amount;
        }
    }
}
