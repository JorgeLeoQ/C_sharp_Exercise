using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise8
{
    public class ObservableQuote : IObservable<Quote>
    {
        private List<IObserver<Quote>> observers;
        private List<Quote> quotes;

        public ObservableQuote()
        {
            observers = new List<IObserver<Quote>>();
            quotes = new List<Quote>();
        }

        public IDisposable Subscribe(IObserver<Quote> observer)
        {

            if (!observers.Contains(observer))
            {
                observers.Add(observer);

                foreach (var item in quotes)
                    observer.OnNext(item);
            }
            return new Unsubscriber<Quote>(observers, observer);
        }

        public void QuoteAdd(Quote quote, string society)
        {

            if (quote.Price > 0 && quote.Symbol == society)
            {
                foreach (var observer in observers)
                    observer.OnNext(quote);
            }
            else
            {
                foreach (var observer in observers)
                    observer.OnError(new ArgumentOutOfRangeException());
            }
        }

        public void QuoteAddList(List<Quote> quote, string value)
        {
            foreach (Quote item in quote)
            {
                this.QuoteAdd(item, value);
            }
        }
        public void ClearAll()
        {
            foreach (var observer in observers)
                observer.OnCompleted();

            observers.Clear();
        }
    }
    internal class Unsubscriber<Quote> : IDisposable
    {
        private List<IObserver<Quote>> observers;
        private IObserver<Quote> observer;

        internal Unsubscriber(List<IObserver<Quote>> observers, IObserver<Quote> observer)
        {
            this.observers = observers;
            this.observer = observer;
        }

        public void Dispose()
        {
            if (observers.Contains(observer))
                observers.Remove(observer);
        }
    }
}
