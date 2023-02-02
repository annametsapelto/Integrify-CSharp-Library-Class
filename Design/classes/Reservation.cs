public class Reservation 
{
    public int ReservationNumber {get; init;}
    public Loanable ReservedItem { get; init;}
    public DateTime StartDate {get; init;}
    public DateTime EndDate { get; init;}
}