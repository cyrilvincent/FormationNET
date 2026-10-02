using System;
using System.Collections.Generic;
using System.Data;
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

        // Créer la classe Owner
        // Un compte possède un seul Owner
        // Créer la classe Transaction
        // Possède un montant et une date
        // Il existe le type DateTime.Now
        // Un compte possède une liste de transaction qui au départ est vide []
        // Quand tu credites le compte ca créé une transaction positive
        // Quand tu débites le compte ca créé une transaction négative
        
        // AccountWithInterest
        // Rate
        // ComputeInterests : rate * solde
        // AbondeInterest : Créer la transaction crédit avec les interets
    }
}
