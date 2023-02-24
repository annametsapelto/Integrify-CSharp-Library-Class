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
    public IList<Loan>? LoanHistory { get; set; }
    public IList<Loan>? CurrentLoans { get; set; }
    public IList<Reservation>? Reservations { get; set; }
    public IList<Loanable>? LostLoanables { get; set; }
}
