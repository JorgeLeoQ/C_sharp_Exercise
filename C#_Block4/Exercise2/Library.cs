using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise2
{
    public class Library
    {
        public string NameLibrary { private set; get; }
        private List<Book> listBooks = new List<Book>();

        public List<Book> ListBooks
        {
            get
            {
                return this.listBooks;
            }
        }

        public Library(string nameLibrary)
        {
            this.NameLibrary = nameLibrary;
        }
        //method for add book in dinamic library list
        public void AddBook(string titleBook, string authorBook, uint publisherBook, uint releseDate, string isbnNumber)
        {
            Book tempBook = new Book(titleBook, authorBook, publisherBook, releseDate, isbnNumber);
            this.ListBooks.Add(tempBook);
        }
        public void AddBook(string titleBook, string authorBook)
        {
            Book tempBook = new Book(titleBook, authorBook);
            this.ListBooks.Add(tempBook);
        }
        //method for delete some book by Author
        public string DeleteBook(string authorBook)
        {
            if (this.ListBooks.Count > 0)
            {
                StringBuilder DeletesBook = new StringBuilder();
                DeletesBook.Append("---------Books Delete---------").AppendLine();

                for (int i = 0; i < ListBooks.Count; i++)
                {
                    if (ListBooks[i].AuthorBook == authorBook)
                    {
                        DeletesBook.Append("\n" + ListBooks[i].ToString()).AppendLine();
                    }
                }

                ListBooks.RemoveAll(x => x.AuthorBook == authorBook);

                return DeletesBook.ToString();
            }
            else
            {
                throw new Exception("There are not books in this library");
            }
        }
        //returt the list of my books in the library
        public override string ToString()
        {
            StringBuilder InfoString = new StringBuilder();
            InfoString.AppendFormat("------------------{0}'s Library------------------", this.NameLibrary).AppendLine();
            InfoString.Append("List Library:").AppendLine();

            foreach (var items in ListBooks)
            {
                InfoString.Append("\n" + items.ToString()).AppendLine();
            }

            return InfoString.ToString();
        }
    }
}
