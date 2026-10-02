using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormationCS
{
    public class Account
    {
        private double solde = 0;
        private long iban;
        private string? owner;
        private string? bank;

        public Account(long iban, string owner, string bank)
        {
            this.iban = iban;
            this.owner = owner;
            this.bank = bank;
        }

        public void Deposer(double amount)
        {
            this.solde += amount;
        }

        public double Retirer(double amount)
        {
            if (amount <= this.solde)
            {
                this.solde -= amount;
                return amount;
            }
            else
            {
                throw new ArgumentException("Le montant doit être inférieur au solde");
            }
        }


    }
}
