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
    }
}