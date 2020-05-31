using System;

namespace MediaLibrary
{
    class Movie : MediaType
    {
        public string Director { get; private set;}
        public string DisplayText => "Movie: " + Title + ", by: " + Director;
        public Movie(string title, string director)
         : base(title)
        {
            Director = director;
        }
    }
}
