using System;
using Exercise8;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest8
    {
        [TestMethod]
        public void TestQuoteIMBObserver()
        {
            ObservableQuote observableQuote = new ObservableQuote();
            IBMObserver IMB = new IBMObserver();
            IEnumerable<Quote> quotes = new QuoteRepository().GetAllQuotes();
            List<Quote> quotesList = quotes.ToList();

            observableQuote.Subscribe(IMB);
            observableQuote.QuoteAddList(quotesList, "DELL");

            Assert.AreEqual(false, IMB.CompletedBool);
            Assert.AreEqual(true, IMB.NextBool);
            Assert.AreEqual(true, IMB.ErrorBool);

            observableQuote.ClearAll();
            Assert.AreEqual(true, IMB.CompletedBool);
        }
        [TestMethod]
        public void TestQuoteDELLObserver()
        {
            ObservableQuote observableQuote = new ObservableQuote();
            IBMObserver DELL = new IBMObserver();
            IEnumerable<Quote> quotes = new QuoteRepository().GetAllQuotes();
            List<Quote> quotesList = quotes.ToList();

            observableQuote.Subscribe(DELL);
            observableQuote.QuoteAddList(quotesList, "DELL");

            Assert.AreEqual(false, DELL.CompletedBool);
            Assert.AreEqual(true, DELL.NextBool);
            Assert.AreEqual(true, DELL.ErrorBool);

            observableQuote.ClearAll();
            Assert.AreEqual(true, DELL.CompletedBool);
        }
    }
}
