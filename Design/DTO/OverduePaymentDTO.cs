namespace DTOs;

using System.ComponentModel.DataAnnotations;
using Models;

public class OverduePaymentDTO
{
    [Required]
    public Account Account {get; init;}
    [Required]
    public double[] Payments { get; set; }
    public double MaxPayment { get; set; } = 10;
}