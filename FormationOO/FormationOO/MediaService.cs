using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormationOO
{
    public interface IMediaService
    {
        List<IMedia> SearchByPrice(double price);
        IMedia SelectMedia(string id);

        Cart AddToCart(Media media);

        bool ValidateCart(Cart cart);

        bool Pay(Cart cart);


    }

    public class MediaService : IMediaService
    {

        private SqlMediaRepository repository = new SqlMediaRepository();

        public Cart AddToCart(Media media)
        {
            // Le media ne peut pas être nul
            // Le prix du media ne doit pas être <= 0
            throw new NotImplementedException();
        }

        public bool Pay(Cart cart)
        {
            // Que si le panier est validé
            throw new NotImplementedException();
        }

        public List<IMedia> SearchByPrice(double price)
        {
            throw new NotImplementedException();
        }

        public IMedia SelectMedia(string id)
        {
            
            IMedia media = repository.GetBookById(id);
            if(media == null)
            {
                throw new NotImplementedException();
            }
            return media;
        }

        public bool ValidateCart(Cart cart)
        {
            // Le panier ne peux pas être vide
            if(cart.Count == 0)
            {
                throw new NotImplementedException();
            }
            else
            {
                throw new NotImplementedException();
            }
            
        }
    }
}
