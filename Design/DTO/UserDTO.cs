namespace DTOs;

using System.ComponentModel.DataAnnotations;
using Models;

public class UserDTO
{
    [Required]
    public string FirstName { get; set; }
    [Required]
    public string LastName { get; set; }
    [Required]
    public Address Address { get; set; }
    [Required]
    public string SocialSecurityNumber { get; init; }
    public string Email { get; set; }
}