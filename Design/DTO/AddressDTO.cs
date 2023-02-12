namespace DTOs;

using System.ComponentModel.DataAnnotations;

public class AddressDTO
{
    [Required]
    public string StreetAddress { get; set; }
    [Required]
    public string ZipCode { get; set; }
    [Required]
    public string City { get; set; }
    public string Country { get; set; } = "Finland";
}