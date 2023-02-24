namespace Models;

public class OverduePayment
{
    public int Id { get; set; }
    public Account Account {get; init;}
    public IList<double> Payments { get; set; }
    public double MaxPayment { get; set; } = 10;

    public OverduePayment(int id, Account account, IList<double> payment, double max)
    {
        this.Id = id;
        this.Account = account;
        this.Payments = payment;
        this.MaxPayment = max;
    }

    public double CountTotal(double[] Payments) {
        double Counted = 0.0;
        for (int i = 0; i<Payments.Length; i++)
        {
            Counted = Counted + Payments[i];
        }
        return Counted;
    }
}