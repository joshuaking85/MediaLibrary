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

            Console.WriteLine(album1.GetDisplayText());
            Console.WriteLine(album2.GetDisplayText());
            Console.WriteLine(album3.GetDisplayText());

            album1.Loan("Jessie James");
            Console.WriteLine(album1.GetDisplayText());
            album1.Return();
            Console.WriteLine(album1.GetDisplayText());

        }
    }

}

