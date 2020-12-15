using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormationOO
{
    public class Cd : Media
    {
        public int NbTrack { get; set; }

        public override double VATPrice
        {
            get { return Price * 1.2; }
        }
        public Cd(string id, string title, double price, List<Author> authors, string theme = "", int nbTrack = 0, Publisher publisher = null)
            : base(id, title, price, authors, theme, publisher)
        {
            NbTrack = nbTrack;
        }
    }
}
