using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FormationLibrary;

namespace FormationUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AuthorTest()
        {
            Author a = new Author();
            a.Id = 1;
            a.Name = "toto";
            Assert.AreEqual(1, a.Id);
        }

        [TestMethod]
        public void BookTest()
        {
            Book b = new Book { Id = 1, Title = ".NET" };
            Assert.AreEqual(1, b.Id);
        }

        [TestMethod]
        public void PublisherTest()
        {
            Book b = new Book { Id = 1, Title = ".NET", Publisher = new Publisher { Id = 2, Name="Publisher"} };
            Assert.AreEqual(2, b.Publisher.Id);
        }

        [TestMethod]
        public void Author2Test()
        {
            Book b = new Book { Id = 1, Title = ".NET"};
            b.Authors.Add(new Author { Name = "Cyril" });
            Assert.AreEqual(2, b.Publisher.Id);
        }
    }
}
