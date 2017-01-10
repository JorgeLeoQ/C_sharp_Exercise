using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise8
{
    public class DELLObserver : IObserver<Quote>
    {
        public bool CompletedBool { get; set; }
        public bool ErrorBool { get; set; }
        public bool NextBool { get; set; }

        public void OnCompleted()
        {
            CompletedBool = true;
        }

        public void OnError(Exception error)
        {
            ErrorBool = true;
        }

        public void OnNext(Quote value)
        {
            NextBool = true;
        }
    }
}
