namespace Models;

public class User
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public Address Address { get; set; }
    public string SocialSecurityNumber { get; init; }
    public string Email { get; set; }

    public User(int id, string first, string last, Address address, string socialSecurityNumber, string email)
    {
        this.Id = id;
        this.FirstName = first;
        this.LastName = last;
        this.Address = address;
        this.SocialSecurityNumber = socialSecurityNumber;
        this.Email = email;
    }
    public string GetFullName()
    {
        string FullName = this.LastName + ", " + this.FirstName;
        return FullName;
    }
}