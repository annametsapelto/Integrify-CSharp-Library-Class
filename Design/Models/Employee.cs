namespace Models;

public class Employee : User
{
    public int Id { get; set; }
    private string _accessCode { get; init; }
    private string _password { get; set; }
    public Employee(int id, string first, string last, Address address, string socialSecurityNumber, string email, string access, string pass)
    : base(id, first, last, address, socialSecurityNumber, email)
    {
        this._accessCode = access;
        this._password = pass;
    }
}