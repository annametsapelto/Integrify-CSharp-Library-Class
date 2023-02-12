namespace Controllers;

using Models;
using Services;
using DTOs;

public class UserController
{
    private readonly IUserService _service;

    public UserController(IUserService service)
    {
        this._service = service;
    }

    //POST /api/users
    public async Task<User> CreateUserAsync(UserDTO request)
    {
        var task = await _service.CreateUserAsync(request);
        return task;
    }

    //PUT /api/users/{id}
    public async Task<User> UpdateUserAsync(int id, UserDTO request)
    {
        var task = await _service.UpdateUserAsync(id, request);
        return task;
    }

    //GET /api/users/{id}
    public async Task<User> GetUserAsync(int id)
    {
        var task = await _service.GetUserAsync(id);
        return task;
    }

    //GET /api/users
    public async Task<ICollection<User>> GetAllUsers()
    {
        var task = await _service.GetAllUsersAsync();
        return task;
    }

    //DELETE /api/users/{id}
    public async Task<bool> DeleteUserAsync(int id)
    {
        var task = await _service.DeleteUserAsync(id);
        return task;
    }
}