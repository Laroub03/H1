using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Stack<Book> stackBooks = new Stack<Book>();
            string pushbook = "";

            Librarian librarian = new Librarian();

            Console.WriteLine("Available books\n");
            foreach (Book i in librarian.books)
            {
                Console.WriteLine(i.Title);
            }


            Console.WriteLine("\nWhat book would you like you check out?");
            pushbook = Console.ReadLine().ToUpper();

            Book j = librarian.books.Find(j => j.Title == pushbook);

            stackBooks.Push(j);
            librarian.books.Remove(j);

            foreach (Book i in stackBooks)
            {
                Console.WriteLine(i.Title);
            }

            try
            {
                while (stackBooks.Count() > 0)
                {
                    Console.WriteLine(stackBooks.Pop());
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}