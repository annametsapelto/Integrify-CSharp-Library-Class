namespace Models;

public class OverduePayment
{
    public int Id { get; set; }
    public double[] Payments { get; set; }
    public double MaxPayment { get; set; } = 10;

    public OverduePayment(double[] payment, double max)
    {
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