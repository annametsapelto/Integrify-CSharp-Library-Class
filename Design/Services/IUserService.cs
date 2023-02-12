namespace Services;

using Models;
using DTOs;

public interface IUserService
{
    Task<User> CreateUserAsync(UserDTO request);

    Task<User> UpdateUserAsync(int id, UserDTO request);

    Task<bool> DeleteUserAsync(int id);

    Task<User> GetUserAsync(int id);

    Task<ICollection<User>> GetAllUsersAsync();
}