public class Employee : User
{
    private string _accessCode {get; init;}
    private string _password {get; set;}
    public Employee(string _first, string _last, Address _address, string _socialSecurityNumber, string _email, string _access, string _pass)
    : base(_first, _last, _address, _socialSecurityNumber, _email)
    {
        this._accessCode = _access;
        this._password = _pass;
    }
}