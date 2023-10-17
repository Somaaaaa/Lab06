using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    internal class Book
    {
        string author;
        string title;
        int releaseDate;
        int pages;

        public Book(string author, string title, int releaseDate, int pages)
        {
            this.author = author;
            this.title = title;
            this.releaseDate = releaseDate;
            this.pages = pages;
        }
        public string AllData()
        {
            return $"{author}: {title}, {releaseDate} ({pages} pages)";
        }
    }
}
