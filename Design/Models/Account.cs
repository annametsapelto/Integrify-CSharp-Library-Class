namespace Models;

public class Account 
{
    public int Id { get; set; }
    public User Owner { get; init; }
    public int CardNumber { get; set; }
    public string Password { get; set; }
    public OverduePayment Overdue { get; set; }
    public bool CardActive { get; set; } = true;
    public Loan[] LoanHistory { get; set; }
    public Loan[] CurrentLoans { get; set; }
    public Reservation[] Reservations { get; set; }
    public Loanable[] LostLoanables { get; set; }

    public Account(){}
    
    public Account(
        int id,
        User owner, 
        bool active, 
        int cardNumber, 
        OverduePayment overdue, 
        Loan[] history, 
        Loan[] current, 
        Loanable[] lost, 
        Reservation[] 
        reservation, 
        string password)
    {
        this.Id = id;
        this.Owner = owner;
        this.Overdue = overdue;
        this.CardNumber = cardNumber;
        this.CardActive = active;
        this.LoanHistory = history;
        this.CurrentLoans = current;
        this.LostLoanables = lost;
        this.Reservations = reservation;
        this.Password = password;
    }

    public void DisableAccount(OverduePayment Overdues)
    {
        if (this.CardActive)
        {
            if (Overdues.CountTotal(Overdues.Payments) > Overdues.MaxPayment)
            {
                this.CardActive = false;
            }
        }
     }

    public void EnableAccount(OverduePayment Overdues)
    {
        if (!this.CardActive)
        {
            if (Overdues.CountTotal(Overdues.Payments) < Overdues.MaxPayment)
            {
                this.CardActive = true;
            }
        }
    }
}