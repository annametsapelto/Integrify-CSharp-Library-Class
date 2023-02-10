namespace Models;

public class OverduePayment
{
    public int Id;
    public double[] Payments {get; set;}
    public double MaxPayment {get; set;} = 10;

    public OverduePayment(double[] _payment, double _total, double _max)
    {
        this.Payments = _payment;
        this.MaxPayment = _max;
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