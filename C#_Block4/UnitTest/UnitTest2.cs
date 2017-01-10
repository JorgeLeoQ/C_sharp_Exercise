using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Exercise2;

namespace UnitTest
{
    [TestClass]
    public class UnitTest2
    {
        Library Library1 = new Library("Leo's Library");
        Library Library2 = new Library("Empty Library");

        [TestInitialize]
        public void InitializeLibrary()
        {
            Library1.AddBook("Shinig", "Stephen King", 1977u, 2002, "88-04-46422-4");
            Library1.AddBook("It", "Stephen King", 1986u, 2000u, "88-200-0705-3");
            Library1.AddBook("Harry Potter and the philosopher's stone", "J.K. Rowling", 1997u, 1998u, "0-7475-3269-9");
            Library1.AddBook("Hunger Games", "Suzanne Collins", 2008u, 2008u, "978-88-04-59410-9");
            Library1.AddBook("The Green Mile", "Stephen King", 1996u, 1996u, "88-8274-129-X");
        }

        [TestMethod]
        public void TestMyBook1()
        {
            string titleBook = "Harry Potter and the philosopher's stone";
            Book tempBook = Library1.ListBooks.Find(x => x.TitleBook == titleBook);
            Assert.AreEqual("J.K. Rowling", tempBook.AuthorBook);
            Assert.AreEqual("0-7475-3269-9", tempBook.IsbnNumber);
            Assert.AreEqual(1997u, tempBook.PublisherBook);
        }

        [TestMethod]
        public void TestMyBook2()
        {
            string titleBook = "Hunger Games";
            Book tempBook = Library1.ListBooks.Find(x => x.TitleBook == titleBook);
            Assert.AreEqual("Suzanne Collins", tempBook.AuthorBook);
            Assert.AreEqual("978-88-04-59410-9", tempBook.IsbnNumber);
            Assert.AreEqual(2008u, tempBook.PublisherBook);
        }

        [TestMethod]
        public void TestGenericBook()
        {
            Book newBook = new Book("Fifty Shades of Grey", "E. L. James", 2012u, 2012u, "978-8804648895");
            Assert.AreEqual("Fifty Shades of Grey", newBook.TitleBook);
            Assert.AreEqual("978-8804648895", newBook.IsbnNumber);
        }

        [TestMethod]
        public void TestDeleteBooksStephen()
        {
            Library1.DeleteBook("Stephen King");
            Assert.AreEqual(2, Library1.ListBooks.Count);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void TestDeleteEmptyLibrary()
        {
            Library2.DeleteBook("Nothing");
        }
    }
}
