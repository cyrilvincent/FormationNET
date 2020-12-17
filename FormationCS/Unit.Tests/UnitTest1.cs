using EF.Library;
using EF.Library.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace Unit.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestEF()
        {
            MediaContext context = new MediaContext();
            Book b = new Book { Title = "C#", Price = 10.0 };
            context.Books.Add(b);
            context.SaveChanges();
            var books = context.Books.ToList();
            Assert.IsNotNull(books);
        }
    }
}
