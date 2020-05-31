using System;

namespace MediaLibrary
{
    class MediaLibrary
    {
        private MediaType[] _items;
        public int NumberOfItems => _items.Length;
        public MediaLibrary(MediaType[] items)
        {
            _items = items;
        }
        public MediaType GetItemAt(int index)
        {
            //return index < _items.Length ? _items[index] : null;
            if(index < _items.Length)
            {
                return _items[index];
            } 
            else
            {
                Console.WriteLine("An Element at index " + index + " doesn't exist in the Media Library");
                return null;
            }
        }

        public void DisplayItems()
        {
            for(int i=0; i < _items.Length; i++)
            {
               DisplayItem(_items[i]);
            }
        }
        public static void DisplayItem(MediaType item)
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
    }
}