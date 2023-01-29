public class Customer : User
{
    public int CardNumber {get; set;}
    public OverduePayment Overdue;
    public bool CardActive {get; set;} = true;

    public Customer(string _first, string _last, Address _address, bool _active, string _socialSecurityNumber, int _cardNumber, OverduePayment _overdue, string _email)
    : base(_first, _last, _address, _socialSecurityNumber, _email)
    {
        this.Overdue = _overdue;
        this.CardNumber = _cardNumber;
        this.CardActive = _active;
    }
}