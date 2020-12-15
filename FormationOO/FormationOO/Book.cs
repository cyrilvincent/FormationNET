using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FormationOO
{
    public class Book : Media
    {
        public int NbPage { get; set; }

        public Book(string isbn, string title, double price, List<Author> authors, string theme="", int nbPage = 0, Publisher publisher = null)
            : base(isbn, title,price,authors,theme,publisher)
        {
            NbPage = nbPage;
        }

        public string Isbn
        {
            get { return Id; }
        }

        public override double VATPrice
        {
            get { return Price * 1.05; }
        }
    }
}