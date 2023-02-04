public class User
{
    public string FirstName {get; set;}
    public string LastName {get; set;}
    public Address Address;
    public string SocialSecurityNumber {get; init;}
    public string Email {get; set;}

    public User(string _first, string _last, Address _address, string _socialSecurityNumber, string _email)
    {
        this.FirstName = _first;
        this.LastName = _last;
        this.Address = _address;
        this.SocialSecurityNumber = _socialSecurityNumber;
        this.Email = _email;
    }
    public string GetFullName()
    {
        string FullName = this.LastName + ", " + this.FirstName;
        return FullName;
    }
}