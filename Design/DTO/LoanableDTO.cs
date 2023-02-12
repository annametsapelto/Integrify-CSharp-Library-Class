namespace DTOs;

using System.ComponentModel.DataAnnotations;
using Models;

public abstract class LoanableDTO
{
    [Required]
    public string Title { get; init; }
    [Required]
    public int PublishingYear { get; init; }
    [Required]
    public int EntryCode { get; init; }
    [Required]
    public Category Category { get; init; }
    public bool HasReservations { get; set; }
    public Availability Status { get; set; }
}