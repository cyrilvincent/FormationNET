using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormationOO
{
    class ProgramMedia
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Media");
            Book b1 = new Book("123", "C#", 10, nbPage : 10);
            Console.WriteLine($"VATPrice: {b1.VATPrice}");
            Console.ReadKey();
        }
    }
}
