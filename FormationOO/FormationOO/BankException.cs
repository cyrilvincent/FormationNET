using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormationOO
{
    public class BankException : Exception
    {
        public int Id { get; set; }
        public BankException(string message, int id) : base(message)
        {
            Id = id;
        }
    }
}
