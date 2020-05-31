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

                var item = mediaLibrary.FindItem("Arabia");

                if (item != null)
                {
                    MediaLibrary.DisplayItem(item);
                }
                else
                {
                    Console.WriteLine("Item Not Found!");
                }

                /* Console.WriteLine("Number of Items " + mediaLibrary.NumberOfItems);                
                
                mediaLibrary.DisplayItems(); */
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception : " + ex.Message);
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

