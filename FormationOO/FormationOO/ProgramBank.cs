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
            Account account = new Account();
            Console.WriteLine($"Balance: {account.balance}");
            account.Deposit(100);
            Console.WriteLine($"Balance: {account.balance}");
            account.Withdraw(50);
            Console.WriteLine($"Balance: {account.balance}");
            Console.ReadKey();
        }
    }
}
