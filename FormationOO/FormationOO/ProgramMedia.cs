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
            Publisher p = new Publisher("ENI");
            Book b1 = new Book("123", "C#", 10, authors, nbPage : 10, publisher : p);
            Console.WriteLine($"VATPrice: {b1.VATPrice}");
            Console.WriteLine($"Publisher: {b1.Publisher.Name}");
            foreach(Author a in b1.Authors)
            {
                Console.WriteLine($"Author: {a.Name}");
            }
            Cd cd1 = new Cd("007", "Allumez le feu", 10, authors, nbTrack: 9);
            Console.WriteLine($"CD VATPrice: {cd1.VATPrice}");
            Cart cart = new Cart();
            cart.Add(b1);
            cart.Add(cd1);
            Console.WriteLine($"Cart: {cart.TotalVATPrice}");
            Console.WriteLine($"NbMedia: {Media.NbMedia}");
            b1 = null;
            GC.Collect();
            // Garbage Collector
            Console.ReadKey();
            Console.WriteLine($"NbMedia: {Media.NbMedia}");
            Console.ReadKey();

            /*
             * Media
             * Book hérite de Media : npPage
             * Cd : nbTrack
             * Dvd : zone
             * */

            /*
             * Créer la classe Cart() je peux mettre des medias
             * Calculer le prix TTC du panier TotalNetPrice
             * Tester */
        }
    }
}
