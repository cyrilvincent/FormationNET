using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormationOO
{
    public class ProgramBank
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bank");
            Account account = new Account(123,"Cyril");
            Console.WriteLine($"Balance: {account.Balance}");
            account.Deposit(100);
            Console.WriteLine($"Balance: {account.Balance}");
            account.Withdraw(50);
            Console.WriteLine($"Balance: {account.Balance}");
            Console.WriteLine($"Transactions: {account.Transactions.Count}");
            try
            {
                account.Withdraw(10000);
            }
            catch(BankException ex)
            {
                Console.WriteLine("Error "+ex.Message);
            }
            Console.ReadKey();
        }
    }
}
