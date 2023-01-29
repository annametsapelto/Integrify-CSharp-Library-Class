public class Book : Loanable
{
    public Author[] Authors {get; init;}
    public string? Translator {get; init;}
    public int PageCount {get; init;}
    public string Publisher {get; init;}

    public Book (string title, int year, int code, Author[] authors, int pages, string publisher) :base (title, year, code) 
    {
        this.Authors = authors;
        this.PageCount = pages;
        this.Publisher = publisher;
    }
        public Book (string title, int year, int code, Author[] authors, int pages, string publisher, string translator) :base (title, year, code) 
    {
        this.Authors = authors;
        this.PageCount = pages;
        this.Publisher = publisher;
        this.Translator = translator;
    }
}