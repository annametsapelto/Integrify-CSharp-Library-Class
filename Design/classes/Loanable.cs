public abstract class Loanable
{
    public string Title {get; init;}
    public int PublishingYear {get; init;}
    public int EntryCode {get; init;}
    public Category Category {get; init;}
    public bool HasReservations;

    public Loanable (string title, int year, int code, Category category, bool reservations)
    {
        this.Title = title;
        this.PublishingYear = year;
        this.EntryCode = code;
        this.Category = category;
        this.HasReservations = reservations;
    }
}