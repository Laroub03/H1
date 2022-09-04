using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    internal class Librarian
    {
        public List<Book> books = new List<Book>();

        public List<Book> Books
        {
            get { return books; }
            set { books = value; }
        }

        public Librarian()
        {
            Book book1 = new Book("IT", "Stephen King");
            Book book2 = new Book("A GAME OF THRONES", "George R. R. Martin");
            Book book3 = new Book("DIARY OF A WIMPY KID", "Jeff Kinney");

            books.Add(book1);
            books.Add(book2);
            books.Add(book3);

        }
    }
}