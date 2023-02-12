namespace DTOs;

using System.ComponentModel.DataAnnotations;
using Models;

public class ReservationDTO 
{
    [Required]
    public int ReservationNumber { get; init; }
    [Required]
    public Loanable ReservedItem { get; init; }
    [Required]
    public DateTime StartDate { get; init; }
    [Required]
    public DateTime EndDate { get; init; }
}