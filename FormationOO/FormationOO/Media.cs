using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormationOO
{
    public abstract class Media : IMedia
    {
        public string Title { get; set; }
        public List<Author> Authors { get; set; }
        public double Price { get; set; }
        public string Theme { get; set; }
        public int Note { get; set; }
        public string Id { get; set; }

        public Publisher Publisher { get; set; }

        public static int NbMedia { get; private set; } = 0;

        public Media(string id, string title, double price, List<Author> authors, string theme = "", Publisher publisher = null)
        {
            Id = id;
            Title = title;
            Price = price;
            Authors = authors;
            Theme = theme;
            Note = 0;
            Publisher = publisher;
            NbMedia++;
        }

        ~Media()
        {
            NbMedia--;
        }

        /*public virtual double VATPrice // redefinissable
        {
            get { return Price * 1.2; }
        }*/

        public abstract double VATPrice { get; }
    }
}
