using System;

namespace MediaLibrary
{
    class Book : MediaType
    {
        public string Author { get; private set; }
        public string DisplayText => "Book: " + Title + ", by: " + Author;
        public Book(string title, string author)
         : base(title)
        {
            Author = author;
        }
    }
}