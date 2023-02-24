namespace DTOs;

public class EmployeeDTO : UserDTO
{
    public string AccessCode { get; init; }
    public string Password { get; set; }
}