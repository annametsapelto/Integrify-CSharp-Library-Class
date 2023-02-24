namespace Models;

public class Employee : User
{
    public int Id { get; set; }
    public string AccessCode { get; init; }
    public string Password { get; set; }
    public Employee(int id, string first, string last, Address address, string socialSecurityNumber, string email, string access, string pass)
    : base(id, first, last, address, socialSecurityNumber, email)
    {
        this.AccessCode = access;
        this.Password = pass;
    }
}