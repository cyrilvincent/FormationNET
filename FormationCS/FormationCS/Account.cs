using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormationCS
{
    public class Account
    {
        public double Solde { get; private set; } = 0;
        public long Iban { get; private set; }
        public string? Owner { get; private set; }
        public string? Bank { get; private set; }

        public Account(long iban, string owner, string bank)
        {
            this.Iban = iban;
            this.Owner = owner;
            this.Bank = bank;
        }

        public void Deposer(double amount)
        {
            this.Solde += amount;
        }

        public double Retirer(double amount)
        {
            if (amount <= this.Solde)
            {
                this.Solde -= amount;
                return amount;
            }
            else
            {
                throw new ArgumentException("Le montant doit être inférieur au solde");
            }
        }


    }
}
