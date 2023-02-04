public class Account 
{
    public User Owner {get; init;}
    public int CardNumber {get; set;}
    public string Password {get; set;}
    public OverduePayment Overdue {get; set;}
    public bool CardActive {get; set;} = true;
    public Loan[] LoanHistory {get; set;}
    public Loan[] CurrentLoans {get; set;}
    public Reservation[] Reservations {get; set;}
    public Loanable[] LostLoanables {get; set;}

    public Account(User _owner, string _first, string _last, Address _address, bool _active, string _socialSecurityNumber, int _cardNumber, OverduePayment _overdue, string _email, Loan[] _history, Loan[] current, Loanable[] lost, Reservation[] reservation, string _password)
    {
        this.Owner = _owner;
        this.Overdue = _overdue;
        this.CardNumber = _cardNumber;
        this.CardActive = _active;
        this.LoanHistory = _history;
        this.CurrentLoans = current;
        this.LostLoanables = lost;
        this.Reservations = reservation;
        this.Password = _password;
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