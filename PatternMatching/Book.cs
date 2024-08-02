using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternMatching
{
    public class Book
    {
        public string Title { get; set; } = "NoName";
        public string Author { get; set; } = "";
        public uint PublishedYear { get; set; } = 0;
        public uint ISBN { get; set; } = 0;

        public Book(string Title, string Author,uint Year, uint ISBN)
        {
            this.Title = Title;
            this.Author = Author;
            this.PublishedYear = Year;
            this.ISBN = ISBN;
        }

    }
}
