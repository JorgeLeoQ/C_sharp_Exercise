using System;

namespace Exercise7
{
    public class BirthFutereException : ApplicationException
    {
        private string message = null;

        public BirthFutereException(string message)
        {
            this.message = message;
        }

        public override string Message
        {
            get
            {
                return this.message;
            }
        }
    }

    public class TooOldBirthException : ApplicationException
    {
        private string message = null;

        public TooOldBirthException(string message)
        {
            this.message = message;
        }

        public override string Message
        {
            get
            {
                return this.message;
            }
        }
    }
}
