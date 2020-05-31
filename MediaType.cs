using System;

namespace MediaLibrary
{
    class MediaType
    {
        public string Title;
        public string Loanee = null;
        public bool OnLoan = false;

        public MediaType(string title)
        {
            if (string.IsNullOrEmpty(title))
            {
                throw new Exception("A Media Type Must Have a Title");
            }
            Title = title;
        }
        public void Loan()
        {
            OnLoan = true;
        }
        public void Loan(string loanee)
        {
            Loanee = loanee;
            Loan();
        }
        public void Return()
        {
            Loanee = null;
            OnLoan = false;
        }
    }
}