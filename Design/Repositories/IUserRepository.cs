namespace Repositories;

using Models;
using DTOs;

public interface IUserRepository
{
    Task<User> CreateUser(UserDTO request);

    Task<User> UpdateUser(int id, UserDTO request);

    Task<bool> DeleteUser(int id);

    Task<User> GetUser(int id);

    Task<ICollection<User>> GetAllUsers();
}