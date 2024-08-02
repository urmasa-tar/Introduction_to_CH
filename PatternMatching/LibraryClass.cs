using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternMatching
{
    public class LibraryClass
    {
        Book example;
        List<Book> booksInLib;

        public LibraryClass()
        {
            example = new Book("Example", "", 2024, 10000);
        }
        public LibraryClass(string name, string autor, uint year, uint id)
        {
            example = new Book(name, autor, year, id);
        }

        public List<Book> GetAllBooks()
        {
            List<Book> result = this.booksInLib;
            result.Add(this.example);

            foreach (Book book in result)
            {
                Console.WriteLine(book + " ");
            }

            return result;
        }

        public void AddBook(Book book)
        {
            booksInLib.Add(book);
        }

        public void RemoveBook(int isbn)
        {
            foreach (Book book in booksInLib)
            {
                if(book.ISBN == isbn)
                {
                    booksInLib.Remove(book);
                }
            }
        }

        List<Book> SearchBooks(string searchTerm)
        {
            List<Book> result = new List<Book>();


            
            foreach (Book book in this.booksInLib)
            {
                //if()
            }
            

            return result;
        }
        /*
        int GetId(string name, string autor) => (id) switch
        {
            (this.booksInLib., )
        }
        */
    }
}
