namespace Repositories;

using Models;
using DTOs;

public interface IAuthorRepository
{
    Task<Author> CreateAuthorAsync(AuthorDTO request);

    Task<Author> UpdateAuthorAsync(int id, AuthorDTO request);

    Task<bool> DeleteAuthorAsync(int id);

    Task<Author> GetAuthorAsync(int id);

    Task<ICollection<Author>> GetAllAuthorsAsync();
}