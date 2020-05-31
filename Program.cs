using System;

namespace MediaLibrary
{
    class Program
    {
        static void Main()
        {
            try
            {
                var album1 = new Album("Hybrid Theory", "Linkin Park");
                var album2 = new Album("The Wall", "Pink Floyd");
                var album3 = new Album("Bohemian Rhapsody", "Queen");
                var book = new Book("Harry Potter", "J.K. Rowling");
                var movie = new Movie("Deadpool", "Tim Miller");

                DetectMediaType(album1);
                DetectMediaType(album2);
                DetectMediaType(album3);
                DetectMediaType(book);
                DetectMediaType(movie);
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
                Console.WriteLine(album3.GetDisplayText());
                Console.WriteLine(book.GetDisplayText());
                Console.WriteLine(movie.GetDisplayText());
                album1.Return();
                album2.Return();
                book.Return();
                movie.Return();
                Console.WriteLine(album1.GetDisplayText());
                Console.WriteLine(album2.GetDisplayText());
                Console.WriteLine(album3.GetDisplayText());
                Console.WriteLine(book.GetDisplayText());
                Console.WriteLine(movie.GetDisplayText());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception : " + ex.Message);
            }
        }
        static void DetectMediaType(MediaType item)
        {
            if (item is Album)
            {
                Console.WriteLine(item.Title + " Is an Album");
            }
            else if (item is Book)
            {
                Console.WriteLine(item.Title + " Is a Book");

            }
            else if (item is Movie)
            {
                Console.WriteLine(item.Title + " Is a Movie");
            }
            else
            {
                throw new Exception("Unexpected Media Subtype Encountered");
            }
        }
    }

}

