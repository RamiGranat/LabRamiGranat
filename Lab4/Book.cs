using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Book
    {
        string title;
        int pageCount;
        string author;
        int bookCount;
        public string Title
        {
            get { return title; }
            set
            {
                var isFirstUperCase = value[0].ToString().ToUpper() == value[0].ToString();
                if (isFirstUperCase)
                    title = value;
            }
        }
        public int PageCount
        {
            get { return pageCount; }
            set
            {
                if (value >= 1)
                    pageCount = value;
            }
        }
        public string Author
        {
            get { return author; }
            set
            {
                var isFirstUpperCase = value[0].ToString().ToUpper() == value[0].ToString();
                if (isFirstUpperCase)
                    author = value;
            }
        }
        public int BookCount
        {
            get { return bookCount; }
        }
        public Book()
        {
            Title = "Priests of Mars";
            PageCount = 317;
            Author = "Graham McNeill";
            bookCount++;
        }
        public Book(string title, int pageCount) : this()
        {
            Title = title;
            PageCount = pageCount;
        }
        public override string ToString()
        {
            return $"Title: {Title} Page count: {PageCount} Author: {Author}";
        }
    }
}
