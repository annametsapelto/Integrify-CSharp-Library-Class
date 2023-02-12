namespace Models;

public class Reservation 
{
    public int Id { get; set; }
    public int ReservationNumber { get; init; }
    public Loanable ReservedItem { get; init; }
    public DateTime StartDate { get; init; }
    public DateTime EndDate { get; init; }

    public Reservation(int id, int number, Loanable item, DateTime start, DateTime end)
    {
        this.Id = id;
        this.ReservationNumber = number;
        this.ReservedItem = item;
        this.EndDate = end;
        this.StartDate = start;
    }
}