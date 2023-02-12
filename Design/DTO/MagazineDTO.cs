namespace DTOs;

using System.ComponentModel.DataAnnotations;

public class MagazineDTO: LoanableDTO
{
    [Required]
    public string IssueNumber { get; init; }
    [Required]
    public string Editor { get; init; }
}