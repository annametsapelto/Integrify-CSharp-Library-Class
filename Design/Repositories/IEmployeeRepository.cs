namespace Repositories;

using Models;
using DTOs;

public interface IEmployeeRepository
{
    Task<Employee> CreateEmployee(EmployeeDTO request);

    Task<Employee> UpdateEmployee(int id, EmployeeDTO request);

    Task<bool> DeleteEmployee(int id);

    Task<Employee> GetEmployee(int id);

    Task<ICollection<Employee>> GetAllEmployees();
}