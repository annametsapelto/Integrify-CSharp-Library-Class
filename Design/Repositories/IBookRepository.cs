namespace Repositories;

using Models;
using DTOs;

public interface IBookRepository
{
    Task<Book> CreateBookAsync(BookDTO request);

    Task<Book> UpdateBookAsync(int id, BookDTO request);

    Task<bool> DeleteBookAsync(int id);

    Task<Book> GetBookAsync(int id);

    Task<ICollection<Book>> GetAllBooksAsync();
}