using System;

namespace Exercise7
{
    public class DownloadFromInternetException : ApplicationException
    {
        private string message;

        public DownloadFromInternetException(Exception internalException, string error)
               : base(null, internalException)
        {
            this.message = error;
        }

        public DownloadFromInternetException(string error)
        {
            this.message = error;
        }

        public override string Message
        {
            get { return this.message; }
        }
    }
}
