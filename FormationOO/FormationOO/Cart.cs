using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormationOO
{
    public class Cart
    {
        public List<Media> Medias { get; private set; }

        public Cart()
        {
            Medias = new List<Media>();
        }

        public void Add(Media media)
        {
            Medias.Add(media);
        }

        public int Count
        {
            get { return Medias.Count; }
        }

        public void Remove(Media media)
        {
            Medias.Remove(media);
        }

        public double TotalVATPrice
        {
            get
            {
                double total = 0;
                foreach(Media media in Medias)
                {
                    total += media.VATPrice;
                }
                return total;
            } 
        }

    }
}
