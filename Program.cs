using System;

namespace MediaLibrary
{
    class Program
    {
        static void Main()
        {
            try
            {
                var mediaLibrary = new MediaLibrary(new MediaType[]
                {
                    new Album("Hybrid Theory", "Linkin Park"),
                    new Album("The Wall", "Pink Floyd"),
                    new Album("Bohemian Rhapsody", "Queen"),
                    new Book("Harry Potter", "J.K. Rowling"),
                    new Movie("Deadpool", "Tim Miller")
                });

                Console.WriteLine("Number of Items " + mediaLibrary.NumberOfItems);                

                DetectMediaType(mediaLibrary.GetItemAt(0));
                DetectMediaType(mediaLibrary.GetItemAt(1));
                DetectMediaType(mediaLibrary.GetItemAt(2));
                DetectMediaType(mediaLibrary.GetItemAt(3));
                DetectMediaType(mediaLibrary.GetItemAt(4));
                DetectMediaType(mediaLibrary.GetItemAt(5));

                Display(mediaLibrary.GetItemAt(0));
                Display(mediaLibrary.GetItemAt(1));
                Display(mediaLibrary.GetItemAt(2));
                Display(mediaLibrary.GetItemAt(3));
                Display(mediaLibrary.GetItemAt(4));
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception : " + ex.Message);
            }
        }
        static void Display(MediaType item)
        {
            if (item == null)
            {
                return;
            }
            if (item is Album)
            {
                Console.WriteLine(((Album)item).DisplayText);
            }
            else if (item is Book)
            {
                Console.WriteLine(((Book)item).DisplayText);
            }
            else if (item is Movie)
            {
                Console.WriteLine(((Movie)item).DisplayText);
            }
            else
            {
                throw new Exception("Unexpected Media Subtype Encountered");
            }
        }
        static void DetectMediaType(MediaType item)
        {
            if (item == null)
            {
                return;
            }
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

