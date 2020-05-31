using System;

namespace MediaLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            var album = new Album("Hybrid Theory", "Linkin Park");
            var book = new Book("Harry Potter", "J.K. Rowling");
            var movie = new Movie("Deadpool", "Tim Miller");

            Console.WriteLine("Album: " + album.Title + ", by: " + album.Artist);
            Console.WriteLine("Album: " + book.Title + ", by: " + book.Author);
            Console.WriteLine("Album: " + movie.Title + ", by: " + movie.Director);
        }
    }

}

