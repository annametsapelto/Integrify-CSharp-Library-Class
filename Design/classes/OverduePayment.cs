public class OverduePayment
{
    public double[] Payments {get; set;}
    public double Total {get; set;}
    public double MaxPayment {get; set;} = 10;

    public OverduePayment(double[] _payment, double _total, double _max)
    {
        this.Payments = _payment;
        this.MaxPayment = _max;
        this.Total = _total;
    }
}