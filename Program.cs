using System;

namespace MediaLibrary
{
    class Program
    {
        static void Main()
        {
            var album1 = new Album("Hybrid Theory", "Linkin Park");
            var album2 = new Album("The Wall", "Pink Floyd");
            var album3 = new Album("Bohemian Rhapsody", "Queen");
            var book = new Book("Harry Potter", "J.K. Rowling");
            var movie = new Movie("Deadpool", "Tim Miller");

            Console.WriteLine(album1.GetDisplayText());
            Console.WriteLine(album2.GetDisplayText());
            Console.WriteLine(album3.GetDisplayText());
            Console.WriteLine(book.GetDisplayText());

            Console.WriteLine(movie.GetDisplayText());


            album1.Loan("Jessie James");
            album2.Loan();
            book.Loan();
            movie.Loan();
            Console.WriteLine(album1.GetDisplayText());
            Console.WriteLine(album2.GetDisplayText());
            Console.WriteLine(book.GetDisplayText());
            Console.WriteLine(movie.GetDisplayText());
            album1.Return();
            album2.Return();
            book.Return();
            movie.Return();
            Console.WriteLine(album1.GetDisplayText());
            Console.WriteLine(album2.GetDisplayText());
            Console.WriteLine(book.GetDisplayText());
            Console.WriteLine(movie.GetDisplayText());
        }
    }

}

