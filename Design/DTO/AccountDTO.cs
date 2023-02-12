namespace DTOs;

using System.ComponentModel.DataAnnotations;
using Models;

public class AccountDTO 
{
    [Required]
    public User Owner { get; init; }
    [Required]
    public int CardNumber { get; set; }
    [Required]
    public string Password { get; set; }
    public OverduePayment? Overdue { get; set; }
    public bool CardActive { get; set; } = true;
    public Loan[]? LoanHistory { get; set; }
    public Loan[]? CurrentLoans { get; set; }
    public Reservation[]? Reservations { get; set; }
    public Loanable[]? LostLoanables { get; set; }
}
