using System;

namespace MediaLibrary
{
    class Book : MediaType
    {
        public string Author { get; private set; }

        public Book(string title, string author)
         : base(title)
        {
            Author = author;
        }
        public string GetDisplayText()
        {
            string text = "Book: " + Title + ", by: " + Author;
            if(OnLoan)
            {
                if(!string.IsNullOrEmpty(Loanee)){
                    text += " (Currently on loan to " + Loanee +")";
                }else{
                    text += "(Currently on loan)";
                }
                
            }

            return text;
        }
    }
}