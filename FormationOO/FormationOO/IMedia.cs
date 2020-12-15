using System.Collections.Generic;

namespace FormationOO
{
    public interface IMedia
    {
        List<Author> Authors { get; set; }
        string Id { get; set; }
        int Note { get; set; }
        double Price { get; set; }
        Publisher Publisher { get; set; }
        string Theme { get; set; }
        string Title { get; set; }
        double VATPrice { get; }
    }
}