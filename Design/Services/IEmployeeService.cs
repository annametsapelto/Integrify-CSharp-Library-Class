namespace Services;

using Models;
using DTOs;

public interface IEmployeeService
{
    Task<Employee> CreateEmployeeAsync(EmployeeDTO request);

    Task<Employee> UpdateEmployeeAsync(int id, EmployeeDTO request);

    Task<bool> DeleteEmployeeAsync(int id);

    Task<Employee> GetEmployeeAsync(int id);

    Task<ICollection<Employee>> GetAllEmployeesAsync();
}