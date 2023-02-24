namespace Models;

public class Book : Loanable
{
    public int Id { get; set; }
    public IList<Author> Authors { get; init; }
    public string? Translator { get; init; }
    public int PageCount { get; init; }
    public string Publisher { get; init; }

    public Book (int id, string title, int year, int code, IList<Author> authors, int pages, string publisher, Category category, bool reservations, Availability status) 
    :base (title, year, code, category, reservations, status) 
    {
        this.Id = id;
        this.Authors = authors;
        this.PageCount = pages;
        this.Publisher = publisher;
    }
        public Book (string title, int year, int code, IList<Author> authors, int pages, string publisher, string translator, Category category, bool reservations, Availability status) 
        :base (title, year, code, category, reservations, status) 
    {
        this.Authors = authors;
        this.PageCount = pages;
        this.Publisher = publisher;
        this.Translator = translator;
    }
}