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