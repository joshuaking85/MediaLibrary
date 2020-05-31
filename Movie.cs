using System;

namespace MediaLibrary
{
    public class Movie
    {
        public readonly string Title;
        public readonly string Director;

        public Movie(string title, string director)
        {
            Title = title;
            Director = director;
        }
    }
}
