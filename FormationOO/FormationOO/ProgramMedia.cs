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
            List<Author> authors = new List<Author>();
            Author a1 = new Author("Cyril");
            authors.Add(a1);
            Book b1 = new Book("123", "C#", 10, authors, nbPage : 10);
            Console.WriteLine($"VATPrice: {b1.VATPrice}");
            foreach(Author a in b1.Authors)
            {
                Console.WriteLine($"Author: {a.Name}");
            }
            Console.ReadKey();
        }
    }
}
