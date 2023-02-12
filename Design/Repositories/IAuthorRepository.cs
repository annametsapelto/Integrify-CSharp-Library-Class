namespace Repositories;

using Models;
using DTOs;

public interface IAuthorRepository
{
    Task<Author> CreateAuthor(AuthorDTO request);

    Task<Author> UpdateAuthor(int id, AuthorDTO request);

    Task<bool> DeleteAuthor(int id);

    Task<Author> GetAuthor(int id);

    Task<ICollection<Author>> GetAllAuthors();
}