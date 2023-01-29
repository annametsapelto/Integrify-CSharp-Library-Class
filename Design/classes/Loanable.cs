public abstract class Loanable
{
    public string Title {get; init;}
    public int PublishingYear {get; init;}
    public int EntryCode {get; init;}

    public Loanable (string title, int year, int code)
    {
        this.Title = title;
        this.PublishingYear = year;
        this.EntryCode = code;
    }
}