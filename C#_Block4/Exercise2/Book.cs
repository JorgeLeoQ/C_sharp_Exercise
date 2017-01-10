using System;
using System.Text;

namespace Exercise2
{
    public class Book
    {
        public string TitleBook { get; private set; }
        public string AuthorBook { get; private set; }
        public uint PublisherBook { get; private set; }
        public uint ReleseDate { get; private set; }
        public string IsbnNumber { get; }

        //costructors books
        public Book(string titleBook, string authorBook, uint publisherBook, uint releseDate, string isbnNumber)
        {
            this.TitleBook = titleBook;
            this.AuthorBook = authorBook;
            this.PublisherBook = publisherBook;
            this.ReleseDate = releseDate;
            this.IsbnNumber = isbnNumber;
        }
        public Book(string titleBook, string authorBook)
            : this(titleBook, authorBook, 0, 0, null)
        { }
        //return parametre of specific book
        public override string ToString()
        {
            StringBuilder MyInfo = new StringBuilder();
            MyInfo.AppendFormat("Title: {0, 10}", this.TitleBook).AppendLine();
            MyInfo.AppendFormat("Author: {0, 10}", this.AuthorBook).AppendLine();
            MyInfo.AppendFormat("Publisher date: {0, 10}", this.PublisherBook).AppendLine();
            MyInfo.AppendFormat("Relese Date: {0, 10}", this.ReleseDate).AppendLine();
            MyInfo.AppendFormat("ISBN: {0, 10}", this.IsbnNumber).AppendLine();
            return MyInfo.ToString();
        }
    }
}
