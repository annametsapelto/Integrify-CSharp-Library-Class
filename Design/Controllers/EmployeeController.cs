namespace Controllers;

using Models;
using Services;
using DTOs;

public class EmployeeController
{
    private readonly IEmployeeService _service;

    public EmployeeController(IEmployeeService service)
    {
        this._service = service;
    }

    //POST /api/employees
    public async Task<Employee> CreateEmployeeAsync(EmployeeDTO request)
    {
        var task = await _service.CreateEmployeeAsync(request);
        return task;
    }

    //PUT /api/employees/{id}
    public async Task<Employee> UpdateEmployeeAsync(int id, EmployeeDTO request)
    {
        var task = await _service.UpdateEmployeeAsync(id, request);
        return task;
    }

    //GET /api/employees/{id}
    public async Task<Employee> GetEmployeeAsync(int id)
    {
        var task = await _service.GetEmployeeAsync(id);
        return task;
    }

    //GET /api/employees
    public async Task<ICollection<Employee>> GetAllEmployees()
    {
        var task = await _service.GetAllEmployeesAsync();
        return task;
    }

    //DELETE /api/employees/{id}
    public async Task<bool> DeleteEmployeeAsync(int id)
    {
        var task = await _service.DeleteEmployeeAsync(id);
        return task;
    }
}