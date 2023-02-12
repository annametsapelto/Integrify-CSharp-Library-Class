namespace DTOs;

using System.ComponentModel.DataAnnotations;
using Models;

public class BookDTO : LoanableDTO
{
    [Required]
    public Author[] Authors { get; init; }
    public string? Translator { get; init; }
    public int PageCount { get; init; }
    [Required]
    public string Publisher { get; init; }

}
