namespace DTOs;

public class EmployeeDTO : UserDTO
{
    private string _accessCode { get; init; }
    private string _password { get; set; }
}