using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FormationOO
{
    public class Book
    {
        public string Title { get; set; }
        public string Authors { get; set; }
        public double Price { get; set; }
        public string Theme { get; set; }
        public int Note { get; set; }
        public int NbPage { get; set; }
        public string Isbn { get; set; }

        public Book(string isbn, string title, double price, string authors="", string theme="", int nbPage = 0)
        {
            Isbn = isbn;
            Title = title;
            Price = price;
            Authors = authors;
            Theme = theme;
            NbPage = nbPage;
            Note = 0;
        }

        public double VATPrice
        {
            get { return Price * 1.05; }
        }
    }
}