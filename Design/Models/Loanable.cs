namespace Models;

public abstract class Loanable
{
    public string Title {get; init;}
    public int PublishingYear {get; init;}
    public int EntryCode {get; init;}
    public Category Category {get; init;}
    public bool HasReservations {get; set;}
    public Availability Status {get; set;}

    public Loanable (string title, int year, int code, Category category, bool reservations, Availability status)
    {
        this.Title = title;
        this.PublishingYear = year;
        this.EntryCode = code;
        this.Category = category;
        this.HasReservations = reservations;
        this.Status = status;
    }
}