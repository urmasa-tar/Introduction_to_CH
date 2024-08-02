using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternMatching
{
    public class Book
    {
        public string Title;
        public string Author;
        public uint PublishedYear;
        public uint ISBN;

        public Book(string Title, string Author,uint Year, uint ISBN)
        {
            this.Title = Title;
            this.Author = Author;
            this.PublishedYear = Year;
            this.ISBN = ISBN;
        }

    }
}
