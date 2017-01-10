using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercise9;

namespace UnitTestProject1
{

    [TestClass]
    public class Test9
    {
        public static List<LibraryItem> ItemList;
        public static List<LibraryPatron> PatronList;

        [ClassInitialize]
        public static void InitilizeClass(TestContext testCont)
        {

            ItemList = new List<LibraryItem>();
            PatronList = new List<LibraryPatron>();

            LibraryItem b1 = new LibraryBook("Multithreading with C# Cookbook - Second Edition", "Packt Publishing", 2016, 14, "ZZ25 3G", "Eugene Agafonov");
            LibraryItem b2 = new LibraryBook("Agile Software Development: Principles, Patterns, and Practices", "Prentice Hall", 2002, 14, "ZZ27 3G", "Robert Cecil Martin ");
            LibraryItem m1 = new LibraryMovie("The Lord of the Rings: The Fellowship of the Ring", "New Line Cinema", 2002, 7, "MM33 2D", 178, "Peter Jackson", LibraryMediaItem.MediaType.BLURAY, LibraryMovie.MPAARatings.PG);
            LibraryItem m2 = new LibraryMovie("Star Wars", "LucasFilm", 1977, 7, "MM35 3D", 97.5, "George Lucas", LibraryMediaItem.MediaType.BLURAY, LibraryMovie.MPAARatings.PG);
            LibraryItem t1 = new LibraryMusic("Ten", "Epic", 1991, 14, "CD44 4Z", 53.2, "Pearl Jam", LibraryMediaItem.MediaType.CD, 11);
            LibraryItem t2 = new LibraryMusic("Born to Run", "columbia", 1975, 14, "CD46 4Z", 39.26, "Bruce Springsteen", LibraryMediaItem.MediaType.CD, 8);
            LibraryItem j1 = new LibraryJournal("IEEE Transactions on Pattern Analysis and Machine Intelligence", "IEEE", 2011, 14, "JJ12 7M", 1, 2, "Bioengineering Computing & Processing", "David A. Forsyth");
            LibraryItem j2 = new LibraryJournal("IEEE Transactions on Image Processing", "IEEE", 2011, 14, "JJ15 7M", 1, 2, "Image Processing", "Scott Acton");
            LibraryItem z1 = new LibraryMagazine("C# Monthly", "Unige Mags", 2010, 14, "MA53 9A", 16, 9);
            LibraryItem z2 = new LibraryMagazine("C# Monthly", "Unige Mags", 2010, 14, "MA57 9A", 19, 12);
            LibraryPatron patron1 = new LibraryPatron("Patron1", "1");
            LibraryPatron patron2 = new LibraryPatron("Patron2", "2");
            LibraryPatron patron3 = new LibraryPatron("Patron3", "3");
            LibraryPatron patron4 = new LibraryPatron("Patron4", "4");

            ItemList.Add(b1);
            ItemList.Add(b2);
            ItemList.Add(m1);
            ItemList.Add(m2);
            ItemList.Add(t1);
            ItemList.Add(t2);
            ItemList.Add(j1);
            ItemList.Add(j2);
            ItemList.Add(z1);
            ItemList.Add(z2);
            PatronList.Add(patron1);
            PatronList.Add(patron2);
            PatronList.Add(patron3);
            PatronList.Add(patron4);

        }

        [TestMethod]
        public void TestSelectCheckedOutItems()
        {
            ItemList[0].CheckOut(PatronList[0]);
            ItemList[1].CheckOut(PatronList[1]);
            ItemList[3].CheckOut(PatronList[2]);
            ItemList[6].CheckOut(PatronList[3]);

            var checkedOutItems =
                from item in ItemList
                where (item.IsCheckedOut())
                select item;

            Assert.AreEqual(4, checkedOutItems.Count());
        }

        [TestMethod]
        public void TestSelectMediaItems()
        {
            ItemList[0].CheckOut(PatronList[0]);
            ItemList[1].CheckOut(PatronList[1]);
            ItemList[3].CheckOut(PatronList[2]);
            ItemList[6].CheckOut(PatronList[3]);

            var checkedOutItems =
                      from item in ItemList
                      where (item.IsCheckedOut())
                      select item;

            var selectMediaItems1 =
                from item in checkedOutItems
                where (item.ToString().Contains("LibraryMusic"))
                select item;

            var selectMediaItems2 =
                from item in checkedOutItems
                where (item.ToString().Contains("LibraryMovie"))
                select item;

            Assert.AreEqual(1, selectMediaItems1.Count() + selectMediaItems2.Count());

        }
        [TestMethod]
        public void TestSelectMegazine()
        {
            var magazine =
                  from item in ItemList
                  where item.ToString().Contains("LibraryMagazine")
                  select item;

            Assert.AreEqual(2, magazine.Count());
        }

        [TestMethod]
        public void TestLoanPerid()
        {
            var test = from item in ItemList where item.CallNumber.StartsWith("ZZ") select new { item.Title, item.LoanPeriod };

            Assert.AreEqual(test.ElementAt(0).Title, "Multithreading with C# Cookbook - Second Edition");
            Assert.AreEqual(test.ElementAt(1).Title, "Agile Software Development: Principles, Patterns, and Practices");
            Assert.AreEqual(test.ElementAt(0).LoanPeriod, 14);
            Assert.AreEqual(test.ElementAt(1).LoanPeriod, 14);
        }
        [TestMethod]
        public void TestLoanPerioModify()
        {
            ItemList[0].LoanPeriod = ItemList[0].LoanPeriod + 7;
            ItemList[1].LoanPeriod = ItemList[1].LoanPeriod + 7;

            var test = from item in ItemList where item.CallNumber.StartsWith("ZZ") select new { item.Title, item.LoanPeriod };

            Assert.AreEqual(test.ElementAt(0).Title, "Multithreading with C# Cookbook - Second Edition");
            Assert.AreEqual(test.ElementAt(1).Title, "Agile Software Development: Principles, Patterns, and Practices");
            Assert.AreEqual(test.ElementAt(0).LoanPeriod, 21);
            Assert.AreEqual(test.ElementAt(1).LoanPeriod, 21);
        }


        [TestMethod]
        public void TestSevenDays()
        {
            var result = from items in ItemList
                         where items is LibraryBook
                         where items.LoanPeriod == items.LoanPeriod + 7
                         select new
                         {
                             items.Title,
                             items.LoanPeriod
                         };

            foreach (var c in result.ToList())
            {
                Assert.IsTrue(c.LoanPeriod > 7);
                Assert.IsNotNull(c.Title);
            }


        }
    }
}
