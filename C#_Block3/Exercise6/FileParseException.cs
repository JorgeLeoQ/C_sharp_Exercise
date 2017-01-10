using System;

namespace Exercise6
{
    public class FileParseException : ApplicationException
    {
        private string FileName { get; set; }
        private int Row { get; set; }
        private string message;

        public FileParseException(string fileName, int row, Exception innerException) : base(null, innerException)
        {
            this.FileName = fileName;
            this.Row = row;
            this.message = string.Format("Error in file input. Input: {0}. row: {1}.", this.FileName, this.Row);
        }

        public FileParseException(string message, Exception innerException) : base(null, innerException)
        {
            this.message = message;
        }

        public FileParseException(string message)
        {
            this.message = message;
        }

        public FileParseException(string fileName, int row)
            : this(fileName, row, null)
        {
        }

        public override string Message
        {
            get { return base.Message; }
        }

        static void Main(string[] args)
        {
        }
    }
}
