namespace DTOs;

using System.ComponentModel.DataAnnotations;
using Models;

public class LoanDTO 
{
    [Required]
    public Loanable LoanedItem { get; init; }
    [Required]
    public DateTime LoanDate { get; init; }
    [Required]
    public DateTime DueDate { get; set; }
}