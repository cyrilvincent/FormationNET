using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormationOO
{
    public interface IMediaRepository
    {
        string ConnectionString { get; }

        List<IMedia> GetAll();
        List<Book> GetAllBooks();

        Book GetBookById(string id);

        List<Book> GetBooksByTitle(string title);

        List<Book> GetBooksByPrice(double price);

        void AddBook(Book book);
        void UpdateBook(Book book);
        void DeleteBook(Book book);

    }

    public class SqlMediaRepository : IMediaRepository
    {
        public string ConnectionString => throw new NotImplementedException();

        public void AddBook(Book book)
        {
            throw new NotImplementedException();
        }

        public void DeleteBook(Book book)
        {
            throw new NotImplementedException();
        }

        public List<IMedia> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<Book> GetAllBooks()
        {
            throw new NotImplementedException();
        }

        public Book GetBookById(string id)
        {
            throw new NotImplementedException();
        }

        public List<Book> GetBooksByPrice(double price)
        {
            throw new NotImplementedException();
        }

        public List<Book> GetBooksByTitle(string title)
        {
            throw new NotImplementedException();
        }

        public void UpdateBook(Book book)
        {
            throw new NotImplementedException();
        }
    }
}
