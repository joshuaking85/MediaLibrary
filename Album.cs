using System;

namespace MediaLibrary
{
    class Album
    {
        public readonly string Title;
        public readonly string Artist;
        public string Loanee = null;
        public bool OnLoan = false;

        public Album(string title, string artist)
        {
            Title = title;
            Artist = artist;
        }

        public string GetDisplayText()
        {
            string text = "Album: " + Title + ", by: " + Artist;
            if(OnLoan)
            {
                text += " (Currently onloan to " + Loanee +")";
            }

            return text;
        }

        public void Loan(string loanee)
        {
            Loanee = loanee;
            OnLoan = true;

        }
        public void Return()
        {
            Loanee = null;
            OnLoan = false;
        }
    }
}