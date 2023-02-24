namespace DTOs;

using System.ComponentModel.DataAnnotations;
using Models;

public class AuthorDTO 
{
    [Required]
    public string FirstName { set; get; }
    [Required]
    public string LastName { set; get; }
    [Required]
    public IList<Book> Publications { set; get; }
    public string? Biography { set; get; }

}